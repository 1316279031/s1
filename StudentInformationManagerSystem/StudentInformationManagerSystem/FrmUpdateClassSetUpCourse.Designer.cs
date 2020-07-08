namespace StudentInformationManagerSystem
{
    partial class FrmUpdateClassSetUpCourse
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClassName = new HZH_Controls.Controls.TextBoxTransparent();
            this.txtCourseName = new HZH_Controls.Controls.TextBoxTransparent();
            this.comTeachName = new System.Windows.Forms.ComboBox();
            this.ucBtnExt1 = new HZH_Controls.Controls.UCBtnExt();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(106, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "班级";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(106, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "课程";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(106, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "教师";
            // 
            // txtClassName
            // 
            this.txtClassName.BackAlpha = 10;
            this.txtClassName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtClassName.DecLength = 2;
            this.txtClassName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtClassName.InputType = HZH_Controls.TextInputType.NotControl;
            this.txtClassName.Location = new System.Drawing.Point(169, 45);
            this.txtClassName.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtClassName.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txtClassName.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.OldText = null;
            this.txtClassName.PromptColor = System.Drawing.Color.Gray;
            this.txtClassName.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtClassName.PromptText = "";
            this.txtClassName.RegexPattern = "";
            this.txtClassName.Size = new System.Drawing.Size(148, 26);
            this.txtClassName.TabIndex = 1;
            // 
            // txtCourseName
            // 
            this.txtCourseName.BackAlpha = 10;
            this.txtCourseName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCourseName.DecLength = 2;
            this.txtCourseName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCourseName.InputType = HZH_Controls.TextInputType.NotControl;
            this.txtCourseName.Location = new System.Drawing.Point(169, 93);
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
            this.txtCourseName.RegexPattern = "";
            this.txtCourseName.Size = new System.Drawing.Size(148, 26);
            this.txtCourseName.TabIndex = 1;
            // 
            // comTeachName
            // 
            this.comTeachName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comTeachName.FormattingEnabled = true;
            this.comTeachName.Location = new System.Drawing.Point(169, 141);
            this.comTeachName.Name = "comTeachName";
            this.comTeachName.Size = new System.Drawing.Size(148, 24);
            this.comTeachName.TabIndex = 2;
            // 
            // ucBtnExt1
            // 
            this.ucBtnExt1.BackColor = System.Drawing.Color.Transparent;
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
            this.ucBtnExt1.Location = new System.Drawing.Point(169, 188);
            this.ucBtnExt1.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt1.Name = "ucBtnExt1";
            this.ucBtnExt1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt1.RectWidth = 1;
            this.ucBtnExt1.Size = new System.Drawing.Size(148, 55);
            this.ucBtnExt1.TabIndex = 3;
            this.ucBtnExt1.TabStop = false;
            this.ucBtnExt1.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt1.TipsText = "";
            this.ucBtnExt1.BtnClick += new System.EventHandler(this.ucBtnExt1_BtnClick);
            // 
            // FrmUpdateClassSetUpCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(435, 286);
            this.Controls.Add(this.ucBtnExt1);
            this.Controls.Add(this.comTeachName);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(451, 325);
            this.MinimumSize = new System.Drawing.Size(451, 325);
            this.Name = "FrmUpdateClassSetUpCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "更新班级开课信息";
            this.Load += new System.EventHandler(this.FrmUpdateClassSetUpCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private HZH_Controls.Controls.TextBoxTransparent txtClassName;
        private HZH_Controls.Controls.TextBoxTransparent txtCourseName;
        private System.Windows.Forms.ComboBox comTeachName;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt1;
    }
}