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
            navigation[1].Click += Click_OpenAuthorityMana;
            navigation[2].Click += Click_OpenCollegeMana;
            navigation[3].Click += Click_OpenAccountMana;
            naMenu.Items = navigation;
            //控件事件(sender=控件对象)
            naMenu.ClickItemed += NaMenu_ClickItemed;
        }

        private void Click_OpenAccountMana(object sender, EventArgs e)
        {
            MessageBox.Show("打开账号管理");
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
            MessageBox.Show("打开课程信息管理");
        }

        private void Click_OpenClassInforamationMana(object sender, EventArgs e)
        {
            MessageBox.Show("打开班级信息管理");
        }

        private void Click_OpenStudetnInforamationMana(object sender, EventArgs e)
        {
            MessageBox.Show("打开学生信息管理");
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
