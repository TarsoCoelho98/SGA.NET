using SGA.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGA.UI
{
    public partial class frmUpdateUsuario : Form
    {
        private static string charLimitLog = "O limite de caracteres foi excedido em um ou mais campos.";
        private static string fillRequiredFields = "Para atualizar, é necessário preencher pelo menos um dos campos com novos valores.";

        public string Racf { get; set; }
        
        public frmUpdateUsuario(string racf)
        {
            InitializeComponent();

            Racf = racf;
            gbUsuario.Text += Racf + " ";
        }

        private void Update()
        {
            string nome = mtbNome.Text;
            string senha = mtbSenha.Text.Replace(" ", ""); ;
            string rua = mtbRua.Text;
            string numero = mtbNumero.Text.Replace(" ", ""); ;
            string bairro = mtbBairro.Text;
            string cpf = mtbCpf.Text.Replace(" ", ""); ;
            string rg = mtbRg.Text.Replace(" ", ""); ;
            string racfReferencia = Racf;
            string email = mtbEmail.Text.Replace(" ", ""); ;
            string emailSenha = mtbSenhaEmail.Text.Replace(" ", ""); ;

            try
            {
                if (CanUpdate(nome, email, senha, rua, bairro, numero, cpf, rg, emailSenha))
                {
                    UsuarioBusiness.Update(racfReferencia, email, nome, senha, rua, bairro, numero, cpf, rg, emailSenha);
                    MessageBox.Show($"Atualização realizada com sucesso.", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um erro atualizar. Erro: " + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            mtbNome.Text = string.Empty;
            mtbSenha.Text = string.Empty;
            mtbRua.Text = string.Empty;
            mtbNumero.Text = string.Empty;
            mtbBairro.Text = string.Empty;
            mtbCpf.Text = string.Empty;
            mtbRg.Text = string.Empty;
            mtbEmail.Text = string.Empty;
            mtbSenhaEmail.Text = string.Empty;
        }

        private bool CanUpdate(string nome, string email, string senha, string rua, string bairro, string numero, string cpf, string rg, string emailSenha)
        {                     
            if (string.IsNullOrEmpty(nome) && string.IsNullOrEmpty(email) && string.IsNullOrEmpty(senha) &&
                string.IsNullOrEmpty(rua) && string.IsNullOrEmpty(bairro) && string.IsNullOrEmpty(numero) &&
                string.IsNullOrEmpty(cpf) && string.IsNullOrEmpty(rg) && string.IsNullOrEmpty(emailSenha))
            {
                MessageBox.Show(fillRequiredFields, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else if (!string.IsNullOrEmpty(senha) && senha.Length < 6)
            {
                MessageBox.Show("Escolha uma senha com 6 dígitos.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (nome.Length > 100 || rua.Length > 50 || bairro.Length > 100 || email.Length > 100)
            {
                MessageBox.Show(charLimitLog, "Dados Incorretos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!string.IsNullOrEmpty(email) && string.IsNullOrEmpty(emailSenha))
            {
                MessageBox.Show("Para atualizar o seu endereço de e-mail é necessário preencher o campo senha, abaixo de e-mail.", "Dados Incorretos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(emailSenha))
            {
                MessageBox.Show("Para atualizar a senha vinculada ao seu endereço de e-mail é necessário preencher o campo e-mail, acima de senha.", "Dados Incorretos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!string.IsNullOrEmpty(email) && !EmailBusiness.EmailVerify(email, emailSenha))
            {
                MessageBox.Show("Os dados do e-mail fornecido estão incorretos ou este e-mail não foi configurado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            mtbNome.Focus();
            ClearFields();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            mtbNome.Focus();
            Update();
        }
    }
}
