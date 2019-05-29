using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerticalMenu
{
    public class ImageButton : Button
    {
        Bitmap _leftImage = null;
        Bitmap _rightImage = null;
        /// <summary>
        /// 按钮左侧图标，图标大小为24X24
        /// </summary>
        /// <param name="img"></param>
        public void SetLeftImage(Bitmap img)
        {
            if (img != null)
            {
                _leftImage = new Bitmap(img, new Size(16, 16));
            }
            else
            {
                _leftImage = null;
            }
            Refresh();
        }
        /// <summary>
        /// 按钮右侧图标，图标大小为24X24
        /// </summary>
        /// <param name="img"></param>
        public void SetRightImage(Bitmap img)
        {
            if (img != null)
            {
                _rightImage = new Bitmap(img, new Size(16, 16));
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            if (_leftImage != null)
            {
                pevent.Graphics.DrawImage(_leftImage, new PointF(8.0f, 12.0f));
            }
            if (_rightImage != null)
            {
                pevent.Graphics.DrawImage(_rightImage, new PointF(Width - 24 - 8.0f, 12.0f));
            }
        }
    }
}
