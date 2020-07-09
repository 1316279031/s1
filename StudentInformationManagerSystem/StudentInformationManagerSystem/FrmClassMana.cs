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
    public partial class FrmClassMana : Form
    {
        public FrmClassMana()
        {
            InitializeComponent();
        }
        private int curIndex = 1; 
        private int collegeID = -1;
        private int dataLength = 16;
        private void FrmClassMana_Load(object sender, EventArgs e)
        {
            try
            {
                LoadNavMenuItem();
                LoadTreeNodes();
                //首先我们加载所有学生信息，以分页的方式显示出来
                var res = new T_ClassDAL().LoadPagiation(curIndex, dataLength, collegeID);
                if (res == null) return;
                dataGridView1.DataSource = res;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.Columns[0].HeaderText = "班级编号";
                dataGridView1.Columns[1].HeaderText = "班级名";
                dataGridView1.Columns[2].HeaderText = "学院编号";
            }
            catch {
                MessageBox.Show("错误");
            }
        }
        //加载树
        private void LoadTreeNodes()
        {
            T_CollegeDAL collegeDal = new T_CollegeDAL();
            var collegeRes = collegeDal.LoadCollege();
            TreeNode[] nodes = new TreeNode[collegeRes.Count];
            for (int i = 0; i < collegeRes.Count; i++)
            {
                TreeNode node = new TreeNode();
                node.Text = collegeRes[i].CollegeName;
                node.Tag = collegeRes[i];
                nodes[i] = node;
                
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

        //上一页
        private void Click_JumpHailPage(object sender, EventArgs e)
        {
            int temp = curIndex;
            curIndex -= 1;
            T_ClassDAL dal = new T_ClassDAL();
            var res=dal.LoadPagiation(curIndex,dataLength,collegeID);
            if (res == null)
            {
                curIndex = temp;
                return;
            }
            dataGridView1.DataSource = res;
        }

        private void Click_DeleteDataInforamtion(object sender, EventArgs e)
        {
            //删除信息
            var rows = dataGridView1.SelectedRows;
            if (rows.Count == 0)
            {
                FrmDialog.ShowDialog(this, "请选择一行");
                return;
            }
            var row = rows[0].DataBoundItem as T_Class;
            if (row == null) return;
            string t_sql = "DeleteIntoT_Class";
            SqlParameter par = new SqlParameter("@classID", SqlDbType.Int) { Value = row.ClassID };
            T_ClassDAL dal = new T_ClassDAL();
            int temp1 = curIndex;
            int temp2 = collegeID;
            try
            {
                var res = (int)dal.ExecuteScalar(t_sql, CommandType.StoredProcedure, par);
                if (res == 1)
                {
                    dataGridView1.DataSource = dal.LoadPagiation(curIndex, dataLength, collegeID);
                    FrmDialog.ShowDialog(this, "保存成功");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                curIndex = temp1;
                collegeID = temp2;
                FrmDialog.ShowDialog(this, "保存失败,请检查输入是否正确");
            }

        }
        //下一页
        private void Click_JumpNextPage(object sender, EventArgs e)
        {
            int temp = curIndex;
            curIndex += 1;
            T_ClassDAL dal = new T_ClassDAL();
            var res = dal.LoadPagiation(curIndex, dataLength, collegeID);
            if (res == null)
            {
                curIndex = temp;
                return;
            }
            dataGridView1.DataSource = res;
        }
        //插入数据
        private void Click_OpenInsertDataInforamtion(object sender, EventArgs e)
        {
            FrmInputs inputs = new FrmInputs("插入班级信息", new string[] { "班级名称", "学院编号" }, new Dictionary<string, HZH_Controls.TextInputType>() { { "班级名称", HZH_Controls.TextInputType.Regex }, { "学院编号", HZH_Controls.TextInputType.Regex } }, new Dictionary<string, string>() { { "班级名称", @"^[\u4E00-\u9FFF0-9]+$" } ,{"学员编号",@"^\d+$" } });
            inputs.ShowDialog();
            var values = inputs.Values;
            foreach (var item in values)
            {
                if (item == null || item == string.Empty) return;
            }
            string t_sql = "InsertintoT_Class";
            SqlParameter[] pars = new SqlParameter[] {
                new SqlParameter("@className",SqlDbType.VarChar,20){Value=values[0] },
                new SqlParameter("@collegeID",SqlDbType.Int){Value=values[1] },
            };
            T_ClassDAL dal = new T_ClassDAL();
            int temp1 = curIndex;
            int temp2 = collegeID;
            try
            {
                var res = (int)dal.ExecuteScalar(t_sql, CommandType.StoredProcedure, pars);
                if (res == 1)
                {
                    curIndex = 1;
                    dataGridView1.DataSource = dal.LoadPagiation(curIndex, dataLength, collegeID);
                    FrmDialog.ShowDialog(this, "保存成功");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                curIndex = temp1;
                collegeID = temp2;
                FrmDialog.ShowDialog(this, "保存失败,请检查输入是否正确");
            }
        }
        //弹出更新信息子窗体，进行修改保存
        private void Click_OpenUpdateDataInforamtion(object sender, EventArgs e)
        {
            var rows=dataGridView1.SelectedRows;
            if(rows.Count==0)
            {
                FrmDialog.ShowDialog(this,"请选中一行","提示");
                return;
            }
            var row = rows[0].DataBoundItem as T_Class;
            if (row == null) return;
            FrmUpdataClassInformation update = new FrmUpdataClassInformation(row);
            update.ShowDialog();
            update.Close();
            //重新加载页面
            dataGridView1.DataSource = new T_ClassDAL().LoadPagiation(curIndex, dataLength,collegeID);
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
            FrmInputs inputs = new FrmInputs("模糊查询", new string[] { "班级编号","班级名称", "学院编号" }, new Dictionary<string, HZH_Controls.TextInputType>() { {"班级编号",HZH_Controls.TextInputType.Regex },{ "班级名称", HZH_Controls.TextInputType.Regex }, { "学院编号", HZH_Controls.TextInputType.Regex } }, new Dictionary<string, string>() { {"班级编号",@"^\d+$" }, { "班级名称", @"^[\u4E00-\u9FFF0-9]+$" }, { "学员编号", @"^\d+$" } });
            inputs.ShowDialog();
            var values = inputs.Values;
            T_ClassDAL dal = new T_ClassDAL();
            string t_sql = "FulzySearchInT_Class";
            SqlParameter[] pars = new SqlParameter[] {
                new SqlParameter("@classID",SqlDbType.VarChar){ Value="%"+values[0]+"%"},
                new SqlParameter("@className",SqlDbType.VarChar){ Value="%"+values[1]+"%"},
                new SqlParameter("@collegeID",SqlDbType.VarChar){ Value="%"+values[2]+"%"}

            };
           dataGridView1.DataSource= dal.FulzySearch(t_sql, CommandType.StoredProcedure, pars);
        }
        //查询所有
        private void Click_QueryAll(object sender, EventArgs e)
        {
          
            T_ClassDAL dal = new T_ClassDAL();
            try
            {
                var res = dal.LoadPagiation(1, dataLength, -1);
                dataGridView1.DataSource = res;
                curIndex = 1;
                collegeID = -1;
            }
            catch
            {

            }
        }

        private void trvEx1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var college = e.Node.Tag as T_College;
            if (college == null) return;
            T_ClassDAL classDAL = new T_ClassDAL();
            int cur = 1;
            try
            {
                var res = classDAL.LoadClass(college.CollegeID);
                dataGridView1.DataSource=res;
                cur = 1;
                collegeID = college.CollegeID;
            }
            catch
            {
                cur = curIndex;
            }
            curIndex = cur;
        }
    }
}
