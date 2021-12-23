using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors.Filtering.Controls;
using DevExpress.XtraEditors.Repository;
using TechnicService.Core.Service;

namespace TechnicService.Forms
{
    public partial class FrmProductList : Form
    {
        public FrmProductList()
        {
            InitializeComponent();
        }

        private TechnicServiceEntities _entities = new TechnicServiceEntities();
        UsdService _usdService = new UsdService();
        public void ProductList()
        {
            var sa = _entities.Products.Select(d => d.Purchase).ToList();
            foreach (var index in sa)
            {
                var ass = index.ToString("C");
                
            }
            var usd = _usdService.Usd();
            
            
            var values = _entities.Products.AsEnumerable().Select(x=>new
               
                {
                    x.Id,
                    Ürün = x.Name.ToString(),
                    Marka = x.Brand,
                    Kategori = x.Category.Name,
                    AlışFiyatı = x.Purchase.ToString("C",new CultureInfo("en-Us")),
                    SatışFiyatı = (x.SalesPrice * usd).ToString("C"),
                    Stok = x.stock,
                    Barkod = x.BarcodeNo,
                    Cari = x.Customers.FirstName,
                    Durum = x.Status ? "Stokta var" : "Stokta yok"
                });
            gridControl1.DataSource = values.ToList();

           
        }

        void CountOfPurchase()
        {
            if (_entities.Products.Count()>0)
            {
                lblPurches.Text = _entities.Products.Sum(x => x.Purchase).ToString("##,##") + "$";
            }
        }

        void CountOfExpenses()
        {

            if (_entities.Products.Count() > 0)
            {
                lblExpenses.Text = _entities.Products.Sum(x => x.SalesPrice).ToString("##,##") + "$";
                
            }
        }
        void CountOfStock()
        {

            if (_entities.Products.Count() > 0)
            {
                lblStockCount.Text = _entities.Products.Sum(x => x.stock)+ " Adet";
            }
  
        }
        void CountOutOfStock()
        {

            if (_entities.Products.Count() > 0)
            {
                lblOutOfStock.Text = _entities.Products.Count(x=>x.stock<=0) + " Adet";
            }

            
        }

        private void FrmProductList_Load(object sender, EventArgs e)
        {
            if (_entities.Products.Count()==0)
            {
                btnDelete.Enabled = false;
            }
            CountOfPurchase();
            CountOfExpenses();
            CountOfStock();
            CountOutOfStock();
            ProductList();
            lblUsd.Text = "USD/TL: " + _usdService.Usd().ToString("C");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Ürünü silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            try
            {

                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id").ToString());
                    var product = _entities.Products.Find(id);
                    _entities.Products.Remove(product);
                    _entities.SaveChanges();
                    ProductList();

                    MessageBox.Show(product.Name + " Ürünü başarıyla silindi", "Bilgi", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (DbUpdateException exception)
            {
                MessageBox.Show("Veri güvenliği sebebi ile bu ürün silinemez.", "Uyarı", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

    }
}
