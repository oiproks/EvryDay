using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;

namespace EvryDay
{
    public partial class Main : Form
    {
        #region Variables
        ToolTip tip = new ToolTip();
        VideoCaptureDevice videoCaptureDevice;
        FilterInfoCollection filterInfoCollection;
        bool hasCamera = false, snapshot = false;
        Image defaultImage = null;
        #endregion

        #region Common
        public Main()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            while (!hasCamera)
            {
                filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                foreach (FilterInfo filterInfo in filterInfoCollection)
                    cmbCameras.Items.Add(filterInfo.Name);

                if (cmbCameras.Items.Count > 0)
                {
                    cmbCameras.SelectedIndex = 0;
                    VideoCaptureDeviceInit();
                    hasCamera = true;
                }
                else if (MessageBox.Show(this, "No camera connected", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                    break;
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopVideo();

            Environment.Exit(0);
        }

        #region TopBar Buttons
        private void Min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Expand_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ToolTipOn(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string text = string.Empty;
            int x = button.Location.X;
            int y = button.Location.Y + button.Height + 5;
            switch (button.Tag)
            {
                case "minimize":
                    text = "Minimize on taskbar";
                    break;
                case "close":
                    text = "Quit";
                    break;
                case "maximize":
                    if (WindowState == FormWindowState.Normal)
                        text = "Maximize";
                    else
                        text = "Restore down";
                    break;
                default:
                    break;
            }
            tip.Dispose();
            tip = new ToolTip();
            tip.Show(text,
                this,
                x,
                y,
                5000);
        }

        private void ToolTipOff(object sender, EventArgs e)
        {
            if (tip.Active)
                tip.Dispose();
        }
        #endregion

        #region Interface Interactions
        bool mouseDown = false;
        Point lastLocation;
        private void Interface_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Interface_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point((Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);
                Update();
            }
        }

        private void Interface_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private const int cGrip = 16;      // Grip size
        private const int cBorder = 5;      // Border size

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);

                if (pos.X <= cBorder)
                {
                    m.Result = (IntPtr)10; // Left border
                    return;
                }
                else if (pos.X >= this.ClientSize.Width - cBorder && pos.Y <= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)11; // Right border
                    return;
                }
                else if (pos.X <= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cBorder)
                {
                    m.Result = (IntPtr)15; // Bottom border
                    return;
                }
                else if (pos.Y <= cBorder)
                {
                    m.Result = (IntPtr)12; // Bottom border
                    return;
                }
                else if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // Bottom Right Corner
                    return;
                }
            }
            base.WndProc(ref m);
        }
        #endregion
        #endregion

        #region CameraTab
        #region ShutterButton
        #region VisualEffects
        private void BtnShutter_MouseEnter(object sender, EventArgs e)
        {
            btnShutter.BackgroundImage = Properties.Resources.camera_shutter_over;
        }

        private void BtnShutter_MouseLeave(object sender, EventArgs e)
        {
            btnShutter.BackgroundImage = Properties.Resources.camera_shutter;
        }

        private void BtnShutter_MouseUp(object sender, MouseEventArgs e)
        {
            btnShutter.BackgroundImage = Properties.Resources.camera_shutter_over;
        }

        private void BtnShutter_MouseDown(object sender, MouseEventArgs e)
        {
            btnShutter.BackgroundImage = Properties.Resources.camera_shutter_click;
        }
        #endregion

        private void BtnShutter_Click(object sender, EventArgs e)
        {
            if (!snapshot)
            {
                snapshot = true;

                //TODO: show save/delete button
            }
            else
            {
                snapshot = false;

                if (defaultImage == null)
                    defaultPic.Visible = false;
                else
                {                    
                    defaultPic.Visible = true;
                }

                VideoCaptureDeviceInit();
                
                if (defaultImage != null)
                    defaultPic.Image = SetAlpha((Bitmap)defaultImage, 100);
            }
        }
        #endregion

        #region CameraManager
        private void VideoCaptureDeviceInit()
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cmbCameras.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Image image = (Bitmap)eventArgs.Frame.Clone();
            image.RotateFlip(RotateFlipType.Rotate180FlipY);
            if (snapshot)
            {
                StopVideo();

                //if (defaultImage == null)
                defaultImage = image;

                //defaultPic.Visible = true;
                defaultPic.Visible = true;
                camera.Image = null;
            }
            else
            {
                if (camera.Image != null)
                    camera.Image.Dispose();
                camera.Image = image;
            }
        }

        static Bitmap SetAlpha(Bitmap bmpIn, int alpha)
        {
            Bitmap bmpOut = new Bitmap(bmpIn.Width, bmpIn.Height);
            float a = alpha / 255f;
            Rectangle r = new Rectangle(0, 0, bmpIn.Width, bmpIn.Height);

            float[][] matrixItems = {
                new float[] {1, 0, 0, 0, 0},
                new float[] {0, 1, 0, 0, 0},
                new float[] {0, 0, 1, 0, 0},
                new float[] {0, 0, 0, a, 0},
                new float[] {0, 0, 0, 0, 1}
            };

            ColorMatrix colorMatrix = new ColorMatrix(matrixItems);

            ImageAttributes imageAtt = new ImageAttributes();
            imageAtt.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            using (Graphics g = Graphics.FromImage(bmpOut))
                g.DrawImage(bmpIn, r, r.X, r.Y, r.Width, r.Height, GraphicsUnit.Pixel, imageAtt);

            return bmpOut;
        }

        private void StopVideo()
        {
            if (videoCaptureDevice != null)
            {
                videoCaptureDevice.SignalToStop();
                while (videoCaptureDevice.IsRunning)
                {
                    Thread.Sleep(100);
                }
                videoCaptureDevice.WaitForStop();
                videoCaptureDevice.Stop();
                videoCaptureDevice.NewFrame -= VideoCaptureDevice_NewFrame;
            }
        }
        #endregion
        #endregion

        #region HistoryTab

        #endregion

        #region SettingsTab
        private void CmbCameras_SelectedIndexChanged(object sender, EventArgs e)
        {
            VideoCaptureDeviceInit();
        }
        #endregion
    }
}
