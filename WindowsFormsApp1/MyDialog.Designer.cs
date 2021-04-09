namespace WindowsFormsApp1
{
    partial class MyDialog
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
            this.IbxData = new System.Windows.Forms.ListBox();
            this.btnInputData = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IbxData
            // 
            this.IbxData.FormattingEnabled = true;
            this.IbxData.ItemHeight = 12;
            this.IbxData.Location = new System.Drawing.Point(77, 60);
            this.IbxData.Name = "IbxData";
            this.IbxData.Size = new System.Drawing.Size(343, 136);
            this.IbxData.TabIndex = 0;
            // 
            // btnInputData
            // 
            this.btnInputData.Location = new System.Drawing.Point(284, 243);
            this.btnInputData.Name = "btnInputData";
            this.btnInputData.Size = new System.Drawing.Size(136, 28);
            this.btnInputData.TabIndex = 2;
            this.btnInputData.Text = "輸入資料";
            this.btnInputData.UseVisualStyleBackColor = true;
            this.btnInputData.Click += new System.EventHandler(this.btnInputData_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(77, 243);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(136, 28);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "清除資料";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // MyDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 314);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnInputData);
            this.Controls.Add(this.IbxData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MyDialog";
            this.Text = "資料列表";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox IbxData;
        private System.Windows.Forms.Button btnInputData;
        private System.Windows.Forms.Button btnClear;
    }
}