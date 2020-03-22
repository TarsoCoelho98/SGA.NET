using SGA.DAL.Entity;
using SGA.DAL.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGA.UI
{
    public partial class frmLoad : Form
    {
        public string Racf { get; set; }

        public frmLoad(string racf)
        {
            InitializeComponent();
            Racf = racf;
        }

        public void CallNextForm()
        {
            frmMain frm = new frmMain(Racf);

            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            if (pbLoading.Value < 100)
                pbLoading.Value += 2;
            else
            {
                timerLoading.Enabled = false;
                CallNextForm();
            }
        }

    }
}
