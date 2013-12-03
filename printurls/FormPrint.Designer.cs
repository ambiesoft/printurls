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
            this.wbPrint.Location = new System.Drawing.Point(12, 41);
            this.wbPrint.MinimumSize = new System.Drawing.Size(20, 22);
            this.wbPrint.Name = "wbPrint";
            this.wbPrint.Size = new System.Drawing.Size(745, 325);
            this.wbPrint.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Location = new System.Drawing.Point(682, 393);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // udWait
            // 
            this.udWait.Location = new System.Drawing.Point(51, 393);
            this.udWait.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.udWait.Name = "udWait";
            this.udWait.Size = new System.Drawing.Size(87, 20);
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
            this.chkPause.Location = new System.Drawing.Point(181, 397);
            this.chkPause.Name = "chkPause";
            this.chkPause.Size = new System.Drawing.Size(56, 17);
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
            this.progMain.Location = new System.Drawing.Point(12, 12);
            this.progMain.Name = "progMain";
            this.progMain.Size = new System.Drawing.Size(745, 23);
            this.progMain.TabIndex = 4;
            // 
            // statusMain
            // 
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slBrowser,
            this.slStatus});
            this.statusMain.Location = new System.Drawing.Point(0, 409);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(769, 22);
            this.statusMain.TabIndex = 5;
            this.statusMain.Text = "statusStrip1";
            // 
            // slBrowser
            // 
            this.slBrowser.Name = "slBrowser";
            this.slBrowser.Size = new System.Drawing.Size(84, 17);
            this.slBrowser.Text = "Browser Ready";
            // 
            // slStatus
            // 
            this.slStatus.Name = "slStatus";
            this.slStatus.Size = new System.Drawing.Size(39, 17);
            this.slStatus.Text = "Ready";
            // 
            // FormPrint
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 431);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.progMain);
            this.Controls.Add(this.chkPause);
            this.Controls.Add(this.udWait);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.wbPrint);
            this.Name = "FormPrint";
            this.Text = "FormPrint";
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