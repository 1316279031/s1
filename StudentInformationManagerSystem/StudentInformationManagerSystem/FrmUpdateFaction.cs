using HZH_Controls.Forms;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationManagerSystem
{
    public partial class FrmUpdateFaction : Form
    {
        public FrmUpdateFaction()
        {
            InitializeComponent();
        }
        public FrmUpdateFaction(T_CourseFaction faction) : this()
        {
            this.faction = faction;
        }
        private T_CourseFaction faction;
        private void FrmUpdateFaction_Load(object sender, EventArgs e)
        {
            txtStuID.Text = faction.StuID.ToString();
            txtStuName.Text = faction.StuName;
            txtCourseName.Text = faction.CourseName;
            txtTeachName.Text = faction.TeacherName;
            txtFaction.Text = faction.Faction.ToString();
        }

        private void ucBtnExt1_BtnClick(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtFaction.Text, @"^^\d{1,3}\.*5{0,1}$") == false)
            {
                return;
            }
            T_CourseDAL dal = new T_CourseDAL();
            SqlParameter[] pars = new SqlParameter[] {
                new SqlParameter("@faction",SqlDbType.Int){Value=txtFaction.Text},
                new SqlParameter("@id",SqlDbType.Int){Value=faction.ID}
            };
            try
            {
                var res = (int)dal.ExecuteScalar("UpdateStudentFaction", CommandType.StoredProcedure, pars);
                if (res == 1)
                {
                    FrmDialog.ShowDialog(this, "保存成功");
                    faction.Faction = float.Parse(txtFaction.Text);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                FrmDialog.ShowDialog(this, "保存失败!请检查是否重复插入");
            }
        }
    }
}
