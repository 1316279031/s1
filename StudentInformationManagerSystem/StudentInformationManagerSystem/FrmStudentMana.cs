using HZH_Controls.Controls;
using HZH_Controls.Forms;
using StudentInformationManagerSystem.BLL;
using StudentInformationManagerSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationManagerSystem
{
    public partial class FrmStudentMana : Form
    {
        public FrmStudentMana()
        {
            InitializeComponent();
        }
        private int curIndex = 1;
        private int dataLength = 16;
        private int classID = -1;
        private void FrmStudentMana_Load(object sender, EventArgs e)
        {
            LoadNavMenuItem();
            LoadTreeNodes();
            //首先我们加载所有学生信息，以分页的方式显示出来
            dataGridView1.DataSource=new T_StudentDal().LoadStudents(curIndex, dataLength, classID);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].HeaderText = "学生编号";
            dataGridView1.Columns[1].HeaderText = "姓名";
            dataGridView1.Columns[2].HeaderText = "出生年月";
            dataGridView1.Columns[3].HeaderText = "性别";
            dataGridView1.Columns[4].HeaderText="班级编号";
        }
        //加载树
        private void LoadTreeNodes() {
            T_CollegeDAL collegeDal = new T_CollegeDAL();
            T_ClassDAL classDal = new T_ClassDAL();
            var collegeRes=collegeDal.LoadCollege();
            
            TreeNode[] nodes = new TreeNode[collegeRes.Count];
            for (int i = 0; i < collegeRes.Count; i++)
            {
                TreeNode node = new TreeNode();
                node.Text = collegeRes[i].CollegeName;
                node.Tag = collegeRes[i];
                nodes[i] = node;
                var classRes = classDal.LoadClass(collegeRes[i].CollegeID);
                if (classRes == null) continue;
                foreach (var item in classRes)
                {
                    TreeNode node1 = new TreeNode(item.ClassName);
                    node1.Tag = item;
                    nodes[i].Nodes.Add(node1);
                }
            }
            trvEx1.Nodes.AddRange(nodes);
        }
        //加载导航栏
        private void LoadNavMenuItem()
        {
            ExpandNavigationMenuItem[] items = new ExpandNavigationMenuItem[] {
                new ExpandNavigationMenuItem(){Text="查询信息" },
                new ExpandNavigationMenuItem(){Text="更新信息" },
                new ExpandNavigationMenuItem(){ Text="插入信息"},
                new ExpandNavigationMenuItem(){Text="删除信息" },
                 new ExpandNavigationMenuItem(){ Text="下一页",AnchorRight=true},
                new ExpandNavigationMenuItem(){ Text="上一页",AnchorRight=true}
            };
            items[1].Click += Click_OpenUpdateDataInforamtion;
            items[2].Click += Click_OpenInsertDataInforamtion;
            items[3].Click += Click_DeleteDataInforamtion;
            items[4].Click += Click_JumpNextPage;
            items[5].Click += Click_JumpHailPage;
            var it1 = new ExpandNavigationMenuItem[] {
                new ExpandNavigationMenuItem(){Text="查询所有" },
                new ExpandNavigationMenuItem(){Text="模糊查询" },
            };
            it1[0].Click += Click_QueryAll;
            it1[1].Click += Click_QueryOnly;
            navMenu.Items = items;
            navMenu.Items[0].Items = it1;
            navMenu.ClickItemed += Click_Start;
        }
        //下一页
        private void Click_JumpNextPage(object sender, EventArgs e)
        {
            curIndex += 1;
            var res = new T_StudentDal().LoadStudents(curIndex, dataLength, classID);
            if (res == null) {
                curIndex -= 1;
            }
            else
            {
                dataGridView1.DataSource = res;
            }
        }
        //上一页
        private void Click_JumpHailPage(object sender, EventArgs e)
        {
            curIndex -= 1;
            var res = new T_StudentDal().LoadStudents(curIndex, dataLength, classID);
            if (res == null)
            {
                curIndex += 1;
            }
            else
            {
                dataGridView1.DataSource = res;
            }
        }
        //删除数据
        private void Click_DeleteDataInforamtion(object sender, EventArgs e)
        {
            MessageBox.Show("删除");
        }
        //插入数据
        private void Click_OpenInsertDataInforamtion(object sender, EventArgs e)
        {
            MessageBox.Show("插入");
        }
        //更新数据
        private void Click_OpenUpdateDataInforamtion(object sender, EventArgs e)
        {
            MessageBox.Show("更新");
        }

        private void Click_Start(object sender, EventArgs e)
        {
            var sen = sender as UCNavigationMenu;
            if (sen == null) return;
            var item= sen.SelectItem as ExpandNavigationMenuItem;
            item.Start(item,e);
        }

        //模糊查询
        private void Click_QueryOnly(object sender, EventArgs e)
        {
            MessageBox.Show("模糊查询");
        }
        //查询所有
        private void Click_QueryAll(object sender, EventArgs e)
        {
            curIndex = 1;
            classID = -1;
            var res = new T_StudentDal().LoadStudents(curIndex, dataLength, classID);
            if (res == null)
            {
                curIndex -= 1;
            }
            else
            {
                dataGridView1.DataSource = res;
            }
        }

        private void trvEx1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var @class = e.Node.Tag as T_Class;
            if (@class == null) {
                return;
            }
            //保存状态，用于在异常中恢复状态
            int temp1 =classID;
            classID = @class.ClassID;
            //临时保存curIndex页，保证我们的SQL语句在执行报错的情况下，恢复curIndex状态
            int temp2 = curIndex;
            curIndex = 1;
            T_StudentDal dal = new T_StudentDal();
            try
            {
                var res = dal.LoadStudents(curIndex, dataLength, classID);
                dataGridView1.DataSource = res;
            }
            catch
            {
                classID = temp1;
                curIndex = temp2;
            }
        }
    }
}
