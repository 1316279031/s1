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
            HZH_Controls.Controls.NavigationMenuItem navigationMenuItem17 = new HZH_Controls.Controls.NavigationMenuItem();
            HZH_Controls.Controls.NavigationMenuItem navigationMenuItem18 = new HZH_Controls.Controls.NavigationMenuItem();
            HZH_Controls.Controls.NavigationMenuItem navigationMenuItem19 = new HZH_Controls.Controls.NavigationMenuItem();
            HZH_Controls.Controls.NavigationMenuItem navigationMenuItem20 = new HZH_Controls.Controls.NavigationMenuItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.naMenu = new HZH_Controls.Controls.UCNavigationMenu();
            this.tvMenu = new HZH_Controls.Controls.TreeViewEx();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // naMenu
            // 
            this.naMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(73)))));
            this.naMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.naMenu.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.naMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            navigationMenuItem17.AnchorRight = false;
            navigationMenuItem17.DataSource = null;
            navigationMenuItem17.HasSplitLintAtTop = false;
            navigationMenuItem17.Icon = null;
            navigationMenuItem17.Items = null;
            navigationMenuItem17.ItemWidth = 100;
            navigationMenuItem17.ShowTip = false;
            navigationMenuItem17.Text = "菜单1";
            navigationMenuItem17.TipText = null;
            navigationMenuItem18.AnchorRight = false;
            navigationMenuItem18.DataSource = null;
            navigationMenuItem18.HasSplitLintAtTop = false;
            navigationMenuItem18.Icon = null;
            navigationMenuItem18.Items = null;
            navigationMenuItem18.ItemWidth = 100;
            navigationMenuItem18.ShowTip = false;
            navigationMenuItem18.Text = "菜单2";
            navigationMenuItem18.TipText = null;
            navigationMenuItem19.AnchorRight = true;
            navigationMenuItem19.DataSource = null;
            navigationMenuItem19.HasSplitLintAtTop = false;
            navigationMenuItem19.Icon = null;
            navigationMenuItem19.Items = null;
            navigationMenuItem19.ItemWidth = 100;
            navigationMenuItem19.ShowTip = false;
            navigationMenuItem19.Text = "菜单3";
            navigationMenuItem19.TipText = null;
            navigationMenuItem20.AnchorRight = true;
            navigationMenuItem20.DataSource = null;
            navigationMenuItem20.HasSplitLintAtTop = false;
            navigationMenuItem20.Icon = null;
            navigationMenuItem20.Items = null;
            navigationMenuItem20.ItemWidth = 100;
            navigationMenuItem20.ShowTip = false;
            navigationMenuItem20.Text = "菜单4";
            navigationMenuItem20.TipText = null;
            this.naMenu.Items = new HZH_Controls.Controls.NavigationMenuItem[] {
        navigationMenuItem17,
        navigationMenuItem18,
        navigationMenuItem19,
        navigationMenuItem20};
            this.naMenu.Location = new System.Drawing.Point(0, 0);
            this.naMenu.Name = "naMenu";
            this.naMenu.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.naMenu.Size = new System.Drawing.Size(800, 60);
            this.naMenu.TabIndex = 2;
            this.naMenu.TabStop = false;
            this.naMenu.TipColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            // 
            // tvMenu
            // 
            this.tvMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.tvMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvMenu.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.tvMenu.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tvMenu.FullRowSelect = true;
            this.tvMenu.HideSelection = false;
            this.tvMenu.IsShowByCustomModel = true;
            this.tvMenu.IsShowTip = false;
            this.tvMenu.ItemHeight = 50;
            this.tvMenu.Location = new System.Drawing.Point(0, 60);
            this.tvMenu.LstTips = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("tvMenu.LstTips")));
            this.tvMenu.Name = "tvMenu";
            this.tvMenu.NodeBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.tvMenu.NodeDownPic = ((System.Drawing.Image)(resources.GetObject("tvMenu.NodeDownPic")));
            this.tvMenu.NodeForeColor = System.Drawing.Color.White;
            this.tvMenu.NodeHeight = 50;
            this.tvMenu.NodeIsShowSplitLine = true;
            this.tvMenu.NodeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(73)))));
            this.tvMenu.NodeSelectedForeColor = System.Drawing.Color.White;
            this.tvMenu.NodeSplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(61)))), ((int)(((byte)(73)))));
            this.tvMenu.NodeUpPic = ((System.Drawing.Image)(resources.GetObject("tvMenu.NodeUpPic")));
            this.tvMenu.ParentNodeCanSelect = true;
            this.tvMenu.ShowLines = false;
            this.tvMenu.ShowPlusMinus = false;
            this.tvMenu.ShowRootLines = false;
            this.tvMenu.Size = new System.Drawing.Size(150, 390);
            this.tvMenu.TabIndex = 8;
            this.tvMenu.TipFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tvMenu.TipImage = ((System.Drawing.Image)(resources.GetObject("tvMenu.TipImage")));
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(150, 60);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(650, 390);
            this.webBrowser1.TabIndex = 9;
            this.webBrowser1.Url = new System.Uri("http://www.google.cn/", System.UriKind.Absolute);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.tvMenu);
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
        private HZH_Controls.Controls.TreeViewEx tvMenu;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}