namespace Music_Player_Project.Control
{
    partial class ctrHomePage
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
            this.pbHomePage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHomePage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbHomePage
            // 
            this.pbHomePage.Image = global::Music_Player_Project.Properties.Resources.disk_512;
            this.pbHomePage.Location = new System.Drawing.Point(191, 92);
            this.pbHomePage.Name = "pbHomePage";
            this.pbHomePage.Size = new System.Drawing.Size(333, 226);
            this.pbHomePage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHomePage.TabIndex = 0;
            this.pbHomePage.TabStop = false;
            // 
            // ctrHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbHomePage);
            this.Name = "ctrHomePage";
            this.Size = new System.Drawing.Size(765, 471);
            this.Load += new System.EventHandler(this.ctrHomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHomePage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHomePage;
    }
}
