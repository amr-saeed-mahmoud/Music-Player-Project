using System;
using System.Windows.Forms;

namespace Music_Player_Project.Control
{
    public partial class ctrHomePage : UserControl
    {
        public ctrHomePage()
        {
            InitializeComponent();
        }

        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e); // Call the base class method

            // Check if the parent is not null
            if (this.Parent != null)
            {
                // Set this control's background color to match the parent's background color
                this.BackColor = this.Parent.BackColor;
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            pbHomePage.Left = (this.ClientSize.Width - pbHomePage.Width - 55) / 2;
            pbHomePage.Top = (this.ClientSize.Height - pbHomePage.Height + 40) / 2;

        }
        private void StretchControl_SizeChanged(object Sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void ctrHomePage_Load(object sender, EventArgs e)
        {
            this.SizeChanged += StretchControl_SizeChanged;
            this.Dock = DockStyle.Fill;
        }
    }
}
