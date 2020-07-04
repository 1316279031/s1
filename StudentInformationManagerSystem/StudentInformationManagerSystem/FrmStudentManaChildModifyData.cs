using HZH_Controls.Controls;
using HZH_Controls.Forms;
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
    public partial class FrmStudentManaChildModifyData : Form
    {
        public FrmStudentManaChildModifyData()
        {
            InitializeComponent();
        }
        public FrmStudentManaChildModifyData(T_Student stu):this (){
            t_stu = stu;
        }
        private T_Student t_stu;
        //保存数据
        private void ucBtnSave_BtnClick(object sender, EventArgs e)
        {
            //使用正则表达式验证修改信息
            var b1 = txtNameValidate.Verification();
            var b2 = txtBirthDayValidate.Verification();
            var b3 = txtClassIDValidate.Verification();
            int sex = 1;
            if (b1 == false || b2 == false || b3 == false)
            {
                return;
            }
            //进行保存
            t_stu.StuName = txtStuName.Text;
            t_stu.StuBirthday = txtBirthDay.Text;
            t_stu.StuSex_filed = ucRidMan.Checked ? true : false;
            sex= ucRidMan.Checked ? 1 : 0;
            t_stu.ClassID = int.Parse(txtClassID.Text);
            //可以进行保存
            try
            {
                string t_sql = "ModifyIntoStudentBasicInformation";
                SqlParameter[] pars = new SqlParameter[] {
                    new SqlParameter("@StuID",SqlDbType.Int){Value=txtStuID.Text},
                    new SqlParameter("@StuName",SqlDbType.VarChar,20){Value=txtStuName.Text},
                    new SqlParameter("@StuBirthday",SqlDbType.Date){Value=txtBirthDay.Text},
                    new SqlParameter("@StuSex",SqlDbType.Bit){Value=sex},
                    new SqlParameter("@ClassID",SqlDbType.Int){Value=txtClassID.Text}
                };
                T_StudentDal dal = new T_StudentDal();
                var res=(int)dal.ExecuteScalar(t_sql, CommandType.StoredProcedure, pars);
                if (res == 1) {
                    FrmDialog.ShowDialog(this, "保存成功", "提示");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                FrmDialog.ShowDialog(this,"保存失败","提示");
                t_stu.ClassID = copy.ClassID;
                t_stu.StuName = copy.StuName;
                t_stu.StuBirthday = copy.StuBirthday;
                t_stu.StuSex_filed = copy.StuSex_filed;

            }
            Close();
        }
        private T_Student copy;
        private void FrmStudentManaChildModifyData_Load(object sender, EventArgs e)
        {
            copy = new T_Student();
            txtBirthDay.Text = t_stu.StuBirthday;
            txtStuID.Text = t_stu.StuID.ToString();
            txtStuName.Text = t_stu.StuName;
            txtClassID.Text = t_stu.ClassID.ToString();

            copy.StuBirthday = t_stu.StuBirthday;
            copy.StuID = t_stu.StuID;
            copy.StuName = t_stu.StuName;
            copy.StuSex_filed = t_stu.StuSex_filed;
            copy.ClassID = t_stu.ClassID;
            //true:男;false：女
            if (t_stu.StuSex_filed)
            {
                ucRidMan.Checked = true;
            }
            else
            {
                ucRdiWoman.Checked = true;
            }
            txtNameValidate.SetVerificationCustomRegex(txtStuName, @"^[\u4E00-\u9FFF]{2,10}$");
            txtNameValidate.SetVerificationErrorMsg(txtStuName, "非法输入");
            txtNameValidate.SetVerificationRequired(txtStuName, true);
            txtNameValidate.SetVerificationModel(txtStuName, VerificationModel.Custom);

            txtBirthDayValidate.SetVerificationCustomRegex(txtBirthDay, @"^(?!0000)[0-9]{4}-((0{0,1}[1-9]|1[0-2])-(0{0,1}[1-9]|1[0-9]|2[0-8])|(0{0,1}[13-9]|1[0-2])-(29|30)|(0{0,1}[13578]|1[02])-31)$");
            txtBirthDayValidate.SetVerificationErrorMsg(txtBirthDay, "非法输入");
            txtBirthDayValidate.SetVerificationRequired(txtBirthDay, true);
            txtBirthDayValidate.SetVerificationModel(txtBirthDay, VerificationModel.Custom);

            txtClassIDValidate.SetVerificationCustomRegex(txtClassID, @"^\d{4,}$");
            txtClassIDValidate.SetVerificationErrorMsg(txtClassID, "非法输入");
            txtClassIDValidate.SetVerificationRequired(txtClassID, true);
            txtClassIDValidate.SetVerificationModel(txtClassID, VerificationModel.Custom);
        }
    }
}
