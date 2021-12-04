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
    public partial class FrmStatistickMounthSell : Form
    {
        public FrmStatistickMounthSell()
        {
            InitializeComponent();
        }

        private TechnicServiceEntities _entities = new TechnicServiceEntities();

        void MonthlyProductSalesChart()
        {
            DateTime start = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day).AddMonths(-1);
            DateTime end = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 29);


            if (_entities.Expenses.Count()>0)
            {
                var price = _entities.Expenses.Where(x => x.Date >= start && x.Date <= end).Select(x => x.Price);
                var productName = _entities.Expenses.Where(x => x.Date >= start && x.Date <= end).Select(x => x.Products.Name);
                var date = _entities.Expenses.Where(x => x.Date >= start).Select(x => x.Date);
                var sumPrice = _entities.Expenses.Sum(x => x.Price);


                var priceList = price.ToList();
                var productNameList = productName.ToList();
                var dateList = date.ToList();

                for (int i = 0; i < price.Count(); i++)
                {
                    chartControl1.Series["Series 2"].Points.AddPoint(productNameList[i] + " " + dateList[i], Convert.ToInt32(priceList[i]));
                    // chartControl1.Series["Series 2"].Points.AddPoint(date[i].ToString(), Convert.ToInt32(price[i]));
                }

                lblSumPrice.Text = "Satılan ürünlerin toplam fiyatı (tüm zamanlar): " + sumPrice + "₺";
            }
        }

        private void FrmStatistickMounthSell_Load(object sender, EventArgs e)
        {
            MonthlyProductSalesChart();
        }
    }
}
