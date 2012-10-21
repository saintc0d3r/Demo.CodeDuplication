namespace Demo.Duplication.WinForm
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("References");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Transactions");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Reports");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Utility");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("<Computer Name>", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainStatus = new System.Windows.Forms.StatusStrip();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutDuplicationCodeDemoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mainTreeview = new System.Windows.Forms.TreeView();
            this.nodesImageList = new System.Windows.Forms.ImageList(this.components);
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainStatus
            // 
            this.mainStatus.Location = new System.Drawing.Point(0, 699);
            this.mainStatus.Name = "mainStatus";
            this.mainStatus.Size = new System.Drawing.Size(1006, 22);
            this.mainStatus.TabIndex = 0;
            this.mainStatus.Text = "statusStrip1";
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1006, 28);
            this.mainMenu.TabIndex = 2;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutDuplicationCodeDemoToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutDuplicationCodeDemoToolStripMenuItem
            // 
            this.aboutDuplicationCodeDemoToolStripMenuItem.Name = "aboutDuplicationCodeDemoToolStripMenuItem";
            this.aboutDuplicationCodeDemoToolStripMenuItem.Size = new System.Drawing.Size(284, 24);
            this.aboutDuplicationCodeDemoToolStripMenuItem.Text = "About Duplication Code Demo";
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Location = new System.Drawing.Point(0, 28);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(1006, 25);
            this.mainToolStrip.TabIndex = 3;
            this.mainToolStrip.Text = "toolStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.splitContainer1.Location = new System.Drawing.Point(0, 53);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.mainTreeview);
            this.splitContainer1.Panel2Collapsed = true;
            this.splitContainer1.Size = new System.Drawing.Size(250, 646);
            this.splitContainer1.SplitterDistance = 237;
            this.splitContainer1.TabIndex = 4;
            // 
            // mainTreeview
            // 
            this.mainTreeview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTreeview.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTreeview.ImageIndex = 0;
            this.mainTreeview.ImageList = this.nodesImageList;
            this.mainTreeview.Location = new System.Drawing.Point(0, 0);
            this.mainTreeview.Name = "mainTreeview";
            treeNode1.ImageKey = "Applications Cascade.ico";
            treeNode1.Name = "ReferencesNode";
            treeNode1.SelectedImageKey = "Applications Cascade.ico";
            treeNode1.Text = "References";
            treeNode2.ImageKey = "Document Write.ico";
            treeNode2.Name = "TransactionsNode";
            treeNode2.SelectedImageKey = "Document Write.ico";
            treeNode2.Text = "Transactions";
            treeNode3.ImageKey = "Copy.ico";
            treeNode3.Name = "ReportsNode";
            treeNode3.SelectedImageKey = "Copy.ico";
            treeNode3.Text = "Reports";
            treeNode4.ImageKey = "Configuration.ico";
            treeNode4.Name = "UtilityNode";
            treeNode4.SelectedImageKey = "Configuration.ico";
            treeNode4.Text = "Utility";
            treeNode5.Name = "rootNode";
            treeNode5.Text = "<Computer Name>";
            this.mainTreeview.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.mainTreeview.SelectedImageIndex = 0;
            this.mainTreeview.Size = new System.Drawing.Size(246, 642);
            this.mainTreeview.TabIndex = 0;
            this.mainTreeview.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.mainTreeview_NodeMouseDoubleClick);
            // 
            // nodesImageList
            // 
            this.nodesImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("nodesImageList.ImageStream")));
            this.nodesImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.nodesImageList.Images.SetKeyName(0, "Monitor.ico");
            this.nodesImageList.Images.SetKeyName(1, "Applications Cascade.ico");
            this.nodesImageList.Images.SetKeyName(2, "Document Write.ico");
            this.nodesImageList.Images.SetKeyName(3, "Copy.ico");
            this.nodesImageList.Images.SetKeyName(4, "Configuration.ico");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.mainStatus);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:: Duplication Code Demo ::.";
            this.Load += new System.EventHandler(this.MainFormOnLoad);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip mainStatus;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutDuplicationCodeDemoToolStripMenuItem;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView mainTreeview;
        private System.Windows.Forms.ImageList nodesImageList;
    }
}

