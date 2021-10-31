using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using TechnicService.Forms;

namespace TechnicService
{
    public partial class Home : Form
    {
        private Forms.FrmMalfunction frmMalfunction;
        public Home()
        {
            InitializeComponent();
        }


      

        private void btnMalfunctions_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmMalfunction == null || frmMalfunction.IsDisposed)
            {
                frmMalfunction = new FrmMalfunction();
                frmMalfunction.MdiParent = this;
                frmMalfunction.Show();
            }
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
            FrmProductList frmProductList = new FrmProductList();
            frmProductList.MdiParent = this;
            frmProductList.Show();
        }

        private void barProductUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void barProductAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmProductAdd add = new FrmProductAdd();
            add.MdiParent = this;
            add.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            FrmProductList frmProductList = new FrmProductList();
            frmProductList.MdiParent = this;
            frmProductList.Show();
        }
    }
}
