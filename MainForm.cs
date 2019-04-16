using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime;

namespace ImageEnableDisable
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeImage(ref pictureBoxAsButton);
            new ToolTip().SetToolTip(pictureBoxAsButton, "Click me");
        }

        private void InitializeImage(ref PictureBox pictureBox)
        {
            LogCaller();
            try
            {
                pictureBox.UseWaitCursor = true;
                pictureBox.Load(@"http://voltura.se/voltura/wp-content/themes/zwin/images/photo.jpg");
                using (Bitmap c = new Bitmap(pictureBox.Image))
                {
                    pictureBox.InitialImage = ToolStripRenderer.CreateDisabledImage(c);
                    pictureBox.BackgroundImage = pictureBox.Image;
                    pictureBox.Image = pictureBox.InitialImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                pictureBox.UseWaitCursor = false;
            }
        }

        private void SwitchImage(PictureBox pictureBox)
        {
            LogCaller();
            pictureBox.InitialImage = pictureBox.Image;
            pictureBox.Image = pictureBox.BackgroundImage;
            pictureBox.BackgroundImage = pictureBox.InitialImage;
            CleanupMemory();
        }

        private static void CleanupMemory()
        {
            GCSettings.LargeObjectHeapCompactionMode = GCLargeObjectHeapCompactionMode.CompactOnce;
            GCSettings.LatencyMode = GCLatencyMode.Batch;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            GC.WaitForFullGCComplete(1000);
        }

        private static void LogCaller()
        {
            StackTrace stackTrace = new StackTrace();
            var functionCalled = stackTrace.GetFrame(1).GetMethod().Name;
            var functionCalledFrom = stackTrace.GetFrame(2).GetMethod().Name;
            Debug.WriteLine($"{functionCalled} called from {functionCalledFrom}");
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            SwitchImage((PictureBox)sender);
        }

        private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            SwitchImage((PictureBox)sender);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            AskToExit();
        }

        private void AskToExit()
        {
            if (DialogResult.Yes == MessageBox.Show(this,
                $"Close {Application.ProductName}?", $"{Application.ProductName} version {Application.ProductVersion}",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }
    }
}