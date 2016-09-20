namespace printurls
{
    partial class FormPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrint));
            this.wbPrint = new System.Windows.Forms.WebBrowser();
            this.btnClose = new System.Windows.Forms.Button();
            this.udWait = new System.Windows.Forms.NumericUpDown();
            this.chkPause = new System.Windows.Forms.CheckBox();
            this.basicTimer = new System.Windows.Forms.Timer(this.components);
            this.progMain = new System.Windows.Forms.ProgressBar();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.slBrowser = new System.Windows.Forms.ToolStripStatusLabel();
            this.slStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnPrintAndGoNext = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.udPrintWait = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.udWait)).BeginInit();
            this.statusMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udPrintWait)).BeginInit();
            this.SuspendLayout();
            // 
            // wbPrint
            // 
            resources.ApplyResources(this.wbPrint, "wbPrint");
            this.wbPrint.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbPrint.Name = "wbPrint";
            this.wbPrint.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.wbPrint_Navigated);
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // udWait
            // 
            resources.ApplyResources(this.udWait, "udWait");
            this.udWait.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.udWait.Name = "udWait";
            this.udWait.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // chkPause
            // 
            resources.ApplyResources(this.chkPause, "chkPause");
            this.chkPause.Name = "chkPause";
            this.chkPause.UseVisualStyleBackColor = true;
            // 
            // basicTimer
            // 
            this.basicTimer.Interval = 1000;
            this.basicTimer.Tick += new System.EventHandler(this.basicTimer_Tick);
            // 
            // progMain
            // 
            resources.ApplyResources(this.progMain, "progMain");
            this.progMain.Name = "progMain";
            // 
            // statusMain
            // 
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slBrowser,
            this.slStatus});
            resources.ApplyResources(this.statusMain, "statusMain");
            this.statusMain.Name = "statusMain";
            // 
            // slBrowser
            // 
            this.slBrowser.Name = "slBrowser";
            resources.ApplyResources(this.slBrowser, "slBrowser");
            // 
            // slStatus
            // 
            this.slStatus.Name = "slStatus";
            resources.ApplyResources(this.slStatus, "slStatus");
            // 
            // btnPrintAndGoNext
            // 
            resources.ApplyResources(this.btnPrintAndGoNext, "btnPrintAndGoNext");
            this.btnPrintAndGoNext.Name = "btnPrintAndGoNext";
            this.btnPrintAndGoNext.UseVisualStyleBackColor = true;
            this.btnPrintAndGoNext.Click += new System.EventHandler(this.btnPrintAndGoNext_Click);
            // 
            // txtUrl
            // 
            resources.ApplyResources(this.txtUrl, "txtUrl");
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.ReadOnly = true;
            // 
            // udPrintWait
            // 
            resources.ApplyResources(this.udPrintWait, "udPrintWait");
            this.udPrintWait.Name = "udPrintWait";
            this.udPrintWait.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // FormPrint
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.udPrintWait);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnPrintAndGoNext);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.progMain);
            this.Controls.Add(this.chkPause);
            this.Controls.Add(this.udWait);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.wbPrint);
            this.MaximizeBox = false;
            this.Name = "FormPrint";
            this.Load += new System.EventHandler(this.FormPrint_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrint_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.udWait)).EndInit();
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udPrintWait)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.NumericUpDown udWait;
        private System.Windows.Forms.CheckBox chkPause;
        private System.Windows.Forms.Timer basicTimer;
        private System.Windows.Forms.ProgressBar progMain;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.ToolStripStatusLabel slBrowser;
        private System.Windows.Forms.ToolStripStatusLabel slStatus;
        private System.Windows.Forms.Button btnPrintAndGoNext;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.NumericUpDown udPrintWait;
        private System.Windows.Forms.Label label1;
    }
}