using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGA.DAL.Entity;
using SGA.BLL;
using System.Globalization;
using SGA.DAL.Enums;

namespace SGA.UI.UC
{
    public partial class ucUpdateQuarto : UserControl
    {
        private static string monetaryLog = "Forneça valores válidos nos campos monetários para atualização.";
        private static string charLimitLog = "O limite de caracteres foi excedido em um ou mais campos.";
        private static string floatingPointLimitLog = "Os campos monetários aceitam, no máximo, duas casas decimais. Forneça um valor válido para inserção.";
        private static string fillRequiredFields = "Para atualizar, é necessário preencher pelo menos um dos campos com novos valores.";

        public Quarto Quarto { get; set; }

        public ucUpdateQuarto(Quarto quarto)
        {
            Quarto = quarto;
            InitializeComponent();
            InitializeFields();
        }

        public void InitializeFields()
        {
            List<string> combo = new List<string>();
            gbAtualizacao.Text += Quarto.IdQuarto.ToString() + " ";

            cbStatus.DataSource = CommonBusiness.EnumToList<StatusQuarto>();
            cbStatus.SelectedItem = cbStatus.Items[2];
        }

        private bool CanUpdate(string casa, string aluguel, string calcao, string status, string observacao)
        {
            decimal result;

            if (string.IsNullOrEmpty(aluguel) && string.IsNullOrEmpty(calcao) && string.IsNullOrEmpty(casa) &&
                string.IsNullOrEmpty(observacao) && status.Equals(Quarto.Status))
            {
                MessageBox.Show(fillRequiredFields, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!string.IsNullOrEmpty(casa) && !CommonBusiness.ForeignKeyExists("Casa", Convert.ToInt32(casa)))
            {
                MessageBox.Show("Forneça um código de casa válido para inserção.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (calcao.Length > 12 || aluguel.Length > 12 || observacao.Length > 150)
            {
                MessageBox.Show(charLimitLog, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void ClearFields()
        {
            mtbAluguel.Text = string.Empty;
            mtbCalcao.Text = string.Empty;
            mtbCasa.Text = string.Empty;
            mtbObservacao.Text = string.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            mtbCasa.Focus();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            UpdateQuarto();
            mtbCasa.Focus();
        }


        private void UpdateQuarto()
        {
            string aluguelFormat = mtbAluguel.Text.Replace(",", ".").Trim();
            string calcaoFormat = mtbCalcao.Text.Replace(",", ".").Trim();
            string status = cbStatus.SelectedItem.ToString().Trim();
            string observacao = mtbObservacao.Text.Trim();
            string casa = mtbCasa.Text;

            if (CanUpdate(casa, aluguelFormat, calcaoFormat, status, observacao))
            {
                try
                {
                    QuartoBusiness.Update(Quarto.IdQuarto, aluguelFormat, calcaoFormat, casa, status, observacao);
                    MessageBox.Show($"Atualização realizada com sucesso.", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    QuartoBusiness.QueryAll(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
                    this.ParentForm.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Ocorreu um erro atualizar. Erro: " + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            mtbCasa.Focus();
        }
    }
}
