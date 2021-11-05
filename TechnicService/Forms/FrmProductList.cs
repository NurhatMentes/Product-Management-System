using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Filtering.Controls;
using DevExpress.XtraEditors.Repository;

namespace TechnicService.Forms
{
    public partial class FrmProductList : Form
    {
        public FrmProductList()
        {
            InitializeComponent();
        }

        private TechnicServiceEntities _entities = new TechnicServiceEntities();
        void ProductList()
        {
            var values = from x in _entities.Products
                select new
                {
                    x.Id,
                    Başlık = x.Name,
                    Marka = x.Brand,
                    Kategori = x.Category.Name,
                    AlışFiyatı = x.Purchase,
                    SatışFiyatı = x.SalesPrice,
                    Stok = x.stock,
                    Barkod = x.BarcodeNo,
                    Durum = x.Status ? "Stokta var" : "Stokta yok"
                };
            gridControl1.DataSource = values.ToList();
        }
        private void FrmProductList_Load(object sender, EventArgs e)
        {
            
            ProductList();
        }

       

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Ürünü silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            
            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id").ToString());
                var product = _entities.Products.Find(id);
                _entities.Products.Remove(product);
                _entities.SaveChanges();
                ProductList();

                MessageBox.Show(product.Name + "" + "Ürünü başarıyla silindi", "Bilgi",MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
           
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }
    }
}
