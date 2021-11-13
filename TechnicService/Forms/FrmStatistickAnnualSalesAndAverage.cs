using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace TechnicService.Forms
{
    public partial class FrmStatistickAnnualSalesAndAverage : Form
    {
        public FrmStatistickAnnualSalesAndAverage()
        {
            InitializeComponent();
        }


        private TechnicServiceEntities _entities = new TechnicServiceEntities();



        void MonthlyTotalIncomeChart()
        {
            DateTime start = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day).AddMonths(-1);
            DateTime end = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 29);
            DateTime lastYear = new DateTime(DateTime.Now.AddYears(-1).Year, DateTime.Today.Month, 29);
            DateTime year = new DateTime(DateTime.Now.Year, DateTime.Today.Month, DateTime.Today.Day);


            var thisYearPrice = _entities.Expenses.Where(x => x.Date >= lastYear).Sum(x => x.Price);
            var lastYearPrice = _entities.Expenses.Where(x => x.Date <= lastYear).Sum(x => x.Price);
            var average1 = _entities.Expenses.Where(x => x.Date >= lastYear).Average(x => x.Price);
            var average2 = _entities.Expenses.Where(x => x.Date <= year).Average(x => x.Price);


            Series series1 = new Series(DateTime.Now.AddYears(-1).Year.ToString(), ViewType.Bar);
            Series series2 = new Series(DateTime.Now.Year.ToString(), ViewType.Bar);
            Series series3 = new Series(DateTime.Now.Year + " ortalaması", ViewType.Spline);
            Series series4 = new Series(DateTime.Now.AddYears(-1).Year + " ortalaması", ViewType.Spline);


            for (int i = 2020; i < 2022; i++)
            {
                series1.Points.Add(new SeriesPoint(i, thisYearPrice));
                series2.Points.Add(new SeriesPoint( i, lastYearPrice));
                series3.Points.Add(new SeriesPoint(i, average1));
                series4.Points.Add(new SeriesPoint(i, average2));
            }

            //series1.Points.Add(new SeriesPoint(series1, thisYearPrice));
            //series2.Points.Add(new SeriesPoint(series2, lastYearPrice));
            //series3.Points.Add(new SeriesPoint(series1, average1));
            //series4.Points.Add(new SeriesPoint(series2, average2));


            chartControl1.Series.Add(series1);
            chartControl1.Series.Add(series2);
            chartControl1.Series.Add(series3);
            chartControl1.Series.Add(series4);

            chartControl1.Dock = DockStyle.Fill;
            ((BarSeriesView)series1.View).FillStyle.FillMode = FillMode.Hatch;
            ((BarSeriesView)series2.View).FillStyle.FillMode = FillMode.Hatch;

            ((SplineSeriesView)series3.View).Color = Color.White;
            ((SplineSeriesView)series3.View).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;

            ((SplineSeriesView)series4.View).Color = Color.Red;
            ((SplineSeriesView)series4.View).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;


            ChartTitle chartTitle1 = new ChartTitle();
            chartTitle1.Text = "Yıllık Satış ve Ortalama Raporu";
            chartTitle1.WordWrap = true;
            chartControl1.Titles.Add(chartTitle1);

            this.Controls.Add(chartControl1);
        }


        private void FrmStatistickAnnualSalesAndAverage_Load(object sender, EventArgs e)
        {
            MonthlyTotalIncomeChart();
        }
    }
}
