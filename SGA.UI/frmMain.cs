using SGA.UI.UC;
using System;
using System.Windows.Forms;

namespace SGA.UI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent(); 
        }

        private void tsmItemQueryFromCasa_Click(object sender, EventArgs e)
        {
            ucQueryCasa usc = new ucQueryCasa();
            this.Controls.Add(usc);
            usc.Dock = DockStyle.Fill;
        }
    }
}
