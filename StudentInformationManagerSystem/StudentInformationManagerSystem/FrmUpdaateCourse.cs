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
    public partial class FrmUpdaateCourse : Form
    {
        public FrmUpdaateCourse()
        {
            InitializeComponent();
        }
        public FrmUpdaateCourse(T_CourseName course) : this()
        {
            this.course = course;
        }
        private T_CourseName course;
        private void FrmUpdaateCourse_Load(object sender, EventArgs e)
        {
            txtCourseID.Text = course.CourseID.ToString();
            txtCourseName.Text = course.CourseName.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool res=Regex.IsMatch(txtCourseName.Text, @"^.{5,}$");
            if (res == false) return;
            T_CourseDAL dal = new T_CourseDAL();
            string t_sql = "ModifyCourseName";
            SqlParameter[] pars = new SqlParameter[] {
                new SqlParameter("@courseID",SqlDbType.Int){Value=txtCourseID.Text},
                new SqlParameter("@courseName",SqlDbType.VarChar){Value=txtCourseName.Text}
            };
            try
            {
                int modifyRes = (int)dal.ExecuteScalar(t_sql, CommandType.StoredProcedure, pars);
                if (modifyRes == 1)
                {
                    FrmDialog.ShowDialog(this, "保存成功");
                    course.CourseName = txtCourseName.Text;
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
