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
    public partial class FrmUpdataClassInformation : Form
    {
        public FrmUpdataClassInformation()
        {
            InitializeComponent();
        }
        public FrmUpdataClassInformation(T_Class @class):this()
        {
            this.@class = @class;
        }
        private T_Class @class;
        private void FrmUpdataClassInformation_Load(object sender, EventArgs e)
        {
            if (@class == null) return;
            txtUPclassID.Text = @class.ClassID.ToString();
            txtUPClassName.Text = @class.ClassName;
            txtUPCollegeID.Text = @class.CollegeID.ToString();

            //配置输入框验证模式
            verNameValidate.SetVerificationCustomRegex(txtUPClassName, @"^[\u4E00-\u9FFF0-9]{5,20}$");
            verNameValidate.SetVerificationErrorMsg(txtUPClassName, "非法输入");
            verNameValidate.SetVerificationModel(txtUPClassName, VerificationModel.Custom);
            verNameValidate.SetVerificationRequired(txtUPClassName,true);

            verCollegeIDValidate.SetVerificationCustomRegex(txtUPCollegeID, @"^\d+$");
            verCollegeIDValidate.SetVerificationErrorMsg(txtUPCollegeID,"非法输入");
            verCollegeIDValidate.SetVerificationModel(txtUPCollegeID, VerificationModel.Custom);
            verCollegeIDValidate.SetVerificationRequired(txtUPCollegeID,true);
        }

        private void ucBtnSave_BtnClick(object sender, EventArgs e)
        {
            var b1=verNameValidate.Verification();
            var b2 = verCollegeIDValidate.Verification();
            if (b1 == false || b2 == false) return;
            //验证通过，提交修改
            T_ClassDAL dal = new T_ClassDAL();
            string t_sql = "ModifyIntoT_Class";
            SqlParameter[] pars = new SqlParameter[] {
                new SqlParameter("@classID",SqlDbType.Int){Value=txtUPclassID.Text},
                new SqlParameter("@className",SqlDbType.VarChar,20){Value=txtUPClassName.Text},
                new SqlParameter("@collegeID",SqlDbType.Int){Value=txtUPCollegeID.Text}
            };
            try
            {
                var res = (int)dal.ExecuteScalar(t_sql, CommandType.StoredProcedure, pars);
                if (res == 1)
                {
                    FrmDialog.ShowDialog(this,"保存成功","提示");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                FrmDialog.ShowDialog(this,"保存失败","提示");
            }
        }
    }
}
