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
using SGA.DAL.Enums;
using System.Globalization;

namespace SGA.UI.UC
{
    public partial class ucInsertLocatario : UserControl
    {
        public string Racf { get; set; }

        private static string monetaryLog = "Forneça valores válidos nos campos monetários para inserção.";
        private static string emailWarning = "Você não preencheu o campo E-mail. Deste modo, não será possível enviar e-mails automáticos de cobrança a este inquilino." +
                                             " Tem certeza de que deseja prosseguir?";
        private static string charLimitLog = "O limite de caracteres foi excedido em um ou mais campos.";
        private static string floatingPointLimitLog = "Os campos monetários aceitam, no máximo, duas casas decimais. Forneça um valor válido para inserção.";
        private static string fillRequiredFields = "Para adicionar, preencha os campos obrigatórios (nome, casa, quarto, aluguel, data do primeiro pagamento, CPF e RG).";

        public ucInsertLocatario(string racf)
        {
            Racf = racf;

            InitializeComponent();
            InitializeFields();
        }

        public void InitializeFields()
        {
            cbMes.DataSource = new List<string>(CommonBusiness.EnumToList<Mes>());
            cbPagamento.DataSource = new List<string>(CommonBusiness.EnumToList<StatusPagamento>());
            cbStatusCalcao.DataSource = new List<string>(CommonBusiness.EnumToList<StatusCalcao>());
            cbSexo.DataSource = new List<string>(CommonBusiness.EnumToList<Sexo>());
        }

        public void ClearFields()
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

            cbMes.SelectedItem = cbMes.Items[0];
            cbPagamento.SelectedItem = cbPagamento.Items[0];
            cbSexo.SelectedItem = cbSexo.Items[0];
            cbStatusCalcao.SelectedItem = cbStatusCalcao.Items[0];
        }

