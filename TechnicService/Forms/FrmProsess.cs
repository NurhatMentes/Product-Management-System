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
    public partial class FrmProsess : Form
    {
        public string malfunctionSerialNo;
        TechnicServiceEntities _entities = new TechnicServiceEntities();
        Malfunctions malfunctions = new Malfunctions();
        public FrmProsess()
        {
            InitializeComponent();
        }

        private void FrmProsess_Load(object sender, EventArgs e)
        {

            var values = (from x in _entities.MalfunctionUpdate
                select new
                {
                    x.Id,
                    SeriNo = x.SerialNo,
                    İşlem = x.Process,
                }).Where(x=>x.SeriNo==malfunctionSerialNo);
            dtProsess.DataSource = values.ToList();

        }
    }
}
