namespace danielCherrinAssignment02
{
    partial class frm_saveFile
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
            this.txt_fileName = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_FILE_NAME = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_fileName
            // 
            this.txt_fileName.Location = new System.Drawing.Point(12, 22);
            this.txt_fileName.Name = "txt_fileName";
            this.txt_fileName.Size = new System.Drawing.Size(419, 20);
            this.txt_fileName.TabIndex = 0;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(12, 57);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_FILE_NAME
            // 
            this.lbl_FILE_NAME.AutoSize = true;
            this.lbl_FILE_NAME.Location = new System.Drawing.Point(9, 6);
            this.lbl_FILE_NAME.Name = "lbl_FILE_NAME";
            this.lbl_FILE_NAME.Size = new System.Drawing.Size(86, 13);
            this.lbl_FILE_NAME.TabIndex = 2;
            this.lbl_FILE_NAME.Text = "Sales File Name:";
            // 
            // frm_saveFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 92);
            this.Controls.Add(this.lbl_FILE_NAME);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_fileName);
            this.Name = "frm_saveFile";
            this.Text = "Save Sales file...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_saveFile_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_fileName;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_FILE_NAME;
    }
}