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
    public partial class VMenu : UserControl
    {
        public VMenu()
        {
            InitializeComponent();

        }

        public void SetMenu(VMenuItem[] menuItems)
        {
            var pnl = this;
            var lst = new List<MenuItem>();
            var index = 0;
            foreach(var item in menuItems)
            {
                if (!item.HasSubMenuItem)
                {
                    var mi = new MenuItemGeneral();
                    mi.Dock = DockStyle.Top;
                    mi.SetButton(item.Text, item.LeftImage, item.ClickAction);
                    mi.Tag = index;
                    lst.Add(mi);
                }
                else
                {
                    var mi = new MenuItemWithSubItem();
                    mi.Dock = DockStyle.Top;
                    mi.Text = item.Text;
                    if (item.LeftImage != null)
                    {
                        mi.SetLeftImage(item.LeftImage);
                    }
                    mi.Tag = index;
                    lst.Add(mi);
                    foreach (var m in item.SubItems)
                    {
                        mi.AddButton(m.Text, m.LeftImage, m.ClickAction);
                    }
                }
                index ++;
            }
            var vmis = lst.OrderByDescending(x => (int)x.Tag);
            foreach (var c in vmis) pnl.Controls.Add(c);

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
        }
    }

    public class VMenuItem
    {
        /// <summary>
        /// 按钮标题
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// 按钮动作
        /// </summary>
        public Action ClickAction { get; set; }
        /// <summary>
        /// 左侧图标
        /// </summary>
        public Bitmap LeftImage { get; set; }
        /// <summary>
        /// 右侧图标
        /// </summary>
        public Bitmap RightImage { get; set; }
        /// <summary>
        /// 是否包含子菜单项
        /// </summary>
        public bool HasSubMenuItem { get; set; }
        /// <summary>
        /// 子菜单项
        /// </summary>
        public IEnumerable<VMenuItem> SubItems { get; set; }
    }
}
