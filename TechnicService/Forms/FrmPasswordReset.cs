using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnicService.Forms
{
    public partial class FrmPasswordReset : Form
    {
        public FrmPasswordReset()
        {
            InitializeComponent();
        }
        
        TechnicServiceEntities _entities = new TechnicServiceEntities();
        private Login _login = new Login();

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked)
            {
                txtPassword.Properties.PasswordChar = '\0';
            }

            else
            {
                txtPassword.Properties.PasswordChar = '●';
            }
        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit2.Checked)
            {
                txtPassword2.Properties.PasswordChar = '\0';
            }

            else
            {
                txtPassword2.Properties.PasswordChar = '●';
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length>5)
            {
                if (txtPassword.Text != "123456")
                {
                    if (txtPassword.Text == txtPassword2.Text)
                    {
                        var user = _entities.Users.First(x => x.Id == 1);
                        user.Password = txtPassword.Text;
                        _entities.SaveChanges();
                        MessageBox.Show("Parola güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();;
                    }
                    else
                    {
                        MessageBox.Show("Şifreler eşlemiyor. Lütfen tekrar deneyin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen daha güçlü bir parola giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("En az 6 karakter girmelisiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
