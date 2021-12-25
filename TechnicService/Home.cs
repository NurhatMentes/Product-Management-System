using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.ReportServer.ServiceModel.ConnectionProviders;
using DevExpress.XtraBars;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using TechnicService.Core.Service;
using TechnicService.Forms;


namespace TechnicService
{
    public partial class Home : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        FrmProductList frmProductList;
        FrmMalfunction frmMalfunction;
        FrmProductUpdate update;
        FrmProductAdd add;
        FrmExpenses expenses;
        FrmStatistic statistic;
        FrmStatistickMounthSell mounlyStatistic;
        FrmStatistickAnnualSalesAndAverage annualStatistic;
        FrmCustomerAdd frmCustomer;
        FrmCustomerList frmCustomerList;
        FrmCustomerUpdate frmCustomerUpdate; 
        Login _login = new Login();
        private int timer = 0;



        public Home()
        {
            InitializeComponent();
        }


        private void btnMalfunctions_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            frmMalfunction = new FrmMalfunction();
            frmMalfunction.MdiParent = this;
            frmMalfunction.Show();

        }

        private void btnCategoryAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCategoryAdd categoryAdd = new FrmCategoryAdd();
            categoryAdd.Show();
        }

        private void btnCategoryDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCategoryDelete categoryDelete = new FrmCategoryDelete();
            categoryDelete.Show();
        }

        private void btnCategoryUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCategoryUpdate categoryUpdate = new FrmCategoryUpdate();
            categoryUpdate.Show();
        }

        private void btnProducts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            barProductAdd.Visibility = BarItemVisibility.Always;
            barProductUpdate.Visibility = BarItemVisibility.Always;

            frmProductList = new FrmProductList();
            frmProductList.MdiParent = this;
            frmProductList.Show();


            frmProductList.MdiParent.Show();
            frmProductList.ProductList();
        }

        private void barProductUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {

            update = new FrmProductUpdate();
            update.MdiParent = this;
            update.Show();

        }

        private void barProductAdd_ItemClick(object sender, ItemClickEventArgs e)
        {

            add = new FrmProductAdd();
            add.MdiParent = this;
            add.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            DiskBackup backup = new DiskBackup();
            frmProductList = new FrmProductList();
            frmProductList.MdiParent = this;
            frmProductList.Show();
            

            //---------------Database backup---------------

            var drive = System.IO.Directory.Exists(@"C:\"); 
           var drive2 = System.IO.Directory.Exists(@"D:\");

           if (drive)
            {
                backup.BackupByDisk("C");
            }
            if (drive2)
            {
                backup.BackupByDisk("D");
            }

        }

       

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            expenses = new FrmExpenses();
            expenses.MdiParent = this;
            expenses.Show();

        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            statistic = new FrmStatistic();
            statistic.MdiParent = this;
            statistic.Show();

        }

        private void barMounthSell_ItemClick(object sender, ItemClickEventArgs e)
        {
            mounlyStatistic = new FrmStatistickMounthSell();
            mounlyStatistic.MdiParent = this;
            mounlyStatistic.Show();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (DateTime.Now.Year>=2023)
            {
                annualStatistic = new FrmStatistickAnnualSalesAndAverage();
                annualStatistic.MdiParent = this;
                annualStatistic.Show();
            }
            else
            {
                MessageBox.Show("İstatistiğin gösterilmesi için yeterli veri bulunamadı.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void barReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            Report report = new Report();
            report.Show();
        }

        private void barcCustormer_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCustomerList = new FrmCustomerList();
            frmCustomerList.MdiParent = this;
            frmCustomerList.Show();
            frmCustomerList.CustomerList();
            barCustomerAdd.Visibility = BarItemVisibility.Always;
            barCustomerUpdate.Visibility = BarItemVisibility.Always;
        }

        private void barCustomerAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCustomer = new FrmCustomerAdd();
            frmCustomer.MdiParent = this;
            frmCustomer.Show();
        }

        private void barCustomerUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCustomerUpdate = new FrmCustomerUpdate();
            frmCustomerUpdate.MdiParent = this;
            frmCustomerUpdate.Show();
        }

    }

    
}
