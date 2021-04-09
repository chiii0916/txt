namespace _1072008_HW4_1
{
    partial class picform
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pbx = new System.Windows.Forms.PictureBox();
            this.btnback = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnfolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            ((System.ComponentModel.ISupportInitialize)(this.pbx)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx
            // 
            this.pbx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbx.Location = new System.Drawing.Point(30, 27);
            this.pbx.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pbx.Name = "pbx";
            this.pbx.Size = new System.Drawing.Size(482, 328);
            this.pbx.TabIndex = 0;
            this.pbx.TabStop = false;
            // 
            // btnback
            // 
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnback.Location = new System.Drawing.Point(171, 359);
            this.btnback.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(92, 26);
            this.btnback.TabIndex = 1;
            this.btnback.Text = "上一張";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnnext
            // 
            this.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnnext.Location = new System.Drawing.Point(277, 359);
            this.btnnext.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(92, 26);
            this.btnnext.TabIndex = 2;
            this.btnnext.Text = "下一張";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnfolder
            // 
            this.btnfolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnfolder.Location = new System.Drawing.Point(443, 359);
            this.btnfolder.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnfolder.Name = "btnfolder";
            this.btnfolder.Size = new System.Drawing.Size(92, 26);
            this.btnfolder.TabIndex = 3;
            this.btnfolder.Text = "選擇資料夾";
            this.btnfolder.UseVisualStyleBackColor = true;
            this.btnfolder.Click += new System.EventHandler(this.btnfolder_Click);
            // 
            // picform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 390);
            this.Controls.Add(this.btnfolder);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.pbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.MaximizeBox = false;
            this.Name = "picform";
            this.Text = "簡易看圖程式";
            this.Load += new System.EventHandler(this.picform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnfolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}

