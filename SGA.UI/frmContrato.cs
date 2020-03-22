using SGA.UI.UC;
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
    public partial class frmContrato : Form
    {
        public frmContrato(string racf, string email, string nome, string cpf)
        {
            InitializeComponent();

            ucContrato uc = new ucContrato(racf, email, nome, cpf);
            this.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void frmContrato_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show($"Tem certeza que deseja sair?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result.Equals(DialogResult.No))
            {
                e.Cancel = true;
            }
        }
    }
}
