using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraDiagram.Bars;
using DevExpress.XtraRichEdit.Layout;

namespace TechnicService.Forms
{
    public partial class FrmCustomerList : DevExpress.XtraEditors.XtraForm
    {
        public FrmCustomerList()
        {
            InitializeComponent();
        }

        private TechnicServiceEntities _entities = new TechnicServiceEntities();
        public void CustomerList()
        {
            
            var customerList = from x in _entities.Customers
                select new
                {
                    Özel‏‏‏‏‏‏‏‏Kod = x.Id,
                    ÜnvanıAdı = x.FirstName,
                    ÜnvanıSoyad = x.LastName,
                    Telefon = x.Phone,
                    EPosta = x.Mail,
                    Website = x.Website,
                    VergiDairesiTC = x.TaxAdministration,
                    Şehir = x.Province,
                    İlçe = x.District,
                    Adres = x.Adress,
                    Bloke = x.Status ? "Aktif" : "Pasif"
                };
            gridControl1.DataSource = customerList.ToList();
        }

        private void FrmCustomerList_Load(object sender, EventArgs e)
        {
            CustomerList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Cari kaydı silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ÖzelKod").ToString());
                var customer = _entities.Customers.Find(id);
                _entities.Customers.Remove(customer);
                _entities.SaveChanges();
                CustomerList();

                MessageBox.Show(customer.FirstName + "" + "İsimli cari kayıt başarıyla silindi", "Bilgi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
