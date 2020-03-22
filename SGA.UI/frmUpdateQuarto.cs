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
using SGA.DAL.Entity;

namespace SGA.UI
{
    public partial class frmUpdateQuarto : Form
    {
        public frmUpdateQuarto(Quarto quarto)
        {
            InitializeComponent();

            ucUpdateQuarto uc = new ucUpdateQuarto(quarto);
            this.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }
    }
}
