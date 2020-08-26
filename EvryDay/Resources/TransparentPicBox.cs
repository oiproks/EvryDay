using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvryDay.Resources
{
    public partial class TransparentPicBox : UserControl
    {
        private Timer refresher;
        private Image _image = null;
        private Image resizedImage = null;

        public TransparentPicBox()
        {
            refresher = new Timer();
            refresher.Tick += new EventHandler(this.TimerOnTick);
            refresher.Interval = 50;
            refresher.Start();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x20;
                return cp;
            }
        }

        protected override void OnMove(EventArgs e)
        {
            base.RecreateHandle();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (_image != null)
            {
                if (resizedImage != null)
                    resizedImage.Dispose();

                if (_image.Size.Width < this.Width)
                {
                    int newWidth = _image.Size.Width * this.Height / _image.Size.Height;
                    resizedImage = new Bitmap(_image, newWidth, this.Height);
                }
                else
                {
                    int newHeight = this.Height * _image.Size.Height / _image.Size.Width;
                    resizedImage = new Bitmap(_image, this.Width, newHeight);
                }
                e.Graphics.DrawImage(resizedImage, 0, 0);
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
        }

        private void TimerOnTick(object source, EventArgs e)
        {
            base.RecreateHandle();
            //refresher.Stop();
        }

        public Image Image
        {
            get
            {
                return _image;
            }
            set
            {
                _image = value;
                base.RecreateHandle();
            }
        }
}
}
