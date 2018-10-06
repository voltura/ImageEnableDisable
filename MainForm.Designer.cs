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
            this._pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox1)).BeginInit();
            this.SuspendLayout();
            this._pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this._pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pictureBox1.Location = new System.Drawing.Point(0, 0);
            this._pictureBox1.Name = "_pictureBox1";
            this._pictureBox1.Size = new System.Drawing.Size(600, 400);
            this._pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this._pictureBox1.TabIndex = 0;
            this._pictureBox1.TabStop = false;
            this._pictureBox1.WaitOnLoad = true;
            this._pictureBox1.MouseEnter += new System.EventHandler(this.PictureBox1_MouseEnter);
            this._pictureBox1.MouseLeave += new System.EventHandler(this.PictureBox1_MouseLeave);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this._pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Enable Disable Example";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox _pictureBox1;
    }
}