using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using TechnicService.Forms;

namespace TechnicService
{
    public partial class Login : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Login()
        {
            InitializeComponent();
        }

       
        Random rnd = new Random();
        public int code;

        public void SendMail()
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("starworkdestek@hotmail.com", "StarWork-IT");
            ePosta.Subject = "Güvenlik Kodu";
            try
            {
                ePosta.To.Add("info@mbselektronik.com");
                ePosta.Body = "Güvenliğiniz için kodu başkası ile paylaşmayınız.\n \n" + " Güvenlik Kodu: "+code;
                SmtpClient smtp = new SmtpClient();
                smtp.Credentials = new System.Net.NetworkCredential("starworkdestek@hotmail.com", "kvasirstarwork2021");
                smtp.Port = 587;              // smtp 25 veya 587 portunu kullanır.
                smtp.Host = "smtp-mail.outlook.com";  // gmail için: smtp.gmail.com, outlook için: smtp-mail.outlook.com
                smtp.EnableSsl = true;       // true/false değerlerlerinden birini alır.
                smtp.Send(ePosta);
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        private void Login_Load(object sender, EventArgs e)
        {
            txtPassword.Properties.PasswordChar='●';
            code = rnd.Next(123456, 987654);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
             TechnicServiceEntities _entities = new TechnicServiceEntities();
        Home _home=new Home();
            var user = _entities.Users.Any(x => x.Mail == txtEmail.Text && x.Password == txtPassword.Text);

            if (user)
            {
                _home.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Giriş başarısız. Lütfen bilgilerinizi kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblForgetPassword_Click(object sender, EventArgs e)
        {
           SendMail();
           MessageBox.Show("Lütfen E-Postanıza gelen güvenlik kodunu giriniz","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            FrmForgetPassword frmForgetPassword = new FrmForgetPassword();
            frmForgetPassword.code2 = code;
            frmForgetPassword.Show();
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked)
            {
                //karakteri göster.
                txtPassword.Properties.PasswordChar = '\0';
            }
      
            else
            {
                txtPassword.Properties.PasswordChar = '●';
            }
        }
    }
}
