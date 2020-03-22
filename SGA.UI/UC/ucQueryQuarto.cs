using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGA.DAL.Enums;
using SGA.DAL;
using SGA.BLL;
using SGA.DAL.Entity;
using System.Globalization;

namespace SGA.UI.UC
{
    public partial class ucQueryQuarto : UserControl
    {

        private static string monetaryLog = "Forneça valores válidos nos campos monetários para consulta."; 
        private static string floatingPointLimitLog = "Os campos monetários aceitam, no máximo, duas casas decimais. Forneça um valor válido para consulta.";

        public ucQueryQuarto()
        {
            InitializeComponent();
            InitializeFields();
            Search();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            mtbId.Focus();
        }

        public void FillComboBox()
        {
            List<string> combo = new List<string>() { "Todos" };
            combo.AddRange(CommonBusiness.EnumToList<StatusQuarto>());
            cbStatus.DataSource = combo;
        }

        public void InitializeFields()
        {
            FillComboBox();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
            mtbId.Focus();
        }

        private void ClearFields()
        {
            mtbId.Text = string.Empty;
            mtbAluguel.Text = string.Empty;
            mtbCasa.Text = string.Empty;
            mtbCalcao.Text = string.Empty;
            cbStatus.SelectedItem = cbStatus.Items[0];
        }

        private bool CanQuery(string aluguel, string calcao)
        {
            decimal result;

            if (calcao.Length > 12 || aluguel.Length > 12)
            {
                MessageBox.Show(monetaryLog, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!string.IsNullOrEmpty(aluguel) && !decimal.TryParse(aluguel, out result))
            {
                MessageBox.Show(monetaryLog, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!string.IsNullOrEmpty(calcao) && !decimal.TryParse(calcao, out result))
            {
                MessageBox.Show(monetaryLog, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!string.IsNullOrEmpty(aluguel) && aluguel.Contains('.') && aluguel.Split('.')[1].Length > 2)
            {
                MessageBox.Show(floatingPointLimitLog, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!string.IsNullOrEmpty(calcao) && calcao.Contains('.') && calcao.Split('.')[1].Length > 2)
            {
                MessageBox.Show(floatingPointLimitLog, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
                return true;
        }


        private void Search()
        {
            string aluguelFormat = mtbAluguel.Text.Replace(",", ".").Trim();
            string calcaoFormat = mtbCalcao.Text.Replace(",", ".").Trim();
            string id = mtbId.Text.Trim();
            string casa = mtbCasa.Text.Trim();
            string status = cbStatus.SelectedItem.ToString().Trim();

            if (status.Equals("Todos"))
                status = string.Empty;

            if (CanQuery(aluguelFormat, calcaoFormat))
            {
                try
                {
                    List<Quarto> quartos = new List<Quarto>();
                    quartos = QuartoBusiness.QueryAll(id, aluguelFormat, calcaoFormat, casa, status);

                    lblCount.Text = quartos.Count().ToString();
                    dgvQuarto.DataSource = quartos;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Ocorreu um erro pesquisar. Erro: " + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvQuarto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == columnEditar.Index && e.RowIndex > -1)
            {
                var quarto = (Quarto)dgvQuarto.Rows[e.RowIndex].DataBoundItem;

                frmUpdateQuarto frm = new frmUpdateQuarto(quarto);
                frm.ShowDialog();
                Search();
            }

            if (e.ColumnIndex == columnRemover.Index && e.RowIndex > -1)
            {
                var quarto = (Quarto)dgvQuarto.Rows[e.RowIndex].DataBoundItem;

                DialogResult result = MessageBox.Show("Ao remover este item, todos os locatários associados a ele serão removidos. Tem certeza de que deseja remover?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (result.Equals(DialogResult.Yes))
                {
                    string table = "Quarto";

                    try
                    {
                        CommonBusiness.DeleteAllForeignKeyReferences(table, quarto.IdQuarto);
                        QuartoBusiness.Delete(quarto.IdQuarto);
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
            KeyValuePair<bool, string> keyValue = CommonBusiness.ExtractToExcel(dgvQuarto);

            if (keyValue.Key.Equals(false))
                MessageBox.Show("Ocorreu um erro exportar para excel. Erro: " + keyValue.Value, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            mtbId.Focus();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            mtbId.Focus();
            ExtractToExcel();
        }
    }
}
