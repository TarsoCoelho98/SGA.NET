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
    public partial class ucUpdateCasa : UserControl
    {
        private static string charLimitLog = "O limite de caracteres foi excedido em um ou mais campos.";
        private static string fillRequiredFields = "Para atualizar, é necessário preencher pelo menos um dos campos com novos valores.";
        public Casa Casa { get; set; }

        public ucUpdateCasa(Casa casa)
        {
            Casa = casa;

            InitializeComponent();
            InitizalizeFields();
        }

        private void InitizalizeFields()
        {
            gbAtualizacao.Text += Casa.IdCasa.ToString() + " ";
        }

        private void ClearFields()
        {
            mtbBairro.Text = string.Empty;
            mtbRua.Text = string.Empty;
            mtbCEP.Text = string.Empty;
            mtbNumero.Text = string.Empty;
            mtbObservacao.Text = string.Empty;
        }

        private bool CanUpdate(string novoRua, string novoBairro, string novoNumero, string novoCep, string novoObservacao, string cidade)
        {
            int cepLimit = 8;

            if (string.IsNullOrEmpty(novoRua) && string.IsNullOrEmpty(novoBairro) && string.IsNullOrEmpty(novoNumero)
                && string.IsNullOrEmpty(novoCep) && string.IsNullOrEmpty(novoObservacao) && string.IsNullOrEmpty(cidade))
            {
                MessageBox.Show(fillRequiredFields, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (novoRua.Length > 100 || novoBairro.Length > 150 || novoObservacao.Length > 150 || cidade.Length > 50)
            {
                MessageBox.Show(charLimitLog, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if(novoCep.Length != cepLimit && !string.IsNullOrEmpty(novoCep))
            {
                MessageBox.Show("Forneça um número de CEP válido para atualização.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }           
            else
                return true;
        }

        public void UpdateCasa()
        {
            string cepFormat = mtbCEP.Text.Replace("-", "").Replace(" ", "");
            int idReferencia = Casa.IdCasa;
            string novoRua = mtbRua.Text.Trim();
            string novoBairro = mtbBairro.Text.Trim();
            string novoNumero = mtbNumero.Text.Trim();
            string observacao = mtbObservacao.Text.Trim();
            string cidade = mtbCidade.Text.Trim();

            if (CanUpdate(novoRua, novoBairro, novoNumero, cepFormat, observacao, cidade))
            {
                try
                {
                    CasaBusiness.Update(idReferencia, novoRua, novoBairro, novoNumero, cepFormat, observacao, cidade);
                    MessageBox.Show($"Atualização realizada com sucesso.", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CasaBusiness.QueryAll(string.Empty, string.Empty, string.Empty, string.Empty);
                    this.ParentForm.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Ocorreu um erro atualizar. Erro: " + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            UpdateCasa();
            mtbRua.Focus();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearFields();
            mtbRua.Focus();
        }
    }
}
