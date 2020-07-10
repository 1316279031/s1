using HZH_Controls.Controls;
using HZH_Controls.Forms;
using StudentInformationManagerSystem.BLL;
using StudentInformationManagerSystem.DAL;
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
            LoadTeaches();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            item[1].Click += OpenUpdate;
            item[2].Click += OpenInserted;
            item[3].Click += OpenDelete;
            item[4].Click += NextPage;
            item[5].Click += PrePage;
            ExpandNavigationMenuItem[] serach = new
                ExpandNavigationMenuItem[] {
                    new ExpandNavigationMenuItem(){Text="查询所有"},
                    new ExpandNavigationMenuItem(){Text="模糊查询"},
                    new ExpandNavigationMenuItem(){ Text="授课学生成绩"}
                };
            serach[0].Click += OpenQueryAll;
            serach[1].Click += FuzzyQuery;
            serach[2].Click += TeachersStudentCourseFraction; 
            item[0].Items = serach;
            navMenu.Items = item;
            navMenu.ClickItemed += NavMenu_ClickItemed;
        }

        private void NavMenu_ClickItemed(object sender, EventArgs e)
        {
            var sen = sender as UCNavigationMenu;
            if (sen == null) return;
            var item = sen.SelectItem as ExpandNavigationMenuItem;
            if (item == null) return;
            item.Start(item, e);
        }

        private int _curIndex = 1;
        private int _dataLength = 16;
        private int _modelID = -1;
        private void  LoadTeaches() {
            InitialDataGridViewDataSource(-1, _curIndex);
        }
        private void InitialDataGridViewDataSource(int modelID,int curIndex)
        {
            T_TeachBll bll = new T_TeachBll();
            int tempCurIndex = _curIndex;
            int tempCurModelID = _modelID;
            try
            {
                _curIndex = curIndex;
                _modelID = modelID;
                var res = bll.ModelOptionLoad(modelID, _curIndex, _dataLength,_values);
                try
                {
                    if (res == null) throw new Exception("不存在数据");
                    else dataGridView1.DataSource = res;
                }
                catch(Exception ex)
                {
                    FrmDialog.ShowDialog(this, ex.Message);
                    throw;
                }
            }
            catch
            {
                _curIndex = tempCurIndex;
                _modelID = tempCurModelID;
            }
        }
        private void NextPage(object sender, EventArgs e)
        {
            InitialDataGridViewDataSource(_modelID, _curIndex+1);
        }

        private void PrePage(object sender, EventArgs e)
        {
            InitialDataGridViewDataSource(_modelID, _curIndex - 1);
        }

        private void OpenDelete(object sender, EventArgs e)
        {
            var rows=dataGridView1.SelectedRows;
            if (!(rows.Count > 0))
            {
                FrmDialog.ShowDialog(this, "请选择教师");
                return;
            }
            var row=rows[0].DataBoundItem as T_Teach;
            if (row == null) return;
            T_TeachBll teachBll = new T_TeachBll();
            var res=teachBll.DeleteDataInforMation(row.TeachID);
            if (res)
            {
                FrmDialog.ShowDialog(this, "保存成功");
                InitialDataGridViewDataSource(_modelID, _curIndex);
            }
            else
            {
                FrmDialog.ShowDialog(this, "保存失败");
            }
        }

        //插入数据
        private void OpenInserted(object sender, EventArgs e)
        {
            using (FrmTeachManaDDMLData frm = new FrmTeachManaDDMLData())
            {
                var res=frm.ShowDialog();
                if (res == DialogResult.Cancel)
                {
                    return;
                }
                _values = frm.Values;
                T_TeachBll bll = new T_TeachBll();
                try
                {
                    var saveRes = bll.InsertedInforMation(_values);
                    if (saveRes)
                    {
                        FrmDialog.ShowDialog(this, "保存成功");
                        InitialDataGridViewDataSource(_modelID, _curIndex);
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    FrmDialog.ShowDialog(this, "插入失败");
                }
            }
        }
        //更新数据
        private void OpenUpdate(object sender, EventArgs e)
        {
            var rows = dataGridView1.SelectedRows;
            if (!(rows.Count > 0))
            {
                FrmDialog.ShowDialog(this, "请选择教师");
                return;
            }
            var row = rows[0].DataBoundItem as T_Teach;
            if (row == null) return;
            using (FrmTeachManaDDMLData frm = new FrmTeachManaDDMLData())
            {
                var res = frm.ShowDialog();
                if (res == DialogResult.Cancel)
                {
                    return;
                }
                var listRes= frm.Values.ToList();
                listRes.Add(row.TeachID.ToString());
                _values = listRes.ToArray();
                T_TeachBll bll = new T_TeachBll();
                try
                {
                    var saveRes = bll.UpdateInformation(_values);
                    if (saveRes)
                    {
                        FrmDialog.ShowDialog(this, "保存成功");
                        InitialDataGridViewDataSource(_modelID, _curIndex);
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    FrmDialog.ShowDialog(this, "插入失败");
                }
            }
        }

        /// <summary>
        /// 教师的学生课程分数
        /// </summary>
        private void TeachersStudentCourseFraction(object sender, EventArgs e)
        {
            using (FrmInputs inputs = new FrmInputs("查询教师教授课程学生成绩", new string[] { "教师编号"}, new Dictionary<string, HZH_Controls.TextInputType>() { { "教师编号", HZH_Controls.TextInputType.Regex } }, new Dictionary<string, string>() { { "教师编号", @"^\d+$" }}))
            {
                inputs.ShowDialog();
                _values = inputs.Values;
                InitialDataGridViewDataSource(1, 1);
            }
        }
        private string[] _values;
        /// <summary>
        /// 模糊查询
        /// </summary>
        private void FuzzyQuery(object sender, EventArgs e)
        {
            using (FrmInputs inputs = new FrmInputs("查询教师", new string[] { "教师编号", "教师姓名" }, new Dictionary<string, HZH_Controls.TextInputType>() { { "教师编号", HZH_Controls.TextInputType.Regex }, { "教师姓名", HZH_Controls.TextInputType.Regex } }, new Dictionary<string, string>() { { "教师编号", @"^\d+$" }, { "教师姓名", @"^[\u4e00-\u9fa5]+$" } }))
            {
                inputs.ShowDialog();
                _values= inputs.Values;
                InitialDataGridViewDataSource(0, 1);
            }
        }

        /// <summary>
        /// 全部查询
        /// </summary>
        private void OpenQueryAll(object sender, EventArgs e)
        {
            InitialDataGridViewDataSource(-1, 1);
        }
    }
}
