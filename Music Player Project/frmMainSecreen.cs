using Music_Player_Project.Control;
using System;
using System.Windows.Forms;
using Music_Player_Project.Control;
using static Music_Player_Project.Control.ctrMusicList;
using Music_Player_Project.Properties;
using static Music_Player_Project.ctrMusicPlaylist;

namespace Music_Player_Project
{
    public partial class frmMainSecreen : Form
    {
        public frmMainSecreen()
        {
            InitializeComponent();
        }

        public enum enMode {AddMusicToPlaylist = 0, OpenMusicPlaylist = 1}
        enMode Mode = enMode.OpenMusicPlaylist;

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (ctrSlider1.CurPlayState == NAudio.Wave.PlaybackState.Paused)
            {
                ctrSlider1.PlayMusic();
                btnPlay.Image = Resources.stop_button_32;
            }
            else
            {
                ctrSlider1.PauseMusic();
                btnPlay.Image = Resources.play_button_32;
            }
        }

        private void btnPref_Click(object sender, EventArgs e)
        {
            ctrSlider1.DecrementSeconds((int)ctrSlider1.CurrrentTime.TotalSeconds + 1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(ctrSlider1.CurrentPosition >= 1)
                btnPlay.Image = Resources.play_button_32;


            TimeSpan Time = ctrSlider1.CurrrentTime;
            string H, M, S;


            if (Time.Hours > 9)
                H = Time.Hours.ToString();
            else H = "0" + Time.Hours.ToString();

            if (Time.Minutes > 9)
                M = Time.Minutes.ToString();
            else M = "0" + Time.Minutes.ToString();

            if (Time.Seconds > 9)
                S = Time.Seconds.ToString();
            else S = "0" + Time.Seconds.ToString();

            lbTime.Text = H + ":" + M + ":" + S;
        }

        ctrHomePage HomePage = new ctrHomePage();
        ctrMusicList MusicList = new ctrMusicList();
        ctrMusicPlaylist Playlists = new ctrMusicPlaylist();

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlCentralScreen.Controls.Clear();
            pnlCentralScreen.Controls.Add(HomePage);
        }

        private void frmMainSecreen_Load(object sender, EventArgs e)
        {
            btnPlay.Image = Resources.play_button_32;

            HomePage.Dock = DockStyle.Fill;
            // for Music List
            MusicList.Top = (pictureBox1.Top + 40);
            MusicList.Left = pnlCentralScreen.Left - pnlCentralScreen.Width/4 + 10;
            MusicList.Width = pnlCentralScreen.Width - 50;
            // for playlist
            Playlists.Top = (pictureBox1.Top + 40);
            Playlists.Left = pnlCentralScreen.Left - pnlCentralScreen.Width / 4 + 10;
            Playlists.Width = pnlCentralScreen.Width - 50;

            MusicList.SelectedMusic += OnSelectedMusic;

            Playlists.OnSelectedMusic += OnMusicSelectedFromPlaylist;

            btnHome_Click(btnHome, EventArgs.Empty);
        }

        private void btnMusicList_Click(object sender, EventArgs e)
        {
            pnlCentralScreen.Controls.Clear();
            pnlCentralScreen.Controls.Add(MusicList);
        }

        private void OnSelectedMusic(object sender, SelectedMusicEventArgs e)
        {
            // handel next button
            if (MusicList.CountOfMusicInMusicList == MusicList.SelectedMusicIndex + 1)
                btnNext.Enabled = false;
            else btnNext.Enabled = true;

            pnlControlUnit.Enabled = true;
            ctrSlider1.LoadMusic(new NAudio.Wave.AudioFileReader(e.MusicFilePath));
            btnPlay.Image = Properties.Resources.stop_button_32;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(MusicList.CountOfMusicInMusicList == MusicList.SelectedMusicIndex + 1)
            {
                btnNext.Enabled = false;
                return;
            }

            MusicList.ChangeSelectedIndex(MusicList.SelectedMusicIndex + 1);

        }

        private void btnPlayist_Click(object sender, EventArgs e)
        {
            pnlCentralScreen.Controls.Clear();
            pnlCentralScreen.Controls.Add(Playlists);
        }

        private void OnMusicSelectedFromPlaylist(object sender, MusicSelectedEventArgs e)
        {

            if (Playlists.CurMusicIndex + 1 == Playlists.CountOfMusicInSelectedPlaylist)
                btnNext.Enabled = false;
            else btnNext.Enabled = true;

            pnlControlUnit.Enabled = true;
            ctrSlider1.LoadMusic(e.CurMusic);
            btnPlay.Image = Properties.Resources.stop_button_32;

        }
    }
}
