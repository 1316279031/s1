namespace StudentInformationManagerSystem
{
    partial class FrmUpdataClassInformation
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
            this.ucBtnSave = new HZH_Controls.Controls.UCBtnExt();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUPCollegeID = new HZH_Controls.Controls.TextBoxEx();
            this.txtUPClassName = new HZH_Controls.Controls.TextBoxEx();
            this.txtUPclassID = new HZH_Controls.Controls.TextBoxTransparent();
            this.verNameValidate = new HZH_Controls.Controls.VerificationComponent(this.components);
            this.verCollegeIDValidate = new HZH_Controls.Controls.VerificationComponent(this.components);
            this.SuspendLayout();
            // 
            // ucBtnSave
            // 
            this.ucBtnSave.BackColor = System.Drawing.Color.White;
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
            this.ucBtnSave.Location = new System.Drawing.Point(175, 186);
            this.ucBtnSave.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnSave.Name = "ucBtnSave";
            this.ucBtnSave.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnSave.RectWidth = 1;
            this.ucBtnSave.Size = new System.Drawing.Size(170, 47);
            this.ucBtnSave.TabIndex = 15;
            this.ucBtnSave.TabStop = false;
            this.ucBtnSave.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnSave.TipsText = "";
            this.ucBtnSave.BtnClick += new System.EventHandler(this.ucBtnSave_BtnClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(70, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "学院编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(70, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "班级名称 ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(70, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "班级编号";
            // 
            // txtUPCollegeID
            // 
            this.txtUPCollegeID.DecLength = 2;
            this.txtUPCollegeID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUPCollegeID.InputType = HZH_Controls.TextInputType.NotControl;
            this.txtUPCollegeID.Location = new System.Drawing.Point(175, 114);
            this.txtUPCollegeID.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtUPCollegeID.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txtUPCollegeID.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txtUPCollegeID.Name = "txtUPCollegeID";
            this.txtUPCollegeID.OldText = null;
            this.txtUPCollegeID.PromptColor = System.Drawing.Color.Gray;
            this.txtUPCollegeID.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUPCollegeID.PromptText = "";
            this.txtUPCollegeID.RegexPattern = "";
            this.txtUPCollegeID.Size = new System.Drawing.Size(170, 26);
            this.txtUPCollegeID.TabIndex = 7;
            this.verNameValidate.SetVerificationCustomRegex(this.txtUPCollegeID, "");
            this.verCollegeIDValidate.SetVerificationCustomRegex(this.txtUPCollegeID, "");
            this.verNameValidate.SetVerificationErrorMsg(this.txtUPCollegeID, "");
            this.verCollegeIDValidate.SetVerificationErrorMsg(this.txtUPCollegeID, "");
            this.verNameValidate.SetVerificationModel(this.txtUPCollegeID, HZH_Controls.Controls.VerificationModel.None);
            this.verCollegeIDValidate.SetVerificationModel(this.txtUPCollegeID, HZH_Controls.Controls.VerificationModel.None);
            this.verCollegeIDValidate.SetVerificationRequired(this.txtUPCollegeID, false);
            this.verNameValidate.SetVerificationRequired(this.txtUPCollegeID, false);
            // 
            // txtUPClassName
            // 
            this.txtUPClassName.DecLength = 2;
            this.txtUPClassName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUPClassName.InputType = HZH_Controls.TextInputType.NotControl;
            this.txtUPClassName.Location = new System.Drawing.Point(175, 71);
            this.txtUPClassName.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtUPClassName.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txtUPClassName.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txtUPClassName.Name = "txtUPClassName";
            this.txtUPClassName.OldText = null;
            this.txtUPClassName.PromptColor = System.Drawing.Color.Gray;
            this.txtUPClassName.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUPClassName.PromptText = "";
            this.txtUPClassName.RegexPattern = "";
            this.txtUPClassName.Size = new System.Drawing.Size(170, 26);
            this.txtUPClassName.TabIndex = 9;
            this.verNameValidate.SetVerificationCustomRegex(this.txtUPClassName, "");
            this.verCollegeIDValidate.SetVerificationCustomRegex(this.txtUPClassName, "");
            this.verNameValidate.SetVerificationErrorMsg(this.txtUPClassName, "");
            this.verCollegeIDValidate.SetVerificationErrorMsg(this.txtUPClassName, "");
            this.verNameValidate.SetVerificationModel(this.txtUPClassName, HZH_Controls.Controls.VerificationModel.None);
            this.verCollegeIDValidate.SetVerificationModel(this.txtUPClassName, HZH_Controls.Controls.VerificationModel.None);
            this.verCollegeIDValidate.SetVerificationRequired(this.txtUPClassName, false);
            this.verNameValidate.SetVerificationRequired(this.txtUPClassName, false);
            // 
            // txtUPclassID
            // 
            this.txtUPclassID.BackAlpha = 10;
            this.txtUPclassID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtUPclassID.DecLength = 2;
            this.txtUPclassID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUPclassID.InputType = HZH_Controls.TextInputType.NotControl;
            this.txtUPclassID.Location = new System.Drawing.Point(175, 25);
            this.txtUPclassID.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtUPclassID.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txtUPclassID.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txtUPclassID.Name = "txtUPclassID";
            this.txtUPclassID.OldText = null;
            this.txtUPclassID.PromptColor = System.Drawing.Color.Gray;
            this.txtUPclassID.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUPclassID.PromptText = "";
            this.txtUPclassID.RegexPattern = "";
            this.txtUPclassID.Size = new System.Drawing.Size(170, 26);
            this.txtUPclassID.TabIndex = 6;
            this.verCollegeIDValidate.SetVerificationCustomRegex(this.txtUPclassID, "");
            this.verNameValidate.SetVerificationCustomRegex(this.txtUPclassID, "");
            this.verCollegeIDValidate.SetVerificationErrorMsg(this.txtUPclassID, "");
            this.verNameValidate.SetVerificationErrorMsg(this.txtUPclassID, "");
            this.verCollegeIDValidate.SetVerificationModel(this.txtUPclassID, HZH_Controls.Controls.VerificationModel.None);
            this.verNameValidate.SetVerificationModel(this.txtUPclassID, HZH_Controls.Controls.VerificationModel.None);
            this.verCollegeIDValidate.SetVerificationRequired(this.txtUPclassID, false);
            this.verNameValidate.SetVerificationRequired(this.txtUPclassID, false);
            // 
            // verNameValidate
            // 
            this.verNameValidate.AutoCloseErrorTipsTime = 3000;
            this.verNameValidate.ErrorTipsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.verNameValidate.ErrorTipsForeColor = System.Drawing.Color.White;
            // 
            // verCollegeIDValidate
            // 
            this.verCollegeIDValidate.AutoCloseErrorTipsTime = 3000;
            this.verCollegeIDValidate.ErrorTipsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.verCollegeIDValidate.ErrorTipsForeColor = System.Drawing.Color.White;
            // 
            // FrmUpdataClassInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(415, 258);
            this.Controls.Add(this.ucBtnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUPCollegeID);
            this.Controls.Add(this.txtUPClassName);
            this.Controls.Add(this.txtUPclassID);
            this.MaximumSize = new System.Drawing.Size(431, 297);
            this.MinimumSize = new System.Drawing.Size(431, 297);
            this.Name = "FrmUpdataClassInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUpdataClassInformation";
            this.Load += new System.EventHandler(this.FrmUpdataClassInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private HZH_Controls.Controls.UCBtnExt ucBtnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private HZH_Controls.Controls.TextBoxEx txtUPCollegeID;
        private HZH_Controls.Controls.TextBoxEx txtUPClassName;
        private HZH_Controls.Controls.TextBoxTransparent txtUPclassID;
        private HZH_Controls.Controls.VerificationComponent verNameValidate;
        private HZH_Controls.Controls.VerificationComponent verCollegeIDValidate;
    }
}