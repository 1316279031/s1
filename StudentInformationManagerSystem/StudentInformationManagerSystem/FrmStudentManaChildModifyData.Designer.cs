namespace StudentInformationManagerSystem
{
    partial class FrmStudentManaChildModifyData
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
            this.txtStuID = new HZH_Controls.Controls.TextBoxTransparent();
            this.txtStuName = new HZH_Controls.Controls.TextBoxEx();
            this.txtBirthDay = new HZH_Controls.Controls.TextBoxEx();
            this.txtClassID = new HZH_Controls.Controls.TextBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ucBtnSave = new HZH_Controls.Controls.UCBtnExt();
            this.ucRidMan = new HZH_Controls.Controls.UCRadioButton();
            this.ucRdiWoman = new HZH_Controls.Controls.UCRadioButton();
            this.txtNameValidate = new HZH_Controls.Controls.VerificationComponent(this.components);
            this.txtBirthDayValidate = new HZH_Controls.Controls.VerificationComponent(this.components);
            this.txtClassIDValidate = new HZH_Controls.Controls.VerificationComponent(this.components);
            this.SuspendLayout();
            // 
            // txtStuID
            // 
            this.txtStuID.BackAlpha = 10;
            this.txtStuID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtStuID.DecLength = 2;
            this.txtStuID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtStuID.InputType = HZH_Controls.TextInputType.NotControl;
            this.txtStuID.Location = new System.Drawing.Point(179, 35);
            this.txtStuID.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtStuID.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txtStuID.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txtStuID.Name = "txtStuID";
            this.txtStuID.OldText = null;
            this.txtStuID.PromptColor = System.Drawing.Color.Gray;
            this.txtStuID.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtStuID.PromptText = "";
            this.txtStuID.RegexPattern = "";
            this.txtStuID.Size = new System.Drawing.Size(170, 26);
            this.txtStuID.TabIndex = 0;
            this.txtNameValidate.SetVerificationCustomRegex(this.txtStuID, "");
            this.txtClassIDValidate.SetVerificationCustomRegex(this.txtStuID, "");
            this.txtBirthDayValidate.SetVerificationCustomRegex(this.txtStuID, "");
            this.txtClassIDValidate.SetVerificationErrorMsg(this.txtStuID, "");
            this.txtBirthDayValidate.SetVerificationErrorMsg(this.txtStuID, "");
            this.txtNameValidate.SetVerificationErrorMsg(this.txtStuID, "");
            this.txtNameValidate.SetVerificationModel(this.txtStuID, HZH_Controls.Controls.VerificationModel.None);
            this.txtBirthDayValidate.SetVerificationModel(this.txtStuID, HZH_Controls.Controls.VerificationModel.None);
            this.txtClassIDValidate.SetVerificationModel(this.txtStuID, HZH_Controls.Controls.VerificationModel.None);
            this.txtNameValidate.SetVerificationRequired(this.txtStuID, false);
            this.txtClassIDValidate.SetVerificationRequired(this.txtStuID, false);
            this.txtBirthDayValidate.SetVerificationRequired(this.txtStuID, false);
            // 
            // txtStuName
            // 
            this.txtStuName.DecLength = 2;
            this.txtStuName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtStuName.InputType = HZH_Controls.TextInputType.NotControl;
            this.txtStuName.Location = new System.Drawing.Point(179, 81);
            this.txtStuName.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtStuName.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txtStuName.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.OldText = null;
            this.txtStuName.PromptColor = System.Drawing.Color.Gray;
            this.txtStuName.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtStuName.PromptText = "";
            this.txtStuName.RegexPattern = "";
            this.txtStuName.Size = new System.Drawing.Size(170, 26);
            this.txtStuName.TabIndex = 1;
            this.txtClassIDValidate.SetVerificationCustomRegex(this.txtStuName, "");
            this.txtBirthDayValidate.SetVerificationCustomRegex(this.txtStuName, "");
            this.txtNameValidate.SetVerificationCustomRegex(this.txtStuName, "");
            this.txtClassIDValidate.SetVerificationErrorMsg(this.txtStuName, "");
            this.txtBirthDayValidate.SetVerificationErrorMsg(this.txtStuName, "");
            this.txtNameValidate.SetVerificationErrorMsg(this.txtStuName, "");
            this.txtNameValidate.SetVerificationModel(this.txtStuName, HZH_Controls.Controls.VerificationModel.None);
            this.txtBirthDayValidate.SetVerificationModel(this.txtStuName, HZH_Controls.Controls.VerificationModel.None);
            this.txtClassIDValidate.SetVerificationModel(this.txtStuName, HZH_Controls.Controls.VerificationModel.None);
            this.txtNameValidate.SetVerificationRequired(this.txtStuName, false);
            this.txtClassIDValidate.SetVerificationRequired(this.txtStuName, false);
            this.txtBirthDayValidate.SetVerificationRequired(this.txtStuName, false);
            // 
            // txtBirthDay
            // 
            this.txtBirthDay.DecLength = 2;
            this.txtBirthDay.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBirthDay.InputType = HZH_Controls.TextInputType.NotControl;
            this.txtBirthDay.Location = new System.Drawing.Point(179, 124);
            this.txtBirthDay.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtBirthDay.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txtBirthDay.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txtBirthDay.Name = "txtBirthDay";
            this.txtBirthDay.OldText = null;
            this.txtBirthDay.PromptColor = System.Drawing.Color.Gray;
            this.txtBirthDay.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBirthDay.PromptText = "";
            this.txtBirthDay.RegexPattern = "";
            this.txtBirthDay.Size = new System.Drawing.Size(170, 26);
            this.txtBirthDay.TabIndex = 1;
            this.txtClassIDValidate.SetVerificationCustomRegex(this.txtBirthDay, "");
            this.txtBirthDayValidate.SetVerificationCustomRegex(this.txtBirthDay, "");
            this.txtNameValidate.SetVerificationCustomRegex(this.txtBirthDay, "");
            this.txtClassIDValidate.SetVerificationErrorMsg(this.txtBirthDay, "");
            this.txtBirthDayValidate.SetVerificationErrorMsg(this.txtBirthDay, "");
            this.txtNameValidate.SetVerificationErrorMsg(this.txtBirthDay, "");
            this.txtNameValidate.SetVerificationModel(this.txtBirthDay, HZH_Controls.Controls.VerificationModel.None);
            this.txtBirthDayValidate.SetVerificationModel(this.txtBirthDay, HZH_Controls.Controls.VerificationModel.None);
            this.txtClassIDValidate.SetVerificationModel(this.txtBirthDay, HZH_Controls.Controls.VerificationModel.None);
            this.txtNameValidate.SetVerificationRequired(this.txtBirthDay, false);
            this.txtClassIDValidate.SetVerificationRequired(this.txtBirthDay, false);
            this.txtBirthDayValidate.SetVerificationRequired(this.txtBirthDay, false);
            // 
            // txtClassID
            // 
            this.txtClassID.DecLength = 2;
            this.txtClassID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtClassID.InputType = HZH_Controls.TextInputType.NotControl;
            this.txtClassID.Location = new System.Drawing.Point(179, 207);
            this.txtClassID.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtClassID.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txtClassID.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.OldText = null;
            this.txtClassID.PromptColor = System.Drawing.Color.Gray;
            this.txtClassID.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtClassID.PromptText = "";
            this.txtClassID.RegexPattern = "";
            this.txtClassID.Size = new System.Drawing.Size(170, 26);
            this.txtClassID.TabIndex = 1;
            this.txtClassIDValidate.SetVerificationCustomRegex(this.txtClassID, "");
            this.txtBirthDayValidate.SetVerificationCustomRegex(this.txtClassID, "");
            this.txtNameValidate.SetVerificationCustomRegex(this.txtClassID, "");
            this.txtClassIDValidate.SetVerificationErrorMsg(this.txtClassID, "");
            this.txtBirthDayValidate.SetVerificationErrorMsg(this.txtClassID, "");
            this.txtNameValidate.SetVerificationErrorMsg(this.txtClassID, "");
            this.txtNameValidate.SetVerificationModel(this.txtClassID, HZH_Controls.Controls.VerificationModel.None);
            this.txtBirthDayValidate.SetVerificationModel(this.txtClassID, HZH_Controls.Controls.VerificationModel.None);
            this.txtClassIDValidate.SetVerificationModel(this.txtClassID, HZH_Controls.Controls.VerificationModel.None);
            this.txtNameValidate.SetVerificationRequired(this.txtClassID, false);
            this.txtClassIDValidate.SetVerificationRequired(this.txtClassID, false);
            this.txtBirthDayValidate.SetVerificationRequired(this.txtClassID, false);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(74, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "学号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(74, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(74, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "出生日期";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(74, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "性别";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(74, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "班级编号";
            // 
            // ucBtnSave
            // 
            this.ucBtnSave.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnSave.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnSave.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnSave.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnSave.BtnText = "保存";
            this.ucBtnSave.ConerRadius = 5;
            this.ucBtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnSave.EnabledMouseEffect = false;
            this.ucBtnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnSave.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnSave.IsRadius = true;
            this.ucBtnSave.IsShowRect = true;
            this.ucBtnSave.IsShowTips = false;
            this.ucBtnSave.Location = new System.Drawing.Point(179, 256);
            this.ucBtnSave.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnSave.Name = "ucBtnSave";
            this.ucBtnSave.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnSave.RectWidth = 1;
            this.ucBtnSave.Size = new System.Drawing.Size(170, 47);
            this.ucBtnSave.TabIndex = 4;
            this.ucBtnSave.TabStop = false;
            this.ucBtnSave.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnSave.TipsText = "";
            this.ucBtnSave.BtnClick += new System.EventHandler(this.ucBtnSave_BtnClick);
            // 
            // ucRidMan
            // 
            this.ucRidMan.Checked = false;
            this.ucRidMan.GroupName = null;
            this.ucRidMan.Location = new System.Drawing.Point(179, 164);
            this.ucRidMan.Name = "ucRidMan";
            this.ucRidMan.Size = new System.Drawing.Size(101, 30);
            this.ucRidMan.TabIndex = 5;
            this.ucRidMan.TextValue = "男";
            // 
            // ucRdiWoman
            // 
            this.ucRdiWoman.Checked = false;
            this.ucRdiWoman.GroupName = null;
            this.ucRdiWoman.Location = new System.Drawing.Point(286, 164);
            this.ucRdiWoman.Name = "ucRdiWoman";
            this.ucRdiWoman.Size = new System.Drawing.Size(101, 30);
            this.ucRdiWoman.TabIndex = 5;
            this.ucRdiWoman.TextValue = "女";
            // 
            // txtNameValidate
            // 
            this.txtNameValidate.AutoCloseErrorTipsTime = 3000;
            this.txtNameValidate.ErrorTipsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.txtNameValidate.ErrorTipsForeColor = System.Drawing.Color.White;
            // 
            // txtBirthDayValidate
            // 
            this.txtBirthDayValidate.AutoCloseErrorTipsTime = 3000;
            this.txtBirthDayValidate.ErrorTipsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.txtBirthDayValidate.ErrorTipsForeColor = System.Drawing.Color.White;
            // 
            // txtClassIDValidate
            // 
            this.txtClassIDValidate.AutoCloseErrorTipsTime = 3000;
            this.txtClassIDValidate.ErrorTipsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.txtClassIDValidate.ErrorTipsForeColor = System.Drawing.Color.White;
            // 
            // FrmStudentManaChildModifyData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(422, 339);
            this.Controls.Add(this.ucRdiWoman);
            this.Controls.Add(this.ucRidMan);
            this.Controls.Add(this.ucBtnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClassID);
            this.Controls.Add(this.txtBirthDay);
            this.Controls.Add(this.txtStuName);
            this.Controls.Add(this.txtStuID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(438, 378);
            this.MinimumSize = new System.Drawing.Size(438, 378);
            this.Name = "FrmStudentManaChildModifyData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStudentManaChildModifyData";
            this.Load += new System.EventHandler(this.FrmStudentManaChildModifyData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HZH_Controls.Controls.TextBoxTransparent txtStuID;
        private HZH_Controls.Controls.TextBoxEx txtStuName;
        private HZH_Controls.Controls.TextBoxEx txtBirthDay;
        private HZH_Controls.Controls.TextBoxEx txtClassID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private HZH_Controls.Controls.UCBtnExt ucBtnSave;
        private HZH_Controls.Controls.UCRadioButton ucRidMan;
        private HZH_Controls.Controls.UCRadioButton ucRdiWoman;
        private HZH_Controls.Controls.VerificationComponent txtNameValidate;
        private HZH_Controls.Controls.VerificationComponent txtBirthDayValidate;
        private HZH_Controls.Controls.VerificationComponent txtClassIDValidate;
    }
}