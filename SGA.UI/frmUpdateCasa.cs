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
    public partial class frmUpdateCasa : Form
    {
        public frmUpdateCasa(Casa casa)
        {
            InitializeComponent();

            ucUpdateCasa uc = new ucUpdateCasa(casa);
            this.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }
    }
}
