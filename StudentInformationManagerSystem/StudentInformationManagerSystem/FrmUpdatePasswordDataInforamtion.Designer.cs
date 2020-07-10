namespace StudentInformationManagerSystem
{
    partial class FrmUpdatePasswordDataInforamtion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.ucBtnExt1 = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt2 = new HZH_Controls.Controls.UCBtnExt();
            this.validateUserID = new HZH_Controls.Controls.VerificationComponent(this.components);
            this.validatePassword1 = new HZH_Controls.Controls.VerificationComponent(this.components);
            this.validatePassword2 = new HZH_Controls.Controls.VerificationComponent(this.components);
            this.validateNewPassword = new HZH_Controls.Controls.VerificationComponent(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(155, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // txtUserID
            // 
            this.txtUserID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUserID.Location = new System.Drawing.Point(249, 77);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(237, 26);
            this.txtUserID.TabIndex = 1;
            this.validatePassword2.SetVerificationCustomRegex(this.txtUserID, "");
            this.validateNewPassword.SetVerificationCustomRegex(this.txtUserID, "");
            this.validatePassword1.SetVerificationCustomRegex(this.txtUserID, "");
            this.validateUserID.SetVerificationCustomRegex(this.txtUserID, "");
            this.validatePassword1.SetVerificationErrorMsg(this.txtUserID, "");
            this.validateUserID.SetVerificationErrorMsg(this.txtUserID, "");
            this.validateNewPassword.SetVerificationErrorMsg(this.txtUserID, "");
            this.validatePassword2.SetVerificationErrorMsg(this.txtUserID, "");
            this.validatePassword1.SetVerificationModel(this.txtUserID, HZH_Controls.Controls.VerificationModel.None);
            this.validateUserID.SetVerificationModel(this.txtUserID, HZH_Controls.Controls.VerificationModel.None);
            this.validateNewPassword.SetVerificationModel(this.txtUserID, HZH_Controls.Controls.VerificationModel.None);
            this.validatePassword2.SetVerificationModel(this.txtUserID, HZH_Controls.Controls.VerificationModel.None);
            this.validatePassword1.SetVerificationRequired(this.txtUserID, false);
            this.validateUserID.SetVerificationRequired(this.txtUserID, false);
            this.validateNewPassword.SetVerificationRequired(this.txtUserID, false);
            this.validatePassword2.SetVerificationRequired(this.txtUserID, false);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(171, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "密码";
            // 
            // txtPassword1
            // 
            this.txtPassword1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPassword1.Location = new System.Drawing.Point(249, 136);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.Size = new System.Drawing.Size(237, 26);
            this.txtPassword1.TabIndex = 1;
            this.validatePassword2.SetVerificationCustomRegex(this.txtPassword1, "");
            this.validateNewPassword.SetVerificationCustomRegex(this.txtPassword1, "");
            this.validatePassword1.SetVerificationCustomRegex(this.txtPassword1, "");
            this.validateUserID.SetVerificationCustomRegex(this.txtPassword1, "");
            this.validatePassword1.SetVerificationErrorMsg(this.txtPassword1, "");
            this.validateUserID.SetVerificationErrorMsg(this.txtPassword1, "");
            this.validateNewPassword.SetVerificationErrorMsg(this.txtPassword1, "");
            this.validatePassword2.SetVerificationErrorMsg(this.txtPassword1, "");
            this.validatePassword1.SetVerificationModel(this.txtPassword1, HZH_Controls.Controls.VerificationModel.None);
            this.validateUserID.SetVerificationModel(this.txtPassword1, HZH_Controls.Controls.VerificationModel.None);
            this.validateNewPassword.SetVerificationModel(this.txtPassword1, HZH_Controls.Controls.VerificationModel.None);
            this.validatePassword2.SetVerificationModel(this.txtPassword1, HZH_Controls.Controls.VerificationModel.None);
            this.validatePassword1.SetVerificationRequired(this.txtPassword1, false);
            this.validateUserID.SetVerificationRequired(this.txtPassword1, false);
            this.validateNewPassword.SetVerificationRequired(this.txtPassword1, false);
            this.validatePassword2.SetVerificationRequired(this.txtPassword1, false);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(107, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "再次输入密码";
            // 
            // txtPassword2
            // 
            this.txtPassword2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPassword2.Location = new System.Drawing.Point(249, 190);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(237, 26);
            this.txtPassword2.TabIndex = 1;
            this.validatePassword2.SetVerificationCustomRegex(this.txtPassword2, "");
            this.validateNewPassword.SetVerificationCustomRegex(this.txtPassword2, "");
            this.validatePassword1.SetVerificationCustomRegex(this.txtPassword2, "");
            this.validateUserID.SetVerificationCustomRegex(this.txtPassword2, "");
            this.validatePassword1.SetVerificationErrorMsg(this.txtPassword2, "");
            this.validateUserID.SetVerificationErrorMsg(this.txtPassword2, "");
            this.validateNewPassword.SetVerificationErrorMsg(this.txtPassword2, "");
            this.validatePassword2.SetVerificationErrorMsg(this.txtPassword2, "");
            this.validatePassword1.SetVerificationModel(this.txtPassword2, HZH_Controls.Controls.VerificationModel.None);
            this.validateUserID.SetVerificationModel(this.txtPassword2, HZH_Controls.Controls.VerificationModel.None);
            this.validateNewPassword.SetVerificationModel(this.txtPassword2, HZH_Controls.Controls.VerificationModel.None);
            this.validatePassword2.SetVerificationModel(this.txtPassword2, HZH_Controls.Controls.VerificationModel.None);
            this.validatePassword1.SetVerificationRequired(this.txtPassword2, false);
            this.validateUserID.SetVerificationRequired(this.txtPassword2, false);
            this.validateNewPassword.SetVerificationRequired(this.txtPassword2, false);
            this.validatePassword2.SetVerificationRequired(this.txtPassword2, false);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(155, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "新密码";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNewPassword.Location = new System.Drawing.Point(249, 245);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(237, 26);
            this.txtNewPassword.TabIndex = 1;
            this.validatePassword2.SetVerificationCustomRegex(this.txtNewPassword, "");
            this.validateNewPassword.SetVerificationCustomRegex(this.txtNewPassword, "");
            this.validatePassword1.SetVerificationCustomRegex(this.txtNewPassword, "");
            this.validateUserID.SetVerificationCustomRegex(this.txtNewPassword, "");
            this.validatePassword1.SetVerificationErrorMsg(this.txtNewPassword, "");
            this.validateUserID.SetVerificationErrorMsg(this.txtNewPassword, "");
            this.validateNewPassword.SetVerificationErrorMsg(this.txtNewPassword, "");
            this.validatePassword2.SetVerificationErrorMsg(this.txtNewPassword, "");
            this.validatePassword1.SetVerificationModel(this.txtNewPassword, HZH_Controls.Controls.VerificationModel.None);
            this.validateUserID.SetVerificationModel(this.txtNewPassword, HZH_Controls.Controls.VerificationModel.None);
            this.validateNewPassword.SetVerificationModel(this.txtNewPassword, HZH_Controls.Controls.VerificationModel.None);
            this.validatePassword2.SetVerificationModel(this.txtNewPassword, HZH_Controls.Controls.VerificationModel.None);
            this.validatePassword1.SetVerificationRequired(this.txtNewPassword, false);
            this.validateUserID.SetVerificationRequired(this.txtNewPassword, false);
            this.validateNewPassword.SetVerificationRequired(this.txtNewPassword, false);
            this.validatePassword2.SetVerificationRequired(this.txtNewPassword, false);
            // 
            // ucBtnExt1
            // 
            this.ucBtnExt1.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnExt1.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt1.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnText = "确定修改";
            this.ucBtnExt1.ConerRadius = 5;
            this.ucBtnExt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt1.EnabledMouseEffect = false;
            this.ucBtnExt1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt1.IsRadius = true;
            this.ucBtnExt1.IsShowRect = true;
            this.ucBtnExt1.IsShowTips = false;
            this.ucBtnExt1.Location = new System.Drawing.Point(139, 306);
            this.ucBtnExt1.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt1.Name = "ucBtnExt1";
            this.ucBtnExt1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt1.RectWidth = 1;
            this.ucBtnExt1.Size = new System.Drawing.Size(184, 60);
            this.ucBtnExt1.TabIndex = 2;
            this.ucBtnExt1.TabStop = false;
            this.ucBtnExt1.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt1.TipsText = "";
            this.ucBtnExt1.BtnClick += new System.EventHandler(this.ucBtnExt1_BtnClick);
            // 
            // ucBtnExt2
            // 
            this.ucBtnExt2.BackColor = System.Drawing.Color.White;
            this.ucBtnExt2.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt2.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt2.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt2.BtnText = "取消";
            this.ucBtnExt2.ConerRadius = 5;
            this.ucBtnExt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt2.EnabledMouseEffect = false;
            this.ucBtnExt2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt2.IsRadius = true;
            this.ucBtnExt2.IsShowRect = true;
            this.ucBtnExt2.IsShowTips = false;
            this.ucBtnExt2.Location = new System.Drawing.Point(331, 306);
            this.ucBtnExt2.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt2.Name = "ucBtnExt2";
            this.ucBtnExt2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt2.RectWidth = 1;
            this.ucBtnExt2.Size = new System.Drawing.Size(184, 60);
            this.ucBtnExt2.TabIndex = 2;
            this.ucBtnExt2.TabStop = false;
            this.ucBtnExt2.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt2.TipsText = "";
            this.ucBtnExt2.BtnClick += new System.EventHandler(this.ucBtnExt2_BtnClick);
            // 
            // validateUserID
            // 
            this.validateUserID.AutoCloseErrorTipsTime = 3000;
            this.validateUserID.ErrorTipsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.validateUserID.ErrorTipsForeColor = System.Drawing.Color.White;
            // 
            // validatePassword1
            // 
            this.validatePassword1.AutoCloseErrorTipsTime = 3000;
            this.validatePassword1.ErrorTipsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.validatePassword1.ErrorTipsForeColor = System.Drawing.Color.White;
            // 
            // validatePassword2
            // 
            this.validatePassword2.AutoCloseErrorTipsTime = 3000;
            this.validatePassword2.ErrorTipsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.validatePassword2.ErrorTipsForeColor = System.Drawing.Color.White;
            // 
            // validateNewPassword
            // 
            this.validateNewPassword.AutoCloseErrorTipsTime = 3000;
            this.validateNewPassword.ErrorTipsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.validateNewPassword.ErrorTipsForeColor = System.Drawing.Color.White;
            // 
            // FrmUpdatePasswordDataInforamtion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(621, 442);
            this.ControlBox = false;
            this.Controls.Add(this.ucBtnExt2);
            this.Controls.Add(this.ucBtnExt1);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmUpdatePasswordDataInforamtion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUpdatePasswordDataInforamtion";
            this.Load += new System.EventHandler(this.FrmUpdatePasswordDataInforamtion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewPassword;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt1;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt2;
        private HZH_Controls.Controls.VerificationComponent validatePassword2;
        private HZH_Controls.Controls.VerificationComponent validateNewPassword;
        private HZH_Controls.Controls.VerificationComponent validatePassword1;
        private HZH_Controls.Controls.VerificationComponent validateUserID;
    }
}