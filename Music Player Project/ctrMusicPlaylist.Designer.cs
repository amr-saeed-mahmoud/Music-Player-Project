namespace Music_Player_Project
{
    partial class ctrMusicPlaylist
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrMusicPlaylist));
            this.PlayLists = new System.Windows.Forms.ListView();
            this.cmsPlaylistProperty = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deletePlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlCreatePlaylistSection = new System.Windows.Forms.Panel();
            this.btnCreatePlaylist = new System.Windows.Forms.Button();
            this.txtPlaylistName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.addMusicToPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPlaylistProperty.SuspendLayout();
            this.pnlCreatePlaylistSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayLists
            // 
            this.PlayLists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.PlayLists.ContextMenuStrip = this.cmsPlaylistProperty;
            this.PlayLists.Dock = System.Windows.Forms.DockStyle.Top;
            this.PlayLists.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayLists.ForeColor = System.Drawing.Color.White;
            this.PlayLists.HideSelection = false;
            this.PlayLists.Location = new System.Drawing.Point(0, 0);
            this.PlayLists.MultiSelect = false;
            this.PlayLists.Name = "PlayLists";
            this.PlayLists.Size = new System.Drawing.Size(980, 303);
            this.PlayLists.TabIndex = 0;
            this.PlayLists.UseCompatibleStateImageBehavior = false;
            this.PlayLists.View = System.Windows.Forms.View.List;
            this.PlayLists.SelectedIndexChanged += new System.EventHandler(this.PlayLists_SelectedIndexChanged);
            this.PlayLists.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayLists_MouseDown);
            this.PlayLists.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PlayLists_MouseUp);
            this.PlayLists.Resize += new System.EventHandler(this.PlayLists_Resize);
            // 
            // cmsPlaylistProperty
            // 
            this.cmsPlaylistProperty.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsPlaylistProperty.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deletePlaylistToolStripMenuItem,
            this.addMusicToPlaylistToolStripMenuItem});
            this.cmsPlaylistProperty.Name = "cmsPlaylistProperty";
            this.cmsPlaylistProperty.Size = new System.Drawing.Size(219, 80);
            // 
            // deletePlaylistToolStripMenuItem
            // 
            this.deletePlaylistToolStripMenuItem.Name = "deletePlaylistToolStripMenuItem";
            this.deletePlaylistToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.deletePlaylistToolStripMenuItem.Text = "Delete Playlist";
            this.deletePlaylistToolStripMenuItem.Click += new System.EventHandler(this.deletePlaylistToolStripMenuItem_Click);
            // 
            // pnlCreatePlaylistSection
            // 
            this.pnlCreatePlaylistSection.Controls.Add(this.btnCreatePlaylist);
            this.pnlCreatePlaylistSection.Controls.Add(this.txtPlaylistName);
            this.pnlCreatePlaylistSection.Controls.Add(this.label1);
            this.pnlCreatePlaylistSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCreatePlaylistSection.Location = new System.Drawing.Point(0, 303);
            this.pnlCreatePlaylistSection.Name = "pnlCreatePlaylistSection";
            this.pnlCreatePlaylistSection.Size = new System.Drawing.Size(980, 52);
            this.pnlCreatePlaylistSection.TabIndex = 1;
            // 
            // btnCreatePlaylist
            // 
            this.btnCreatePlaylist.BackColor = System.Drawing.Color.White;
            this.btnCreatePlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePlaylist.Location = new System.Drawing.Point(488, 11);
            this.btnCreatePlaylist.Name = "btnCreatePlaylist";
            this.btnCreatePlaylist.Size = new System.Drawing.Size(160, 30);
            this.btnCreatePlaylist.TabIndex = 5;
            this.btnCreatePlaylist.Text = "Create Playlist";
            this.btnCreatePlaylist.UseVisualStyleBackColor = false;
            this.btnCreatePlaylist.Click += new System.EventHandler(this.btnCreatePlaylist_Click);
            // 
            // txtPlaylistName
            // 
            this.txtPlaylistName.BackColor = System.Drawing.SystemColors.Window;
            this.txtPlaylistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaylistName.Location = new System.Drawing.Point(148, 14);
            this.txtPlaylistName.Name = "txtPlaylistName";
            this.txtPlaylistName.Size = new System.Drawing.Size(318, 24);
            this.txtPlaylistName.TabIndex = 4;
            this.txtPlaylistName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaylistName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Playlist Name";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.btnBack.Enabled = false;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.Location = new System.Drawing.Point(879, 1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(101, 34);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // addMusicToPlaylistToolStripMenuItem
            // 
            this.addMusicToPlaylistToolStripMenuItem.Name = "addMusicToPlaylistToolStripMenuItem";
            this.addMusicToPlaylistToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.addMusicToPlaylistToolStripMenuItem.Text = "Add Music To Playlist";
            this.addMusicToPlaylistToolStripMenuItem.Click += new System.EventHandler(this.addMusicToPlaylistToolStripMenuItem_Click);
            // 
            // ctrMusicPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlCreatePlaylistSection);
            this.Controls.Add(this.PlayLists);
            this.Name = "ctrMusicPlaylist";
            this.Size = new System.Drawing.Size(980, 355);
            this.Load += new System.EventHandler(this.ctrMusicPlaylist_Load);
            this.cmsPlaylistProperty.ResumeLayout(false);
            this.pnlCreatePlaylistSection.ResumeLayout(false);
            this.pnlCreatePlaylistSection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView PlayLists;
        private System.Windows.Forms.Panel pnlCreatePlaylistSection;
        private System.Windows.Forms.TextBox txtPlaylistName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreatePlaylist;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ContextMenuStrip cmsPlaylistProperty;
        private System.Windows.Forms.ToolStripMenuItem deletePlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMusicToPlaylistToolStripMenuItem;
    }
}
