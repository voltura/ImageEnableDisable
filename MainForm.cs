﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace ImageEnableDisable
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeImage(ref _pictureBox1);
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
        }

        private static void LogCaller()
        {
            StackTrace stackTrace = new StackTrace();
            var functionCalled = stackTrace.GetFrame(1).GetMethod().Name;
            var functionCalledFrom = stackTrace.GetFrame(2).GetMethod().Name;
            Debug.WriteLine(string.Format("{0} called from {1}", functionCalled, functionCalledFrom));
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            SwitchImage((PictureBox)sender);
        }

        private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            SwitchImage((PictureBox)sender);
        }
    }
}