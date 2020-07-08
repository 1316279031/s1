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
    public partial class FrmInsertedCourse : Form
    {
        public FrmInsertedCourse()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //根据输入插入
            if (Regex.IsMatch(txtCourseName.Text, @"^.{5,}$")==false)
            {
                return;
            }
            T_CourseDAL dal = new T_CourseDAL();
            SqlParameter par = new SqlParameter("@courseName", SqlDbType.VarChar) { Value = txtCourseName.Text };
            try
            {
                var res = (int)dal.ExecuteScalar("InsertedCourse", CommandType.StoredProcedure, par);
                if(res == 1)
                {
                    FrmDialog.ShowDialog(this, "保存成功");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                FrmDialog.ShowDialog(this, "保存失败");
            }
        }
    }
}
