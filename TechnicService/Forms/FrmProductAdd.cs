using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnicService.Forms
{
    public partial class FrmProductAdd : Form
    {
        public FrmProductAdd()
        {
            InitializeComponent();
        }

        private TechnicServiceEntities _entities = new TechnicServiceEntities();
        void CategorySelection()
        {
            cbxCategory.Properties.DataSource = (from x in _entities.Category 
                select new
                {
                    x.Id,
                    x.Name
                }).ToList();
        }

        void CustomerCategorySelection()
        {
            cbxCustomer.Properties.DataSource = (from x in _entities.Customers where x.Status==true
                select new
                {
                    ÖzelKod = x.Id,
                    UnvanAd = x.FirstName
                }).ToList();
        }

        private void FrmProductAdd_Load(object sender, EventArgs e)
        {
            CategorySelection();
            CustomerCategorySelection();
        }
        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            if (txtAdd.Text != "" && txtbrand.Text !="" && txtPurchase.Text != "" && txtSalesPrice.Text != "" && txtStock.Text != "" && Convert.ToInt32(cbxCategory.EditValue)> 0)
            {
                Products products = new Products();
                products.CustomerId = Convert.ToInt32(cbxCustomer.EditValue.ToString());
                products.Name = char.ToUpper(txtAdd.Text[0]) + txtAdd.Text.Substring(1);
                products.Brand = char.ToUpper(txtbrand.Text[0]) + txtbrand.Text.Substring(1);
                products.CategoryId = Convert.ToInt32(cbxCategory.EditValue.ToString());
                products.Purchase = Convert.ToDecimal(txtPurchase.Text);
                products.SalesPrice = Convert.ToDecimal(txtSalesPrice.Text);
                products.stock = Convert.ToInt32(txtStock.Text);
                products.BarcodeNo = txtBarcode.Text.ToUpper();
                products.Status = Convert.ToInt32(txtStock.Text) > 0 ? true : false;
                _entities.Products.Add(products);
                _entities.SaveChanges();
                MessageBox.Show("Ürün başarı ile eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                txtAdd.Text = "";
                txtbrand.Text = "";
                txtBarcode.Text = "";
                txtPurchase.Text = "";
                txtSalesPrice.Text = "";
                txtStock.Text = "";
            }
            else
            {
                MessageBox.Show("Doldurulmayan alanları doldurunuz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
