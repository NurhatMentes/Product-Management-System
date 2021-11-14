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
    public partial class FrmCategoryUpdate : Form
    {
        public FrmCategoryUpdate()
        {
            InitializeComponent();
        }

        private TechnicServiceEntities _entities = new TechnicServiceEntities();

        void CategorySelection()
        {
            cbxCategory.Properties.DataSource = (from x in _entities.Category select new
                {
                    x.Id,
                    x.Name

                }).ToList();
        }

        private void FrmCategoryUpdate_Load(object sender, EventArgs e)
        {
            CategorySelection();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cbxCategory.Text != "")
            {
                int id = Int32.Parse(cbxCategory.EditValue.ToString());
                Category category = (from x in _entities.Category
                    where x.Id == id
                    select x).FirstOrDefault();
                category.Name = char.ToUpper(txtName.Text[0]).ToString() + txtName.Text.Substring(1);
                _entities.SaveChanges();

                CategorySelection();
                MessageBox.Show("Kategori güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Güncelleme Başarısız!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIgnore_Click(object sender, EventArgs e)
        {
            this.Close();;
        }
    }
}
