using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerticalMenu
{
    public partial class MenuItemGeneral : MenuItem
    {
        // 按钮的高度
        private int item_height = 40;
        public MenuItemGeneral()
        {
            InitializeComponent();

            btnMenuItem.FlatStyle = FlatStyle.Flat;
            btnMenuItem.FlatAppearance.BorderSize = 0;
            btnMenuItem.Height = 40;
            btnMenuItem.Dock = DockStyle.Top;
            btnMenuItem.Location = new System.Drawing.Point(0, 0);
            Height = item_height;
        }
        /// <summary>
        /// 设置按钮标题
        /// </summary>
        public override string Text { get => btnMenuItem.Text; set => btnMenuItem.Text = value; }
        /// <summary>
        /// 设置左侧图标
        /// </summary>
        /// <param name="img"></param>
        public void SetLeftImage(Bitmap img) => btnMenuItem.SetLeftImage(img);
        public void SetButton(string text, Bitmap img, Action a)
        {
            Text = text;
            SetLeftImage(img);
            if (a != null)
            {
                btnMenuItem.Click += (o, e) => a();
            }            
        }
    }
}
