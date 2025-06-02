using NAudio.Wave;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Music_Player_Project
{
    public partial class ctrSlider : UserControl
    {
        public ctrSlider()
        {
            InitializeComponent();
        }

        decimal MinValue = 0.0m, MaxValue = 1.0m, CurValue = 0.0M;

        private decimal KnobPosition(decimal Value)// this method takes a ratio
        {
            return (Slider.Width - 14) * Value;
        }

        // this function takes coordinate x and returns the percentage of time that has passed
        private decimal TimeIsPassed(decimal coordinate)
        {
            if (coordinate < MinValue) coordinate = MinValue;
            return coordinate / (decimal)Slider.Width;
        }

        // this part related to design and drawing

        private void Slider_Paint(object sender, PaintEventArgs e)
        {
            decimal x = KnobPosition(CurValue);
            decimal y = Slider.Height * 0.5m;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            // draw bar
            e.Graphics.FillRectangle(Brushes.White, 0, (float)y, Slider.Width, (float)(y / 2.5m));
            e.Graphics.FillRectangle(Brushes.Red, 0, (float)y, (float)x, (float)(y / 2.5m));
            // draw knob
            using (Pen pen = new Pen(Brushes.Black, 8))
            {
                e.Graphics.DrawEllipse(pen, (float)(x + 2.3m), (float)(y - 2.3m), Slider.Height / 3, Slider.Height / 3);
                e.Graphics.FillEllipse(Brushes.Red, (float)(x + 2.3m), (float)(y - 2.3m), Slider.Height / 3, Slider.Height / 3);
            }
            using (Pen pen = new Pen(Brushes.White, 5))
            {
                e.Graphics.DrawEllipse(pen, (float)(x + 2.3m), (float)(y - 2.3m), Slider.Height / 3, Slider.Height / 3);
            }
        }

        // this part is responsible for stretching
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            Slider.Size = new Size(this.Width - 20, Slider.Height);
            Slider.Location = new Point(10, Slider.Location.Y);
        }

        private void StretchControl_SizeChanged(object Sender, EventArgs e)
        {
            this.Invalidate(); // because visual appearance of a control has changed and needs to be repainted
        }

        // --------------Part Movement------------- 
        // this method is responsible for moving knob Slider
        private void MoveSliderKnob(decimal Position)
        {
            if (MinValue > Position) Position = MinValue; // for checking anyway
            if (MaxValue < Position) Position = MaxValue; // for checking anyway

            CurValue = Position; // change current position
            Slider.Refresh(); // refresh Slider

        }

        bool Mouse = false;
        bool IsPlay = true;
        private void Slider_MouseDown(object sender, MouseEventArgs e)
        {
            IsPlay = MusicOut.PlaybackState == PlaybackState.Playing ? IsPlay = true : false;
            timer1.Stop();
            MusicOut.Pause();
            Mouse = true;
            MoveSliderKnob(TimeIsPassed(e.X));
            Music.CurrentTime = TimeSpan.FromMilliseconds((double)TimeIsPassed(e.X) * (double)TotalTime);
        }
        private void Slider_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mouse)
            {
                MoveSliderKnob(TimeIsPassed(e.X));
                Music.CurrentTime = TimeSpan.FromMilliseconds(Math.Abs((double)TimeIsPassed(e.X) * (double)TotalTime));
            }
        }
        private void Slider_MouseUp(object sender, MouseEventArgs e)
        {
            Music.CurrentTime = TimeSpan.FromMilliseconds((double)TimeIsPassed(e.X >= 0 ? e.X : 0) * (double)TotalTime);
            Mouse = false;
            timer1.Start();
            if (IsPlay)
                MusicOut.Play();
            else
                MusicOut.Pause();
        }
        //------Part Business Logic------ 

        NAudio.Wave.AudioFileReader Music = null;
        NAudio.Wave.DirectSoundOut MusicOut = null;

        decimal TotalTime = 0;

        public NAudio.Wave.AudioFileReader CurMusic
        {
            get
            {
                if (Music != null) return Music;
                else return null;
            }
        }
        public NAudio.Wave.PlaybackState CurPlayState
        {
            get
            {
                return MusicOut.PlaybackState;
            }
        }
        public void LoadMusic(NAudio.Wave.AudioFileReader Value)
        {
            if (Music != null)
                ClearCurMusic();
            Music = Value;
            TotalTime = (decimal)Music.TotalTime.TotalMilliseconds;
            MusicOut = new DirectSoundOut();
            MusicOut.Init(Music);
            timer1.Enabled = true;
            MusicOut.Play();
        }
        public decimal CurrentPosition
        {
            get { return CurValue; }
        }
        public TimeSpan CurrrentTime
        {
            get
            {
                if (Music == null) return TimeSpan.Zero;

                return Music.CurrentTime;
            }
        }
        bool IsEnable = true;
        public bool SliderEnable
        {
            get { return IsEnable; }
            set
            {
                IsEnable = value;
                Slider.Enabled = IsEnable;
                timer1.Enabled = IsEnable;
            }
        }

        public bool PlayMusic()
        {
            if (Music == null || MusicOut == null)
                return false;

            MusicOut.Play();
            return true;
        }
        public bool PauseMusic()
        {
            if (Music == null || MusicOut == null)
                return false;
            MusicOut.Pause();
            return true;
        }
        public void ClearCurMusic()
        {
            Music.Dispose();
            Music = null;
            MusicOut.Dispose();
            MusicOut = null;

            CurValue = 0;
            TotalTime = 0;
            timer1.Enabled = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CurValue >= 1)
            {
                //timer1.Stop();
                MusicOut.Pause();
            }
            
            if(Music != null)
            {
                CurValue = (decimal)Music.CurrentTime.TotalMilliseconds / TotalTime;

                if(CurValue < 1)
                    MoveSliderKnob(CurValue);
            }

        }

        public void IncrementSeconds(int Second)
        {
            MusicOut.Pause();
            Music.CurrentTime += TimeSpan.FromSeconds(Second);
            MusicOut.Play();
        }
        public void DecrementSeconds(int Second)
        {
            MusicOut.Pause();
            Music.CurrentTime -= TimeSpan.FromSeconds(Second);
            MusicOut.Play();
        }
    }
}
