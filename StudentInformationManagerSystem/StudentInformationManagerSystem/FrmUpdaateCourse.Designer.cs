namespace StudentInformationManagerSystem
{
    partial class FrmUpdaateCourse
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
            this.txtCourseName = new HZH_Controls.Controls.TextBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCourseID = new HZH_Controls.Controls.TextBoxTransparent();
            this.SuspendLayout();
            // 
            // txtCourseName
            // 
            this.txtCourseName.DecLength = 2;
            this.txtCourseName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCourseName.InputType = HZH_Controls.TextInputType.NotControl;
            this.txtCourseName.Location = new System.Drawing.Point(223, 52);
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
            this.txtCourseName.Size = new System.Drawing.Size(193, 26);
            this.txtCourseName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(14, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "课程号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(161, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "课程名";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(334, 97);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 25);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCourseID
            // 
            this.txtCourseID.BackAlpha = 10;
            this.txtCourseID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCourseID.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCourseID.DecLength = 2;
            this.txtCourseID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCourseID.InputType = HZH_Controls.TextInputType.NotControl;
            this.txtCourseID.Location = new System.Drawing.Point(72, 52);
            this.txtCourseID.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtCourseID.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txtCourseID.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.OldText = null;
            this.txtCourseID.PromptColor = System.Drawing.Color.Gray;
            this.txtCourseID.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCourseID.PromptText = "";
            this.txtCourseID.ReadOnly = true;
            this.txtCourseID.RegexPattern = "";
            this.txtCourseID.Size = new System.Drawing.Size(83, 26);
            this.txtCourseID.TabIndex = 0;
            this.txtCourseID.TabStop = false;
            this.txtCourseID.WordWrap = false;
            // 
            // FrmUpdaateCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(455, 154);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.txtCourseID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(471, 193);
            this.MinimumSize = new System.Drawing.Size(471, 193);
            this.Name = "FrmUpdaateCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUpdaateCourse";
            this.Load += new System.EventHandler(this.FrmUpdaateCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private HZH_Controls.Controls.TextBoxEx txtCourseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private HZH_Controls.Controls.TextBoxTransparent txtCourseID;
    }
}