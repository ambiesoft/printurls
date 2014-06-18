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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIterate));
            this.wbBase = new System.Windows.Forms.WebBrowser();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnUnique = new System.Windows.Forms.Button();
            this.btnPrintAll = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.slMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.spWebList = new System.Windows.Forms.SplitContainer();
            this.spRoot = new System.Windows.Forms.SplitContainer();
            this.listUrls = new DragNDrop.DragAndDropListView();
            this.hdUrl = new System.Windows.Forms.ColumnHeader();
            this.statusMain.SuspendLayout();
            this.spWebList.Panel1.SuspendLayout();
            this.spWebList.Panel2.SuspendLayout();
            this.spWebList.SuspendLayout();
            this.spRoot.Panel1.SuspendLayout();
            this.spRoot.Panel2.SuspendLayout();
            this.spRoot.SuspendLayout();
            this.SuspendLayout();
            // 
            // wbBase
            // 
            this.wbBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbBase.Location = new System.Drawing.Point(0, 0);
            this.wbBase.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBase.Name = "wbBase";
            this.wbBase.Size = new System.Drawing.Size(771, 231);
            this.wbBase.TabIndex = 1;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRemoveItem.Location = new System.Drawing.Point(693, 3);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveItem.TabIndex = 3;
            this.btnRemoveItem.Text = "&Remove";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnUnique
            // 
            this.btnUnique.Location = new System.Drawing.Point(3, 3);
            this.btnUnique.Name = "btnUnique";
            this.btnUnique.Size = new System.Drawing.Size(170, 23);
            this.btnUnique.TabIndex = 4;
            this.btnUnique.Text = "&Unique";
            this.btnUnique.UseVisualStyleBackColor = true;
            this.btnUnique.Click += new System.EventHandler(this.btnUnique_Click);
            // 
            // btnPrintAll
            // 
            this.btnPrintAll.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPrintAll.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPrintAll.Location = new System.Drawing.Point(388, 32);
            this.btnPrintAll.Name = "btnPrintAll";
            this.btnPrintAll.Size = new System.Drawing.Size(255, 23);
            this.btnPrintAll.TabIndex = 5;
            this.btnPrintAll.Text = "&Print URLs";
            this.btnPrintAll.UseVisualStyleBackColor = true;
            this.btnPrintAll.Click += new System.EventHandler(this.btnPrintAll_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(649, 32);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // statusMain
            // 
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slMain});
            this.statusMain.Location = new System.Drawing.Point(0, 527);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(771, 22);
            this.statusMain.TabIndex = 7;
            // 
            // slMain
            // 
            this.slMain.Name = "slMain";
            this.slMain.Size = new System.Drawing.Size(37, 17);
            this.slMain.Text = "Ready";
            // 
            // spWebList
            // 
            this.spWebList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spWebList.Location = new System.Drawing.Point(0, 0);
            this.spWebList.Name = "spWebList";
            this.spWebList.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spWebList.Panel1
            // 
            this.spWebList.Panel1.Controls.Add(this.wbBase);
            // 
            // spWebList.Panel2
            // 
            this.spWebList.Panel2.Controls.Add(this.listUrls);
            this.spWebList.Size = new System.Drawing.Size(771, 462);
            this.spWebList.SplitterDistance = 231;
            this.spWebList.TabIndex = 8;
            // 
            // spRoot
            // 
            this.spRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spRoot.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.spRoot.Location = new System.Drawing.Point(0, 0);
            this.spRoot.Name = "spRoot";
            this.spRoot.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spRoot.Panel1
            // 
            this.spRoot.Panel1.Controls.Add(this.spWebList);
            // 
            // spRoot.Panel2
            // 
            this.spRoot.Panel2.Controls.Add(this.btnUnique);
            this.spRoot.Panel2.Controls.Add(this.btnPrintAll);
            this.spRoot.Panel2.Controls.Add(this.btnRemoveItem);
            this.spRoot.Panel2.Controls.Add(this.btnCancel);
            this.spRoot.Size = new System.Drawing.Size(771, 549);
            this.spRoot.SplitterDistance = 462;
            this.spRoot.TabIndex = 9;
            // 
            // listUrls
            // 
            this.listUrls.AllowDrop = true;
            this.listUrls.AllowReorder = true;
            this.listUrls.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hdUrl});
            this.listUrls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listUrls.LineColor = System.Drawing.Color.Red;
            this.listUrls.Location = new System.Drawing.Point(0, 0);
            this.listUrls.Name = "listUrls";
            this.listUrls.Size = new System.Drawing.Size(771, 227);
            this.listUrls.TabIndex = 3;
            this.listUrls.UseCompatibleStateImageBehavior = false;
            this.listUrls.View = System.Windows.Forms.View.Details;
            // 
            // hdUrl
            // 
            this.hdUrl.Text = "URL";
            this.hdUrl.Width = 256;
            // 
            // FormIterate
            // 
            this.AcceptButton = this.btnPrintAll;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(771, 549);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.spRoot);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormIterate";
            this.Text = "Extract URLs : PrintURLs";
            this.Load += new System.EventHandler(this.FormIterate_Load);
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.spWebList.Panel1.ResumeLayout(false);
            this.spWebList.Panel2.ResumeLayout(false);
            this.spWebList.ResumeLayout(false);
            this.spRoot.Panel1.ResumeLayout(false);
            this.spRoot.Panel2.ResumeLayout(false);
            this.spRoot.ResumeLayout(false);
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
    }
}

