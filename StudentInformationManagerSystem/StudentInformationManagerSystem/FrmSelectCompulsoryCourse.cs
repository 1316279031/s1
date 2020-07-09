using HZH_Controls.Controls;
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

    public partial class FrmSelectCompulsoryCourse : Form
    {
        public FrmSelectCompulsoryCourse()
        {
            InitializeComponent();
        }
        private string[] values;
        public string[] Values { get { return values; }}
        private void FrmSelectCompulsoryCourse_Load(object sender, EventArgs e)
        {
            //加载班级
            LoadClass();
            //加载课程
        }
        private void LoadClass() {
            T_ClassDAL dal = new T_ClassDAL();
            List<T_Class> @class=dal.LoadClass();
            comClass.DataSource = @class;
            comClass.SelectedIndexChanged += ComClass_SelectedIndexChanged;
            ComClass_SelectedIndexChanged(comClass, null);
        }
        /// <summary>
        /// 加载指定班级下的T_Course
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            T_CourseDAL dal = new T_CourseDAL();
            T_Class @class=comClass.SelectedItem as T_Class;
            if (@class == null) ucBtnExt2_BtnClick(null,null);
            comCourse.DataSource= dal.ExecuteT_ClassSetUpCourseTeach(@class.ClassID);
        }

        private void ucBtnExt1_BtnClick(object sender, EventArgs e)
        {
            if (comClass.Items.Count < 0 || comCourse.Items.Count < 0) return;
            T_Class @class=comClass.SelectedItem as T_Class;
            T_InsertedFactionModel course = comCourse.SelectedItem as T_InsertedFactionModel;
            if (@class == null || course == null) return;
            DialogResult = DialogResult.OK;
            values = new string[2] {@class.ClassID.ToString(),course.CourseID.ToString() };
            Close();
        }

        private void ucBtnExt2_BtnClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
