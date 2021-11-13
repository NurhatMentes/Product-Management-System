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
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Customization;
using DevExpress.XtraGrid.Views.Grid;

namespace TechnicService.Forms
{
    public partial class FrmMalfunction : Form
    {
        public FrmMalfunction()
        {
            InitializeComponent();
        }

        TechnicServiceEntities _entities = new TechnicServiceEntities();
        Malfunctions _malfunctions = new Malfunctions(); 
        MalfunctionUpdate _malfunctionUpdate = new MalfunctionUpdate();
        


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
                    Durum = x.Status ? "Teslim Edildi"  : "Teslim edilmedi" 
                };
            dtList.DataSource = values.ToList();

            //foreach (DataGridViewRow row in dtList.BackColor)
            //{
            //    if (row.Cells[5].Value.ToString() == "Pasif")
            //    {
            //        row.DefaultCellStyle.BackColor = Color.Red;
            //    }
            //}
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

                    _malfunctions.Title = char.ToUpper(textEdit1.Text[0]).ToString()+ textEdit1.Text.Substring(1);
                    _malfunctions.Problem = char.ToUpper(txtProblem.Text[0]).ToString() + txtProblem.Text.Substring(1);
                    _malfunctions.Description = char.ToUpper(txtDescription.Text[0]).ToString() + txtDescription.Text.Substring(1);
                    _malfunctions.Price=Convert.ToDecimal(txtPrice.Text);
                    _malfunctionUpdate.Process = char.ToUpper(txtProcess.Text[0]).ToString() + txtProcess.Text.Substring(1);
                    _malfunctions.Status = false;
                    _malfunctions.CustomerFirstName = char.ToUpper(txtFirstName.Text[0]).ToString() + txtFirstName.Text.Substring(1);
                    _malfunctions.CustomerLastName = char.ToUpper(txtLastName.Text[0]).ToString() + txtLastName.Text.Substring(1);
                    _malfunctions.CustomerPhone = char.ToUpper(txtPhone.Text[0]).ToString() + txtPhone.Text.Substring(1);
                    _malfunctions.SerialNo = rnd1.ToString() + rnd2 + rnd3 + rnd4;
                    _malfunctionUpdate.SerialNo = rnd1.ToString() + rnd2 + rnd3 + rnd4;
                    _entities.MalfunctionUpdate.Add(_malfunctionUpdate);
                    _entities.Malfunctions.Add(_malfunctions);
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
            _malfunctionUpdate.SerialNo = cbxSerialNo.EditValue.ToString();
            _malfunctionUpdate.Process = txtProcessUptade.Text;
            _entities.MalfunctionUpdate.Add(_malfunctionUpdate);

            if (check.Checked)
            {
                Malfunctions malfunctions = (from malfunction in _entities.Malfunctions
                    where malfunction.SerialNo == _malfunctionUpdate.SerialNo
                    select malfunction).SingleOrDefault();
                malfunctions.Status = true;
            }

            _entities.SaveChanges();

            MessageBox.Show("Ürün başarı ile Güncellendi", "Başarılı", MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);
        }

        private void dtList_MouseDown(object sender, MouseEventArgs e)
        {
            FrmProsess frmProsess = new FrmProsess();
            string id = grdMalfunction.GetFocusedRowCellValue("SerialNo").ToString();

            frmProsess.malfunctionSerialNo = id;
            frmProsess.Show();
        }

        private void dtList_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                GridView View = sender as GridView;
                if (e.Column.FieldName == "SiparisHareket")
                {
                    bool value = Convert.ToBoolean(View.GetRowCellDisplayText(e.RowHandle, "Aktif"));
                    // "Aktif" yerine kolon kullanabilirsiniz. View.Columns[1]
                    if (value)
                        e.Appearance.BackColor = Color.Green;
                    else
                    {
                        value = Convert.ToBoolean(View.GetRowCellDisplayText(e.RowHandle, "Pasif"));
                        // "Pasif" yerine kolon kullanabilirsiniz. View.Columns[2]
                        if (value)
                            e.Appearance.BackColor = Color.Red;
                    }
                }
            }
        }
    }
}
