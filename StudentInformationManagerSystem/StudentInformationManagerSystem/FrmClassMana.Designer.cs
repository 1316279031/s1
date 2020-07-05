namespace StudentInformationManagerSystem
{
    partial class FrmClassMana
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
            HZH_Controls.Controls.NavigationMenuItem navigationMenuItem9 = new HZH_Controls.Controls.NavigationMenuItem();
            HZH_Controls.Controls.NavigationMenuItem navigationMenuItem10 = new HZH_Controls.Controls.NavigationMenuItem();
            HZH_Controls.Controls.NavigationMenuItem navigationMenuItem11 = new HZH_Controls.Controls.NavigationMenuItem();
            HZH_Controls.Controls.NavigationMenuItem navigationMenuItem12 = new HZH_Controls.Controls.NavigationMenuItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClassMana));
            this.navMenu = new HZH_Controls.Controls.UCNavigationMenu();
            this.trvEx1 = new HZH_Controls.Controls.TreeViewEx();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // navMenu
            // 
            this.navMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(73)))));
            this.navMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.navMenu.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.navMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            navigationMenuItem9.AnchorRight = false;
            navigationMenuItem9.DataSource = null;
            navigationMenuItem9.HasSplitLintAtTop = false;
            navigationMenuItem9.Icon = null;
            navigationMenuItem9.Items = null;
            navigationMenuItem9.ItemWidth = 100;
            navigationMenuItem9.ShowTip = false;
            navigationMenuItem9.Text = "菜单1";
            navigationMenuItem9.TipText = null;
            navigationMenuItem10.AnchorRight = false;
            navigationMenuItem10.DataSource = null;
            navigationMenuItem10.HasSplitLintAtTop = false;
            navigationMenuItem10.Icon = null;
            navigationMenuItem10.Items = null;
            navigationMenuItem10.ItemWidth = 100;
            navigationMenuItem10.ShowTip = false;
            navigationMenuItem10.Text = "菜单2";
            navigationMenuItem10.TipText = null;
            navigationMenuItem11.AnchorRight = true;
            navigationMenuItem11.DataSource = null;
            navigationMenuItem11.HasSplitLintAtTop = false;
            navigationMenuItem11.Icon = null;
            navigationMenuItem11.Items = null;
            navigationMenuItem11.ItemWidth = 100;
            navigationMenuItem11.ShowTip = false;
            navigationMenuItem11.Text = "菜单3";
            navigationMenuItem11.TipText = null;
            navigationMenuItem12.AnchorRight = true;
            navigationMenuItem12.DataSource = null;
            navigationMenuItem12.HasSplitLintAtTop = false;
            navigationMenuItem12.Icon = null;
            navigationMenuItem12.Items = null;
            navigationMenuItem12.ItemWidth = 100;
            navigationMenuItem12.ShowTip = false;
            navigationMenuItem12.Text = "菜单4";
            navigationMenuItem12.TipText = null;
            this.navMenu.Items = new HZH_Controls.Controls.NavigationMenuItem[] {
        navigationMenuItem9,
        navigationMenuItem10,
        navigationMenuItem11,
        navigationMenuItem12};
            this.navMenu.Location = new System.Drawing.Point(0, 0);
            this.navMenu.Name = "navMenu";
            this.navMenu.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.navMenu.Size = new System.Drawing.Size(800, 81);
            this.navMenu.TabIndex = 0;
            this.navMenu.TipColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            // 
            // trvEx1
            // 
            this.trvEx1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(73)))));
            this.trvEx1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trvEx1.Dock = System.Windows.Forms.DockStyle.Left;
            this.trvEx1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.trvEx1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.trvEx1.FullRowSelect = true;
            this.trvEx1.HideSelection = false;
            this.trvEx1.IsShowByCustomModel = true;
            this.trvEx1.IsShowTip = false;
            this.trvEx1.ItemHeight = 50;
            this.trvEx1.Location = new System.Drawing.Point(0, 81);
            this.trvEx1.LstTips = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("trvEx1.LstTips")));
            this.trvEx1.Name = "trvEx1";
            this.trvEx1.NodeBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.trvEx1.NodeDownPic = ((System.Drawing.Image)(resources.GetObject("trvEx1.NodeDownPic")));
            this.trvEx1.NodeForeColor = System.Drawing.Color.White;
            this.trvEx1.NodeHeight = 50;
            this.trvEx1.NodeIsShowSplitLine = false;
            this.trvEx1.NodeSelectedColor = System.Drawing.SystemColors.ActiveCaption;
            this.trvEx1.NodeSelectedForeColor = System.Drawing.Color.White;
            this.trvEx1.NodeSplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.trvEx1.NodeUpPic = ((System.Drawing.Image)(resources.GetObject("trvEx1.NodeUpPic")));
            this.trvEx1.ParentNodeCanSelect = true;
            this.trvEx1.ShowLines = false;
            this.trvEx1.ShowPlusMinus = false;
            this.trvEx1.ShowRootLines = false;
            this.trvEx1.Size = new System.Drawing.Size(176, 369);
            this.trvEx1.TabIndex = 2;
            this.trvEx1.TipFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.trvEx1.TipImage = ((System.Drawing.Image)(resources.GetObject("trvEx1.TipImage")));
            this.trvEx1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvEx1_AfterSelect);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(176, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(624, 369);
            this.dataGridView1.TabIndex = 3;
            // 
            // FrmClassMana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.trvEx1);
            this.Controls.Add(this.navMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmClassMana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmClassMana";
            this.Load += new System.EventHandler(this.FrmClassMana_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HZH_Controls.Controls.UCNavigationMenu navMenu;
        private HZH_Controls.Controls.TreeViewEx trvEx1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}