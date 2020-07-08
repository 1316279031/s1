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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationManagerSystem
{
    public partial class FrmUpdateClassSetUpCourse : Form
    {
        public FrmUpdateClassSetUpCourse()
        {
            InitializeComponent();
        }
        public FrmUpdateClassSetUpCourse(T_Course course):this()
        {
            this.course = course;
        }
        private T_Course course;
        private T_Teach teach;
        private void FrmUpdateClassSetUpCourse_Load(object sender, EventArgs e)
        {
            txtClassName.Text = course.ClassName;
            txtCourseName.Text = course.CourseName;
            comTeachName.Text = course.TeachName;
            comTeachName.DataSource=LoadesTeachNames();
            comTeachName.SelectedIndexChanged += ComTeachName_SelectedIndexChanged;
        }

        private void ComTeachName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var box=sender as ComboBox;
            if (box == null) return;
            teach=box.SelectedItem as T_Teach;
        }

        private List<T_Teach> LoadesTeachNames()
        {
            T_TeachDAL dal = new T_TeachDAL();
            return dal.GetTeches();
        }

        private void ucBtnExt1_BtnClick(object sender, EventArgs e)
        {
            //保存
            if (teach == null) return; 
            T_CourseDAL dal = new T_CourseDAL();
            SqlParameter[] pars = new SqlParameter[] {
                new SqlParameter("@classid",SqlDbType.Int){Value=course.classID },
                new SqlParameter("@courseid",SqlDbType.Int){Value=course.CourseID },
                new SqlParameter("@teachid",SqlDbType.Int){Value= teach.TeachID}
            };
            try {
                var res=(int)dal.ExecuteScalar("ModifyClassSetUpCourse", CommandType.StoredProcedure, pars);
                if (res == 1)
                {
                    FrmDialog.ShowDialog(this, "保存成功");
                    course.teachID = teach.TeachID;
                    course.TeachName = teach.TeachName;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                FrmDialog.ShowDialog(this, "保存失败!");
            }
            
        }
    }
}
