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
    public partial class FrmInsertCourseFaction : Form
    {
        public FrmInsertCourseFaction()
        {
            InitializeComponent();
        }

        private T_Student stu;
        private T_InsertedFactionModel courseTeach;
        private void ucBtnExt1_BtnClick(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtFaction.Text, @"^^\d{1,3}\.*5{0,1}$") == false) {
                return;
            } else if (courseTeach == null) return;
            T_CourseDAL dal = new T_CourseDAL();
            SqlParameter[] pars = new SqlParameter[] {
                new SqlParameter("@courseID",SqlDbType.Int){ Value=courseTeach.CourseID},
                new SqlParameter("@teachID",SqlDbType.Int){Value=courseTeach.TeacherID},
                new SqlParameter("@faction",SqlDbType.Float){Value=txtFaction.Text},
                new SqlParameter("@stuID",SqlDbType.Int){Value=stu.StuID}
            };
            try
            {
                var res = (int)dal.ExecuteScalar("InserintoCourseFaction", CommandType.StoredProcedure, pars);
                if(res == 1)
                {
                    FrmDialog.ShowDialog(this,"保存成功");
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
        private List<T_InsertedFactionModel> LoadComCourseName(string stuid)
        {
            string t_sql = "select ClassID from T_StudentBasicInformation where T_StudentBasicInformation.StuID = @stuid";
            SqlParameter pars = new SqlParameter("@stuid", SqlDbType.Int) { Value = stu.StuID };
            T_CourseDAL dal = new T_CourseDAL();
            int classID = (int)dal.ExecuteScalar(t_sql, CommandType.Text, pars);
            return dal.ExecuteT_ClassSetUpCourseTeach(classID);
        }
        private void FrmUpdateCourseFaction_Load(object sender, EventArgs e)
        {
            comCourseName.SelectedIndexChanged += comCourseName_SelectedIndexChanged;
        }
        private void LoadScreenControlData() {
            txtStuID.Text = stu.StuID.ToString();
            txtStuName.Text = stu.StuName;
            comCourseName.DataSource = LoadComCourseName(stu.StuID.ToString());
        }
        private void comCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
           var obj= sender as ComboBox;
           var res = obj.SelectedItem as T_InsertedFactionModel;
           if (res == null) return;
            txtTeachName.Text = res.TeacherName;
            courseTeach = res;
        }
        private event Func<object, EventArgs, DataGridViewSelectedRowCollection> Select_Students;
        private void ucBtnExt2_BtnClick(object sender, EventArgs e)
        {
            //选择一名学生
            FrmSelectStudent selectStu = new FrmSelectStudent();
            Select_Students += selectStu.SelectStudents;
            selectStu.ShowDialog();
            var rows=Select_Students(sender, e);
            //将每行逐条插入
            if (rows.Count == 0) return;
            stu = rows[0].DataBoundItem as T_Student;
            if (stu == null) return;
            LoadScreenControlData();
        }
    }
}
