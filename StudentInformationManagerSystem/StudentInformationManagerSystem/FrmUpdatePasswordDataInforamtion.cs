using HZH_Controls.Forms;
using StudentInformationManagerSystem.BLL;
using StudentInformationManagerSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationManagerSystem
{
    public partial class FrmUpdatePasswordDataInforamtion : Form
    {
        public FrmUpdatePasswordDataInforamtion()
        {
            InitializeComponent();
        }

        private void FrmUpdatePasswordDataInforamtion_Load(object sender, EventArgs e)
        {
            validateUserID.SetVerificationErrorMsg(txtUserID, "非法输入");
            validateUserID.SetVerificationModel(txtUserID, HZH_Controls.Controls.VerificationModel.Custom);
            validateUserID.SetVerificationRequired(txtUserID, true);
            validateUserID.SetVerificationCustomRegex(txtUserID, @"^\d{8,15}$");

            validatePassword1.SetVerificationErrorMsg(txtPassword1, "非法输入");
            validatePassword1.SetVerificationModel(txtPassword1, HZH_Controls.Controls.VerificationModel.Custom);
            validatePassword1.SetVerificationRequired(txtPassword1, true);
            validatePassword1.SetVerificationCustomRegex(txtPassword1, @"^(?=.*[a-z]).{8,15}$");

            validateNewPassword.SetVerificationErrorMsg(txtNewPassword, "非法输入");
            validateNewPassword.SetVerificationModel(txtNewPassword, HZH_Controls.Controls.VerificationModel.Custom);
            validateNewPassword.SetVerificationRequired(txtNewPassword, true);
            validateNewPassword.SetVerificationCustomRegex(txtNewPassword, @"^(?=.*[a-z]).{8,15}$");
        }

        private void ucBtnExt1_BtnClick(object sender, EventArgs e)
        {
            var b1=validateUserID.Verification(txtUserID);
            var b2=validatePassword1.Verification(txtPassword1);
            validatePassword2.SetVerificationErrorMsg(txtPassword2, "非法输入");
            validatePassword2.SetVerificationModel(txtPassword2, HZH_Controls.Controls.VerificationModel.Custom);
            validatePassword2.SetVerificationRequired(txtPassword2, true);
            validatePassword2.SetVerificationCustomRegex(txtPassword2, $"^{txtPassword1.Text}$");
            var b3=validatePassword2.Verification(txtPassword2);
            var b4=validateNewPassword.Verification(txtNewPassword);
            if (b1 == false || b2 == false || b3 == false || b4 == false) return;
            try
            {
                CreateGenericCode cre = new CreateGenericCode();
                var oldPwd = cre.CreateSHA256Code(txtPassword1.Text);
                //首先验证是否可以登录
                T_UserBll bll = new T_UserBll();
                try
                {
                    var res = bll.ModelOptionLoad(-1, -1, -1, txtUserID.Text, oldPwd);
                    if (res == null) throw new ArgumentException("账户或密码错误无法登录!");
                    var newPwd = cre.CreateSHA256Code(txtNewPassword.Text);
                    var updateRes = bll.UpdatePassword(txtUserID.Text, newPwd);
                    if (updateRes)
                    {
                        FrmDialog.ShowDialog(this, "修改成功请退出重新登陆");
                        Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
                        Close();
                    }
                    else
                    {
                        throw new ArgumentException("无法保存!");
                    }
                }
                catch
                {
                    throw;
                }
                //修改成功后，立即退出重新启动
            }
            catch (ArgumentException ex)
            {
                FrmDialog.ShowDialog(this, ex.Message);
            }catch(Exception ex)
            {
                FrmDialog.ShowDialog(this,"未知错误");

            }
        }
        private void ucBtnExt2_BtnClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
