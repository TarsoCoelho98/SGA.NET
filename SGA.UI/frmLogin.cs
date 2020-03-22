using SGA.BLL;
using SGA.DAL;
using SGA.DAL.Enums;
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
    public partial class FrmLogin : Form
    {
        private static string userNotFoundLog = "Usuário ou senha não correspondem a nenhuma conta cadastrada. Cadastre-se para iniciar.";

        public FrmLogin()
        {
            InitializeComponent();
            FillComboBox();
        }

        public void FillComboBox()
        {        
            cbAmbiente.DataSource = new List<string>(CommonBusiness.EnumToList<Ambiente>());
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            tbUsuario.Focus();

            string racf = tbUsuario.Text;
            string senha = tbSenha.Text;
            string ambiente = cbAmbiente.SelectedItem.ToString().Trim();


            if (ambiente.Equals("Desenvolvimento"))
            {
                if (UsuarioBusiness.IsDeveloperAcess(racf, senha))
                {
                    frmConfiguracao frm = new frmConfiguracao(racf);                   

                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                }               
                else if (!Configuracao.IsSystemReady())
                {                    
                    MessageBox.Show("O sistema ainda não está configurado, acesso apenas para desenvolvedores.", "Dados Incorretos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (UsuarioBusiness.UserExits(racf, senha))
                {
                    MessageBox.Show("Você está tentando realizar login no ambiente errado, por favor, altere o ambiente para Produção.", "Dados Incorretos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else 
                    MessageBox.Show(userNotFoundLog, "Dados Incorretos", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
            else if (ambiente.Equals("Produção"))
            {
                if (!Configuracao.IsSystemReady())
                {
                    MessageBox.Show("O sistema ainda não está configurado para uso.","Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (UsuarioBusiness.UserExits(racf, senha) || UsuarioBusiness.IsDeveloperAcess(racf, senha))
                {
                    frmLoad frm = new frmLoad(racf);

                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show(userNotFoundLog, "Dados Incorretos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            tbUsuario.Focus();

            if (Configuracao.IsSystemReady())
            {
                frmRegistrar frm = new frmRegistrar();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("O sistema ainda não está configurado para uso.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbAmbiente_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbUsuario.Focus();
        }
    }
}
