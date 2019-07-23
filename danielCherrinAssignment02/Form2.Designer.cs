namespace danielCherrinAssignment02
{
    partial class frm_saleSummary
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_totalSales = new System.Windows.Forms.TextBox();
            this.txt_totalValue = new System.Windows.Forms.TextBox();
            this.lstbx_summary = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total # of Sales:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Value:";
            // 
            // txt_totalSales
            // 
            this.txt_totalSales.Enabled = false;
            this.txt_totalSales.Location = new System.Drawing.Point(118, 6);
            this.txt_totalSales.Name = "txt_totalSales";
            this.txt_totalSales.Size = new System.Drawing.Size(148, 20);
            this.txt_totalSales.TabIndex = 2;
            // 
            // txt_totalValue
            // 
            this.txt_totalValue.Enabled = false;
            this.txt_totalValue.Location = new System.Drawing.Point(118, 32);
            this.txt_totalValue.Name = "txt_totalValue";
            this.txt_totalValue.Size = new System.Drawing.Size(148, 20);
            this.txt_totalValue.TabIndex = 3;
            // 
            // lstbx_summary
            // 
            this.lstbx_summary.FormattingEnabled = true;
            this.lstbx_summary.Location = new System.Drawing.Point(15, 78);
            this.lstbx_summary.Name = "lstbx_summary";
            this.lstbx_summary.Size = new System.Drawing.Size(251, 121);
            this.lstbx_summary.TabIndex = 4;
            // 
            // frm_saleSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 216);
            this.Controls.Add(this.lstbx_summary);
            this.Controls.Add(this.txt_totalValue);
            this.Controls.Add(this.txt_totalSales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_saleSummary";
            this.Text = "Sale Summary";
            this.Load += new System.EventHandler(this.frm_saleSummary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txt_totalSales;
        internal System.Windows.Forms.TextBox txt_totalValue;
        internal System.Windows.Forms.ListBox lstbx_summary;
    }
}