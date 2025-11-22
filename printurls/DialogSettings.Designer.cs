namespace printurls
{
    partial class DialogSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblWavFile = new System.Windows.Forms.Label();
            this.txtWavFile = new System.Windows.Forms.TextBox();
            this.chkPlayAfterFinished = new System.Windows.Forms.CheckBox();
            this.btnNavigateWav = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(332, 161);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 500;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(413, 161);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 600;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblWavFile
            // 
            this.lblWavFile.AutoSize = true;
            this.lblWavFile.Location = new System.Drawing.Point(12, 42);
            this.lblWavFile.Name = "lblWavFile";
            this.lblWavFile.Size = new System.Drawing.Size(48, 13);
            this.lblWavFile.TabIndex = 200;
            this.lblWavFile.Text = "&WAV file";
            // 
            // txtWavFile
            // 
            this.txtWavFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWavFile.Location = new System.Drawing.Point(66, 39);
            this.txtWavFile.Name = "txtWavFile";
            this.txtWavFile.Size = new System.Drawing.Size(391, 20);
            this.txtWavFile.TabIndex = 300;
            // 
            // chkPlayAfterFinished
            // 
            this.chkPlayAfterFinished.AutoSize = true;
            this.chkPlayAfterFinished.Location = new System.Drawing.Point(66, 16);
            this.chkPlayAfterFinished.Name = "chkPlayAfterFinished";
            this.chkPlayAfterFinished.Size = new System.Drawing.Size(132, 17);
            this.chkPlayAfterFinished.TabIndex = 100;
            this.chkPlayAfterFinished.Text = "&Play wav after finished";
            this.chkPlayAfterFinished.UseVisualStyleBackColor = true;
            // 
            // btnNavigateWav
            // 
            this.btnNavigateWav.Location = new System.Drawing.Point(463, 37);
            this.btnNavigateWav.Name = "btnNavigateWav";
            this.btnNavigateWav.Size = new System.Drawing.Size(25, 23);
            this.btnNavigateWav.TabIndex = 400;
            this.btnNavigateWav.Text = "&...";
            this.btnNavigateWav.UseVisualStyleBackColor = true;
            this.btnNavigateWav.Click += new System.EventHandler(this.btnNavigateWav_Click);
            // 
            // DialogSettings
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(500, 196);
            this.Controls.Add(this.btnNavigateWav);
            this.Controls.Add(this.chkPlayAfterFinished);
            this.Controls.Add(this.txtWavFile);
            this.Controls.Add(this.lblWavFile);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.MinimizeBox = false;
            this.Name = "DialogSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DialogSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblWavFile;
        private System.Windows.Forms.TextBox txtWavFile;
        private System.Windows.Forms.CheckBox chkPlayAfterFinished;
        private System.Windows.Forms.Button btnNavigateWav;
    }
}