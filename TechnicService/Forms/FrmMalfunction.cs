using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.ODataLinq.Helpers;
using DevExpress.DataAccess.Native.Web;

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
        MalfunctionUpdate malfunctionUpdate = new MalfunctionUpdate();
        

        void MalfunctionList()
        {
            var values = from x in _entities.Malfunctions
                select new
                {
                    x.SerialNo,
                    Müşteri =x.CustomerFirstName+" "+x.CustomerLastName,
                    Telefon =x.CustomerPhone,
                    Ürün = x.Title,
                    Sorun = x.Problem,
                    Açıklama = x.Description,
                    Fiyat = x.Price,
                    Durum = x.Status ? "Teslim Edildi" : "Teslim edilmedi"
                };
            dtList.DataSource = values.ToList();
        }
        private void FrmMalfunction_Load(object sender, EventArgs e)
        {
            MalfunctionList();
            grpAdd.Visible = false;
            grpUpdate.Visible = false;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            
            pnlList.Visible = true;
            grpAdd.Visible = false;
            grpUpdate.Visible = false;

            MalfunctionList();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            pnlList.Visible = false;
            grpUpdate.Visible = false;
            grpAdd.Visible = true;

        }

        private void btnAddMalfunction_Click(object sender, EventArgs e)
        {
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
                    Random random = new Random();
                    int rnd1 = random.Next(100, 999);
                    int kod = random.Next(65, 91);
                    int kod2 = random.Next(65, 91);
                    int kod3 = random.Next(65, 91);
                    char rnd2 = Convert.ToChar(kod);
                    char rnd3 = Convert.ToChar(kod2);
                    char rnd4 = Convert.ToChar(kod3);

                    malfunctions.Title = textEdit1.Text;
                    malfunctions.Problem = txtProblem.Text;
                    malfunctions.Description = txtDescription.Text;
                    malfunctions.Price=Convert.ToDecimal(txtPrice.Text);
                    malfunctionUpdate.Process = txtProcess.Text;
                    malfunctions.Status = false;
                    malfunctions.CustomerFirstName = txtFirstName.Text;
                    malfunctions.CustomerLastName = txtLastName.Text;
                    malfunctions.CustomerPhone = txtPhone.Text;
                    malfunctions.SerialNo = rnd1.ToString() + rnd2 + rnd3 + rnd4;
                    malfunctionUpdate.SerialNo = rnd1.ToString() + rnd2 + rnd3 + rnd4;
                    _entities.MalfunctionUpdate.Add(malfunctionUpdate);
                    _entities.Malfunctions.Add(malfunctions);
                    try
                    {
                        _entities.SaveChanges();
                    }
                    catch (DbEntityValidationException ex)
                    {
                        foreach (var entityValidationErrors in ex.EntityValidationErrors)
                        {
                            foreach (var validationError in entityValidationErrors.ValidationErrors)
                            {
                               MessageBox.Show("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                            }
                        }
                    }
                    MessageBox.Show("Ürün başarı ile Eklendi", "Başarılı", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        void SerialNoSelection()
        {
            cbxSerialNo.Properties.DataSource = (from x in _entities.Malfunctions where x.Status==false
                select new
                {
                    x.SerialNo
                    
                }).ToList();
        }
        private void grdMalfunction_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            FrmProsess frmProsess = new FrmProsess();
            string id = grdMalfunction.GetFocusedRowCellValue("SerialNo").ToString();

            frmProsess.malfunctionSerialNo = id;
            frmProsess.Show();
        }

        private void grdMalfunction_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            pnlList.Visible = false;
            grpAdd.Visible = false;
            grpUpdate.Visible = true;

            SerialNoSelection();
        }

        private void btnUptated_Click(object sender, EventArgs e)
        {
            malfunctionUpdate.SerialNo = cbxSerialNo.EditValue.ToString();
            malfunctionUpdate.Process = txtProcessUptade.Text;
            _entities.MalfunctionUpdate.Add(malfunctionUpdate);

            if (check.Checked)
            {
                Malfunctions malfunctions = (from malfunction in _entities.Malfunctions
                    where malfunction.SerialNo == malfunctionUpdate.SerialNo
                    select malfunction).SingleOrDefault();
                malfunctions.Status = true;
            }

            _entities.SaveChanges();

            MessageBox.Show("Ürün başarı ile Güncellendi", "Başarılı", MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);
        }
    }
}
