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
using SGA.DAL.Enums;
using SGA.BLL;

namespace SGA.UI.UC
{
    public partial class ucContrato : UserControl
    {
        public string Racf { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public bool EmailEnviado { get; set; }

        private static string fillRequiredFields = "Para enviar o e-mail com o contrato em anexo, é necessário preencher todos os campos.";
        private static string charLimitLog = "O limite de caracteres foi excedido em um ou mais campos.";

        public ucContrato(string racf, string email, string nome, string cpf)
        {
            Racf = racf;
            Nome = nome;
            CPF = cpf;

            InitializeComponent();
            InitializeFiels();
        }

        public void InitializeFiels()
        {
            mtbRua.Focus();
            cbTipoConta.DataSource = CommonBusiness.EnumToList<StatusConta>();
        }

        public void ClearFields()
        {
            mtbRua.Text = string.Empty;
            mtbBairro.Text = string.Empty;
            mtbUf.Text = string.Empty;
            mtbCidade.Text = string.Empty;
            mtbCodigoBanco.Text = string.Empty;
            mtbNomeBanco.Text = string.Empty;
            mtbAgencia.Text = string.Empty;
            mtbConta.Text = string.Empty;
            mtbDigito.Text = string.Empty;
            mtbDtInicioContrato.Text = string.Empty;
            mtbDtTerminoContrato.Text = string.Empty;
            mtbVigenciaMeses.Text = string.Empty;
            mtbEstado.Text = string.Empty;
            cbTipoConta.SelectedItem = cbTipoConta.Items[0];
        }

        public void WelcomeEmail()
        {
            if (EmailEnviado)
            {
                MessageBox.Show("Já foi enviado um e-mail a este locatário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var contrato = GenerateContrato();

            if (contrato == null)
                return;

            var anexoContent = EmailBusiness.GenerateDocument(Racf, Nome, CPF, contrato);
            EmailBusiness.WelcomeEmail(anexoContent, Racf, Nome, CPF);
            
            MessageBox.Show("E-mail enviado com sucesso.", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);            
            EmailEnviado = true;
        }

        public Contrato GenerateContrato()
        {
            string rua = mtbRua.Text;
            string bairro = mtbBairro.Text;
            string uf = mtbUf.Text;
            string cidade = mtbCidade.Text;

            string strDigitoConta = mtbDigito.Text;
            string strCodigoBanco = mtbCodigoBanco.Text;
            string strVigenciaMeses = mtbVigenciaMeses.Text;
            string strAgencia = mtbAgencia.Text.Trim().Replace(" ", "");
            string strConta = mtbConta.Text.Trim().Replace(" ", "");
            
            string tipoConta = cbTipoConta.SelectedItem.ToString().Trim();
            string nomeBanco = mtbNomeBanco.Text;
            string estado = mtbEstado.Text;

            if (CanGenerateContrato(rua, bairro, uf, cidade, estado, nomeBanco, strDigitoConta, strCodigoBanco, strVigenciaMeses, strAgencia, strConta))
            {
                DateTime inicioContrato = Convert.ToDateTime(mtbDtInicioContrato.Text);
                DateTime terminoContrato = Convert.ToDateTime(mtbDtTerminoContrato.Text);

                long agencia = Convert.ToInt64(strAgencia);
                long conta = Convert.ToInt64(strConta);
                int vigenciaMeses = Convert.ToInt32(strVigenciaMeses);
                int digitoConta = Convert.ToInt32(strDigitoConta);
                int codigoBanco = Convert.ToInt32(strCodigoBanco);


                return new Contrato(rua, bairro, uf, cidade, codigoBanco, nomeBanco, agencia, conta,
                                    inicioContrato, terminoContrato, vigenciaMeses, estado, tipoConta, digitoConta);
            }
            else
                return null;
        }

        public bool CanGenerateContrato(string rua, string bairro, string uf, string cidade, string estado, string nomeBanco, 
                                        string strDigitoConta, string strCodigoBanco, string strVigenciaMeses, string strAgencia, 
                                        string strConta)
        {
            DateTime dateResult;
            long defaultValue;
            int defaultIntvalue;

            if (string.IsNullOrEmpty(rua) || string.IsNullOrEmpty(bairro) || string.IsNullOrEmpty(uf) || string.IsNullOrEmpty(cidade) || string.IsNullOrEmpty(mtbCodigoBanco.Text)
               || string.IsNullOrEmpty(mtbAgencia.Text) || string.IsNullOrEmpty(mtbConta.Text) || string.IsNullOrEmpty(mtbDtInicioContrato.Text) || string.IsNullOrEmpty(mtbDtTerminoContrato.Text)
               || string.IsNullOrEmpty(mtbVigenciaMeses.Text) || string.IsNullOrEmpty(estado) || string.IsNullOrEmpty(nomeBanco))
            {
                MessageBox.Show(fillRequiredFields, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (rua.Length > 100 || bairro.Length > 100 || cidade.Length > 100 || estado.Length > 12 || nomeBanco.Length > 50)
            {
                MessageBox.Show(charLimitLog, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!string.IsNullOrWhiteSpace(mtbDtInicioContrato.Text.Replace('/', ' ')) && !DateTime.TryParse(mtbDtInicioContrato.Text, out dateResult))
            {
                MessageBox.Show("Forneça um data de início de contrato válida.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!string.IsNullOrWhiteSpace(mtbDtTerminoContrato.Text.Replace('/', ' ')) && !DateTime.TryParse(mtbDtTerminoContrato.Text, out dateResult))
            {
                MessageBox.Show("Forneça um data de termino de contrato válida.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!string.IsNullOrWhiteSpace(strDigitoConta) && !int.TryParse(strDigitoConta, out defaultIntvalue))
            {
                MessageBox.Show("Forneça valores válidos nas informações bancárias.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!string.IsNullOrWhiteSpace(strCodigoBanco) && !int.TryParse(strCodigoBanco, out defaultIntvalue))
            {
                MessageBox.Show("Forneça valores válidos nas informações bancárias.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!string.IsNullOrWhiteSpace(strVigenciaMeses) && !int.TryParse(strVigenciaMeses, out defaultIntvalue))
            {
                MessageBox.Show("Forneça valores válidos nos dados do contrato.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!string.IsNullOrWhiteSpace(strAgencia) && !long.TryParse(strAgencia, out defaultValue))
            {
                MessageBox.Show("Forneça valores válidos nas informações bancárias.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!string.IsNullOrWhiteSpace(strConta) && !long.TryParse(strConta, out defaultValue))
            {
                MessageBox.Show("Forneça valores válidos nas informações bancárias.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
                return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            mtbRua.Focus();
            ClearFields();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            mtbRua.Focus();

            try
            {
                WelcomeEmail();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha no envio do e-mail. Mensagem: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void cbTipoConta_SelectedIndexChanged(object sender, EventArgs e)
        {
            mtbRua.Focus();
        }

    }
}
