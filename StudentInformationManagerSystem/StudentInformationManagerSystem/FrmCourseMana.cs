using HZH_Controls.Controls;
using HZH_Controls.Forms;
using StudentInformationManagerSystem.BLL;
using StudentInformationManagerSystem.DAL;
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
    public partial class FrmCourseMana : Form
    {
        public FrmCourseMana()
        {
            InitializeComponent();
        }
        private int curIndex = 1;
        private int dataLength = 16;
        //不同的ModelID具有不同的查询选项
        private int modelID = -1;
        private void FrmCourseMana_Load(object sender, EventArgs e)
        {
            LoadNavMenu();
            LoadTreeView();
            LoadInitDataGridView();
        }
        //初始化树:主要是依靠ClassID来查询每个班级开课信息
        private void LoadTreeView() {
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
        //初始加载所有课程信息（此课程信息即本学校所开设的课程）
        private void LoadInitDataGridView() {
            T_CourseDAL dal = new T_CourseDAL();
            int temp = curIndex;
            List<T_CourseName> res = null;
            try
            {
                curIndex = 1;
                res= dal.ExecuteListCourseName(curIndex, dataLength);
            }
            catch
            {
                curIndex = temp;
            }
            if (res == null) return;
            dataGridView1.DataSource = res;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        //加载导航栏
        private void LoadNavMenu()
        {
            //配置nav导航栏
            ExpandNavigationMenuItem[] it1 = new ExpandNavigationMenuItem[] {
                new ExpandNavigationMenuItem(){Text="查询"},
                new ExpandNavigationMenuItem(){Text="更新" },
                new ExpandNavigationMenuItem() {Text="插入" },
                new ExpandNavigationMenuItem() {Text="删除" },
                new ExpandNavigationMenuItem(){Text="下一页",AnchorRight=true},
                new ExpandNavigationMenuItem(){Text="上一页" ,AnchorRight=true}
            };
            it1[4].Click += NextPage;
            it1[5].Click += PrePage;

            ExpandNavigationMenuItem[] it2 = new ExpandNavigationMenuItem[] {
                new ExpandNavigationMenuItem(){Text="课程信息" },
                new ExpandNavigationMenuItem(){Text="学生成绩" },
                new ExpandNavigationMenuItem(){Text="班级开课信息" }
            };
            it1[0].Items = it2;
            ExpandNavigationMenuItem[] it3 = new ExpandNavigationMenuItem[] {
                new ExpandNavigationMenuItem(){Text="查询所有" },
                new ExpandNavigationMenuItem(){Text="模糊查询" }
            };
            it3[0].Click += OpenCourseDataInformationQueryAll;
            it3[1].Click += OpenCourseDataInformationFulySearch;
            it2[0].Items = it3;
            ExpandNavigationMenuItem[] it4 = new ExpandNavigationMenuItem[] {
                new ExpandNavigationMenuItem(){Text="查询所有" },
                new ExpandNavigationMenuItem(){Text="模糊查询" }
            };
            it4[0].Click += OpenCourseFactionDataInformationQueryAll; ;
            it4[1].Click += OpenCourseFactionDataInformationFulySerach; ;
            it2[1].Items = it4;
            ExpandNavigationMenuItem[] it8 = new ExpandNavigationMenuItem[] {
                new ExpandNavigationMenuItem(){Text="查询所有" },
                new ExpandNavigationMenuItem(){Text="模糊查询" },
            };
            it8[0].Click += OpenClassOurseDataInformationQueryAll;
            it8[1].Click += OpenClassCourseDataInforamtionFulySerach; ;
            it2[2].Items = it8;
            ExpandNavigationMenuItem[] it5 = new ExpandNavigationMenuItem[] {
                new ExpandNavigationMenuItem(){Text="更新班级开课信息" },
                new ExpandNavigationMenuItem(){Text="更新成绩信息"}
            };
            it1[1].Items = it5;
            it5[0].Click += OpenUpdataCourseDataInformation;
            it5[1].Click += OpenUpdataCourseFactionDataInformation;
            ExpandNavigationMenuItem[] it6 = new ExpandNavigationMenuItem[] {
                new ExpandNavigationMenuItem(){Text="插入班级开课信息" },
                new ExpandNavigationMenuItem(){Text="插入成绩信息"}
            };
            it6[0].Click += OpenInsertCourseDataInformation;
            it6[1].Click += OpenInsertCourseFactionDataInformation;
            it1[2].Items = it6;
            ExpandNavigationMenuItem[] it7 = new ExpandNavigationMenuItem[] {
                new ExpandNavigationMenuItem(){Text="删除班级开课信息" },
                new ExpandNavigationMenuItem(){Text="删除成绩信息"}
            };
            it7[0].Click += OpenDeleteCourseDataInformation; ;
            it7[1].Click += OpenDeleteCourseFactionDataInformation; ;
            it1[3].Items = it7;
            navMenu.Items = it1;
            navMenu.ClickItemed += OpenStart;

        }

        private void OpenClassCourseDataInforamtionFulySerach(object sender, EventArgs e)
        {
            //班级开课信息模糊查询
            FrmInputs inputs = new FrmInputs("班级开课查询", new string[] { "课程名", "班级名", "教师名" }, new Dictionary<string, HZH_Controls.TextInputType>() { { "课程名", HZH_Controls.TextInputType.Regex }, { "班级名", HZH_Controls.TextInputType.Regex }, { "教师名", HZH_Controls.TextInputType.Regex } }, new Dictionary<string, string>() { { "课程名", @"^.+$" }, { "班级名", @"^[\u4E00-\u9FFF0-9]+$" }, {"教师名", @"^[\u4E00-\u9FFF0-9]+$" } });
            var dialogRes=inputs.ShowDialog();
            if (dialogRes == DialogResult.Cancel)
            {
                return;
            }
            values = new string[] { inputs.Values[0], inputs.Values[1], inputs.Values[2] };
            InitialCurIndexToLoades(2);
        }

        private void OpenClassOurseDataInformationQueryAll(object sender, EventArgs e)
        {
            //查询班级开课信息
            InitialCurIndexToLoades(1);
        }
        //0:courseName 1:className 2:teachName
        private string[] values;
        private void PrePage(object sender, EventArgs e)
        {
            //上一页
            int temp = curIndex;
            object res = null;
            try
            {
                curIndex -= 1;
                res=Loades();
                if (res == null) throw new Exception();
                SetDataGridViewDataSource(res);
            }
            catch
            {
                curIndex = temp;
            }
        }

        private void NextPage(object sender, EventArgs e)
        {
            //下一页
            object res = null;
            int temp = curIndex;
            try
            {
                curIndex += 1;
                res = Loades();
                if (res == null) throw new Exception();
                SetDataGridViewDataSource(res);
            }
            catch
            {
                curIndex = temp;
            }
        }
        private void OpenDeleteCourseFactionDataInformation(object sender, EventArgs e)
        {
           //删除学生成绩信息
            MessageBox.Show("删除学生成绩信息");
        }

        private void OpenDeleteCourseDataInformation(object sender, EventArgs e)
        {
            //删除客课程信息
            MessageBox.Show("删除班级开课信息");
        }

        private void OpenInsertCourseFactionDataInformation(object sender, EventArgs e)
        {
            //插入学生成绩信息
            MessageBox.Show("插入学生成绩信息");
        }

        private void OpenInsertCourseDataInformation(object sender, EventArgs e)
        {
            //插入课程信息
            MessageBox.Show("插入班级开课信息");
        }

        private void OpenUpdataCourseFactionDataInformation(object sender, EventArgs e)
        {
            //更新学生成绩信息
            MessageBox.Show("更新学生成绩信息");
        }

        private void OpenUpdataCourseDataInformation(object sender, EventArgs e)
        {
            //更新课程信息
            MessageBox.Show("更新班级开课信息");
        }

        //触发事件
        private void OpenStart(object sender, EventArgs e)
        {
            var sen = sender as UCNavigationMenu;
            if (sen == null) return;
            var item = sen.SelectItem as ExpandNavigationMenuItem;
            if (item == null) return;
            item.Start(item,e);
        }

        private void OpenCourseFactionDataInformationFulySerach(object sender, EventArgs e)
        {
            //学生成绩模糊查询
            FrmInputs inputs = new FrmInputs("成绩查询",new string[] {"学生编号","学生姓名","课程名称","教师姓名"}, new Dictionary<string, HZH_Controls.TextInputType>() { {"学生编号",HZH_Controls.TextInputType.Regex },{ "学生姓名",HZH_Controls.TextInputType.Regex},{"课程名称",HZH_Controls.TextInputType.Regex },{"教师姓名",HZH_Controls.TextInputType.Regex } },new Dictionary<string, string>() { { "学生编号",@"^\d+$" },{"学生姓名", @"^[\u4E00-\u9FFF]+$" },{"课程名称",@"^.+$" },{"教师姓名",@"^[\u4E00-\u9FFF]$" } });
            var dialogRes=inputs.ShowDialog();
            if (dialogRes == DialogResult.Cancel)
            {
                return;
            }
            values = new string[] { inputs.Values[0], inputs.Values[1], inputs.Values[2], inputs.Values[3]};
            InitialCurIndexToLoades(4);
        }

        private void OpenCourseFactionDataInformationQueryAll(object sender, EventArgs e)
        {
            //学生成绩查询所有
            InitialCurIndexToLoades(3);
        }

        private void OpenCourseDataInformationFulySearch(object sender, EventArgs e)
        {
            //课程信息模糊查询
            FrmInputs inputs = new FrmInputs("课程查询",new string[] {"课程名"},new Dictionary<string, HZH_Controls.TextInputType>() { {"课程名",HZH_Controls.TextInputType.Regex } },new Dictionary<string, string>() { { "课程名", @"^.+$" } });
            var dialogRes=inputs.ShowDialog();
            if (dialogRes == DialogResult.Cancel)
            {
                return;
            }
            values = new string[] { inputs.Values[0] };
            InitialCurIndexToLoades(0);
        }

        private void OpenCourseDataInformationQueryAll(object sender, EventArgs e)
        {
            //课程信息查询所有
            InitialCurIndexToLoades(-1);
        }
        private void trvEx1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int temp1 = curIndex;
            var @class = e.Node.Tag as T_Class;
            if (@class == null) return;
            string className = @class.ClassName;
            values = new string[] { string.Empty, className, string.Empty };
            //根据class来进行查询它下面的开课信息
            InitialCurIndexToLoades(2);
        }
        /// <summary>
        /// 初始化modelID和curIndex并调用Loades方法进行查询
        /// </summary>
        /// <param name="modelID"></param>
        /// <param name="curindex"></param>
        private void InitialCurIndexToLoades(int modelID, int curindex = 1){
            this.modelID = modelID;
            int temp = curIndex;
            try
            {
                this.curIndex = curindex;
                var res = Loades();
                SetDataGridViewDataSource(res);
            }
            catch
            {
                curIndex = temp;
            }
        }
        /// <summary>
        /// 根据ModelID选项来设查询
        /// </summary>
        /// <returns></returns>
        private object Loades() {
            object res = null;
            T_CourseDAL dal = new T_CourseDAL();
            switch (modelID)
            {
                case -1: { res = dal.ExecuteListCourseName(curIndex, dataLength); }; break;
                case 0: { res = dal.ExecuteListCourseName(curIndex, dataLength, values[0]); }; break;
                case 1:
                    {
                        res = dal.ExecuteT_Course(curIndex, dataLength, string.Empty, string.Empty, string.Empty);
                    }; break;
                case 2: {
                        res = dal.ExecuteT_Course(curIndex, dataLength, values[0], values[1], values[2]); 
                    }; break;
                case 3: {
                        res = dal.ExecuteT_CourseFaction(curIndex, dataLength, string.Empty,string.Empty,string.Empty,string.Empty);
                    };break;
                case 4: {
                        res = dal.ExecuteT_CourseFaction(curIndex, dataLength,  values[0], values[1], values[2], values[3]);
                    }; break;
                default:; break;
            }
            return res;
        }
        /// <summary>
        /// 设置DataGridView数据源
        /// </summary>
        /// <param name="set"></param>
        private void SetDataGridViewDataSource(object set) {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = set;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
