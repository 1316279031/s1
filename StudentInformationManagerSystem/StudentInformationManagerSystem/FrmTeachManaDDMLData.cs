using HZH_Controls.Forms;
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
    public partial class FrmTeachManaDDMLData : Form
    {
        public FrmTeachManaDDMLData()
        {
            InitializeComponent();
        }
        private string[] _values;
        public string[] Values { 
            get {
                return _values;
            } 
        }
        private void ucBtnExt1_BtnClick(object sender, EventArgs e)
        {
            var res=validateName.Verification(txtName);
            if (res == false) return;
            var time = Convert.ToDateTime(birthDay.Text);
            if((DateTime.Today.Year - time.Year)<20|| (DateTime.Today.Year - time.Year) > 100)
            {
                FrmDialog.ShowDialog(this,"日期格式不正确!");
                return;
            }
            var birth = time.ToString("yyyy-MM-dd");
            var sex = ucMan.Checked ? 1 : 0;
            _values = new string[] { txtName.Text, sex.ToString(), birth };
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ucBtnExt2_BtnClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FrmTeachManaInsetedData_Load(object sender, EventArgs e)
        {
            //注意日期不可为当前日期
            validateName.SetVerificationErrorMsg(txtName, "非法输入");
            validateName.SetVerificationModel(this, HZH_Controls.Controls.VerificationModel.Custom);
            validateName.SetVerificationCustomRegex(txtName, @"^[\u4e00-\u9fa5]{2,8}$");
            validateName.SetVerificationRequired(txtName,true);

            //获取当前日期：-100年()在这100年内时刻输入日期；因就算活到100，也应退休。
            
        }
    }
}
