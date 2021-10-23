using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.ODataLinq.Helpers;

namespace TechnicService.Forms
{
    public partial class FrmMalfunction : Form
    {
        public FrmMalfunction()
        {
            InitializeComponent();
        }

        TechnicServiceEntities _entities = new TechnicServiceEntities();
        Malfunctions malfunctions = new Malfunctions();

        void MalfunctionList()
        {
            var values = from x in _entities.Malfunctions
                select new
                {
                    Müşteri =x.CustomerFirstName+" "+x.CustomerLastName,
                    Telefon =x.CustomerPhone,
                    Ürün = x.Title,
                    Sorun = x.Problem,
                    Açıklama = x.Description,
                    İşlem = x.Process,
                    Fiyat = x.Price,
                    Durum = x.Status ? "Teslim Edildi" : "Teslim edilmedi"
                };
            dtList.DataSource = values.ToList();
        }
        private void FrmMalfunction_Load(object sender, EventArgs e)
        {
            MalfunctionList();
            grpAdd.Visible = false;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            
            pnlList.Visible = true;
            grpAdd.Visible = false;
            MalfunctionList();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            pnlList.Visible = false;
            grpAdd.Visible = true;
        }

        private void btnAddMalfunction_Click(object sender, EventArgs e)
        {

            //if (txtTitle.Text == "")
            //{
            //    errorProvider1.SetError(txtTitle, "Bu alan boş geçilemez");
            //}
            //else if (txtProblem.Text == "")
            //{
            //    errorProvider1.SetError(txtProblem, "Bu alan boş geçilemez");
            //}
            //else if (txtDescription.Text == "")
            //{
            //    errorProvider1.SetError(txtDescription, "Bu alan boş geçilemez");
            //}
            //else if (txtProcess.Text == "")
            //{
            //    errorProvider1.SetError(txtProcess, "Bu alan boş geçilemez");
            //}
            //else if (txtFirstName.Text == "")
            //{
            //    errorProvider1.SetError(txtProcess, "Bu alan boş geçilemez");
            //}
            //else if (txtLastName.Text == "")
            //{
            //    errorProvider1.SetError(txtProcess, "Bu alan boş geçilemez");
            //}
            //else if (txtPhone.Text == "")
            //{
            //    errorProvider1.SetError(txtProcess, "Bu alan boş geçilemez");
            //}

            if (textEdit1.Text == "" && txtProblem.Text == "" && txtDescription.Text == "" && txtProcess.Text == "" &&
                txtFirstName.Text == "" && txtLastName.Text == "" && txtPhone.Text == "")
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                 DialogResult dialogResult;
                dialogResult = MessageBox.Show("Eklemeyi onaylıyor musunuz?", "UYARI", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    malfunctions.Title = textEdit1.Text;
                    malfunctions.Problem = txtProblem.Text;
                    malfunctions.Description = txtDescription.Text;
                    malfunctions.Price=Convert.ToDecimal(txtPrice.Text);
                    malfunctions.Process = txtProcess.Text;
                    malfunctions.Status = false;
                    malfunctions.CustomerFirstName = txtFirstName.Text;
                    malfunctions.CustomerLastName = txtLastName.Text;
                    malfunctions.CustomerPhone = txtPhone.Text;
                    _entities.Malfunctions.Add(malfunctions);
                    _entities.SaveChanges();
                    MessageBox.Show("Ürün başarı ile Eklendi", "Başarılı", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }
    }
}