        public void Insert()
        {
            string aluguelFormat = mtbAluguel.Text.Replace(",", ".").Trim();
            string calcaoFormat = mtbCalcao.Text.Replace(",", ".").Trim();
            string creditoFormat = mtbCredito.Text.Replace(",", ".").Trim();
            string debitoFormat = mtbDebito.Text.Replace(",", ".").Trim();
            string nome = mtbNome.Text.Trim();
            string diaPagamento = mtbDiaPagamento.Text.Trim().Replace(" ", "");
            string email = mtbEmail.Text.Trim();
            string celular = mtbCelular.Text.Trim();
            string casa = mtbCasa.Text.Trim();
            string quarto = mtbQuarto.Text.Trim();
            string dtNascimento = mtbDtNascimento.Text.Trim().Replace(" ", "");
            string observacao = mtbObservacao.Text.Trim();
            string mes = cbMes.SelectedItem.ToString().Trim();
            string statusPagamento = cbPagamento.SelectedItem.ToString().Trim();
            string statusCalcao = cbStatusCalcao.SelectedItem.ToString().Trim();
            string sexo = cbSexo.SelectedItem.ToString().Trim();
            string cpf = mtbCpf.Text.Trim();
            string rg = mtbRg.Text.Replace(" ", "");
            string mae = mtbMae.Text.Trim();
            string pai = mtbPai.Text.Trim();

            if (rg.EndsWith("0"))
                rg = rg.Remove(rg.Length - 1);


            if (CanInsert(nome, casa, quarto, aluguelFormat, debitoFormat, creditoFormat, email, calcaoFormat, observacao, diaPagamento, mes, dtNascimento, celular, cpf, rg, pai, mae))
            {
                try
                {
                    LocatarioBusiness.Insert(nome, aluguelFormat, calcaoFormat, statusCalcao, diaPagamento, email, celular, casa,
                                             quarto, debitoFormat, creditoFormat, dtNascimento, sexo, observacao, statusPagamento,
                                             cpf, rg, mae, pai);

                    if (!string.IsNullOrEmpty(email))
                    {
                        DialogResult logResult = MessageBox.Show("Locatário adicionado com sucesso. Deseja lhe enviar um e-mail de boas vindas com o contrato de locação em anexo?",
                                                                 "Parabéns", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        if (logResult.Equals(DialogResult.Yes))
                        {
                            try
                            {                                
                                frmContrato frm = new frmContrato(Racf, email, nome, cpf);
                                frm.ShowDialog();
                            }
                            catch (Exception e)
                            {
                                MessageBox.Show("Ocorreu um erro ao enviar o e-mail, esta operação precisará ser executada manualmente. Erro: " + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                        MessageBox.Show("Locatário adicionado com sucesso.", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.ParentForm.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Ocorreu um erro inserir. Erro: " + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Insert();
            mtbNome.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            mtbNome.Focus();
        }

        private bool CanInsert(string nome, string casa, string quarto, string aluguel, string debito, string credito,
                               string email, string calcao, string observacao, string diaPagamento, string mes,
                               string dtNascimento, string celular, string cpf, string rg, string pai, string mae)
        {
            decimal result;
            DateTime dateResult;

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(casa) || string.IsNullOrEmpty(quarto) || string.IsNullOrEmpty(aluguel) || string.IsNullOrEmpty(mes)
                || string.IsNullOrEmpty(diaPagamento) || string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(rg))
            {
                MessageBox.Show(fillRequiredFields, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (calcao.Length > 12 || aluguel.Length > 12 || observacao.Length > 150 || debito.Length > 12 || credito.Length > 12
                    || nome.Length > 100 || email.Length > 50 || mae.Length > 100 || pai.Length > 100)
            {
                MessageBox.Show(charLimitLog, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (Convert.ToInt32(casa).Equals(0) || !CommonBusiness.ForeignKeyExists("Casa", Convert.ToInt32(casa)))
            {
                MessageBox.Show("Forneça um código de casa válido para inserção.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (Convert.ToInt32(casa).Equals(0) || !CommonBusiness.ForeignKeyExists("Quarto", Convert.ToInt32(quarto)))
            {
                MessageBox.Show("Forneça um código de quarto válido para inserção.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else if (!string.IsNullOrEmpty(credito) && credito.Contains('.') && credito.Split('.')[1].Length > 2)
            {
                MessageBox.Show(floatingPointLimitLog, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!string.IsNullOrEmpty(debito) && debito.Contains('.') && debito.Split('.')[1].Length > 2)
            {
                MessageBox.Show(floatingPointLimitLog, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (cpf.Length < 11)
            {
                MessageBox.Show("Forneça um número de CPF válido, por favor.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (rg.Length < 7)
            {
                MessageBox.Show("Forneça um número de RG válido, por favor.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (Convert.ToInt32(diaPagamento) > 28 || Convert.ToInt32(diaPagamento) < 1)
            {
                MessageBox.Show("Forneça um dia de pagamento entre 01 e 28 do mês.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!string.IsNullOrWhiteSpace(dtNascimento.Replace('/', ' ')) && !DateTime.TryParse(dtNascimento, out dateResult))
            {
                MessageBox.Show("Forneça um data de nascimento válida para inserção", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!string.IsNullOrEmpty(celular) && celular.Replace(" ", "").Length != 11)
            {
                MessageBox.Show("Forneça um número de celular válido para inserção", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (string.IsNullOrEmpty(email))
            {
                DialogResult logResult = MessageBox.Show(emailWarning, "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (logResult.Equals(DialogResult.Yes))
                    return true;
                else
                    return false;
            }
            else
                return true;
        }


        private void btnClear_Click_1(object sender, EventArgs e)
        {

            ClearFields();
            mtbNome.Focus();
        }

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            Insert();
            mtbNome.Focus();
        }

        private void cbMes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            mtbNome.Focus();
        }

        private void cbSexo_SelectedIndexChanged_1(object sender, EventArgs e)
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
    }
}
