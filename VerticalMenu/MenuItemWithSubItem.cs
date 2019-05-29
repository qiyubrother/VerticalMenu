using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Linq.Expressions;

namespace VerticalMenu
{
    public partial class MenuItemWithSubItem : MenuItem, INotifyPropertyChanged
    {
        // 每个按钮的高度
        private int item_height = 40;
        // 按钮个数
        private int itemCount = 0;

        public MenuItemWithSubItem()
        {
            InitializeComponent();
            // 设置右侧图像
            btnMenuItem.SetRightImage(Properties.Resources.unfold_more_24);
            btnMenuItem.Click += (s, e) =>
            {
                IsShowSubItems = !IsShowSubItems;
                if (!IsShowSubItems)
                {
                    Height = item_height;
                    btnMenuItem.SetRightImage(Properties.Resources.unfold_more_24);
                    btnMenuItem.Refresh();
                }
                else
                {
                    Height = item_height + item_height * itemCount;
                    btnMenuItem.SetRightImage(Properties.Resources.unfold_less_24);
                    btnMenuItem.Refresh();
                }
            };

            PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == "Dock")
                {
                    ;
                }
            };
            // 默认不显示子菜单
            IsShowSubItems = false;
            // 初始化控件高度
            Height = item_height;
        }

        /// <summary>
        /// 是否显示子面板
        /// </summary>
        public bool IsShowSubItems { get; set; }

        public override string Text { get => btnMenuItem.Text; set => btnMenuItem.Text = value; }

        #region 实现INotifyPropertyChanged接口
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        /// <summary>
        /// 设计模式Dock变化后，及时通知设计面板
        /// </summary>
        public override DockStyle Dock { get => base.Dock; set { base.Dock = value; NotifyPropertyChanged("Dock"); } }
        /// <summary>
        /// 添加按钮
        /// </summary>
        /// <param name="name"></param>
        /// <param name="a"></param>
        public void AddButton(string text, Bitmap leftImage, Action a)
        {
            var btn = new ImageButton();
            btn.Dock = DockStyle.Top;
            btn.Text = text;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Height = item_height;
            btn.Location = new System.Drawing.Point(0, 0);
            if (leftImage != null)
            {
                btn.SetLeftImage(leftImage);
            }
            btn.Tag = itemCount + 1;
            if (a != null)
            {
                btn.Click += (o, e) => a();
            }
            pnlContainer.Controls.Add(btn);
            var lst = new List<Button>();
            foreach (Control c in pnlContainer.Controls) lst.Add(c as Button);
            pnlContainer.Controls.Clear();
            var btns = lst.OrderByDescending(x => (int)x.Tag);
            foreach(Button c in btns) pnlContainer.Controls.Add(c);

            if (IsShowSubItems)
            {
                Height = item_height + item_height * itemCount;
            }
            itemCount++;
        }
        /// <summary>
        /// 设置左侧图标
        /// </summary>
        /// <param name="img"></param>
        public void SetLeftImage(Bitmap img) => btnMenuItem.SetLeftImage(img);

    }
}
