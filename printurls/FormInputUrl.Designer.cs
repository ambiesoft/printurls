namespace printurls
{
    partial class FormInputUrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInputUrl));
            this.txtPageUrl = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioOpenUrl = new System.Windows.Forms.RadioButton();
            this.radioEnterURLs = new System.Windows.Forms.RadioButton();
            this.txtEnterURLs = new System.Windows.Forms.TextBox();
            this.btnExpand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPageUrl
            // 
            resources.ApplyResources(this.txtPageUrl, "txtPageUrl");
            this.txtPageUrl.Name = "txtPageUrl";
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnStart.Name = "btnStart";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // radioOpenUrl
            // 
            resources.ApplyResources(this.radioOpenUrl, "radioOpenUrl");
            this.radioOpenUrl.Name = "radioOpenUrl";
            this.radioOpenUrl.UseVisualStyleBackColor = true;
            this.radioOpenUrl.CheckedChanged += new System.EventHandler(this.radioOpenUrl_CheckedChanged);
            // 
            // radioEnterURLs
            // 
            resources.ApplyResources(this.radioEnterURLs, "radioEnterURLs");
            this.radioEnterURLs.Name = "radioEnterURLs";
            this.radioEnterURLs.UseVisualStyleBackColor = true;
            this.radioEnterURLs.CheckedChanged += new System.EventHandler(this.radioEnterURLs_CheckedChanged);
            // 
            // txtEnterURLs
            // 
            this.txtEnterURLs.AcceptsReturn = true;
            resources.ApplyResources(this.txtEnterURLs, "txtEnterURLs");
            this.txtEnterURLs.Name = "txtEnterURLs";
            // 
            // btnExpand
            // 
            resources.ApplyResources(this.btnExpand, "btnExpand");
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.UseVisualStyleBackColor = true;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // FormInputUrl
            // 
            this.AcceptButton = this.btnStart;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.btnExpand);
            this.Controls.Add(this.txtEnterURLs);
            this.Controls.Add(this.radioEnterURLs);
            this.Controls.Add(this.radioOpenUrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtPageUrl);
            this.Name = "FormInputUrl";
            this.Load += new System.EventHandler(this.FormInputUrl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.TextBox txtPageUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioOpenUrl;
        private System.Windows.Forms.RadioButton radioEnterURLs;
        private System.Windows.Forms.TextBox txtEnterURLs;
        private System.Windows.Forms.Button btnExpand;
    }
}