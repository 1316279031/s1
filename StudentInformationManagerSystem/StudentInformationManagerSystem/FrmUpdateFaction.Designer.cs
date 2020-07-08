namespace StudentInformationManagerSystem
{
    partial class FrmUpdateFaction
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
            this.ucBtnExt1 = new HZH_Controls.Controls.UCBtnExt();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFaction = new HZH_Controls.Controls.TextBoxEx();
            this.txtTeachName = new HZH_Controls.Controls.TextBoxTransparent();
            this.txtStuName = new HZH_Controls.Controls.TextBoxTransparent();
            this.txtStuID = new HZH_Controls.Controls.TextBoxTransparent();
            this.txtCourseName = new HZH_Controls.Controls.TextBoxTransparent();
            this.SuspendLayout();
            // 
            // ucBtnExt1
            // 
            this.ucBtnExt1.BackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt1.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnText = "保存";
            this.ucBtnExt1.ConerRadius = 5;
            this.ucBtnExt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt1.EnabledMouseEffect = false;
            this.ucBtnExt1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt1.IsRadius = true;
            this.ucBtnExt1.IsShowRect = true;
            this.ucBtnExt1.IsShowTips = false;
            this.ucBtnExt1.Location = new System.Drawing.Point(222, 328);
            this.ucBtnExt1.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt1.Name = "ucBtnExt1";
            this.ucBtnExt1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt1.RectWidth = 1;
            this.ucBtnExt1.Size = new System.Drawing.Size(173, 63);
            this.ucBtnExt1.TabIndex = 16;
            this.ucBtnExt1.TabStop = false;
            this.ucBtnExt1.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt1.TipsText = "";
            this.ucBtnExt1.BtnClick += new System.EventHandler(this.ucBtnExt1_BtnClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(136, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "分数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(136, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "教师名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(136, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "课程名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(136, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(136, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "学号";
            // 
            // txtFaction
            // 
            this.txtFaction.DecLength = 2;
            this.txtFaction.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFaction.InputType = HZH_Controls.TextInputType.NotControl;
            this.txtFaction.Location = new System.Drawing.Point(222, 269);
            this.txtFaction.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtFaction.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txtFaction.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txtFaction.Name = "txtFaction";
            this.txtFaction.OldText = null;
            this.txtFaction.PromptColor = System.Drawing.Color.Gray;
            this.txtFaction.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFaction.PromptText = "";
            this.txtFaction.RegexPattern = "";
            this.txtFaction.Size = new System.Drawing.Size(173, 26);
            this.txtFaction.TabIndex = 10;
            // 
            // txtTeachName
            // 
            this.txtTeachName.BackAlpha = 10;
            this.txtTeachName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtTeachName.DecLength = 2;
            this.txtTeachName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTeachName.InputType = HZH_Controls.TextInputType.NotControl;
            this.txtTeachName.Location = new System.Drawing.Point(222, 218);
            this.txtTeachName.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtTeachName.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txtTeachName.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txtTeachName.Name = "txtTeachName";
            this.txtTeachName.OldText = null;
            this.txtTeachName.PromptColor = System.Drawing.Color.Gray;
            this.txtTeachName.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTeachName.PromptText = "";
            this.txtTeachName.ReadOnly = true;
            this.txtTeachName.RegexPattern = "";
            this.txtTeachName.Size = new System.Drawing.Size(173, 26);
            this.txtTeachName.TabIndex = 7;
            this.txtTeachName.TabStop = false;
            // 
            // txtStuName
            // 
            this.txtStuName.BackAlpha = 10;
            this.txtStuName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtStuName.DecLength = 2;
            this.txtStuName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtStuName.InputType = HZH_Controls.TextInputType.NotControl;
            this.txtStuName.Location = new System.Drawing.Point(222, 110);
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
            this.txtStuName.ReadOnly = true;
            this.txtStuName.RegexPattern = "";
            this.txtStuName.Size = new System.Drawing.Size(173, 26);
            this.txtStuName.TabIndex = 8;
            this.txtStuName.TabStop = false;
            // 
            // txtStuID
            // 
            this.txtStuID.BackAlpha = 10;
            this.txtStuID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtStuID.DecLength = 2;
            this.txtStuID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtStuID.InputType = HZH_Controls.TextInputType.NotControl;
            this.txtStuID.Location = new System.Drawing.Point(222, 59);
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
            this.txtStuID.ReadOnly = true;
            this.txtStuID.RegexPattern = "";
            this.txtStuID.Size = new System.Drawing.Size(173, 26);
            this.txtStuID.TabIndex = 9;
            this.txtStuID.TabStop = false;
            // 
            // txtCourseName
            // 
            this.txtCourseName.BackAlpha = 10;
            this.txtCourseName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCourseName.DecLength = 2;
            this.txtCourseName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCourseName.InputType = HZH_Controls.TextInputType.NotControl;
            this.txtCourseName.Location = new System.Drawing.Point(222, 159);
            this.txtCourseName.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtCourseName.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txtCourseName.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.OldText = null;
            this.txtCourseName.PromptColor = System.Drawing.Color.Gray;
            this.txtCourseName.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCourseName.PromptText = "";
            this.txtCourseName.ReadOnly = true;
            this.txtCourseName.RegexPattern = "";
            this.txtCourseName.Size = new System.Drawing.Size(173, 26);
            this.txtCourseName.TabIndex = 8;
            this.txtCourseName.TabStop = false;
            // 
            // FrmUpdateFaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(528, 454);
            this.Controls.Add(this.ucBtnExt1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFaction);
            this.Controls.Add(this.txtTeachName);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.txtStuName);
            this.Controls.Add(this.txtStuID);
            this.MaximumSize = new System.Drawing.Size(544, 493);
            this.MinimumSize = new System.Drawing.Size(544, 493);
            this.Name = "FrmUpdateFaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUpdateFaction";
            this.Load += new System.EventHandler(this.FrmUpdateFaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private HZH_Controls.Controls.UCBtnExt ucBtnExt1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private HZH_Controls.Controls.TextBoxEx txtFaction;
        private HZH_Controls.Controls.TextBoxTransparent txtTeachName;
        private HZH_Controls.Controls.TextBoxTransparent txtStuName;
        private HZH_Controls.Controls.TextBoxTransparent txtStuID;
        private HZH_Controls.Controls.TextBoxTransparent txtCourseName;
    }
}