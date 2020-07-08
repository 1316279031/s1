namespace StudentInformationManagerSystem
{
    partial class FrmInsertedCourse
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCourseName = new HZH_Controls.Controls.TextBoxEx();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(319, 96);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 25);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(146, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "课程名";
            // 
            // txtCourseName
            // 
            this.txtCourseName.DecLength = 2;
            this.txtCourseName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCourseName.InputType = HZH_Controls.TextInputType.NotControl;
            this.txtCourseName.Location = new System.Drawing.Point(208, 51);
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
            this.txtCourseName.TabIndex = 5;
            // 
            // FrmInsertedCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(546, 173);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCourseName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(562, 212);
            this.MinimumSize = new System.Drawing.Size(562, 212);
            this.Name = "FrmInsertedCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInsertedCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private HZH_Controls.Controls.TextBoxEx txtCourseName;
    }
}