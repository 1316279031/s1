namespace StudentInformationManagerSystem
{
    partial class FrmSelectStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelectStudent));
            HZH_Controls.Controls.NavigationMenuItem navigationMenuItem1 = new HZH_Controls.Controls.NavigationMenuItem();
            HZH_Controls.Controls.NavigationMenuItem navigationMenuItem2 = new HZH_Controls.Controls.NavigationMenuItem();
            HZH_Controls.Controls.NavigationMenuItem navigationMenuItem3 = new HZH_Controls.Controls.NavigationMenuItem();
            HZH_Controls.Controls.NavigationMenuItem navigationMenuItem4 = new HZH_Controls.Controls.NavigationMenuItem();
            this.graphicalOverlayComponent1 = new HZH_Controls.Controls.GraphicalOverlayComponent(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.trvEx1 = new HZH_Controls.Controls.TreeViewEx();
            this.navMenu = new HZH_Controls.Controls.UCNavigationMenu();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // graphicalOverlayComponent1
            // 
            this.graphicalOverlayComponent1.Owner = null;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(176, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(535, 317);
            this.dataGridView1.TabIndex = 5;
            // 
            // trvEx1
            // 
            this.trvEx1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.trvEx1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trvEx1.Dock = System.Windows.Forms.DockStyle.Left;
            this.trvEx1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.trvEx1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.trvEx1.FullRowSelect = true;
            this.trvEx1.HideSelection = false;
            this.trvEx1.IsShowByCustomModel = true;
            this.trvEx1.IsShowTip = false;
            this.trvEx1.ItemHeight = 50;
            this.trvEx1.Location = new System.Drawing.Point(0, 60);
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
            this.trvEx1.Size = new System.Drawing.Size(176, 317);
            this.trvEx1.TabIndex = 4;
            this.trvEx1.TipFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.trvEx1.TipImage = ((System.Drawing.Image)(resources.GetObject("trvEx1.TipImage")));
            this.trvEx1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvEx1_AfterSelect);
            // 
            // navMenu
            // 
            this.navMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(73)))));
            this.navMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.navMenu.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.navMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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
            this.navMenu.Items = new HZH_Controls.Controls.NavigationMenuItem[] {
        navigationMenuItem1,
        navigationMenuItem2,
        navigationMenuItem3,
        navigationMenuItem4};
            this.navMenu.Location = new System.Drawing.Point(0, 0);
            this.navMenu.Name = "navMenu";
            this.navMenu.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.navMenu.Size = new System.Drawing.Size(711, 60);
            this.navMenu.TabIndex = 3;
            this.navMenu.TipColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            // 
            // FrmSelectStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(711, 377);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.trvEx1);
            this.Controls.Add(this.navMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(727, 416);
            this.MinimumSize = new System.Drawing.Size(727, 416);
            this.Name = "FrmSelectStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSelectStudent";
            this.Load += new System.EventHandler(this.FrmSelectStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private HZH_Controls.Controls.GraphicalOverlayComponent graphicalOverlayComponent1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HZH_Controls.Controls.TreeViewEx trvEx1;
        private HZH_Controls.Controls.UCNavigationMenu navMenu;
    }
}