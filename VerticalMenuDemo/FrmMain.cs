using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VerticalMenu;
namespace VerticalMenuDemo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //vMenu1.SetMenu(new[] { "学生考勤", "开始上课", "课堂提问" });

            vMenu1.SetMenu(new VMenuItem[]
            {
                new VMenuItem{ Text = "学生考勤", HasSubMenuItem = false, LeftImage = Properties.Resources.analysis, ClickAction = ()=>{
                    // 此处添加Click响应
                    ;
                } },
                new VMenuItem{ Text = "开始上课", HasSubMenuItem = false, LeftImage = Properties.Resources.Start, ClickAction = ()=>{
                    // 此处添加Click响应
                    ;
                } },
                new VMenuItem{ Text = "课堂提问", HasSubMenuItem = true, LeftImage = Properties.Resources.menu, SubItems = new []{
                    new VMenuItem{ Text = "发送问题", HasSubMenuItem = false, LeftImage = Properties.Resources.analysis, ClickAction = ()=>{
                        // 此处添加Click响应
                        ;
                    } },
                    new VMenuItem{ Text = "展示问题", HasSubMenuItem = false, LeftImage = Properties.Resources.analysis, ClickAction = ()=>{
                        // 此处添加Click响应
                        ;
                    } },
                    new VMenuItem{ Text = "语音问题", HasSubMenuItem = false, LeftImage = Properties.Resources.analysis, ClickAction = ()=>{
                        // 此处添加Click响应
                        ;
                    } },
                    new VMenuItem{ Text = "课堂测试", HasSubMenuItem = false, LeftImage = Properties.Resources.analysis, ClickAction = ()=>{
                        // 此处添加Click响应
                        ;
                    } },
                } },
                new VMenuItem{ Text = "备课资料", HasSubMenuItem = false, LeftImage = Properties.Resources.Start, ClickAction = ()=>{
                    // 此处添加Click响应
                    ;
                } },
                new VMenuItem{ Text = "接收上传", HasSubMenuItem = false, LeftImage = Properties.Resources.Start, ClickAction = ()=>{
                    // 此处添加Click响应
                    ;
                } },
                new VMenuItem{ Text = "效果分析", HasSubMenuItem = true, LeftImage = Properties.Resources.menu, SubItems = new []{
                    new VMenuItem{ Text = "问答分析", HasSubMenuItem = false, LeftImage = Properties.Resources.analysis, ClickAction = ()=>{
                        // 此处添加Click响应
                        ;
                    } },
                    new VMenuItem{ Text = "测试分析", HasSubMenuItem = false, LeftImage = Properties.Resources.analysis, ClickAction = ()=>{
                        // 此处添加Click响应
                        ;
                    } },
                } },
                new VMenuItem{ Text = "班级图像", HasSubMenuItem = false, LeftImage = Properties.Resources.Start, ClickAction = ()=>{
                    // 此处添加Click响应
                    ;
                } },
                new VMenuItem{ Text = "教辅展示", HasSubMenuItem = false, LeftImage = Properties.Resources.Start, ClickAction = ()=>{
                    // 此处添加Click响应
                    ;
                } },
                new VMenuItem{ Text = "声音控制", HasSubMenuItem = false, LeftImage = Properties.Resources.Start, ClickAction = ()=>{
                    // 此处添加Click响应
                    ;
                } },
                new VMenuItem{ Text = "协同教师", HasSubMenuItem = false, LeftImage = Properties.Resources.Start, ClickAction = ()=>{
                    // 此处添加Click响应
                    ;
                } },
                new VMenuItem{ Text = "提示屏", HasSubMenuItem = true, LeftImage = Properties.Resources.menu, SubItems = new []{
                    new VMenuItem{ Text = "学生列表", HasSubMenuItem = false, LeftImage = Properties.Resources.analysis, ClickAction = ()=>{
                        // 此处添加Click响应
                        ;
                    } },
                    new VMenuItem{ Text = "班级图像", HasSubMenuItem = false, LeftImage = Properties.Resources.analysis, ClickAction = ()=>{
                        // 此处添加Click响应
                        ;
                    } },
                    new VMenuItem{ Text = "问答分析", HasSubMenuItem = false, LeftImage = Properties.Resources.analysis, ClickAction = ()=>{
                        // 此处添加Click响应
                        ;
                    } },
                    new VMenuItem{ Text = "测试分析", HasSubMenuItem = false, LeftImage = Properties.Resources.analysis, ClickAction = ()=>{
                        // 此处添加Click响应
                        ;
                    } },
                    new VMenuItem{ Text = "考勤统计", HasSubMenuItem = false, LeftImage = Properties.Resources.analysis, ClickAction = ()=>{
                        // 此处添加Click响应
                        ;
                    } },
                } },
            });
        }
    }
}
