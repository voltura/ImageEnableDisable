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
            this._pictureBoxAsButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBoxAsButton)).BeginInit();
            this.SuspendLayout();
            // 
            // _pictureBoxAsButton
            // 
            this._pictureBoxAsButton.BackColor = System.Drawing.Color.Transparent;
            this._pictureBoxAsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pictureBoxAsButton.Location = new System.Drawing.Point(0, 0);
            this._pictureBoxAsButton.Name = "_pictureBoxAsButton";
            this._pictureBoxAsButton.Size = new System.Drawing.Size(600, 400);
            this._pictureBoxAsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this._pictureBoxAsButton.TabIndex = 0;
            this._pictureBoxAsButton.TabStop = false;
            this._pictureBoxAsButton.WaitOnLoad = true;
            this._pictureBoxAsButton.Click += new System.EventHandler(this._pictureBox1_Click);
            this._pictureBoxAsButton.MouseEnter += new System.EventHandler(this.PictureBox1_MouseEnter);
            this._pictureBoxAsButton.MouseLeave += new System.EventHandler(this.PictureBox1_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this._pictureBoxAsButton);
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
            ((System.ComponentModel.ISupportInitialize)(this._pictureBoxAsButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox _pictureBoxAsButton;
    }
}