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
            this.pictureBoxA = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAsButton
            // 
            this.pictureBoxA.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxA.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxA.Name = "pictureBoxAsButton";
            this.pictureBoxA.Size = new System.Drawing.Size(600, 400);
            this.pictureBoxA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxA.TabIndex = 0;
            this.pictureBoxA.TabStop = false;
            this.pictureBoxA.WaitOnLoad = true;
            this.pictureBoxA.Click += new System.EventHandler(this.PictureBoxA_Click);
            this.pictureBoxA.MouseEnter += new System.EventHandler(this.PictureBoxA_MouseEnter);
            this.pictureBoxA.MouseLeave += new System.EventHandler(this.PictureBoxA_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.pictureBoxA);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxA;
    }
}