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
    public partial class frm_salesEntry : Form
    {
        //GLOBAL VARIABLES///////////////////////
        public static int counterSale = 0;
        public static double totalValue = 0;
        ////////////////////////////////////////


        public class Products
        {
            public string strCode;
            public string strName;
            public int intStock;
            public double dblPrice;
            public string strImage;

            public void setStock(int a)
            {
                intStock = a;
            }
        }

        public class Sales
        {
            public string strName;
            public double dblRetailPrice;
            public int intStockPurchased;
            public double dblSaleValue;
        }

        List<Products> lstProducts = new List<Products>();
        public static List<Sales> lstSales = new List<Sales>();

        public frm_salesEntry()
        {
            InitializeComponent();

            ///////////////////////SUPPLIED CODE///////////////////////
            StreamReader inFile;
            inFile = File.OpenText("products.txt");
            string strRead;
            while ((strRead = inFile.ReadLine()) != null)
            {
                Products PrdObj = new Products();
                //Products PrdObj;
                string[] strTempArr = new string[5];
                strTempArr = strRead.Split(',');
                PrdObj.strCode = strTempArr[0];
                PrdObj.strName = strTempArr[1];
                PrdObj.intStock = int.Parse(strTempArr[2]);
                PrdObj.dblPrice = double.Parse(strTempArr[3]);
                PrdObj.strImage = strTempArr[4];
                lstProducts.Add(PrdObj);
            }
            foreach (Products PrdObj in lstProducts)
            {
                lstbx_prodSelect.Items.Add(PrdObj.strName);
            }
            inFile.Close();

            txt_saleQuantity.SelectAll();
            txt_saleQuantity.Focus();
            btn_confirmSale.Visible = false;
            btn_cancelSale.Visible = false;

            this.picbx_prodSelect.SizeMode = PictureBoxSizeMode.Zoom;
            ///////////////////////SUPPLIED CODE///////////////////////

        }

        public Boolean validateQuantity()
        {
            int temp;
            if (!int.TryParse(txt_saleQuantity.Text, out temp))
            {
                errtip_general.SetError(txt_saleQuantity, "Input must be a whole number and more than 0.");
                txt_saleQuantity.Clear();
                txt_saleQuantity.Focus();
                btn_confirmSale.Visible = false;
                btn_cancelSale.Visible = false;
                return false;
            }
            else if(temp <= 0)
            {
                errtip_general.SetError(txt_saleQuantity, "Input must be a whole number and more than 0.");
                txt_saleQuantity.Clear();
                txt_saleQuantity.Focus();
                btn_confirmSale.Visible = false;
                btn_cancelSale.Visible = false;
                return false;
            }
            else
            {
                errtip_general.Dispose();
                return true;
            }
        }

        private void lstbx_prodSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Quanity set to null if new selection.
            txt_saleQuantity.Text = null;
            //If selection is not null, incase of cancel sale, do.
            if (lstbx_prodSelect.SelectedItem != null)
            {
                validateQuantity();
                //Enable Sale Quantity textbox///////////////////////////////////////////////////////////
                txt_saleQuantity.Enabled = true;
                /////////////////////////////////////////////////////////////////////////////////////////

                //Set picture box image from list box selection./////////////////////////////////////////
                picbx_prodSelect.Image = Image.FromFile(lstbx_prodSelect.SelectedItem.ToString() + ".jpg");
                /////////////////////////////////////////////////////////////////////////////////////////

                //Set retail price by comparing selected item for each Products in PrdObj. If equal, set
                //retail price to Prd.Obj's price *1.5///////////////////////////////////////////////////
                foreach (Products PrdObj in lstProducts)
                {
                    if (PrdObj.strName == lstbx_prodSelect.SelectedItem.ToString())
                    {
                        txt_retailPrice.Text = (PrdObj.dblPrice * 1.5).ToString("C");
                    }
                }
                /////////////////////////////////////////////////////////////////////////////////////////
            }
            else if (lstbx_prodSelect.SelectedItem == null)
            {
                btn_confirmSale.Visible = false;
                btn_cancelSale.Visible = false;
            }
        }

        private void btn_cancelSale_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Product sale has been canceled.");

            btn_confirmSale.Visible = false;
            btn_cancelSale.Visible = false;

            txt_retailPrice.Clear();
            txt_saleQuantity.Clear();
            txt_costOfSale.Clear();

            lstbx_prodSelect.ClearSelected();

            picbx_prodSelect.Image = null;
        }

        private void btn_sellProduct_Click(object sender, EventArgs e)
        {
            int tempQuantity;

            if (validateQuantity())
            {
                tempQuantity = int.Parse(txt_saleQuantity.Text);

                    foreach (Products PrdObj in lstProducts)
                    {
                        if (PrdObj.strName == lstbx_prodSelect.SelectedItem.ToString() && PrdObj.intStock >= tempQuantity)
                        {
                            txt_costOfSale.Text = (PrdObj.dblPrice * tempQuantity).ToString("C");

                            btn_confirmSale.Visible = true;
                            btn_cancelSale.Visible = true;
                        }
                        else if (PrdObj.strName == lstbx_prodSelect.SelectedItem.ToString() && PrdObj.intStock < tempQuantity)
                        {
                            MessageBox.Show("That stock on that item is currently: " + PrdObj.intStock + "\n" +
                                            "Please enter quantity equal to or smaller than the available quantity.");
                            txt_saleQuantity.Clear();
                            txt_saleQuantity.Focus();
                        }
                    }
            }
            
        }

        private void btn_confirmSale_Click(object sender, EventArgs e)
        {
            int tempQuantity;

            if(validateQuantity())
            {
                tempQuantity = int.Parse(txt_saleQuantity.Text);
                    foreach (Products PrdObj in lstProducts)
                    {
                        if (PrdObj.strName == lstbx_prodSelect.SelectedItem.ToString() && PrdObj.intStock >= tempQuantity)
                        {

                            Sales SaleObj = new Sales();
                            SaleObj.strName = lstbx_prodSelect.SelectedItem.ToString();
                            SaleObj.dblRetailPrice = PrdObj.dblPrice * 1.5;
                            SaleObj.intStockPurchased = tempQuantity;
                            SaleObj.dblSaleValue = PrdObj.dblPrice * tempQuantity;

                            counterSale++;
                            totalValue += PrdObj.dblPrice * tempQuantity;

                            lstSales.Add(SaleObj);
                            PrdObj.intStock -= tempQuantity;
                        }
                        else if (PrdObj.strName == lstbx_prodSelect.SelectedItem.ToString() && PrdObj.intStock < tempQuantity)
                        {
                            MessageBox.Show("That stock on that item is currently: " + PrdObj.intStock + "\n" +
                                            "Please enter quantity equal to or smaller than the available quantity.");
                            txt_saleQuantity.Clear();
                            txt_saleQuantity.Focus();
                        }
                    }
            }
        }

        private void btn_salesSummary_Click(object sender, EventArgs e)
        {
            frm_saleSummary frm_temp = new frm_saleSummary();

            frm_temp.ShowDialog();
        }

        private void frm_salesEntry_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Updates quantity in products.txt file using list//////////////////////////////////////////////////////////////////////
            StreamWriter updateFile = new StreamWriter("products.txt");
            foreach (Products PrdObj in lstProducts)
            {
                updateFile.WriteLine(PrdObj.strCode+","+PrdObj.strName+","+PrdObj.intStock+","+PrdObj.dblPrice+","+PrdObj.strImage);
            }
            updateFile.Close();
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            frm_saveFile frm_temp = new frm_saveFile();
            frm_temp.ShowDialog();
        }
    }
}
