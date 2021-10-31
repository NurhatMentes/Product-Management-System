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
        private void FrmProductAdd_Load(object sender, EventArgs e)
        {
            CategorySelection();
        }
        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            if (txtAdd.Text != "")
            {
                Products products = new Products();
                products.Name = txtAdd.Text;
                products.Brand = txtbrand.Text;
                products.CategoryId = Convert.ToInt32(cbxCategory.EditValue.ToString());
                products.Purchase = Convert.ToDecimal(txtPurchase.Text);
                products.SalesPrice = Convert.ToDecimal(txtSalesPrice.Text);
                products.stock = Convert.ToInt32(txtStock.Text);
                products.Status = Convert.ToInt32(txtStock.Text) > 0 ? true : false;
                _entities.Products.Add(products);
                _entities.SaveChanges();
                MessageBox.Show("Ürün başarı ile eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Doldurulmayan alanları doldurunuz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

       
    }
}
