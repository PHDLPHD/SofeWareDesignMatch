namespace SDM.WinClient
{
    partial class Frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.UserLabel = new DevExpress.XtraBars.BarStaticItem();
            this.UserID = new DevExpress.XtraBars.BarStaticItem();
            this.IpLabel = new DevExpress.XtraBars.BarStaticItem();
            this.IpText = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.MenuPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.MenuTree = new DevExpress.XtraTreeList.TreeList();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.Btn_Close = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_About = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.MenuPanel.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockManager = this.dockManager1;
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.UserLabel,
            this.UserID,
            this.IpLabel,
            this.IpText,
            this.Btn_Close,
            this.Btn_About});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.Btn_Close, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.Btn_About, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.UserLabel),
            new DevExpress.XtraBars.LinkPersistInfo(this.UserID),
            new DevExpress.XtraBars.LinkPersistInfo(this.IpLabel),
            new DevExpress.XtraBars.LinkPersistInfo(this.IpText)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // UserLabel
            // 
            this.UserLabel.Caption = "当前用户:";
            this.UserLabel.Id = 1;
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // UserID
            // 
            this.UserID.Caption = "barStaticItem2";
            this.UserID.Id = 2;
            this.UserID.Name = "UserID";
            this.UserID.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // IpLabel
            // 
            this.IpLabel.Caption = "Your IP:";
            this.IpLabel.Id = 3;
            this.IpLabel.Name = "IpLabel";
            this.IpLabel.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // IpText
            // 
            this.IpText.Caption = "barStaticItem4";
            this.IpText.Id = 4;
            this.IpText.Name = "IpText";
            this.IpText.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1269, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 550);
            this.barDockControlBottom.Size = new System.Drawing.Size(1269, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 526);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1269, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 526);
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.MenuManager = this.barManager1;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.MenuPanel});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.dockPanel1_Container);
            this.MenuPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.MenuPanel.ID = new System.Guid("08d679fa-9f17-4a47-b3fa-a61640195603");
            this.MenuPanel.Location = new System.Drawing.Point(0, 24);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.OriginalSize = new System.Drawing.Size(200, 200);
            this.MenuPanel.Size = new System.Drawing.Size(200, 526);
            this.MenuPanel.Text = "菜单导航";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.MenuTree);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(192, 499);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // MenuTree
            // 
            this.MenuTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuTree.Location = new System.Drawing.Point(0, 0);
            this.MenuTree.Name = "MenuTree";
            this.MenuTree.OptionsView.ShowColumns = false;
            this.MenuTree.Size = new System.Drawing.Size(192, 499);
            this.MenuTree.TabIndex = 5;
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Btn_Close
            // 
            this.Btn_Close.Caption = "退出系统";
            this.Btn_Close.Glyph = ((System.Drawing.Image)(resources.GetObject("Btn_Close.Glyph")));
            this.Btn_Close.Id = 5;
            this.Btn_Close.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("Btn_Close.LargeGlyph")));
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Close_ItemClick);
            // 
            // Btn_About
            // 
            this.Btn_About.Caption = "关于";
            this.Btn_About.Glyph = ((System.Drawing.Image)(resources.GetObject("Btn_About.Glyph")));
            this.Btn_About.Id = 6;
            this.Btn_About.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("Btn_About.LargeGlyph")));
            this.Btn_About.Name = "Btn_About";
            this.Btn_About.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_About_ItemClick);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 577);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IsMdiContainer = true;
            this.Name = "Frm_Main";
            this.Text = "Blank个人财务系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MenuTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel MenuPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraTreeList.TreeList MenuTree;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarStaticItem UserLabel;
        private DevExpress.XtraBars.BarStaticItem UserID;
        private DevExpress.XtraBars.BarStaticItem IpLabel;
        private DevExpress.XtraBars.BarStaticItem IpText;
        private DevExpress.XtraBars.BarButtonItem Btn_Close;
        private DevExpress.XtraBars.BarButtonItem Btn_About;
    }
}