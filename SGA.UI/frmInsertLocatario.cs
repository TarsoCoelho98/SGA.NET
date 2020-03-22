using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGA.UI.UC;


namespace SGA.UI
{
    public partial class frmInsertLocatario : Form
    {
        public frmInsertLocatario(string racf)
        {
            InitializeComponent();
            ucInsertLocatario uc = new ucInsertLocatario(racf);

            this.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }
    }
}
