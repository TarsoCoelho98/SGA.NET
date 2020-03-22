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
using SGA.DAL;
using Microsoft.Office.Interop.Excel;


namespace SGA.UI.UC
{
    public partial class ucQueryCasa : UserControl
    {
        private static string charLimitLog = "O limite de caracteres foi excedido em um ou mais campos.";
        public ucQueryCasa()
        {
            InitializeComponent();
            Search();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            mtbId.Focus();
        }

        private void ClearFields()
        {
            mtbId.Text = string.Empty;
            mtbBairro.Text = string.Empty;
            mtbCidade.Text = string.Empty;
            mtbCEP.Text = string.Empty;
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            Search();
            mtbId.Focus();
        }

        private bool CanQuery(string bairro, string cidade)
        {
            if (bairro.Length > 150 || cidade.Length > 100)
            {
                MessageBox.Show(charLimitLog, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
                return true;
        }

        private void Search()
        {
            List<Casa> casas = new List<Casa>();

            string cepFormat = mtbCEP.Text.Replace("-", "").Replace(" ", "").Trim();
            string id = mtbId.Text.Trim();

            if (CanQuery(mtbBairro.Text, mtbCidade.Text))
            {
                try
                {
                    casas = CasaBusiness.QueryAll(id, mtbCidade.Text.Trim(), mtbBairro.Text.Trim(), cepFormat);
                    lblCount.Text = casas.Count().ToString();

                    dgvCasa.DataSource = casas;
                    mtbId.Focus();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Ocorreu um erro pesquisar. Erro: " + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void dgvCasa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == columnEditar.Index && e.RowIndex > -1)
            {
                var casa = (Casa)dgvCasa.Rows[e.RowIndex].DataBoundItem;

                frmUpdateCasa frm = new frmUpdateCasa(casa);
                frm.ShowDialog();
                Search();
            }

            if (e.ColumnIndex == columnRemover.Index && e.RowIndex > -1)
            {
                var casa = (Casa)dgvCasa.Rows[e.RowIndex].DataBoundItem;

                DialogResult result = MessageBox.Show("Ao remover este item, todos os quartos e locatários associados a ele serão removidos. Tem certeza de que deseja remover?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (result.Equals(DialogResult.Yes))
                {
                    string table = "Casa";

                    try
                    {
                        CommonBusiness.DeleteAllForeignKeyReferences(table, casa.IdCasa);
                        CasaBusiness.Delete(casa.IdCasa);
                        Search();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro deletar. Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void ExtractToExcel()
        {
            KeyValuePair<bool, string> keyValue = CommonBusiness.ExtractToExcel(dgvCasa);

            if (keyValue.Key.Equals(false))
                MessageBox.Show("Ocorreu um erro exportar para excel. Erro: " + keyValue.Value, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            mtbId.Focus();
            ExtractToExcel();
        }
    }
}
