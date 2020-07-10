namespace StudentInformationManagerSystem
{
    partial class FrmTeachManaDDMLData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTeachManaDDMLData));
            this.label1 = new System.Windows.Forms.Label();
            this.birthDay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ucMan = new HZH_Controls.Controls.UCRadioButton();
            this.ucWoman = new HZH_Controls.Controls.UCRadioButton();
            this.txtName = new HZH_Controls.Controls.TextBoxEx();
            this.ucBtnExt1 = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt2 = new HZH_Controls.Controls.UCBtnExt();
            this.validateName = new HZH_Controls.Controls.VerificationComponent(this.components);
            this.validateDate = new HZH_Controls.Controls.VerificationComponent(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // birthDay
            // 
            resources.ApplyResources(this.birthDay, "birthDay");
            this.birthDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthDay.Name = "birthDay";
            this.birthDay.Value = new System.DateTime(2020, 7, 10, 17, 0, 50, 0);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // ucMan
            // 
            resources.ApplyResources(this.ucMan, "ucMan");
            this.ucMan.Checked = true;
            this.ucMan.GroupName = null;
            this.ucMan.Name = "ucMan";
            this.ucMan.TextValue = "男";
            // 
            // ucWoman
            // 
            resources.ApplyResources(this.ucWoman, "ucWoman");
            this.ucWoman.Checked = false;
            this.ucWoman.GroupName = null;
            this.ucWoman.Name = "ucWoman";
            this.ucWoman.TextValue = "女";
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.DecLength = 2;
            this.txtName.InputType = HZH_Controls.TextInputType.NotControl;
            this.txtName.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtName.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txtName.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txtName.Name = "txtName";
            this.txtName.OldText = null;
            this.txtName.PromptColor = System.Drawing.Color.Gray;
            this.txtName.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.PromptText = "";
            this.txtName.RegexPattern = "";
            this.validateName.SetVerificationCustomRegex(this.txtName, resources.GetString("txtName.VerificationCustomRegex"));
            this.validateDate.SetVerificationCustomRegex(this.txtName, resources.GetString("txtName.VerificationCustomRegex1"));
            this.validateName.SetVerificationErrorMsg(this.txtName, resources.GetString("txtName.VerificationErrorMsg"));
            this.validateDate.SetVerificationErrorMsg(this.txtName, resources.GetString("txtName.VerificationErrorMsg1"));
            this.validateName.SetVerificationModel(this.txtName, ((HZH_Controls.Controls.VerificationModel)(resources.GetObject("txtName.VerificationModel"))));
            this.validateDate.SetVerificationModel(this.txtName, ((HZH_Controls.Controls.VerificationModel)(resources.GetObject("txtName.VerificationModel1"))));
            this.validateDate.SetVerificationRequired(this.txtName, ((bool)(resources.GetObject("txtName.VerificationRequired"))));
            this.validateName.SetVerificationRequired(this.txtName, ((bool)(resources.GetObject("txtName.VerificationRequired1"))));
            // 
            // ucBtnExt1
            // 
            resources.ApplyResources(this.ucBtnExt1, "ucBtnExt1");
            this.ucBtnExt1.BackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt1.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnText = "保存";
            this.ucBtnExt1.ConerRadius = 5;
            this.ucBtnExt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt1.EnabledMouseEffect = false;
            this.ucBtnExt1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt1.IsRadius = true;
            this.ucBtnExt1.IsShowRect = true;
            this.ucBtnExt1.IsShowTips = false;
            this.ucBtnExt1.Name = "ucBtnExt1";
            this.ucBtnExt1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt1.RectWidth = 1;
            this.ucBtnExt1.TabStop = false;
            this.ucBtnExt1.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt1.TipsText = "";
            this.ucBtnExt1.BtnClick += new System.EventHandler(this.ucBtnExt1_BtnClick);
            // 
            // ucBtnExt2
            // 
            resources.ApplyResources(this.ucBtnExt2, "ucBtnExt2");
            this.ucBtnExt2.BackColor = System.Drawing.Color.White;
            this.ucBtnExt2.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt2.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt2.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt2.BtnText = "取消";
            this.ucBtnExt2.ConerRadius = 5;
            this.ucBtnExt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt2.EnabledMouseEffect = false;
            this.ucBtnExt2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt2.IsRadius = true;
            this.ucBtnExt2.IsShowRect = true;
            this.ucBtnExt2.IsShowTips = false;
            this.ucBtnExt2.Name = "ucBtnExt2";
            this.ucBtnExt2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt2.RectWidth = 1;
            this.ucBtnExt2.TabStop = false;
            this.ucBtnExt2.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt2.TipsText = "";
            this.ucBtnExt2.BtnClick += new System.EventHandler(this.ucBtnExt2_BtnClick);
            // 
            // validateName
            // 
            resources.ApplyResources(this.validateName, "validateName");
            // 
            // validateDate
            // 
            resources.ApplyResources(this.validateDate, "validateDate");
            // 
            // FrmTeachManaInsetedData
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ControlBox = false;
            this.Controls.Add(this.ucBtnExt2);
            this.Controls.Add(this.ucBtnExt1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.ucWoman);
            this.Controls.Add(this.ucMan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.birthDay);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmTeachManaInsetedData";
            this.Load += new System.EventHandler(this.FrmTeachManaInsetedData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker birthDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private HZH_Controls.Controls.UCRadioButton ucMan;
        private HZH_Controls.Controls.UCRadioButton ucWoman;
        private HZH_Controls.Controls.TextBoxEx txtName;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt1;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt2;
        private HZH_Controls.Controls.VerificationComponent validateName;
        private HZH_Controls.Controls.VerificationComponent validateDate;
    }
}