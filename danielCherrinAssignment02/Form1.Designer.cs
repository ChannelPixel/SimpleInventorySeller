namespace danielCherrinAssignment02
{
    partial class frm_salesEntry
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
            this.components = new System.ComponentModel.Container();
            this.lstbx_prodSelect = new System.Windows.Forms.ListBox();
            this.txt_retailPrice = new System.Windows.Forms.TextBox();
            this.picbx_prodSelect = new System.Windows.Forms.PictureBox();
            this.lbl_RETAIL_PRICE = new System.Windows.Forms.Label();
            this.lbl_SALE_QUANTITY = new System.Windows.Forms.Label();
            this.txt_saleQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_costOfSale = new System.Windows.Forms.TextBox();
            this.btn_sellProduct = new System.Windows.Forms.Button();
            this.btn_salesSummary = new System.Windows.Forms.Button();
            this.btn_confirmSale = new System.Windows.Forms.Button();
            this.btn_cancelSale = new System.Windows.Forms.Button();
            this.errtip_general = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picbx_prodSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errtip_general)).BeginInit();
            this.SuspendLayout();
            // 
            // lstbx_prodSelect
            // 
            this.lstbx_prodSelect.FormattingEnabled = true;
            this.lstbx_prodSelect.Location = new System.Drawing.Point(12, 12);
            this.lstbx_prodSelect.Name = "lstbx_prodSelect";
            this.lstbx_prodSelect.Size = new System.Drawing.Size(150, 173);
            this.lstbx_prodSelect.TabIndex = 0;
            this.lstbx_prodSelect.SelectedIndexChanged += new System.EventHandler(this.lstbx_prodSelect_SelectedIndexChanged);
            // 
            // txt_retailPrice
            // 
            this.txt_retailPrice.Enabled = false;
            this.txt_retailPrice.Location = new System.Drawing.Point(168, 28);
            this.txt_retailPrice.Name = "txt_retailPrice";
            this.txt_retailPrice.Size = new System.Drawing.Size(121, 20);
            this.txt_retailPrice.TabIndex = 1;
            // 
            // picbx_prodSelect
            // 
            this.picbx_prodSelect.Location = new System.Drawing.Point(12, 191);
            this.picbx_prodSelect.Name = "picbx_prodSelect";
            this.picbx_prodSelect.Size = new System.Drawing.Size(150, 150);
            this.picbx_prodSelect.TabIndex = 2;
            this.picbx_prodSelect.TabStop = false;
            // 
            // lbl_RETAIL_PRICE
            // 
            this.lbl_RETAIL_PRICE.AutoSize = true;
            this.lbl_RETAIL_PRICE.Location = new System.Drawing.Point(168, 12);
            this.lbl_RETAIL_PRICE.Name = "lbl_RETAIL_PRICE";
            this.lbl_RETAIL_PRICE.Size = new System.Drawing.Size(63, 13);
            this.lbl_RETAIL_PRICE.TabIndex = 3;
            this.lbl_RETAIL_PRICE.Text = "Retail price:";
            // 
            // lbl_SALE_QUANTITY
            // 
            this.lbl_SALE_QUANTITY.AutoSize = true;
            this.lbl_SALE_QUANTITY.Location = new System.Drawing.Point(168, 51);
            this.lbl_SALE_QUANTITY.Name = "lbl_SALE_QUANTITY";
            this.lbl_SALE_QUANTITY.Size = new System.Drawing.Size(73, 13);
            this.lbl_SALE_QUANTITY.TabIndex = 4;
            this.lbl_SALE_QUANTITY.Text = "Sale Quantity:";
            // 
            // txt_saleQuantity
            // 
            this.txt_saleQuantity.Enabled = false;
            this.txt_saleQuantity.Location = new System.Drawing.Point(168, 67);
            this.txt_saleQuantity.Name = "txt_saleQuantity";
            this.txt_saleQuantity.Size = new System.Drawing.Size(121, 20);
            this.txt_saleQuantity.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cost of sale:";
            // 
            // txt_costOfSale
            // 
            this.txt_costOfSale.Enabled = false;
            this.txt_costOfSale.Location = new System.Drawing.Point(168, 106);
            this.txt_costOfSale.Name = "txt_costOfSale";
            this.txt_costOfSale.Size = new System.Drawing.Size(121, 20);
            this.txt_costOfSale.TabIndex = 7;
            // 
            // btn_sellProduct
            // 
            this.btn_sellProduct.BackColor = System.Drawing.SystemColors.Control;
            this.btn_sellProduct.Location = new System.Drawing.Point(171, 191);
            this.btn_sellProduct.Name = "btn_sellProduct";
            this.btn_sellProduct.Size = new System.Drawing.Size(118, 23);
            this.btn_sellProduct.TabIndex = 8;
            this.btn_sellProduct.Text = "Sell Product";
            this.btn_sellProduct.UseVisualStyleBackColor = false;
            this.btn_sellProduct.Click += new System.EventHandler(this.btn_sellProduct_Click);
            // 
            // btn_salesSummary
            // 
            this.btn_salesSummary.BackColor = System.Drawing.SystemColors.Control;
            this.btn_salesSummary.Location = new System.Drawing.Point(171, 220);
            this.btn_salesSummary.Name = "btn_salesSummary";
            this.btn_salesSummary.Size = new System.Drawing.Size(118, 23);
            this.btn_salesSummary.TabIndex = 9;
            this.btn_salesSummary.Text = "Sales Summary";
            this.btn_salesSummary.UseVisualStyleBackColor = false;
            this.btn_salesSummary.Click += new System.EventHandler(this.btn_salesSummary_Click);
            // 
            // btn_confirmSale
            // 
            this.btn_confirmSale.BackColor = System.Drawing.SystemColors.Control;
            this.btn_confirmSale.Location = new System.Drawing.Point(171, 289);
            this.btn_confirmSale.Name = "btn_confirmSale";
            this.btn_confirmSale.Size = new System.Drawing.Size(118, 23);
            this.btn_confirmSale.TabIndex = 10;
            this.btn_confirmSale.Text = "Confirm Sale";
            this.btn_confirmSale.UseVisualStyleBackColor = false;
            this.btn_confirmSale.Visible = false;
            this.btn_confirmSale.Click += new System.EventHandler(this.btn_confirmSale_Click);
            // 
            // btn_cancelSale
            // 
            this.btn_cancelSale.BackColor = System.Drawing.SystemColors.Control;
            this.btn_cancelSale.Location = new System.Drawing.Point(171, 318);
            this.btn_cancelSale.Name = "btn_cancelSale";
            this.btn_cancelSale.Size = new System.Drawing.Size(118, 23);
            this.btn_cancelSale.TabIndex = 11;
            this.btn_cancelSale.Text = "Cancel Sale";
            this.btn_cancelSale.UseVisualStyleBackColor = false;
            this.btn_cancelSale.Visible = false;
            this.btn_cancelSale.Click += new System.EventHandler(this.btn_cancelSale_Click);
            // 
            // errtip_general
            // 
            this.errtip_general.ContainerControl = this;
            // 
            // frm_salesEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 353);
            this.Controls.Add(this.btn_cancelSale);
            this.Controls.Add(this.btn_confirmSale);
            this.Controls.Add(this.btn_salesSummary);
            this.Controls.Add(this.btn_sellProduct);
            this.Controls.Add(this.txt_costOfSale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_saleQuantity);
            this.Controls.Add(this.lbl_SALE_QUANTITY);
            this.Controls.Add(this.lbl_RETAIL_PRICE);
            this.Controls.Add(this.picbx_prodSelect);
            this.Controls.Add(this.txt_retailPrice);
            this.Controls.Add(this.lstbx_prodSelect);
            this.Name = "frm_salesEntry";
            this.Text = "Cut Price Office Needs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_salesEntry_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picbx_prodSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errtip_general)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbx_prodSelect;
        private System.Windows.Forms.TextBox txt_retailPrice;
        private System.Windows.Forms.PictureBox picbx_prodSelect;
        private System.Windows.Forms.Label lbl_RETAIL_PRICE;
        private System.Windows.Forms.Label lbl_SALE_QUANTITY;
        private System.Windows.Forms.TextBox txt_saleQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_costOfSale;
        private System.Windows.Forms.Button btn_sellProduct;
        private System.Windows.Forms.Button btn_salesSummary;
        private System.Windows.Forms.Button btn_confirmSale;
        private System.Windows.Forms.Button btn_cancelSale;
        private System.Windows.Forms.ErrorProvider errtip_general;
    }
}

