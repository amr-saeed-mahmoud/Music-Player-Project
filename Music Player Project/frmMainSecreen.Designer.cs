namespace Music_Player_Project
{
    partial class frmMainSecreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainSecreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnPlayist = new System.Windows.Forms.Button();
            this.btnResentlyMusic = new System.Windows.Forms.Button();
            this.btnMusicList = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlCentralScreen = new System.Windows.Forms.Panel();
            this.pnlControlUnit = new System.Windows.Forms.Panel();
            this.btnPref = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.ctrSlider1 = new Music_Player_Project.ctrSlider();
            this.lbTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlControlUnit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnPlayist);
            this.panel1.Controls.Add(this.btnResentlyMusic);
            this.panel1.Controls.Add(this.btnMusicList);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 687);
            this.panel1.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Red;
            this.btnEdit.Location = new System.Drawing.Point(0, 446);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(252, 53);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnPlayist
            // 
            this.btnPlayist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnPlayist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlayist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayist.ForeColor = System.Drawing.Color.Red;
            this.btnPlayist.Location = new System.Drawing.Point(0, 393);
            this.btnPlayist.Name = "btnPlayist";
            this.btnPlayist.Size = new System.Drawing.Size(252, 53);
            this.btnPlayist.TabIndex = 4;
            this.btnPlayist.Text = "Playlist";
            this.btnPlayist.UseVisualStyleBackColor = false;
            this.btnPlayist.Click += new System.EventHandler(this.btnPlayist_Click);
            // 
            // btnResentlyMusic
            // 
            this.btnResentlyMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnResentlyMusic.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResentlyMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResentlyMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResentlyMusic.ForeColor = System.Drawing.Color.Red;
            this.btnResentlyMusic.Location = new System.Drawing.Point(0, 340);
            this.btnResentlyMusic.Name = "btnResentlyMusic";
            this.btnResentlyMusic.Size = new System.Drawing.Size(252, 53);
            this.btnResentlyMusic.TabIndex = 3;
            this.btnResentlyMusic.Text = "Resently Music";
            this.btnResentlyMusic.UseVisualStyleBackColor = false;
            // 
            // btnMusicList
            // 
            this.btnMusicList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnMusicList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMusicList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusicList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusicList.ForeColor = System.Drawing.Color.Red;
            this.btnMusicList.Location = new System.Drawing.Point(0, 287);
            this.btnMusicList.Name = "btnMusicList";
            this.btnMusicList.Size = new System.Drawing.Size(252, 53);
            this.btnMusicList.TabIndex = 2;
            this.btnMusicList.Text = "Music List";
            this.btnMusicList.UseVisualStyleBackColor = false;
            this.btnMusicList.Click += new System.EventHandler(this.btnMusicList_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Red;
            this.btnHome.Location = new System.Drawing.Point(0, 234);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(252, 53);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 234);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Music_Player_Project.Properties.Resources.headphones_512;
            this.pictureBox1.Location = new System.Drawing.Point(3, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlCentralScreen
            // 
            this.pnlCentralScreen.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCentralScreen.Location = new System.Drawing.Point(252, 0);
            this.pnlCentralScreen.Name = "pnlCentralScreen";
            this.pnlCentralScreen.Size = new System.Drawing.Size(997, 537);
            this.pnlCentralScreen.TabIndex = 1;
            // 
            // pnlControlUnit
            // 
            this.pnlControlUnit.Controls.Add(this.btnPref);
            this.pnlControlUnit.Controls.Add(this.btnNext);
            this.pnlControlUnit.Controls.Add(this.btnPlay);
            this.pnlControlUnit.Controls.Add(this.ctrSlider1);
            this.pnlControlUnit.Controls.Add(this.lbTime);
            this.pnlControlUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControlUnit.Enabled = false;
            this.pnlControlUnit.Location = new System.Drawing.Point(252, 537);
            this.pnlControlUnit.Name = "pnlControlUnit";
            this.pnlControlUnit.Size = new System.Drawing.Size(997, 150);
            this.pnlControlUnit.TabIndex = 2;
            // 
            // btnPref
            // 
            this.btnPref.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.btnPref.Image = global::Music_Player_Project.Properties.Resources.previous_track_32;
            this.btnPref.Location = new System.Drawing.Point(377, 71);
            this.btnPref.Name = "btnPref";
            this.btnPref.Size = new System.Drawing.Size(52, 42);
            this.btnPref.TabIndex = 5;
            this.btnPref.UseVisualStyleBackColor = false;
            this.btnPref.Click += new System.EventHandler(this.btnPref_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.btnNext.Image = global::Music_Player_Project.Properties.Resources.next_track_32;
            this.btnNext.Location = new System.Drawing.Point(532, 71);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(52, 42);
            this.btnNext.TabIndex = 4;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.btnPlay.Image = global::Music_Player_Project.Properties.Resources.play_button_32;
            this.btnPlay.Location = new System.Drawing.Point(445, 67);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(71, 50);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // ctrSlider1
            // 
            this.ctrSlider1.Location = new System.Drawing.Point(25, 30);
            this.ctrSlider1.Name = "ctrSlider1";
            this.ctrSlider1.Size = new System.Drawing.Size(879, 31);
            this.ctrSlider1.SliderEnable = true;
            this.ctrSlider1.TabIndex = 2;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.Red;
            this.lbTime.Location = new System.Drawing.Point(912, 38);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(64, 18);
            this.lbTime.TabIndex = 1;
            this.lbTime.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMainSecreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1249, 687);
            this.Controls.Add(this.pnlControlUnit);
            this.Controls.Add(this.pnlCentralScreen);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainSecreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player";
            this.Load += new System.EventHandler(this.frmMainSecreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlControlUnit.ResumeLayout(false);
            this.pnlControlUnit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnPlayist;
        private System.Windows.Forms.Button btnResentlyMusic;
        private System.Windows.Forms.Button btnMusicList;
        private System.Windows.Forms.Panel pnlCentralScreen;
        private System.Windows.Forms.Panel pnlControlUnit;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Button btnPref;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPlay;
        private ctrSlider ctrSlider1;
        private System.Windows.Forms.Timer timer1;
    }
}