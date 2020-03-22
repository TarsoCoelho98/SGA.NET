using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGA.DAL.Entity;
using SGA.UI.UC;

namespace SGA.UI
{
    public partial class frmUpdateLocatario : Form
    {
        public frmUpdateLocatario(Locatario loc)
        {
            InitializeComponent();

            ucUpdateLocatario uc = new ucUpdateLocatario(loc);
            this.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }
    }
}
