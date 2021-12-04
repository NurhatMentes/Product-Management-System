using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraScheduler.iCalendar.Components;
using TechnicService.Core.Service;

namespace TechnicService.Forms
{
    public partial class FrmExpenses : Form
    {
        int productId;
        public FrmExpenses()
        {
            InitializeComponent();
        }
        TechnicServiceEntities _entities = new TechnicServiceEntities();
        Expenses _expenses = new Expenses();
        Products _products = new Products();
        UsdService _usdService = new UsdService();

        private void btnSell_Click(object sender, EventArgs e)
        {
            if (txtprice.Text != "")
            {
                var productEnitity = _entities.Products.Find(productId);
                _expenses.ProductId = productId;
                _expenses.Quantity = Int32.Parse(txtquantity.Text);
                _expenses.Price = decimal.Parse(txtprice.Text);
                _expenses.Date = DateTime.UtcNow;
                if (productEnitity != null)
                {
                    productEnitity.stock -= Int32.Parse(txtquantity.Text);
                }
                if (checkSale.Checked)
                {
                    decimal saleRate = Int32.Parse(spinSale.Text);
                    decimal sale = saleRate / 100;
                    decimal productPrice = decimal.Parse(txtprice.Text)*_usdService.Usd();

                    _expenses.Price = productPrice - (productPrice * sale);
                }

                barCodeControl1.Visible = false;
                txtBarcode.Visible = true;
                txtBarcode.Text = "";
                txtquantity.Text = "";
                txtprice.Text="";
                txtBrand.Text = "";
                txtBarcode.Text = "";
                txtProductName.Text = "";

                _entities.Expenses.Add(_expenses);
                _entities.SaveChanges();
                MessageBox.Show("Ürün satışı gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Satış Başarısız!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

            private void txtBarcode_TextChanged(object sender, EventArgs e)
            {
                var entity = _entities.Products.Where(x => x.BarcodeNo == txtBarcode.Text).Select(x => x).FirstOrDefault();
                if (entity == null)
                {
                    txtProductName.Text = "";
                    txtBrand.Text = "";
                    lblStock.Text = "";
                    btnSell.Enabled = false;
                }
                if (entity != null)
                {
                    productId = entity.Id;
                    txtProductName.Text = entity.Name;
                    txtBrand.Text = entity.Brand;
                    lblStock.Text = entity.stock.ToString();
                    txtquantity.Text = 1.ToString();
                    txtprice.Text = entity.SalesPrice.ToString();
                    btnSell.Enabled = true;
                    txtBarcode.Visible = false;
                    barCodeControl1.Text = txtBarcode.Text.ToUpper();
                    barCodeControl1.Visible = true;
                    btnCancel.Visible = true;
                }

            }

            private void FrmExpenses_Load(object sender, EventArgs e)
            {
                btnSell.Enabled = false;
            }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            barCodeControl1.Visible = false;
            txtBarcode.Visible = true;
            txtBarcode.Text = "";
            txtquantity.Text = "";
            txtprice.Text = "";
            txtBrand.Text = "";
            txtBarcode.Text = "";
            txtProductName.Text = "";
            btnCancel.Visible = false;
        }
    }
    }
