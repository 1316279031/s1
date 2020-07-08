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
    public partial class FrmInsertedClassSetUpCourse : Form
    {
        public FrmInsertedClassSetUpCourse()
        {
            InitializeComponent();
        }

        private void FrmInsertedClassSetUpCourse_Load(object sender, EventArgs e)
        {
            //加载学院
            T_CollegeDAL dal = new T_CollegeDAL();
            comCollege.DataSource=dal.LoadCollege();
            //事件触发加载班级
            comCollege.SelectedIndexChanged += ComCollege_SelectedIndexChanged;
            comCollege.SelectedIndex = 0;
            T_ClassDAL classDal = new T_ClassDAL();
            comClass.DataSource= classDal.LoadClass();
            comCourse.DataSource = new T_CourseDAL().ExecuteListCourseName();
            comTeach.DataSource = new T_TeachDAL().GetTeches();
        }

        private void ComCollege_SelectedIndexChanged(object sender, EventArgs e)
        {
            var college = comCollege.SelectedItem as T_College;
            var @class = comCollege.SelectedItem as T_Class;
            var course = comCollege.SelectedItem as T_Course;
            var teach = comCollege.SelectedItem as T_Teach;
            if (college == null || @class == null || course == null || teach == null) return;
            string t_sql = "InsertedClassSetUpCourse";
            T_CourseDAL dal = new T_CourseDAL();
            SqlParameter[] pars = new SqlParameter[] {
                new SqlParameter(){Value=@class.ClassID},
                new SqlParameter(){Value=course.CourseID},
                new SqlParameter(){ Value=teach.TeachID}
            };
            try
            {
                var res=(int)dal.ExecuteScalar(t_sql, CommandType.StoredProcedure, pars);
                if (res == 1)
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
                FrmDialog.ShowDialog(this,"保存失败！请确保录入数据正确且不重复");
            }
        }
    }
}
