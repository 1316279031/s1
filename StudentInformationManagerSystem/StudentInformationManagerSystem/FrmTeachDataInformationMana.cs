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
    public partial class FrmTeachDataInformationMana : Form
    {
        public FrmTeachDataInformationMana()
        {
            InitializeComponent();
        }

        private void FrmTeachDataInformationMana_Load(object sender, EventArgs e)
        {
            LoadNavMenu();
        }
        /// <summary>
        /// 加载导航栏目
        /// </summary>
        private void LoadNavMenu()
        {
            ExpandNavigationMenuItem[] item = new ExpandNavigationMenuItem[] {
                new ExpandNavigationMenuItem(){ Text="查询"},
                new ExpandNavigationMenuItem(){ Text="更新"},
                new ExpandNavigationMenuItem(){ Text="增加"},
                new ExpandNavigationMenuItem(){ Text="删除"},
                new ExpandNavigationMenuItem(){ Text="下一页",AnchorRight=true},
                new ExpandNavigationMenuItem(){ Text="上一页",AnchorRight=true},
            };
            ExpandNavigationMenuItem[] serach = new
                ExpandNavigationMenuItem[] {
                    new ExpandNavigationMenuItem(){Text="查询所有"},
                    new ExpandNavigationMenuItem(){Text="模糊查询"},
                    new ExpandNavigationMenuItem(){ Text="授课学生成绩"}
                };
            item[0].Items = serach;
            navMenu.Items = item;
        }
    }
}
