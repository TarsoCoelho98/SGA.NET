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
using SGA.DAL.Enums;

namespace SGA.UI.UC
{
    public partial class ucUpdateLocatario : UserControl
    {

        private static string monetaryLog = "Forneça valores válidos nos campos monetários para atualização.";
        private static string charLimitLog = "O limite de caracteres foi excedido em um ou mais campos.";
        private static string fillRequiredFields = "Para atualizar, é necessário preencher pelo menos um dos campos com novos valores.";
        private static string floatingPointLimitLog = "Os campos monetários aceitam, no máximo, duas casas decimais. Forneça um valor válido para atualização.";

        public Locatario Locatario { get; set; }

        public ucUpdateLocatario(Locatario loc)
        {
            Locatario = loc;
            InitializeComponent();
            InitializeFields();
        }

        private void InitializeFields()
        {
            cbPagamento.DataSource = CommonBusiness.EnumToList<StatusPagamento>();
            cbStatusCalcao.DataSource = CommonBusiness.EnumToList<StatusCalcao>();
            cbSexo.DataSource = CommonBusiness.EnumToList<Sexo>();
            gbAtualizacao.Text += Locatario.IdLocatario.ToString() + " ";
        }

        private bool CanUpdate(string nome, string aluguel, string calcao, string diaPagamento, string email, string celular, 
                               string quarto, string casa, string debito, string credito, string dtNascimento, string sexo, 
                               string observacao, string statusPagamento, string statusCalcao, string cpf, string rg, string pai, string mae)
        {
            DateTime dateResult;
            decimal result;

            if (string.IsNullOrEmpty(nome) && string.IsNullOrEmpty(aluguel) && string.IsNullOrEmpty(calcao) &&
                string.IsNullOrEmpty(diaPagamento) && string.IsNullOrEmpty(email) && string.IsNullOrEmpty(celular) &&
                string.IsNullOrEmpty(quarto) && string.IsNullOrEmpty(debito) && string.IsNullOrEmpty(credito) &&
                string.IsNullOrWhiteSpace(dtNascimento.Replace('/', ' ')) && string.IsNullOrEmpty(observacao) && string.IsNullOrEmpty(casa) &&
                statusPagamento.Equals(Locatario.StatusPagamento) && sexo.Equals(Locatario.Sexo) && statusCalcao.Equals(Locatario.StatusCalcao) &&
                string.IsNullOrEmpty(cpf) && string.IsNullOrEmpty(rg) && string.IsNullOrEmpty(pai) && string.IsNullOrEmpty(mae))
            {
                MessageBox.Show(fillRequiredFields, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!string.IsNullOrEmpty(casa) && !CommonBusiness.ForeignKeyExists("Casa", Convert.ToInt32(casa)))
            {
                MessageBox.Show("Forneça um código de casa válido para atualização.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!string.IsNullOrEmpty(quarto) && !CommonBusiness.ForeignKeyExists("Quarto", Convert.ToInt32(quarto)))
            {
                MessageBox.Show("Forneça um código de quarto válido para atualização.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (calcao.Length > 12 || aluguel.Length > 12 || credito.Length > 12 || debito.Length > 12 ||
                     nome.Length > 100 || email.Length > 50 || observacao.Length > 150 || mae.Length > 100 || pai.Length > 100)
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
            else if (!string.IsNullOrEmpty(credito) && !decimal.TryParse(credito, out result))
            {
                MessageBox.Show(monetaryLog, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!string.IsNullOrEmpty(debito) && !decimal.TryParse(debito, out result))
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
            else if (!string.IsNullOrEmpty(debito) && debito.Contains('.') && debito.Split('.')[1].Length > 2)
            {
                MessageBox.Show(floatingPointLimitLog, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!string.IsNullOrEmpty(credito) && credito.Contains('.') && credito.Split('.')[1].Length > 2)
            {
                MessageBox.Show(floatingPointLimitLog, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else if (!string.IsNullOrEmpty(credito) && !CommonBusiness.StringVerify(credito))
            {
                MessageBox.Show(monetaryLog, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!string.IsNullOrEmpty(debito) && !CommonBusiness.StringVerify(debito))
            {
                MessageBox.Show(monetaryLog, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!string.IsNullOrEmpty(diaPagamento) && (Convert.ToInt32(diaPagamento) > 28 || Convert.ToInt32(diaPagamento) < 1))
            {
                MessageBox.Show("Forneça um dia de pagamento entre 01 e 28 do mês.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!string.IsNullOrWhiteSpace(dtNascimento.Replace('/', ' ')) && !DateTime.TryParse(dtNascimento, out dateResult))
            {
                MessageBox.Show("Forneça um data de nascimento válida para atualização", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!string.IsNullOrEmpty(celular) && celular.Replace(" ", "").Length != 11)
            {
                MessageBox.Show("Forneça um número de celular válido para atualização", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!string.IsNullOrEmpty(cpf) && cpf.Length < 11)
            {
                MessageBox.Show("Forneça um número de CPF válido, por favor.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!string.IsNullOrEmpty(rg) && rg.Length < 7)
            {
                MessageBox.Show("Forneça um número de RG válido, por favor.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
                return true;
        }

        private void ClearFields()
        {
            mtbNome.Text = string.Empty;
            mtbAluguel.Text = string.Empty;
            mtbCalcao.Text = string.Empty;
            mtbDiaPagamento.Text = string.Empty;
            mtbEmail.Text = string.Empty;
            mtbCelular.Text = string.Empty;
            mtbCasa.Text = string.Empty;
            mtbQuarto.Text = string.Empty;
            mtbDebito.Text = string.Empty;
            mtbCredito.Text = string.Empty;
            mtbDtNascimento.Text = string.Empty;
            mtbObservacao.Text = string.Empty;
            mtbPai.Text = string.Empty;
            mtbMae.Text = string.Empty;
            mtbCpf.Text = string.Empty;
            mtbRg.Text = string.Empty;

            cbPagamento.SelectedItem = cbPagamento.Items[0];
            cbSexo.SelectedItem = cbSexo.Items[0];
            cbStatusCalcao.SelectedItem = cbStatusCalcao.Items[0];
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            mtbNome.Focus();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            UpdateLocatario();
            mtbNome.Focus();
        }

        private void UpdateLocatario()
        {
            string aluguelFormat = mtbAluguel.Text.Replace(",", ".").Trim();
            string calcaoFormat = mtbCalcao.Text.Replace(",", ".").Trim();
            string creditoFormat = mtbCredito.Text.Replace(",", ".").Trim();
            string debitoFormat = mtbDebito.Text.Replace(",", ".").Trim();
            string nome = mtbNome.Text.Trim();
            string diaPagamento = mtbDiaPagamento.Text.Trim().Replace(" ", "");
            string email = mtbEmail.Text.Replace(" ", ""); 
            string celular = mtbCelular.Text.Replace(" ", ""); ;
            string casa = mtbCasa.Text.Trim();
            string quarto = mtbQuarto.Text.Trim();
            string dtNascimento = mtbDtNascimento.Text.Trim().Replace(" ", "");
            string observacao = mtbObservacao.Text.Trim();
            string statusPagamento = cbPagamento.SelectedItem.ToString().Trim();
            string statusCalcao = cbStatusCalcao.SelectedItem.ToString().Trim();
            string sexo = cbSexo.SelectedItem.ToString().Trim();
            string cpf = mtbCpf.Text.Trim();
            string rg = mtbRg.Text.Replace(" ", "");
            string mae = mtbMae.Text.Trim();
            string pai = mtbPai.Text.Trim();

            try
            {
                if (CanUpdate(nome, aluguelFormat, calcaoFormat, diaPagamento, email, celular, quarto, casa, debitoFormat, creditoFormat, dtNascimento, sexo, observacao, statusPagamento, statusCalcao, cpf, rg, pai, mae))
                {
                    LocatarioBusiness.Update(Locatario.IdLocatario.ToString(), nome, aluguelFormat, calcaoFormat, statusCalcao, diaPagamento,
                                             email, celular, casa, quarto, debitoFormat, creditoFormat, dtNascimento, sexo, statusPagamento, 
                                             observacao, cpf, rg, mae, pai);

                    MessageBox.Show($"Atualização realizada com sucesso.", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);                   
                    LocatarioBusiness.QueryAll(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);                    
                    this.ParentForm.Close();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um erro atualizar. Erro: " + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            mtbNome.Focus();
        }

        private void cbStatusCalcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            mtbNome.Focus();
        }

        private void cbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            mtbNome.Focus();
        }

        private void cbPagamento_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            mtbNome.Focus();
        }

        private void cbStatusCalcao_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            mtbNome.Focus();
        }

        private void cbSexo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            mtbNome.Focus();
        }
    }
}
