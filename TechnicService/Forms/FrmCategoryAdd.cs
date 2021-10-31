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
    public partial class FrmCategoryAdd : Form
    {
        public FrmCategoryAdd()
        {
            InitializeComponent();
        }

        private TechnicServiceEntities _entities = new TechnicServiceEntities();
        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                Category category = new Category();
                category.Name =  char.ToUpper(txtName.Text[0]).ToString()+txtName.Text.Substring(1);
                _entities.Category.Add(category);
                _entities.SaveChanges();
            MessageBox.Show("Kategori başarı ile eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Doldurulmayan alanları doldurunuz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnIgnore_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
