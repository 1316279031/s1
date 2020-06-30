namespace StudentInformationManagerSystem
{
    partial class FrmMain
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
            HZH_Controls.Controls.NavigationMenuItem navigationMenuItem1 = new HZH_Controls.Controls.NavigationMenuItem();
            HZH_Controls.Controls.NavigationMenuItem navigationMenuItem2 = new HZH_Controls.Controls.NavigationMenuItem();
            HZH_Controls.Controls.NavigationMenuItem navigationMenuItem3 = new HZH_Controls.Controls.NavigationMenuItem();
            HZH_Controls.Controls.NavigationMenuItem navigationMenuItem4 = new HZH_Controls.Controls.NavigationMenuItem();
            this.naMenu = new HZH_Controls.Controls.UCNavigationMenu();
            this.ucMenu1 = new HZH_Controls.Controls.UCMenu();
            this.SuspendLayout();
            // 
            // naMenu
            // 
            this.naMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(73)))));
            this.naMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.naMenu.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.naMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            navigationMenuItem1.AnchorRight = false;
            navigationMenuItem1.DataSource = null;
            navigationMenuItem1.HasSplitLintAtTop = false;
            navigationMenuItem1.Icon = null;
            navigationMenuItem1.Items = null;
            navigationMenuItem1.ItemWidth = 100;
            navigationMenuItem1.ShowTip = false;
            navigationMenuItem1.Text = "菜单1";
            navigationMenuItem1.TipText = null;
            navigationMenuItem2.AnchorRight = false;
            navigationMenuItem2.DataSource = null;
            navigationMenuItem2.HasSplitLintAtTop = false;
            navigationMenuItem2.Icon = null;
            navigationMenuItem2.Items = null;
            navigationMenuItem2.ItemWidth = 100;
            navigationMenuItem2.ShowTip = false;
            navigationMenuItem2.Text = "菜单2";
            navigationMenuItem2.TipText = null;
            navigationMenuItem3.AnchorRight = true;
            navigationMenuItem3.DataSource = null;
            navigationMenuItem3.HasSplitLintAtTop = false;
            navigationMenuItem3.Icon = null;
            navigationMenuItem3.Items = null;
            navigationMenuItem3.ItemWidth = 100;
            navigationMenuItem3.ShowTip = false;
            navigationMenuItem3.Text = "菜单3";
            navigationMenuItem3.TipText = null;
            navigationMenuItem4.AnchorRight = true;
            navigationMenuItem4.DataSource = null;
            navigationMenuItem4.HasSplitLintAtTop = false;
            navigationMenuItem4.Icon = null;
            navigationMenuItem4.Items = null;
            navigationMenuItem4.ItemWidth = 100;
            navigationMenuItem4.ShowTip = false;
            navigationMenuItem4.Text = "菜单4";
            navigationMenuItem4.TipText = null;
            this.naMenu.Items = new HZH_Controls.Controls.NavigationMenuItem[] {
        navigationMenuItem1,
        navigationMenuItem2,
        navigationMenuItem3,
        navigationMenuItem4};
            this.naMenu.Location = new System.Drawing.Point(0, 0);
            this.naMenu.Name = "naMenu";
            this.naMenu.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.naMenu.Size = new System.Drawing.Size(800, 60);
            this.naMenu.TabIndex = 2;
            this.naMenu.TabStop = false;
            this.naMenu.TipColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            // 
            // ucMenu1
            // 
            this.ucMenu1.AutoScroll = true;
            this.ucMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.ucMenu1.ChildrenItemStyles = null;
            this.ucMenu1.ChildrenItemType = typeof(HZH_Controls.Controls.UCMenuChildrenItem);
            this.ucMenu1.DataSource = null;
            this.ucMenu1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucMenu1.IsShowFirstItem = true;
            this.ucMenu1.Location = new System.Drawing.Point(0, 60);
            this.ucMenu1.MenuStyle = HZH_Controls.Controls.MenuStyle.Fill;
            this.ucMenu1.Name = "ucMenu1";
            this.ucMenu1.ParentItemStyles = null;
            this.ucMenu1.ParentItemType = typeof(HZH_Controls.Controls.UCMenuParentItem);
            this.ucMenu1.Size = new System.Drawing.Size(111, 390);
            this.ucMenu1.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ucMenu1);
            this.Controls.Add(this.naMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主界面";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private HZH_Controls.Controls.UCNavigationMenu naMenu;
        private HZH_Controls.Controls.UCMenu ucMenu1;
    }
}