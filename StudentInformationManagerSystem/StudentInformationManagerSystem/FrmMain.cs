using HZH_Controls.Controls;
using StudentInformationManagerSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationManagerSystem
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadNavigationMenuItem();
            LoadMenuItem();
        }
        //垂直导航菜单(垂直的)
        private void LoadMenuItem() {
            tvMenu.Nodes.Add("通知");
            tvMenu.Nodes[0].Tag = -1;
            tvMenu.Nodes[0].Nodes.Add("操作通知");
            tvMenu.Nodes[0].Nodes[0].Tag = 0;
            tvMenu.Nodes.Add("排班");
            tvMenu.Nodes[1].Nodes.Add("我的排班");
            tvMenu.Nodes[1].Nodes[0].Tag = 1;
            tvMenu.Nodes[1].Tag = -1;
            tvMenu.Nodes.Add("新闻");
            tvMenu.Nodes[2].Nodes.Add("学院新闻");
            tvMenu.Nodes[2].Nodes[0].Tag = 2;
            tvMenu.Nodes[2].Tag = -1;
            tvMenu.AfterSelect += Click_OpenAdminModifyDataInformation;
        }
        private void Click_OpenAdminModifyDataInformation(object sender, TreeViewEventArgs e)
        {
            var tag = (int)e.Node.Tag;
            switch (tag)
            {
                case 0:
                    {
                        MessageBox.Show("操作通知");

                    }; break;
                case 1:
                    {
                        MessageBox.Show("我的排班");
                    }; break;
                case 2:
                    {
                        MessageBox.Show("学院新闻");
                    }; break;
                default: break;
            }
        }

        //加载导航菜单（横向的）
        private void LoadNavigationMenuItem()
        {
            //加载导航栏菜单项
            //为各个菜单项添加事件触发
            ExpandNavigationMenuItem[] it1 = new ExpandNavigationMenuItem[] {
                new ExpandNavigationMenuItem{Text="学生信息管理" },
                new ExpandNavigationMenuItem{ Text="班级信息管理"},
                new ExpandNavigationMenuItem{ Text="课程信息管理"},
                new ExpandNavigationMenuItem{ Text="教师信息管理"},
            };
            it1[0].Click += Click_OpenStudetnInforamationMana;
            it1[1].Click += Click_OpenClassInforamationMana;
            it1[2].Click += Click_OpenCourseInforamtionMna;
            it1[3].Click += Click_OPenTeachInforamtionMana;
            ExpandNavigationMenuItem[] navigation = new ExpandNavigationMenuItem[] {
                new ExpandNavigationMenuItem{Text="信息管理",Items=it1,ShowTip=true},
                new ExpandNavigationMenuItem{ Text="权限管理"},
                new ExpandNavigationMenuItem{ Text="学院管理"},
                new ExpandNavigationMenuItem{ Text="账户管理",AnchorRight=true},
            };
            var it2 = new ExpandNavigationMenuItem[] {
                new ExpandNavigationMenuItem{Text="修改密码" },
                new ExpandNavigationMenuItem{ Text="退出"},
            };
            it2[0].Click += Click_OpenModifyPwd;
            it2[1].Click += Click_LogOut;
            navigation[3].Items = it2;
            navigation[1].Click += Click_OpenAuthorityMana;
            navigation[2].Click += Click_OpenCollegeMana;
            naMenu.Items = navigation;
            //控件事件(sender=控件对象)
            naMenu.ClickItemed += NaMenu_ClickItemed;
        }
        private void Click_LogOut(object sender, EventArgs e) { 
            MessageBox.Show("退出");
            this.Close();
        }
        private void Click_OpenModifyPwd(object sender, EventArgs e)
        {
            MessageBox.Show("修改密码");
        }

        private void Click_OpenCollegeMana(object sender, EventArgs e)
        {
            MessageBox.Show("打开学员管理");
        }

        private void Click_OpenAuthorityMana(object sender, EventArgs e)
        {
            MessageBox.Show("打开权限管理");
        }

        private void Click_OPenTeachInforamtionMana(object sender, EventArgs e)
        {
            MessageBox.Show("打开教师信息管理");
        }

        private void Click_OpenCourseInforamtionMna(object sender, EventArgs e)
        {
            FrmCourseMana courseMain = new FrmCourseMana();
            Hide();
            courseMain.ShowDialog();
            Show();
        }

        private void Click_OpenClassInforamationMana(object sender, EventArgs e)
        {
            //打开班级信息管理窗口
            FrmClassMana classMain = new FrmClassMana();
            Hide();
            classMain.ShowDialog();
            Show();
        }

        private void Click_OpenStudetnInforamationMana(object sender, EventArgs e)
        {
            //打开学生管理窗口
            FrmStudentMana stumain = new FrmStudentMana();
            Hide();
            stumain.ShowDialog();
            Show();
        }

        private void NaMenu_ClickItemed(object sender, EventArgs e)
        {
            UCNavigationMenu nav = sender as UCNavigationMenu;
            if (nav == null)
            {
                return;
            }
            var ck= naMenu.SelectItem as ExpandNavigationMenuItem;
            //无论它是什么，我只要触发与其相关联的事件就行
            ck.Start(naMenu.SelectItem, null);
        }
    }
}
