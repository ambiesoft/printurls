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
            ((System.ComponentModel.ISupportInitialize)(this.udWait)).BeginInit();
            this.statusMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // wbPrint
            // 
            this.wbPrint.Location = new System.Drawing.Point(12, 38);
            this.wbPrint.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbPrint.Name = "wbPrint";
            this.wbPrint.Size = new System.Drawing.Size(745, 300);
            this.wbPrint.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Location = new System.Drawing.Point(682, 359);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // udWait
            // 
            this.udWait.Location = new System.Drawing.Point(12, 363);
            this.udWait.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.udWait.Name = "udWait";
            this.udWait.Size = new System.Drawing.Size(87, 19);
            this.udWait.TabIndex = 2;
            this.udWait.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // chkPause
            // 
            this.chkPause.AutoSize = true;
            this.chkPause.Location = new System.Drawing.Point(621, 363);
            this.chkPause.Name = "chkPause";
            this.chkPause.Size = new System.Drawing.Size(55, 16);
            this.chkPause.TabIndex = 3;
            this.chkPause.Text = "&Pause";
            this.chkPause.UseVisualStyleBackColor = true;
            // 
            // basicTimer
            // 
            this.basicTimer.Interval = 1000;
            this.basicTimer.Tick += new System.EventHandler(this.basicTimer_Tick);
            // 
            // progMain
            // 
            this.progMain.Location = new System.Drawing.Point(12, 11);
            this.progMain.Name = "progMain";
            this.progMain.Size = new System.Drawing.Size(745, 21);
            this.progMain.TabIndex = 4;
            // 
            // statusMain
            // 
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slBrowser,
            this.slStatus});
            this.statusMain.Location = new System.Drawing.Point(0, 396);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(771, 22);
            this.statusMain.TabIndex = 5;
            this.statusMain.Text = "statusStrip1";
            // 
            // slBrowser
            // 
            this.slBrowser.Name = "slBrowser";
            this.slBrowser.Size = new System.Drawing.Size(80, 17);
            this.slBrowser.Text = "Browser Ready";
            // 
            // slStatus
            // 
            this.slStatus.Name = "slStatus";
            this.slStatus.Size = new System.Drawing.Size(38, 17);
            this.slStatus.Text = "Ready";
            // 
            // FormPrint
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 418);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.progMain);
            this.Controls.Add(this.chkPause);
            this.Controls.Add(this.udWait);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.wbPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPrint";
            this.Text = "Print : PrintURLs";
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
    }
}