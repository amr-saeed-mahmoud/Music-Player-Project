namespace Music_Player_Project.Control
{
    partial class ctrMusicList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MusicList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // MusicList
            // 
            this.MusicList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.MusicList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MusicList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MusicList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusicList.ForeColor = System.Drawing.Color.White;
            this.MusicList.HideSelection = false;
            this.MusicList.Location = new System.Drawing.Point(0, 0);
            this.MusicList.MultiSelect = false;
            this.MusicList.Name = "MusicList";
            this.MusicList.Size = new System.Drawing.Size(973, 300);
            this.MusicList.TabIndex = 0;
            this.MusicList.UseCompatibleStateImageBehavior = false;
            this.MusicList.View = System.Windows.Forms.View.List;
            this.MusicList.SelectedIndexChanged += new System.EventHandler(this.MusicList_SelectedIndexChanged);
            // 
            // ctrMusicList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MusicList);
            this.Name = "ctrMusicList";
            this.Size = new System.Drawing.Size(973, 300);
            this.Load += new System.EventHandler(this.ctrMusicList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView MusicList;
    }
}
