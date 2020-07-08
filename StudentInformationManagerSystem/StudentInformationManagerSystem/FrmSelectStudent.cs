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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationManagerSystem
{
    public partial class FrmSelectStudent : Form
    {
        public FrmSelectStudent()
        {
            InitializeComponent();
        }
        private int curIndex = 1;
        private int dataLength = 16;
        //classID=-1;表示加载所有学生
        private int classID = -1;
        private void FrmSelectStudent_Load(object sender, EventArgs e)
        {
            LoadNavMenuItem();
            LoadTreeNodes();
            //首先我们加载所有学生信息，以分页的方式显示出来
            dataGridView1.DataSource = new T_StudentDal().LoadStudents(curIndex, dataLength, classID);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].HeaderText = "学生编号";
            dataGridView1.Columns[1].HeaderText = "姓名";
            dataGridView1.Columns[2].HeaderText = "出生年月";
            dataGridView1.Columns[3].HeaderText = "性别";
            dataGridView1.Columns[4].HeaderText = "班级编号";
        }
        //加载树
        private void LoadTreeNodes()
        {
            T_CollegeDAL collegeDal = new T_CollegeDAL();
            T_ClassDAL classDal = new T_ClassDAL();
            var collegeRes = collegeDal.LoadCollege();

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
                new ExpandNavigationMenuItem(){Text="确定选取" },
                 new ExpandNavigationMenuItem(){ Text="下一页",AnchorRight=true},
                new ExpandNavigationMenuItem(){ Text="上一页",AnchorRight=true}
            };
            items[1].Click += SelectStudentRows;
            items[2].Click += Click_JumpNextPage;
            items[3].Click += Click_JumpHailPage;
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

        private void SelectStudentRows(object sender, EventArgs e)
        {
            this.Close();
        }
        //返回选择的学生列表
        internal DataGridViewSelectedRowCollection SelectStudents(object arg1, EventArgs arg2)
        {
            return dataGridView1.SelectedRows;
        }
        //下一页
        private void Click_JumpNextPage(object sender, EventArgs e)
        {
            curIndex += 1;
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
        private void Click_Start(object sender, EventArgs e)
        {
            var sen = sender as UCNavigationMenu;
            if (sen == null) return;
            var item = sen.SelectItem as ExpandNavigationMenuItem;
            item.Start(item, e);
        }

        //模糊查询
        private void Click_QueryOnly(object sender, EventArgs e)
        {
            //打开多输入窗口
            FrmInputs input = new FrmInputs("模糊查询", new string[] { "学号", "姓名", "班级编号" });
            input.ShowDialog();
            //获取输入值
            var values = input.Values;
            //进行模糊查询配置
            string t_sql = "select StuID, StuName, StuBirthday, StuSex, ClassID from T_StudentBasicInformation where StuID like @stuID and StuName like @name and ClassID like @classID";
            SqlParameter[] pars = new SqlParameter[] {
                new SqlParameter("@stuID",SqlDbType.VarChar){Value="%"+values[0]+"%" },
                new SqlParameter("@name",SqlDbType.VarChar){Value="%"+values[1]+"%" },
                new SqlParameter("@classID",SqlDbType.VarChar){Value="%"+values[2]+"%" }
            };
            T_StudentDal dal = new T_StudentDal();
            var res = dal.FuzzyQuery(t_sql, CommandType.Text, pars);
            dataGridView1.DataSource = res;
            ResetCurIndexAndClassID(1, classID);
        }
        //查询所有
        private void Click_QueryAll(object sender, EventArgs e)
        {
            ResetCurIndexAndClassID(1, -1);
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
            if (@class == null)
            {
                return;
            }
            //保存状态，用于在异常中恢复状态
            int temp1 = classID;
            classID = @class.ClassID;
            //临时保存curIndex页，保证我们的SQL语句在执行报错的情况下，恢复curIndex状态
            int temp2 = curIndex;
            //重置curIndex=1;(因为页面重新加载了)
            ResetCurIndexAndClassID(1, classID);
            T_StudentDal dal = new T_StudentDal();
            try
            {
                var res = dal.LoadStudents(curIndex, dataLength, classID);
                dataGridView1.DataSource = res;
            }
            catch
            {
                ResetCurIndexAndClassID(temp2, temp1);
            }
        }
        /// <summary>
        /// 重置curIndex与classID
        /// </summary>
        /// <param name="curIndex"></param>
        /// <param name="classID"></param>
        private void ResetCurIndexAndClassID(int curIndex, int classID)
        {
            this.curIndex = curIndex;
            this.classID = classID;
        }
    }
}
