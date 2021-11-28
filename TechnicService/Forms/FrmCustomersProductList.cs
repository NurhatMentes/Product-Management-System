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
    public partial class FrmCustomersProductList : DevExpress.XtraEditors.XtraForm
    {
        public FrmCustomersProductList()
        {
            InitializeComponent();
        }

        private TechnicServiceEntities _entities = new TechnicServiceEntities();
        public int customerId;

        void ProductList()
        {
            var values = (from x in _entities.Products
                where x.CustomerId == customerId
                select new
                {
                    x.Id,
                    ÜrünAdı = x.Name,
                    Marka = x.Brand,
                    AlışFiyatı = x.Purchase,
                    SatışFiyatı = x.SalesPrice,
                    StokAdet = x.stock
                });
            gridControl1.DataSource = values.ToList();
        }
        private void FrmCustomersProductList_Load(object sender, EventArgs e)
        {
            ProductList();
        }
    }
}
