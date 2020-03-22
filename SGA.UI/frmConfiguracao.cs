using SGA.BLL;
using SGA.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGA.UI
{
    public partial class frmConfiguracao : Form
    {
        private static string charLimitLog = "O limite de caracteres foi excedido em um ou mais campos.";
        public string Racf { get; set; }

        public frmConfiguracao(string racf)
        {
            InitializeComponent();
            Racf = racf;
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            mtbInstancia.Focus();
            string instanciaSql = mtbInstancia.Text;
            string diretorioBaseAplicacao = mtbDiretorioBaseApliacao.Text;

            try
            {
                ConfiguracaoBusiness bsConfig = new ConfiguracaoBusiness(instanciaSql, diretorioBaseAplicacao);

                if (isValidDirectoryAndSqlInstance(instanciaSql, diretorioBaseAplicacao))
                {
                    if (!ConfiguracaoBusiness.IsSystemReady())
                    {
                        if (bsConfig.ConnectionTest())
                        {
                            bsConfig.ConfigureConnectionString();
                            bsConfig.ConfigureFilePaths();
                            MessageBox.Show("Configuração realizada com sucesso. Sistema pronto para uso.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("O teste de conexão falhou, a instância é inválida ou o SQL Server não foi instalado corretamente.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("O sistema já está pronto para uso, não é necessário configurá-lo novamente.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao configurar sistema: {ex}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool isValidDirectoryAndSqlInstance(string instanciaSql, string diretorioBaseAplicacao)
        {
            if (string.IsNullOrEmpty(instanciaSql) || string.IsNullOrEmpty(diretorioBaseAplicacao))
            {
                MessageBox.Show($"É necessário preencher todos os campos.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!Directory.Exists(diretorioBaseAplicacao))
            {
                MessageBox.Show($"O diretório de destino dos contratos é inválido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }            
            else if (diretorioBaseAplicacao.Length > 500)
            {
                MessageBox.Show(charLimitLog, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            mtbInstancia.Focus();
            mtbInstancia.Text = string.Empty;
            mtbDiretorioBaseApliacao.Text = string.Empty;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain(Racf);
            mtbInstancia.Focus();

            if (!ConfiguracaoBusiness.IsSystemReady())
            {
                MessageBox.Show("O sistema ainda não está configurado para uso.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
