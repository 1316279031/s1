using HZH_Controls.Controls;
using StudentInformationManagerSystem.BLL.ControlSettingInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationManagerSystem.BLL.ControlSetting
{
    /// <summary>
    /// 封装控件相同的操作
    /// </summary>
    public class ControlSet : ISetValidateControlConfig
    {
        public void SetValidateControl(Control inPutValidateCodeTextBox, VerificationComponent showValidateVer, string regex, string text, string errorMsg)
        {
            
            inPutValidateCodeTextBox.Text = text;
            showValidateVer.SetVerificationErrorMsg(inPutValidateCodeTextBox, errorMsg);
            showValidateVer.SetVerificationModel(inPutValidateCodeTextBox, VerificationModel.Custom);
            showValidateVer.SetVerificationCustomRegex(inPutValidateCodeTextBox, regex);
            showValidateVer.SetVerificationRequired(inPutValidateCodeTextBox, true);
        }

        public void SetValidateControl(Control inPutValidateCodeTextBox, VerificationComponent showValidateVer, string regex, string errorMsg)
        {
            showValidateVer.SetVerificationErrorMsg(inPutValidateCodeTextBox, errorMsg);
            showValidateVer.SetVerificationModel(inPutValidateCodeTextBox, VerificationModel.Custom);
            showValidateVer.SetVerificationCustomRegex(inPutValidateCodeTextBox, regex);
            showValidateVer.SetVerificationRequired(inPutValidateCodeTextBox, true);
        }
    }
}
