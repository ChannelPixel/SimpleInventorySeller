using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace danielCherrinAssignment02
{
    public partial class frm_saveFile : Form
    {
        DateTime dte_current = DateTime.Now;

        public frm_saveFile()
        {
            InitializeComponent();
        }

        public static double dbl_totalValue = 0;

        private void btn_save_Click(object sender, EventArgs e)
        {

            if(txt_fileName.Text == null || txt_fileName.Text == "")
            {
                MessageBox.Show("A file name must be entered.");
                txt_fileName.Clear();
                txt_fileName.Focus();
            }
            else
            {
                StreamWriter updateFile = new StreamWriter(txt_fileName.Text + " " + dte_current.ToString("m") + ".txt");
                foreach (frm_salesEntry.Sales SaleObj in frm_salesEntry.lstSales)
                {
                    updateFile.WriteLine(SaleObj.strName + "," + SaleObj.dblRetailPrice.ToString("C") + "," + SaleObj.intStockPurchased + "," + SaleObj.dblSaleValue.ToString("C"));
                    dbl_totalValue += SaleObj.dblSaleValue;
                }
                updateFile.WriteLine("Total Value:" + dbl_totalValue);
                updateFile.Close();
                Environment.Exit(1);
            }
        }

        private void frm_saveFile_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txt_fileName.Text == null || txt_fileName.Text == "")
            {
                MessageBox.Show("A file name was not entered. Default filename has been set to: \n"
                               +"SalesFile "+dte_current.ToString("m"));

                StreamWriter updateFile = new StreamWriter("SalesFile " + dte_current.ToString("m")+".txt");
                foreach (frm_salesEntry.Sales SaleObj in frm_salesEntry.lstSales)
                {
                    updateFile.WriteLine(SaleObj.strName + "," + SaleObj.dblRetailPrice.ToString("C") + "," + SaleObj.intStockPurchased + "," + SaleObj.dblSaleValue.ToString("C"));
                    dbl_totalValue += SaleObj.dblSaleValue;
                }
                updateFile.WriteLine("Total Value:" + dbl_totalValue.ToString("C"));
                updateFile.Close();

            }
        }
    }
}
