using HZH_Controls.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationManagerSystem.BLL.ControlSettingInterface
{
    public interface ISetValidateControlConfig
    {
         void SetValidateControl(Control inPutValidateCodeTextBox, VerificationComponent showValidateVer, string regex, string text, string errorMsg);
         void SetValidateControl(Control inPutValidateCodeTextBox, VerificationComponent showValidateVer, string regex, string errorMsg);
    }
}
