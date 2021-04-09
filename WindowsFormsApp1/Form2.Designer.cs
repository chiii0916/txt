namespace WindowsFormsApp1
{
    partial class Form2
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
            this.rtxEditor = new System.Windows.Forms.RichTextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnForeColor = new System.Windows.Forms.Button();
            this.btnOther = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxEditor
            // 
            this.rtxEditor.Location = new System.Drawing.Point(37, 31);
            this.rtxEditor.Name = "rtxEditor";
            this.rtxEditor.Size = new System.Drawing.Size(487, 414);
            this.rtxEditor.TabIndex = 0;
            this.rtxEditor.Text = "";
            // 
            // btnOpen
            // 
            this.btnOpen.ForeColor = System.Drawing.Color.Purple;
            this.btnOpen.Location = new System.Drawing.Point(561, 50);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(111, 29);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "開啟檔案";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.Color.Purple;
            this.btnSave.Location = new System.Drawing.Point(561, 114);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 29);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "儲存檔案";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnBackColor
            // 
            this.btnBackColor.ForeColor = System.Drawing.Color.Purple;
            this.btnBackColor.Location = new System.Drawing.Point(561, 182);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(111, 29);
            this.btnBackColor.TabIndex = 3;
            this.btnBackColor.Text = "背景顏色";
            this.btnBackColor.UseVisualStyleBackColor = true;
            // 
            // btnFont
            // 
            this.btnFont.ForeColor = System.Drawing.Color.Purple;
            this.btnFont.Location = new System.Drawing.Point(561, 254);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(111, 29);
            this.btnFont.TabIndex = 4;
            this.btnFont.Text = "字型";
            this.btnFont.UseVisualStyleBackColor = true;
            // 
            // btnForeColor
            // 
            this.btnForeColor.ForeColor = System.Drawing.Color.Purple;
            this.btnForeColor.Location = new System.Drawing.Point(561, 326);
            this.btnForeColor.Name = "btnForeColor";
            this.btnForeColor.Size = new System.Drawing.Size(111, 29);
            this.btnForeColor.TabIndex = 5;
            this.btnForeColor.Text = "文字顏色";
            this.btnForeColor.UseVisualStyleBackColor = true;
            // 
            // btnOther
            // 
            this.btnOther.ForeColor = System.Drawing.Color.Purple;
            this.btnOther.Location = new System.Drawing.Point(561, 392);
            this.btnOther.Name = "btnOther";
            this.btnOther.Size = new System.Drawing.Size(111, 29);
            this.btnOther.TabIndex = 6;
            this.btnOther.Text = "其他特效";
            this.btnOther.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(716, 480);
            this.Controls.Add(this.btnOther);
            this.Controls.Add(this.btnForeColor);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnBackColor);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.rtxEditor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "簡易記事本";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxEditor;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnForeColor;
        private System.Windows.Forms.Button btnOther;
    }
}