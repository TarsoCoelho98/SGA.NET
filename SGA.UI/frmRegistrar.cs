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
    public partial class frmRegistrar : Form
    {
        private static string charLimitLog = "O limite de caracteres foi excedido em um ou mais campos.";

        public frmRegistrar()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            mtbNome.Focus();
        }

        private void ClearFields()
        {
            mtbNome.Text = string.Empty;
            mtbRacf.Text = string.Empty;
            mtbSenha.Text = string.Empty;
            mtbRua.Text = string.Empty;
            mtbNumero.Text = string.Empty;
            mtbBairro.Text = string.Empty;
            mtbCpf.Text = string.Empty;
            mtbRg.Text = string.Empty;
            mtbEmail.Text = string.Empty;
            mtbEmailSenha.Text = string.Empty;
        }

        public void Insert()
        {
            string nome = mtbNome.Text;
            string racf = mtbRacf.Text.Replace(" ", "");
            string senha = mtbSenha.Text.Replace(" ", "");
            string rua = mtbRua.Text;
            string numero = mtbNumero.Text.Replace(" ", "");
            string bairro = mtbBairro.Text;
            string cpf = mtbCpf.Text.Trim();
            string rg = mtbRg.Text.Replace(" ", "");
            string email = mtbEmail.Text.Replace(" ", "");
            string senhaEmail = mtbEmailSenha.Text.Replace(" ", "");

            try
            {
                if (CanRegister(nome, email, racf, senha, rua, bairro, numero, cpf, rg, senhaEmail))
                {
                    UsuarioBusiness.Insert(nome, email, racf, senha, rua, bairro, numero, cpf, rg, senhaEmail);
                    MessageBox.Show("Usuário registrado com sucesso.", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um erro inserir. Erro: " + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            mtbNome.Focus();
            Insert();
        }
        
        private bool CanRegister(string nome, string email, string racf, string senha, string rua, string bairro, string numero, string cpf, string rg, string senhaEmail)
        {
            if (UsuarioBusiness.UserAlreadyExists(racf))
            {
                MessageBox.Show("Este usuário já está sendo utilizado em uma outra conta. Por favor, escolha outro.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(racf) || string.IsNullOrEmpty(senha) || string.IsNullOrEmpty(rua) || string.IsNullOrEmpty(bairro) 
                    || string.IsNullOrEmpty(numero) || string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(rg) || string.IsNullOrEmpty(senhaEmail))
            {
                MessageBox.Show("Para prosseguir, é necessário preencher todos os campos.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else if (senha.Length < 6)
            {
                MessageBox.Show("Escolha um senha com 6 dígitos.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (racf.Length < 7)
            {
                MessageBox.Show("Escolha um nome de usuário com 7 dígitos.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (nome.Length > 100 || rua.Length > 50 || bairro.Length > 100 || email.Length > 100 || senhaEmail.Length > 100)
            {
                MessageBox.Show(charLimitLog, "Dados Incorretos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!EmailBusiness.EmailVerify(email, senhaEmail))
            {
                MessageBox.Show("Os dados do e-mail fornecido estão incorretos ou este e-mail não foi configurado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;           
        }
    }
}
