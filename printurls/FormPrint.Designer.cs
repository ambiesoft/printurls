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
            ((System.ComponentModel.ISupportInitialize)(this.udWait)).BeginInit();
            this.statusMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // wbPrint
            // 
            this.wbPrint.AccessibleDescription = null;
            this.wbPrint.AccessibleName = null;
            resources.ApplyResources(this.wbPrint, "wbPrint");
            this.wbPrint.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbPrint.Name = "wbPrint";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleDescription = null;
            this.btnClose.AccessibleName = null;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.BackgroundImage = null;
            this.btnClose.Font = null;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // udWait
            // 
            this.udWait.AccessibleDescription = null;
            this.udWait.AccessibleName = null;
            resources.ApplyResources(this.udWait, "udWait");
            this.udWait.Font = null;
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
            this.chkPause.AccessibleDescription = null;
            this.chkPause.AccessibleName = null;
            resources.ApplyResources(this.chkPause, "chkPause");
            this.chkPause.BackgroundImage = null;
            this.chkPause.Font = null;
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
            this.progMain.AccessibleDescription = null;
            this.progMain.AccessibleName = null;
            resources.ApplyResources(this.progMain, "progMain");
            this.progMain.BackgroundImage = null;
            this.progMain.Font = null;
            this.progMain.Name = "progMain";
            // 
            // statusMain
            // 
            this.statusMain.AccessibleDescription = null;
            this.statusMain.AccessibleName = null;
            resources.ApplyResources(this.statusMain, "statusMain");
            this.statusMain.BackgroundImage = null;
            this.statusMain.Font = null;
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slBrowser,
            this.slStatus});
            this.statusMain.Name = "statusMain";
            // 
            // slBrowser
            // 
            this.slBrowser.AccessibleDescription = null;
            this.slBrowser.AccessibleName = null;
            resources.ApplyResources(this.slBrowser, "slBrowser");
            this.slBrowser.BackgroundImage = null;
            this.slBrowser.Name = "slBrowser";
            // 
            // slStatus
            // 
            this.slStatus.AccessibleDescription = null;
            this.slStatus.AccessibleName = null;
            resources.ApplyResources(this.slStatus, "slStatus");
            this.slStatus.BackgroundImage = null;
            this.slStatus.Name = "slStatus";
            // 
            // btnPrintAndGoNext
            // 
            this.btnPrintAndGoNext.AccessibleDescription = null;
            this.btnPrintAndGoNext.AccessibleName = null;
            resources.ApplyResources(this.btnPrintAndGoNext, "btnPrintAndGoNext");
            this.btnPrintAndGoNext.BackgroundImage = null;
            this.btnPrintAndGoNext.Font = null;
            this.btnPrintAndGoNext.Name = "btnPrintAndGoNext";
            this.btnPrintAndGoNext.UseVisualStyleBackColor = true;
            this.btnPrintAndGoNext.Click += new System.EventHandler(this.btnPrintAndGoNext_Click);
            // 
            // FormPrint
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.btnPrintAndGoNext);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.progMain);
            this.Controls.Add(this.chkPause);
            this.Controls.Add(this.udWait);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.wbPrint);
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormPrint";
            this.Load += new System.EventHandler(this.FormPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.udWait)).EndInit();
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
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
    }
}