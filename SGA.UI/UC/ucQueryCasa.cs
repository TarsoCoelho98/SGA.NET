using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGA.BLL;
using SGA.DAL.Entity;

namespace SGA.UI.UC
{
    public partial class ucQueryCasa : UserControl
    {
        public ucQueryCasa()
        {
            InitializeComponent();
            Search();
        } 

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {

            lblId.Text = string.Empty;
            lblBairro.Text = string.Empty;
            lblRua.Text = string.Empty;
            lblCep.Text = string.Empty;
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            char[] removeChars = new char[] {'-', ' '};

            string cep2 = mtbCep.Text.Trim(removeChars);

            int cep = string.IsNullOrEmpty(mtbCep.Text.Trim(removeChars)) ? 0 : Convert.ToInt32(mtbCep.Text.Trim(removeChars));
            int id = string.IsNullOrWhiteSpace(mtbId.Text) ? 0 : Convert.ToInt32(mtbId.Text);
          
            dgvCasa.DataSource = CasaBusiness.QueryAll(id, mtbRua.Text, mtbBairro.Text, cep);
        }
    }
}
