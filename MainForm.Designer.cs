namespace ImageEnableDisable
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pictureBoxAsButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAsButton)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAsButton
            // 
            this.pictureBoxAsButton.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxAsButton.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAsButton.Name = "pictureBoxAsButton";
            this.pictureBoxAsButton.Size = new System.Drawing.Size(600, 400);
            this.pictureBoxAsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxAsButton.TabIndex = 0;
            this.pictureBoxAsButton.TabStop = false;
            this.pictureBoxAsButton.WaitOnLoad = true;
            this.pictureBoxAsButton.Click += new System.EventHandler(this.PictureBox1_Click);
            this.pictureBoxAsButton.MouseEnter += new System.EventHandler(this.PictureBox1_MouseEnter);
            this.pictureBoxAsButton.MouseLeave += new System.EventHandler(this.PictureBox1_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.pictureBoxAsButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Enable Disable Example";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAsButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAsButton;
    }
}