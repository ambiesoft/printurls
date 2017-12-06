namespace printurls
{
    partial class FormIterate
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIterate));
            this.spWebList = new System.Windows.Forms.SplitContainer();
            this.wbBase = new System.Windows.Forms.WebBrowser();
            this.listUrls = new DragNDrop.DragAndDropListView();
            this.hdUrl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctxListItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsExtract = new System.Windows.Forms.ToolStrip();
            this.tsbExtractAllLinks = new System.Windows.Forms.ToolStripButton();
            this.tsbExtractSelectedLinks = new System.Windows.Forms.ToolStripButton();
            this.tssbInsertURLs = new System.Windows.Forms.ToolStripSplitButton();
            this.deployRangedURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsCopyAll = new System.Windows.Forms.ToolStripButton();
            this.tsPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsClear = new System.Windows.Forms.ToolStripButton();
            this.spRoot = new System.Windows.Forms.SplitContainer();
            this.txtTmp = new System.Windows.Forms.TextBox();
            this.btnUnique = new System.Windows.Forms.Button();
            this.btnPrintAll = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.slMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.slItemCount = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.spWebList)).BeginInit();
            this.spWebList.Panel1.SuspendLayout();
            this.spWebList.Panel2.SuspendLayout();
            this.spWebList.SuspendLayout();
            this.ctxListItem.SuspendLayout();
            this.tsExtract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spRoot)).BeginInit();
            this.spRoot.Panel1.SuspendLayout();
            this.spRoot.Panel2.SuspendLayout();
            this.spRoot.SuspendLayout();
            this.statusMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // spWebList
            // 
            resources.ApplyResources(this.spWebList, "spWebList");
            this.spWebList.Name = "spWebList";
            // 
            // spWebList.Panel1
            // 
            this.spWebList.Panel1.Controls.Add(this.wbBase);
            // 
            // spWebList.Panel2
            // 
            this.spWebList.Panel2.Controls.Add(this.listUrls);
            this.spWebList.Panel2.Controls.Add(this.tsExtract);
            // 
            // wbBase
            // 
            resources.ApplyResources(this.wbBase, "wbBase");
            this.wbBase.Name = "wbBase";
            // 
            // listUrls
            // 
            this.listUrls.AllowDrop = true;
            this.listUrls.AllowReorder = true;
            this.listUrls.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hdUrl});
            this.listUrls.ContextMenuStrip = this.ctxListItem;
            resources.ApplyResources(this.listUrls, "listUrls");
            this.listUrls.LineColor = System.Drawing.Color.Red;
            this.listUrls.Name = "listUrls";
            this.listUrls.UseCompatibleStateImageBehavior = false;
            this.listUrls.View = System.Windows.Forms.View.Details;
            // 
            // hdUrl
            // 
            resources.ApplyResources(this.hdUrl, "hdUrl");
            // 
            // ctxListItem
            // 
            this.ctxListItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem,
            this.openToolStripMenuItem});
            this.ctxListItem.Name = "ctxListItem";
            resources.ApplyResources(this.ctxListItem, "ctxListItem");
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            resources.ApplyResources(this.removeToolStripMenuItem, "removeToolStripMenuItem");
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // tsExtract
            // 
            this.tsExtract.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbExtractAllLinks,
            this.tsbExtractSelectedLinks,
            this.tssbInsertURLs,
            this.toolStripSeparator1,
            this.tsCopyAll,
            this.tsPaste,
            this.toolStripSeparator2,
            this.tsClear});
            resources.ApplyResources(this.tsExtract, "tsExtract");
            this.tsExtract.Name = "tsExtract";
            // 
            // tsbExtractAllLinks
            // 
            resources.ApplyResources(this.tsbExtractAllLinks, "tsbExtractAllLinks");
            this.tsbExtractAllLinks.Name = "tsbExtractAllLinks";
            this.tsbExtractAllLinks.Click += new System.EventHandler(this.tsbExtractAllLinks_Click);
            // 
            // tsbExtractSelectedLinks
            // 
            resources.ApplyResources(this.tsbExtractSelectedLinks, "tsbExtractSelectedLinks");
            this.tsbExtractSelectedLinks.Name = "tsbExtractSelectedLinks";
            this.tsbExtractSelectedLinks.Click += new System.EventHandler(this.tsbExtractSelectedLinks_Click);
            // 
            // tssbInsertURLs
            // 
            this.tssbInsertURLs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deployRangedURLToolStripMenuItem});
            resources.ApplyResources(this.tssbInsertURLs, "tssbInsertURLs");
            this.tssbInsertURLs.Name = "tssbInsertURLs";
            this.tssbInsertURLs.ButtonClick += new System.EventHandler(this.tssbInsertURLs_ButtonClick);
            // 
            // deployRangedURLToolStripMenuItem
            // 
            this.deployRangedURLToolStripMenuItem.Name = "deployRangedURLToolStripMenuItem";
            resources.ApplyResources(this.deployRangedURLToolStripMenuItem, "deployRangedURLToolStripMenuItem");
            this.deployRangedURLToolStripMenuItem.Click += new System.EventHandler(this.deployRangedURLToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // tsCopyAll
            // 
            resources.ApplyResources(this.tsCopyAll, "tsCopyAll");
            this.tsCopyAll.Name = "tsCopyAll";
            this.tsCopyAll.Click += new System.EventHandler(this.tsCopyAll_Click);
            // 
            // tsPaste
            // 
            resources.ApplyResources(this.tsPaste, "tsPaste");
            this.tsPaste.Name = "tsPaste";
            this.tsPaste.Click += new System.EventHandler(this.tsPaste_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // tsClear
            // 
            resources.ApplyResources(this.tsClear, "tsClear");
            this.tsClear.Name = "tsClear";
            this.tsClear.Click += new System.EventHandler(this.tsClear_Click);
            // 
            // spRoot
            // 
            resources.ApplyResources(this.spRoot, "spRoot");
            this.spRoot.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.spRoot.Name = "spRoot";
            // 
            // spRoot.Panel1
            // 
            this.spRoot.Panel1.Controls.Add(this.spWebList);
            // 
            // spRoot.Panel2
            // 
            this.spRoot.Panel2.Controls.Add(this.txtTmp);
            this.spRoot.Panel2.Controls.Add(this.btnUnique);
            this.spRoot.Panel2.Controls.Add(this.btnPrintAll);
            this.spRoot.Panel2.Controls.Add(this.btnRemoveItem);
            this.spRoot.Panel2.Controls.Add(this.btnCancel);
            // 
            // txtTmp
            // 
            resources.ApplyResources(this.txtTmp, "txtTmp");
            this.txtTmp.Name = "txtTmp";
            // 
            // btnUnique
            // 
            resources.ApplyResources(this.btnUnique, "btnUnique");
            this.btnUnique.Name = "btnUnique";
            this.btnUnique.UseVisualStyleBackColor = true;
            this.btnUnique.Click += new System.EventHandler(this.btnUnique_Click);
            // 
            // btnPrintAll
            // 
            resources.ApplyResources(this.btnPrintAll, "btnPrintAll");
            this.btnPrintAll.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPrintAll.Name = "btnPrintAll";
            this.btnPrintAll.UseVisualStyleBackColor = true;
            this.btnPrintAll.Click += new System.EventHandler(this.btnPrintAll_Click);
            // 
            // btnRemoveItem
            // 
            resources.ApplyResources(this.btnRemoveItem, "btnRemoveItem");
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // statusMain
            // 
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slMain,
            this.slItemCount});
            resources.ApplyResources(this.statusMain, "statusMain");
            this.statusMain.Name = "statusMain";
            // 
            // slMain
            // 
            this.slMain.Name = "slMain";
            resources.ApplyResources(this.slMain, "slMain");
            this.slMain.Spring = true;
            // 
            // slItemCount
            // 
            this.slItemCount.Name = "slItemCount";
            resources.ApplyResources(this.slItemCount, "slItemCount");
            // 
            // FormIterate
            // 
            this.AcceptButton = this.btnPrintAll;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.spRoot);
            this.Name = "FormIterate";
            this.Load += new System.EventHandler(this.FormIterate_Load);
            this.spWebList.Panel1.ResumeLayout(false);
            this.spWebList.Panel2.ResumeLayout(false);
            this.spWebList.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spWebList)).EndInit();
            this.spWebList.ResumeLayout(false);
            this.ctxListItem.ResumeLayout(false);
            this.tsExtract.ResumeLayout(false);
            this.tsExtract.PerformLayout();
            this.spRoot.Panel1.ResumeLayout(false);
            this.spRoot.Panel2.ResumeLayout(false);
            this.spRoot.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spRoot)).EndInit();
            this.spRoot.ResumeLayout(false);
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbBase;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnUnique;
        private System.Windows.Forms.Button btnPrintAll;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.ToolStripStatusLabel slMain;
        private System.Windows.Forms.SplitContainer spWebList;
        private System.Windows.Forms.SplitContainer spRoot;
        private DragNDrop.DragAndDropListView listUrls;
        private System.Windows.Forms.ColumnHeader hdUrl;
        private System.Windows.Forms.ToolStrip tsExtract;
        private System.Windows.Forms.ToolStripButton tsbExtractAllLinks;
        private System.Windows.Forms.ToolStripButton tsbExtractSelectedLinks;
        private System.Windows.Forms.ToolStripSplitButton tssbInsertURLs;
        private System.Windows.Forms.ToolStripMenuItem deployRangedURLToolStripMenuItem;
        private System.Windows.Forms.TextBox txtTmp;
        private System.Windows.Forms.ToolStripStatusLabel slItemCount;
        private System.Windows.Forms.ContextMenuStrip ctxListItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsCopyAll;
        private System.Windows.Forms.ToolStripButton tsPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsClear;
    }
}

