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

namespace SGA.UI.UC
{
    public partial class ucInsertCasa : UserControl
    {
        private static string charLimitLog = "O limite de caracteres foi excedido em um ou mais campos.";
        private static string fillRequiredFields = "Para adicionar, preencha os campos obrigatórios (rua, bairro, cidade, número e CEP).";
        public ucInsertCasa()
        {
            InitializeComponent();
        }

        private void ClearFields()
        {
            mtbBairro.Text = string.Empty;
            mtbRua.Text = string.Empty;
            mtbCEP.Text = string.Empty;
            mtbNumero.Text = string.Empty;
            mtbObservacao.Text = string.Empty;
            mtbCidade.Text = string.Empty;
        }

        private bool CanInsert(string novoRua, string novoBairro, int novoNumero, long novoCep, string novoObservacao, string cidade)
        {
            int cepLimit = 8;

            if (string.IsNullOrEmpty(novoRua) || string.IsNullOrEmpty(novoBairro) || novoNumero.Equals(0)
                || novoCep.Equals(0) || string.IsNullOrEmpty(cidade))
            {
                MessageBox.Show(fillRequiredFields, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (novoRua.Length > 100 || novoBairro.Length > 150 || novoObservacao.Length > 150 || cidade.Length > 100)
            {
                MessageBox.Show(charLimitLog, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (novoCep.ToString().Length != cepLimit)
            {
                MessageBox.Show("Forneça um número de CEP válido para inserção.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
                return true;
        }

        public void Insert()
        {
            string cepFormat = mtbCEP.Text.Replace("-", "").Replace(" ", "").Trim();

            string rua = mtbRua.Text.Trim();
            string bairro = mtbBairro.Text.Trim();
            int numero = string.IsNullOrEmpty(mtbNumero.Text) ? 0 : Convert.ToInt32(mtbNumero.Text);
            long cep = string.IsNullOrEmpty(cepFormat) ? 0 : Convert.ToInt64(cepFormat);
            string observacao = mtbObservacao.Text.Trim();
            string cidade = mtbCidade.Text.Trim();

            if (CanInsert(rua, bairro, numero, cep, observacao, cidade))
            {
                try
                {
                    CasaBusiness.Insert(rua, bairro, numero, cep, observacao, cidade);
                    MessageBox.Show("Casa adicionada com sucesso.", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            mtbRua.Focus();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Insert();
            mtbRua.Focus();
        }
    }
}
