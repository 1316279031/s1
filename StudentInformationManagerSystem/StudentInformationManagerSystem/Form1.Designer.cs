namespace StudentInformationManagerSystem
{
    partial class FrmLog
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtAcc = new HZH_Controls.Controls.UCTextBoxEx();
            this.ucSplitLabel1 = new HZH_Controls.Controls.UCSplitLabel();
            this.ucSplitLabel2 = new HZH_Controls.Controls.UCSplitLabel();
            this.ucBtnExt1 = new HZH_Controls.Controls.UCBtnExt();
            this.txtMemCode = new HZH_Controls.Controls.TextBoxTransparent();
            this.txtValidateCode = new HZH_Controls.Controls.UCTextBoxEx();
            this.ucSplitLabel3 = new HZH_Controls.Controls.UCSplitLabel();
            this.verAccountValidate = new HZH_Controls.Controls.VerificationComponent(this.components);
            this.verPwdValidate = new HZH_Controls.Controls.VerificationComponent(this.components);
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.verValidateCode = new HZH_Controls.Controls.VerificationComponent(this.components);
            this.SuspendLayout();
            // 
            // txtAcc
            // 
            this.txtAcc.BackColor = System.Drawing.Color.Transparent;
            this.txtAcc.ConerRadius = 5;
            this.txtAcc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAcc.DecLength = 2;
            this.txtAcc.FillColor = System.Drawing.Color.Empty;
            this.txtAcc.FocusBorderColor = System.Drawing.Color.White;
            this.txtAcc.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAcc.InputText = "";
            this.txtAcc.InputType = HZH_Controls.TextInputType.NotControl;
            this.txtAcc.IsFocusColor = true;
            this.txtAcc.IsRadius = true;
            this.txtAcc.IsShowClearBtn = true;
            this.txtAcc.IsShowKeyboard = false;
            this.txtAcc.IsShowRect = false;
            this.txtAcc.IsShowSearchBtn = false;
            this.txtAcc.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.txtAcc.Location = new System.Drawing.Point(178, 69);
            this.txtAcc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAcc.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtAcc.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.Padding = new System.Windows.Forms.Padding(5);
            this.txtAcc.PromptColor = System.Drawing.Color.Gray;
            this.txtAcc.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAcc.PromptText = "";
            this.txtAcc.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtAcc.RectWidth = 1;
            this.txtAcc.RegexPattern = "";
            this.txtAcc.Size = new System.Drawing.Size(273, 42);
            this.txtAcc.TabIndex = 0;
            this.verValidateCode.SetVerificationCustomRegex(this.txtAcc, "");
            this.verAccountValidate.SetVerificationCustomRegex(this.txtAcc, "");
            this.verPwdValidate.SetVerificationCustomRegex(this.txtAcc, "");
            this.verPwdValidate.SetVerificationErrorMsg(this.txtAcc, "");
            this.verAccountValidate.SetVerificationErrorMsg(this.txtAcc, "");
            this.verValidateCode.SetVerificationErrorMsg(this.txtAcc, "");
            this.verPwdValidate.SetVerificationModel(this.txtAcc, HZH_Controls.Controls.VerificationModel.None);
            this.verAccountValidate.SetVerificationModel(this.txtAcc, HZH_Controls.Controls.VerificationModel.None);
            this.verValidateCode.SetVerificationModel(this.txtAcc, HZH_Controls.Controls.VerificationModel.None);
            this.verPwdValidate.SetVerificationRequired(this.txtAcc, false);
            this.verAccountValidate.SetVerificationRequired(this.txtAcc, false);
            this.verValidateCode.SetVerificationRequired(this.txtAcc, false);
            // 
            // ucSplitLabel1
            // 
            this.ucSplitLabel1.AutoSize = true;
            this.ucSplitLabel1.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.ucSplitLabel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.ucSplitLabel1.Location = new System.Drawing.Point(71, 77);
            this.ucSplitLabel1.MaximumSize = new System.Drawing.Size(0, 25);
            this.ucSplitLabel1.MinimumSize = new System.Drawing.Size(100, 25);
            this.ucSplitLabel1.Name = "ucSplitLabel1";
            this.ucSplitLabel1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ucSplitLabel1.Size = new System.Drawing.Size(100, 25);
            this.ucSplitLabel1.TabIndex = 1;
            this.ucSplitLabel1.Text = "账户";
            this.ucSplitLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucSplitLabel2
            // 
            this.ucSplitLabel2.AutoSize = true;
            this.ucSplitLabel2.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.ucSplitLabel2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.ucSplitLabel2.Location = new System.Drawing.Point(71, 142);
            this.ucSplitLabel2.MaximumSize = new System.Drawing.Size(0, 25);
            this.ucSplitLabel2.MinimumSize = new System.Drawing.Size(100, 25);
            this.ucSplitLabel2.Name = "ucSplitLabel2";
            this.ucSplitLabel2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ucSplitLabel2.Size = new System.Drawing.Size(100, 25);
            this.ucSplitLabel2.TabIndex = 1;
            this.ucSplitLabel2.Text = "密码";
            this.ucSplitLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucBtnExt1
            // 
            this.ucBtnExt1.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnExt1.BtnBackColor = System.Drawing.Color.Transparent;
            this.ucBtnExt1.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt1.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnText = "登录";
            this.ucBtnExt1.ConerRadius = 20;
            this.ucBtnExt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt1.EnabledMouseEffect = false;
            this.ucBtnExt1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt1.IsRadius = true;
            this.ucBtnExt1.IsShowRect = true;
            this.ucBtnExt1.IsShowTips = false;
            this.ucBtnExt1.Location = new System.Drawing.Point(356, 247);
            this.ucBtnExt1.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt1.Name = "ucBtnExt1";
            this.ucBtnExt1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt1.RectWidth = 1;
            this.ucBtnExt1.Size = new System.Drawing.Size(95, 40);
            this.ucBtnExt1.TabIndex = 2;
            this.ucBtnExt1.TabStop = false;
            this.ucBtnExt1.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt1.TipsText = "";
            this.ucBtnExt1.BtnClick += new System.EventHandler(this.ucBtnExt1_BtnClick);
            // 
            // txtMemCode
            // 
            this.txtMemCode.BackAlpha = 10;
            this.txtMemCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtMemCode.DecLength = 2;
            this.txtMemCode.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMemCode.InputType = HZH_Controls.TextInputType.NotControl;
            this.txtMemCode.Location = new System.Drawing.Point(356, 193);
            this.txtMemCode.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtMemCode.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txtMemCode.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txtMemCode.Name = "txtMemCode";
            this.txtMemCode.OldText = null;
            this.txtMemCode.PromptColor = System.Drawing.Color.Gray;
            this.txtMemCode.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMemCode.PromptText = "";
            this.txtMemCode.ReadOnly = true;
            this.txtMemCode.RegexPattern = "";
            this.txtMemCode.Size = new System.Drawing.Size(95, 26);
            this.txtMemCode.TabIndex = 3;
            this.txtMemCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.verValidateCode.SetVerificationCustomRegex(this.txtMemCode, "");
            this.verPwdValidate.SetVerificationCustomRegex(this.txtMemCode, "");
            this.verAccountValidate.SetVerificationCustomRegex(this.txtMemCode, "");
            this.verAccountValidate.SetVerificationErrorMsg(this.txtMemCode, "");
            this.verValidateCode.SetVerificationErrorMsg(this.txtMemCode, "");
            this.verPwdValidate.SetVerificationErrorMsg(this.txtMemCode, "");
            this.verAccountValidate.SetVerificationModel(this.txtMemCode, HZH_Controls.Controls.VerificationModel.None);
            this.verPwdValidate.SetVerificationModel(this.txtMemCode, HZH_Controls.Controls.VerificationModel.None);
            this.verValidateCode.SetVerificationModel(this.txtMemCode, HZH_Controls.Controls.VerificationModel.None);
            this.verAccountValidate.SetVerificationRequired(this.txtMemCode, false);
            this.verValidateCode.SetVerificationRequired(this.txtMemCode, false);
            this.verPwdValidate.SetVerificationRequired(this.txtMemCode, false);
            // 
            // txtValidateCode
            // 
            this.txtValidateCode.BackColor = System.Drawing.Color.Transparent;
            this.txtValidateCode.ConerRadius = 5;
            this.txtValidateCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValidateCode.DecLength = 2;
            this.txtValidateCode.FillColor = System.Drawing.Color.Empty;
            this.txtValidateCode.FocusBorderColor = System.Drawing.Color.White;
            this.txtValidateCode.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtValidateCode.InputText = "";
            this.txtValidateCode.InputType = HZH_Controls.TextInputType.NotControl;
            this.txtValidateCode.IsFocusColor = true;
            this.txtValidateCode.IsRadius = true;
            this.txtValidateCode.IsShowClearBtn = true;
            this.txtValidateCode.IsShowKeyboard = false;
            this.txtValidateCode.IsShowRect = false;
            this.txtValidateCode.IsShowSearchBtn = false;
            this.txtValidateCode.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.txtValidateCode.Location = new System.Drawing.Point(178, 184);
            this.txtValidateCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtValidateCode.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtValidateCode.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txtValidateCode.Name = "txtValidateCode";
            this.txtValidateCode.Padding = new System.Windows.Forms.Padding(5);
            this.txtValidateCode.PromptColor = System.Drawing.Color.Gray;
            this.txtValidateCode.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtValidateCode.PromptText = "";
            this.txtValidateCode.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtValidateCode.RectWidth = 1;
            this.txtValidateCode.RegexPattern = "";
            this.txtValidateCode.Size = new System.Drawing.Size(147, 43);
            this.txtValidateCode.TabIndex = 0;
            this.verValidateCode.SetVerificationCustomRegex(this.txtValidateCode, "");
            this.verAccountValidate.SetVerificationCustomRegex(this.txtValidateCode, "");
            this.verPwdValidate.SetVerificationCustomRegex(this.txtValidateCode, "");
            this.verPwdValidate.SetVerificationErrorMsg(this.txtValidateCode, "");
            this.verAccountValidate.SetVerificationErrorMsg(this.txtValidateCode, "");
            this.verValidateCode.SetVerificationErrorMsg(this.txtValidateCode, "");
            this.verPwdValidate.SetVerificationModel(this.txtValidateCode, HZH_Controls.Controls.VerificationModel.None);
            this.verAccountValidate.SetVerificationModel(this.txtValidateCode, HZH_Controls.Controls.VerificationModel.None);
            this.verValidateCode.SetVerificationModel(this.txtValidateCode, HZH_Controls.Controls.VerificationModel.None);
            this.verPwdValidate.SetVerificationRequired(this.txtValidateCode, false);
            this.verAccountValidate.SetVerificationRequired(this.txtValidateCode, false);
            this.verValidateCode.SetVerificationRequired(this.txtValidateCode, false);
            // 
            // ucSplitLabel3
            // 
            this.ucSplitLabel3.AutoSize = true;
            this.ucSplitLabel3.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.ucSplitLabel3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.ucSplitLabel3.Location = new System.Drawing.Point(71, 195);
            this.ucSplitLabel3.MaximumSize = new System.Drawing.Size(0, 25);
            this.ucSplitLabel3.MinimumSize = new System.Drawing.Size(100, 25);
            this.ucSplitLabel3.Name = "ucSplitLabel3";
            this.ucSplitLabel3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ucSplitLabel3.Size = new System.Drawing.Size(100, 25);
            this.ucSplitLabel3.TabIndex = 1;
            this.ucSplitLabel3.Text = "验证码";
            this.ucSplitLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // verAccountValidate
            // 
            this.verAccountValidate.AutoCloseErrorTipsTime = 3000;
            this.verAccountValidate.ErrorTipsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.verAccountValidate.ErrorTipsForeColor = System.Drawing.Color.White;
            // 
            // verPwdValidate
            // 
            this.verPwdValidate.AutoCloseErrorTipsTime = 3000;
            this.verPwdValidate.ErrorTipsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.verPwdValidate.ErrorTipsForeColor = System.Drawing.Color.White;
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPwd.Location = new System.Drawing.Point(186, 141);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(265, 26);
            this.txtPwd.TabIndex = 4;
            this.verValidateCode.SetVerificationCustomRegex(this.txtPwd, "");
            this.verPwdValidate.SetVerificationCustomRegex(this.txtPwd, "");
            this.verAccountValidate.SetVerificationCustomRegex(this.txtPwd, "");
            this.verPwdValidate.SetVerificationErrorMsg(this.txtPwd, "");
            this.verAccountValidate.SetVerificationErrorMsg(this.txtPwd, "");
            this.verValidateCode.SetVerificationErrorMsg(this.txtPwd, "");
            this.verPwdValidate.SetVerificationModel(this.txtPwd, HZH_Controls.Controls.VerificationModel.None);
            this.verAccountValidate.SetVerificationModel(this.txtPwd, HZH_Controls.Controls.VerificationModel.None);
            this.verValidateCode.SetVerificationModel(this.txtPwd, HZH_Controls.Controls.VerificationModel.None);
            this.verPwdValidate.SetVerificationRequired(this.txtPwd, false);
            this.verAccountValidate.SetVerificationRequired(this.txtPwd, false);
            this.verValidateCode.SetVerificationRequired(this.txtPwd, false);
            // 
            // verValidateCode
            // 
            this.verValidateCode.AutoCloseErrorTipsTime = 3000;
            this.verValidateCode.ErrorTipsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.verValidateCode.ErrorTipsForeColor = System.Drawing.Color.White;
            // 
            // FrmLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(522, 337);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtMemCode);
            this.Controls.Add(this.ucBtnExt1);
            this.Controls.Add(this.ucSplitLabel3);
            this.Controls.Add(this.ucSplitLabel2);
            this.Controls.Add(this.ucSplitLabel1);
            this.Controls.Add(this.txtValidateCode);
            this.Controls.Add(this.txtAcc);
            this.MaximumSize = new System.Drawing.Size(538, 376);
            this.MinimumSize = new System.Drawing.Size(538, 376);
            this.Name = "FrmLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOG";
            this.Load += new System.EventHandler(this.FrmLog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HZH_Controls.Controls.UCTextBoxEx txtAcc;
        private HZH_Controls.Controls.UCSplitLabel ucSplitLabel1;
        private HZH_Controls.Controls.UCSplitLabel ucSplitLabel2;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt1;
        private HZH_Controls.Controls.TextBoxTransparent txtMemCode;
        private HZH_Controls.Controls.UCTextBoxEx txtValidateCode;
        private HZH_Controls.Controls.UCSplitLabel ucSplitLabel3;
        private HZH_Controls.Controls.VerificationComponent verAccountValidate;
        private HZH_Controls.Controls.VerificationComponent verPwdValidate;
        private System.Windows.Forms.TextBox txtPwd;
        private HZH_Controls.Controls.VerificationComponent verValidateCode;
    }
}

