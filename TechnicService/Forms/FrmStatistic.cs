using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Linq.Helpers;
using DevExpress.Data.ODataLinq.Helpers;
using DevExpress.Utils.Extensions;
using DevExpress.XtraCharts;

namespace TechnicService.Forms
{
    public partial class FrmStatistic : Form
    {
        public FrmStatistic()
        {
            InitializeComponent();
        }
        
        private TechnicServiceEntities _entities = new TechnicServiceEntities();

        private void FrmStatistic_Load(object sender, EventArgs e)
        {
            var values = from x in _entities.Expenses
                select new
                {
                    x.Id,
                    Ürün = x.Products.Name,
                    Marka = x.Products.Brand,
                    Fiyat = x.Price,
                    Adet = x.Quantity,
                    SatışTarihi = x.Date
                };
            gridControl1.DataSource = values.ToList();

            //var maxPriceProducts = _entities.Products.SqlQuery("select Brand, Name from Products where SalesPrice = (SELECT MAX(SalesPrice) FROM Products)");
            var maxPriceProducts2 = _entities.Products.Max(x => x.SalesPrice);
            var maxPriceProducts = _entities.Products.Where(x=>x.SalesPrice >= maxPriceProducts2).Select(x=>x.Name).FirstOrDefault();
           
            var minPriceProducts = _entities.Products.Min(x => x.SalesPrice);
            var minPriceProducts2 = _entities.Products.Where(x => x.SalesPrice <= minPriceProducts).Select(x => x.Name).FirstOrDefault();


            var verySalesProducts = _entities.Expenses.Max(x => x.Quantity);
            var verySalesProducts2 = _entities.Expenses.Where(x => x.Quantity >= verySalesProducts).Select(x => x.Products.Name).FirstOrDefault();

            lblMaxPriceProduct.Text = maxPriceProducts + " - " + maxPriceProducts2 + " ₺" + "\n";
            lblMinPriceProduct.Text = minPriceProducts2 + " - " + minPriceProducts + " ₺" + "\n";
            lblVeryExpensesProduct.Text = verySalesProducts2 + " - " + verySalesProducts +" Adet"+ "\n";

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
