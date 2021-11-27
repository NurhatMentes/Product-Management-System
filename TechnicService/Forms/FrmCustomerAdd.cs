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
    public partial class FrmCustomerAdd : DevExpress.XtraEditors.XtraForm
    {
        public FrmCustomerAdd()
        {
            InitializeComponent();
        }

        private TechnicServiceEntities _entities = new TechnicServiceEntities();

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text != "" && txtPhone.Text != "" && txtMail.Text != "")
            {
                Customers customer = new Customers();
                customer.FirstName = char.ToUpper(txtFirstName.Text[0]) + txtFirstName.Text.Substring(1);
                if (txtLastName.Text != "")
                {
                    customer.LastName = char.ToUpper(txtLastName.Text[0]) + txtLastName.Text.Substring(1);
                }
                if (txtAdress.Text != "")
                {
                    customer.Adress = char.ToUpper(txtAdress.Text[0]) + txtAdress.Text.Substring(1);
                }
                if (txtDistrict.Text != "")
                {
                    customer.District = char.ToUpper(txtDistrict.Text[0]) + txtDistrict.Text.Substring(1);
                }
                if (txtProvince.Text != "")
                {
                    customer.Province = char.ToUpper(txtProvince.Text[0]) + txtProvince.Text.Substring(1);
                }
                if (txtTaxAdministration.Text != "")
                {
                    customer.TaxAdministration = char.ToUpper(txtTaxAdministration.Text[0]) + txtTaxAdministration.Text.Substring(1);
                }
                customer.Phone = char.ToUpper(txtPhone.Text[0]) + txtPhone.Text.Substring(1);
                customer.Mail = char.ToUpper(txtMail.Text[0]) + txtMail.Text.Substring(1);
                customer.TaxNo = txtTaxNo.Text;
                customer.Website = txtWebsite.Text;
                customer.Status = true;

                _entities.Customers.Add(customer);
                _entities.SaveChanges();

                txtFirstName.Text = "";
                txtPhone.Text = "";
                txtMail.Text = "";
                txtLastName.Text = "";
                txtAdress.Text = "";
                txtDistrict.Text = "";
                txtProvince.Text = "";
                txtTaxNo.Text = "";
                txtTaxAdministration.Text = "";
                txtWebsite.Text = "";

                MessageBox.Show("Cari kart eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Zorunlu alanları doldurunuz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
