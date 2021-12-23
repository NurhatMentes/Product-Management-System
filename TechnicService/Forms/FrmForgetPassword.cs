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
    public partial class FrmForgetPassword : Form
    {
        public FrmForgetPassword()
        {
            InitializeComponent();
        }

        int sec = 59;
        int min = 3;
        int minsec = 60;

        private FrmPasswordReset _passwordReset = new FrmPasswordReset();
        public int code2;

        private void FrmForgetPassword_Load(object sender, EventArgs e)
        {
            timer1.Start();
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            minsec--;
            if (minsec == 0)
            {
                sec--;
                minsec = 60;
                if (sec == 60)
                {
                    sec = 59;
                    min--;
                }

                if (min == 0)
                {
                    timer1.Stop();
                    btnSend.Enabled = false;
                }
            }

            lblTimer.Text = min + ":" + sec + ":" + minsec;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (code2==int.Parse(txtCode.Text))
            {
                _passwordReset.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hatalı kod girdiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
