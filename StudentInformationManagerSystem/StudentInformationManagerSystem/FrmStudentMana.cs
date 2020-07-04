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
    public partial class FrmStudentMana : Form
    {
        public FrmStudentMana()
        {
            InitializeComponent();
        }
        private int curIndex = 1;
        private int dataLength = 16;
        //classID=-1;表示加载所有学生
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
            //选中一行数据删除即可
            //首先检查当前是否已选中DataGridView中的一行
            //选中:则将其数据提取到弹窗中
            //未选中:提示弹窗需要先进行选取一行
            var rows = dataGridView1.SelectedRows;
            //无论用户选择多少行，每次都只获取用户选择的行中的第一行
            if (rows.Count == 0)
            {
                FrmDialog.ShowDialog(this, "您必须选择一行数据", "提示");
                return;
            }
            //获取所选中第一行所绑定的数据对象
            var row = rows[0];
            var t_Student = row.DataBoundItem as T_Student;
            if (t_Student == null)
            {
                return;
            }
            string t_sql = "DeleteIntoStudentBasicInformation";
            SqlParameter par= new SqlParameter("@StuID",SqlDbType.Int){Value=t_Student.StuID };
            T_StudentDal dal = new T_StudentDal();
            try
            {
                var res = (int)dal.ExecuteScalar(t_sql, CommandType.StoredProcedure, par);
                if (res == 1) {
                    curIndex = 1;
                    dataGridView1.DataSource = dal.LoadStudents(curIndex, dataLength, classID);
                    FrmDialog.ShowDialog(this, "删除成功", "提示");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                FrmDialog.ShowDialog(this, "删除失败", "提示");
            }

        }
        //插入数据
        private void Click_OpenInsertDataInforamtion(object sender, EventArgs e)
        {
            //进行插入数据的操作
            //打开多输入窗口
            FrmInputs input = new FrmInputs("插入学生数据", new string[] { "学号", "姓名", "出生年月","性别","班级编号" },new Dictionary<string, HZH_Controls.TextInputType>() { { "学号", HZH_Controls.TextInputType.Regex },{ "性别",HZH_Controls.TextInputType.Regex },{"班级编号",HZH_Controls.TextInputType.Regex } },
                new Dictionary<string, string>() { { "学号", @"^\d+$" },{"性别", @"^[\u4e00-\u9fa5]{1}$" },{"班级编号",@"^\d+$"} });
            input.ShowDialog();
            var values=input.Values;
            //确保所有数据已输入
            foreach (var item in values)
            {
                if (item==null||item.Trim() == string.Empty) return;
            }
            //必须判断日期输入是否正确
            int sex = values[3] == "男" ? 1 : 0;
            var res=Regex.IsMatch(values[2], @"^(?!0000)[0-9]{4}-((0{0,1}[1-9]|1[0-2])-(0{0,1}[1-9]|1[0-9]|2[0-8])|(0{0,1}[13-9]|1[0-2])-(29|30)|(0{0,1}[13578]|1[02])-31)$");
            if (res == false) return;
            //插入数据存储过程
            string t_sql = "InserIntoStudentBasicInformation";
            SqlParameter[] pars = new SqlParameter[] {
                new SqlParameter("@StuID",SqlDbType.Int){Value=values[0] },
                new SqlParameter("@StuName",SqlDbType.VarChar,20){ Value=values[1]},
                new SqlParameter("@StuBirthday",SqlDbType.Date){Value=values[2] },
                new SqlParameter("@StuSex",SqlDbType.BigInt){Value=sex },
                new SqlParameter("@ClassID",SqlDbType.Int){Value=values[4] }
            };

            T_StudentDal dal = new T_StudentDal();
            //调用 Dal
            try
            {
                int resVal = (int)dal.ExecuteScalar(t_sql, CommandType.StoredProcedure, pars);
                if (resVal == 1)
                {
                    curIndex = 1;
                    classID = int.Parse(values[4]);
                    dataGridView1.DataSource = dal.LoadStudents(curIndex, dataLength, classID);
                    FrmDialog.ShowDialog(this, "保存成功", "提示");
                }
                else
                {
                    throw new Exception("保存失败");
                }
            }
            catch (Exception ex)
            {
                FrmDialog.ShowDialog(this,"保存失败,请检查您输入的学号、班级编号输入正确","提示");
            }
        }
        //更新数据
        private void Click_OpenUpdateDataInforamtion(object sender, EventArgs e)
        {
            //首先检查当前是否已选中DataGridView中的一行
            //选中:则将其数据提取到弹窗中
            //未选中:提示弹窗需要先进行选取一行
            var rows=dataGridView1.SelectedRows;
            //无论用户选择多少行，每次都只获取用户选择的行中的第一行
            if(rows.Count==0)
            {
                FrmDialog.ShowDialog(this, "您必须选择一行数据", "提示");
                return;
            }
            //获取所选中第一行所绑定的数据对象
            var row=rows[0];
            var t_Student = row.DataBoundItem as T_Student;
            if (t_Student == null) {
                return;
            }
            FrmStudentManaChildModifyData childUpdate = new FrmStudentManaChildModifyData(t_Student);
            childUpdate.ShowDialog();
            curIndex = 1;
            classID= t_Student.ClassID;
            T_StudentDal dal = new T_StudentDal();
            dataGridView1.DataSource = dal.LoadStudents(curIndex, dataLength, classID);
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
            //打开多输入窗口
            FrmInputs input = new FrmInputs("模糊查询",new string []{"学号","姓名","班级编号" });
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
            var res=dal.FuzzyQuery(t_sql, CommandType.Text, pars);
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
            if (@class == null) {
                return;
            }
            //保存状态，用于在异常中恢复状态
            int temp1 =classID;
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
        private void ResetCurIndexAndClassID(int curIndex, int classID) {
            this.curIndex = curIndex;
            this.classID = classID;
        }
    }
}
