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
            this.txtPageUrl.AccessibleDescription = null;
            this.txtPageUrl.AccessibleName = null;
            resources.ApplyResources(this.txtPageUrl, "txtPageUrl");
            this.txtPageUrl.BackgroundImage = null;
            this.txtPageUrl.Font = null;
            this.txtPageUrl.Name = "txtPageUrl";
            // 
            // btnStart
            // 
            this.btnStart.AccessibleDescription = null;
            this.btnStart.AccessibleName = null;
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.BackgroundImage = null;
            this.btnStart.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnStart.Font = null;
            this.btnStart.Name = "btnStart";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleDescription = null;
            this.btnCancel.AccessibleName = null;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BackgroundImage = null;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = null;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Font = null;
            this.label1.Name = "label1";
            // 
            // radioOpenUrl
            // 
            this.radioOpenUrl.AccessibleDescription = null;
            this.radioOpenUrl.AccessibleName = null;
            resources.ApplyResources(this.radioOpenUrl, "radioOpenUrl");
            this.radioOpenUrl.BackgroundImage = null;
            this.radioOpenUrl.Font = null;
            this.radioOpenUrl.Name = "radioOpenUrl";
            this.radioOpenUrl.UseVisualStyleBackColor = true;
            this.radioOpenUrl.CheckedChanged += new System.EventHandler(this.radioOpenUrl_CheckedChanged);
            // 
            // radioEnterURLs
            // 
            this.radioEnterURLs.AccessibleDescription = null;
            this.radioEnterURLs.AccessibleName = null;
            resources.ApplyResources(this.radioEnterURLs, "radioEnterURLs");
            this.radioEnterURLs.BackgroundImage = null;
            this.radioEnterURLs.Font = null;
            this.radioEnterURLs.Name = "radioEnterURLs";
            this.radioEnterURLs.UseVisualStyleBackColor = true;
            this.radioEnterURLs.CheckedChanged += new System.EventHandler(this.radioEnterURLs_CheckedChanged);
            // 
            // txtEnterURLs
            // 
            this.txtEnterURLs.AcceptsReturn = true;
            this.txtEnterURLs.AccessibleDescription = null;
            this.txtEnterURLs.AccessibleName = null;
            resources.ApplyResources(this.txtEnterURLs, "txtEnterURLs");
            this.txtEnterURLs.BackgroundImage = null;
            this.txtEnterURLs.Font = null;
            this.txtEnterURLs.Name = "txtEnterURLs";
            // 
            // btnExpand
            // 
            this.btnExpand.AccessibleDescription = null;
            this.btnExpand.AccessibleName = null;
            resources.ApplyResources(this.btnExpand, "btnExpand");
            this.btnExpand.BackgroundImage = null;
            this.btnExpand.Font = null;
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.UseVisualStyleBackColor = true;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // FormInputUrl
            // 
            this.AcceptButton = this.btnStart;
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.btnExpand);
            this.Controls.Add(this.txtEnterURLs);
            this.Controls.Add(this.radioEnterURLs);
            this.Controls.Add(this.radioOpenUrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtPageUrl);
            this.Font = null;
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