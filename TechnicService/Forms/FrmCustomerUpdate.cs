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
    public partial class FrmCustomerUpdate : DevExpress.XtraEditors.XtraForm
    {
        public FrmCustomerUpdate()
        {
            InitializeComponent();
        }

        private TechnicServiceEntities _entities = new TechnicServiceEntities();
        void CategorySelection()
        {
            cbxCustomer.Properties.DataSource = (from x in _entities.Customers
                select new
                {
                  ÖzelKod =  x.Id,
                  UnvanAd = x.FirstName
                }).ToList();
        }

        void GetCustomer()
        {
            int customerId = Convert.ToInt32(cbxCustomer.EditValue);
            if (customerId > 0)
            {
                var customer = _entities.Customers.Find(customerId);
                txtFirstName.Text = customer.FirstName;
                if (customer.LastName!="")
                {
                    txtLastName.Text = customer.LastName;
                }

                txtPhone.Text = customer.Phone;
                txtMail.Text = customer.Mail;
                if (customer.Website!="")
                {
                    txtWebsite.Text = customer.Website;
                }

                if (customer.TaxAdministration!="")
                {
                    txtTaxAdministration.Text = customer.TaxAdministration;
                }

                txtTaxNo.Text = customer.TaxNo;
                if (customer.Adress!="")
                {
                    txtAdress.Text = customer.Adress;
                }
                if (customer.District != "")
                {
                    txtDistrict.Text = customer.District;
                }
                if (customer.Province != "")
                {
                    txtProvince.Text = customer.Province;
                }

                if (customer.Status ==false)
                {
                    chcxStatus.Checked = true;
                }
                else
                {
                    chcxStatus.Checked = false;
                }

            }
        }
        
        private void FrmCustomerUpdate_Load(object sender, EventArgs e)
        {
            CategorySelection();
            
        }

        private void cbxCustomer_EditValueChanged(object sender, EventArgs e)
        {
            GetCustomer();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;

            if (txtFirstName.Text != "" && txtPhone.Text != "" && txtMail.Text != "")
            {
                var message = MessageBox.Show("Güncellemek istediğinize emin misini?", "Soru", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (message==DialogResult.Yes)
                {
                    int id = Int32.Parse(cbxCustomer.EditValue.ToString());
                    var customer = _entities.Customers.Find(id);
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
                    customer.Status = !chcxStatus.Checked;


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

                    MessageBox.Show("Cari kart güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("Zorunlu alanları doldurunuz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
