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
            this.listUrls = new System.Windows.Forms.ListView();
            this.hdUrl = new System.Windows.Forms.ColumnHeader();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnUnique = new System.Windows.Forms.Button();
            this.btnPrintAll = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.slMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // wbBase
            // 
            this.wbBase.Location = new System.Drawing.Point(12, 12);
            this.wbBase.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBase.Name = "wbBase";
            this.wbBase.Size = new System.Drawing.Size(747, 233);
            this.wbBase.TabIndex = 1;
            // 
            // listUrls
            // 
            this.listUrls.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hdUrl});
            this.listUrls.Location = new System.Drawing.Point(12, 272);
            this.listUrls.Name = "listUrls";
            this.listUrls.Size = new System.Drawing.Size(747, 157);
            this.listUrls.TabIndex = 2;
            this.listUrls.UseCompatibleStateImageBehavior = false;
            this.listUrls.View = System.Windows.Forms.View.Details;
            // 
            // hdUrl
            // 
            this.hdUrl.Text = "URL";
            this.hdUrl.Width = 735;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(684, 435);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveItem.TabIndex = 3;
            this.btnRemoveItem.Text = "&Remove";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnUnique
            // 
            this.btnUnique.Location = new System.Drawing.Point(12, 435);
            this.btnUnique.Name = "btnUnique";
            this.btnUnique.Size = new System.Drawing.Size(170, 23);
            this.btnUnique.TabIndex = 4;
            this.btnUnique.Text = "&Unique";
            this.btnUnique.UseVisualStyleBackColor = true;
            this.btnUnique.Click += new System.EventHandler(this.btnUnique_Click);
            // 
            // btnPrintAll
            // 
            this.btnPrintAll.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPrintAll.Location = new System.Drawing.Point(379, 492);
            this.btnPrintAll.Name = "btnPrintAll";
            this.btnPrintAll.Size = new System.Drawing.Size(255, 23);
            this.btnPrintAll.TabIndex = 5;
            this.btnPrintAll.Text = "&Print URLs";
            this.btnPrintAll.UseVisualStyleBackColor = true;
            this.btnPrintAll.Click += new System.EventHandler(this.btnPrintAll_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(640, 492);
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
            this.slMain.Size = new System.Drawing.Size(38, 17);
            this.slMain.Text = "Ready";
            // 
            // FormIterate
            // 
            this.AcceptButton = this.btnPrintAll;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(771, 549);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPrintAll);
            this.Controls.Add(this.btnUnique);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.listUrls);
            this.Controls.Add(this.wbBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormIterate";
            this.Text = "Extract URLs : PrintURLs";
            this.Load += new System.EventHandler(this.FormIterate_Load);
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbBase;
        private System.Windows.Forms.ListView listUrls;
        private System.Windows.Forms.ColumnHeader hdUrl;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnUnique;
        private System.Windows.Forms.Button btnPrintAll;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.ToolStripStatusLabel slMain;
    }
}

