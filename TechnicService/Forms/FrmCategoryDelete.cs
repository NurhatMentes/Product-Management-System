using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace TechnicService.Forms
{
    public partial class FrmCategoryDelete : Form
    {
        public FrmCategoryDelete()
        {
            InitializeComponent();
        }

        private TechnicServiceEntities _entities = new TechnicServiceEntities();
        void CombobxoCategory()
        {
            cbxCategory.Properties.DataSource = (from x in _entities.Category
                select new
                {
                    x.Id,
                    x.Name

                }).ToList();
        }
        private void FrmCategoryDelete_Load(object sender, EventArgs e)
        {
            CombobxoCategory();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cbxCategory.Text !="")
            {

                int id = Int32.Parse(cbxCategory.EditValue.ToString());
                var category = _entities.Category.Find(id);
                _entities.Category.Remove(category);
                _entities.SaveChanges();
                //Category category =
                //    _entities.Category.Single(category1 => category1.Id == id);

                MessageBox.Show("Kategori silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Silme Başarısız!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIgnore_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
