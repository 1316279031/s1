using HZH_Controls.Controls;
using StudentInformationManagerSystem.BLL;
using StudentInformationManagerSystem.BLL.BLL_Interface;
using StudentInformationManagerSystem.BLL.ControlSetting;
using StudentInformationManagerSystem.BLL.ControlSettingInterface;
using StudentInformationManagerSystem.DAL.ModelDAL;
using StudentInformationManagerSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationManagerSystem
{
    public partial class FrmLog : Form
    {
        public FrmLog()
        {
            InitializeComponent();
        }
        private T_User user = null;
        private void FrmLog_Load(object sender, EventArgs e)
        {
            ICreateValidateCode genericCode = new CreateGenericCode();
            ISetValidateControlConfig setValidateControlConfig = new ControlSet();
            var code = genericCode.CreateMemoryValidateCode();
            txtMemCode.Text = code;
            setValidateControlConfig.SetValidateControl(txtAcc,verAccountValidate, @"^[0-9]{10,15}$", "请输入正确的用户名");
            verPwdValidate.SetVerificationErrorMsg(txtPwd, "请输入正确的密码");

            setValidateControlConfig.SetValidateControl(txtPwd, verPwdValidate, @"^(?=.*[a-zA-Z]).+?\d{8,}$", "请输入正确的密码");

            setValidateControlConfig. SetValidateControl(txtValidateCode, verValidateCode, string.Format(@"^({0}|{1})$", code, code.ToLower()), "请输入正确的验证码");
        }
        private void ucBtnExt1_BtnClick(object sender, EventArgs e)
        {
            txtValidateCode.InputText = txtValidateCode.InputText.ToLower();
            bool accValResult = verAccountValidate.Verification(txtAcc);
            bool pwdValResult = verPwdValidate.Verification(txtPwd);
            bool memValCodeResult = verValidateCode.Verification(txtValidateCode);
            try
            {
                if (accValResult && pwdValResult && memValCodeResult)
                {
                    //输入合法，且验证码正确，此时验证账户密码是否正确
                    //使用T_UserDAl
                    T_UserDAl dal = new T_UserDAl();
                    ICreateSha256Pwd createSha256 = new
                        CreateGenericCode();
                    string sha256PWD = createSha256.CreateSHA256Code(txtPwd.Text);
                    object obj = dal.ValidateAccount(txtAcc.InputText, sha256PWD);
                    //obj!=null;表示返回了用户权限，此时我们可以使用Convert.ToInt32(obj);
                    if (obj != null)
                    {
                        user = new T_User(txtAcc.InputText, Convert.ToInt32(obj));
                        //打开主界面窗体
                        FrmMain main = new FrmMain();
                        Hide();
                        main.ShowDialog();
                        Close();
                        return;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                else
                {
                    throw new Exception();
                }
            }
            catch {
                ICreateValidateCode genericCode = new CreateGenericCode();
                ISetValidateControlConfig setValidateControlConfig = new ControlSet();
                var code = genericCode.CreateMemoryValidateCode();
                txtMemCode.Text = code;
                setValidateControlConfig.SetValidateControl(txtValidateCode, verValidateCode, string.Format(@"^({0}|{1})$", code, code.ToLower()), "请输入正确的验证码");
            }
        }
    }
}
