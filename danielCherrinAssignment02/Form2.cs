using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace danielCherrinAssignment02
{
    public partial class frm_saleSummary : Form
    {
        public frm_saleSummary()
        {
            InitializeComponent();
        }

        private void frm_saleSummary_Load(object sender, EventArgs e)
        {
            txt_totalSales.Text = frm_salesEntry.counterSale.ToString();
            txt_totalValue.Text = frm_salesEntry.totalValue.ToString("C");

            foreach(frm_salesEntry.Sales SaleObj in frm_salesEntry.lstSales)
            {
                lstbx_summary.Items.Add("Item:"+SaleObj.strName +"      Quantity:"+ SaleObj.intStockPurchased  +"        Price:"+ SaleObj.dblSaleValue.ToString("C"));
            }
        }
    }
}
