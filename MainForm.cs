using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime;
using System.Windows.Forms;

namespace ImageEnableDisable
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            SetGCSettings();
            InitializeComponent();
            InitializeImage(ref pictureBoxA);
        }

        private void PictureBoxA_MouseLeave(object sender, EventArgs e)
        {
            SwitchImage((PictureBox)sender);
        }

        private void PictureBoxA_MouseEnter(object sender, EventArgs e)
        {
            SwitchImage((PictureBox)sender);
        }

        private void PictureBoxA_Click(object sender, EventArgs e)
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

        private static void InitializeImage(ref PictureBox pb)
        {
            LogCaller();
            try
            {
                pb.Load(@"http://voltura.se/voltura/wp-content/themes/zwin/images/photo.jpg");
                using (Bitmap c = new Bitmap(pb.Image))
                {
                    pb.InitialImage = ToolStripRenderer.CreateDisabledImage(c);
                    pb.BackgroundImage = pb.Image;
                    pb.Image = pb.InitialImage;
                }
                new ToolTip().SetToolTip(pb, "Click me");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        private static void SwitchImage(PictureBox pb)
        {
            LogCaller();
            pb.InitialImage = pb.Image;
            pb.Image = pb.BackgroundImage;
            pb.BackgroundImage = pb.InitialImage;
            CleanupMemory();
        }

        private static void CleanupMemory()
        {
            LogCaller();
            GC.Collect();
            GC.WaitForFullGCComplete(1000);
        }

        private static void SetGCSettings()
        {
            GCSettings.LargeObjectHeapCompactionMode = GCLargeObjectHeapCompactionMode.CompactOnce;
            GCSettings.LatencyMode = GCLatencyMode.Batch;
        }

        private static void LogCaller()
        {
            StackTrace stackTrace = new StackTrace();
            string method = stackTrace.GetFrame(1).GetMethod().Name;
            string callee = stackTrace.GetFrame(2).GetMethod().Name;
            Debug.WriteLine($"{method} called from {callee}");
        }
    }
}