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
using System.Globalization;
using SGA.DAL.Enums;

namespace SGA.UI.UC
{
    public partial class ucInsertQuarto : UserControl
    {

        private static string monetaryLog = "Forneça valores válidos nos campos monetários para inserção.";
        private static string charLimitLog = "O limite de caracteres foi excedido em um ou mais campos.";
        private static string floatingPointLimitLog = "Os campos monetários aceitam, no máximo, duas casas decimais. Forneça um valor válido para inserção.";
        private static string fillRequiredFields = "Para adicionar, preencha os campos obrigatórios (casa e aluguel).";
        public ucInsertQuarto()
        {
            InitializeComponent();
            InitializeFields();
        }

        public void InitializeFields()
        {
            cbStatus.DataSource = new List<string>(CommonBusiness.EnumToList<StatusQuarto>());
            cbStatus.SelectedItem = cbStatus.Items[2];
        }

        private bool CanInsert(string casa, string aluguel, string calcao, string observacao)
        {
            decimal result;

            if (string.IsNullOrEmpty(casa) || string.IsNullOrEmpty(aluguel))
            {
                MessageBox.Show(fillRequiredFields, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (calcao.Length > 12 || aluguel.Length > 12 || observacao.Length > 150)
            {
                MessageBox.Show(charLimitLog, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (Convert.ToInt32(casa).Equals(0) || !CommonBusiness.ForeignKeyExists("Casa", Convert.ToInt32(casa)))
            {
                MessageBox.Show("Forneça um código de casa válido para inserção.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else if (!string.IsNullOrEmpty(aluguel) && !CommonBusiness.StringVerify(aluguel))
            {
                MessageBox.Show(monetaryLog, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!string.IsNullOrEmpty(calcao) && !CommonBusiness.StringVerify(calcao))
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
            mtbCasa.Text = string.Empty;
            mtbAluguel.Text = string.Empty;
            mtbCalcao.Text = string.Empty;
            mtbObservacao.Text = string.Empty;
            cbStatus.SelectedItem = cbStatus.Items[2];
        }

        public void Insert()
        {
            string aluguelFormat = mtbAluguel.Text.Replace(",", ".").Trim();
            string calcaoFormat = mtbCalcao.Text.Replace(",", ".").Trim();
            string casa = mtbCasa.Text.Trim();
            string status = cbStatus.SelectedItem.ToString().Trim();
            string observacao = mtbObservacao.Text.Trim();

            if (CanInsert(casa, aluguelFormat, calcaoFormat, observacao))
            {
                try
                {
                    QuartoBusiness.Insert(aluguelFormat, calcaoFormat, casa, status, observacao);
                    MessageBox.Show("Quarto adicionado com sucesso.", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ParentForm.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Ocorreu um erro inserir. Erro: " + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            mtbCasa.Focus();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Insert();
            mtbCasa.Focus();
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            mtbCasa.Focus();
        }
    }
}
