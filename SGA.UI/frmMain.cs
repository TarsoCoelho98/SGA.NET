using SGA.BLL;
using SGA.DAL;
using SGA.DAL.Entity;
using SGA.DAL.Facade;
using SGA.UI.UC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SGA.UI
{
    public partial class frmMain : Form
    {
        public string Racf { get; set; }

        public frmMain(string racf)
        {
            Racf = racf;

            InitializeComponent();
            VeriryBirthday();
        }

        public void VeriryBirthday()
        {
            KeyValuePair<string, string> credentials = Configuracao.ReturnDeveloperCredentials();

            if (Racf.Equals(credentials.Key))
                return;

            if (Monitoramento.EmailAniversarioEnviadoDataAtual())
                return;

            var listBirthday = new List<Locatario>();
            var listLocatarios = LocatarioBusiness.QueryAll(null, null, null, null, null, null, null, null, null, null);

            var dataCorrente = DateTime.Now;

            foreach (var loc in listLocatarios)
            {
                var diaNascimento = Convert.ToDateTime(loc.DtNascimento).Day;
                var mesNascimento = Convert.ToDateTime(loc.DtNascimento).Month;

                if (diaNascimento == dataCorrente.Day && mesNascimento == dataCorrente.Month)
                {
                    if (string.IsNullOrEmpty(loc.Email))
                        continue;

                    listBirthday.Add(loc);
                }
            }

            if (listBirthday.Equals(null) || listBirthday.Count.Equals(0))
                return;
            else
            {
                DialogResult result = MessageBox.Show($"Há um ou mais inquilinos realizando aniversário no dia de hoje. Gostaria de enviar e-mails de parabenização?", "Aniversário", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result.Equals(DialogResult.Yes))
                {
                    foreach (var loc in listBirthday)
                    {
                        Usuario user = UsuarioBusiness.UserData(Racf);

                        try
                        {
                            EmailBusiness.EmailBirthday(user.Nome, loc.Nome, loc.Email, user.Email, user.SenhaEmail);
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Falha no envio do e-mail: " + e.Message);
                            return;
                        }
                    }

                    MessageBox.Show($"E-mail enviado com sucesso.", "Parabéns", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    Monitoramento.InserirEnvioEmailAniversario();
                }
            }
        }


        private void tsmItemQueryFromCasa_Click(object sender, EventArgs e)
        {
            ucQueryCasa uc = new ucQueryCasa();
            this.Text = "Consulta de Casas";

            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInsertCasa frm = new frmInsertCasa();
            frm.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucQueryQuarto uc = new ucQueryQuarto();
            this.Text = "Consulta de Quartos";

            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void paginaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
        }

        private void adicionarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmInsertQuarto frm = new frmInsertQuarto();
            frm.ShowDialog();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ucQueryLocatario uc = new ucQueryLocatario(Racf);
            this.Text = "Consulta de Locatários";

            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void adicionarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmInsertLocatario frm = new frmInsertLocatario(Racf);
            frm.ShowDialog();
        }

        private void atualizarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeyValuePair<string, string> credentials = Configuracao.ReturnDeveloperCredentials();

            if (Racf.Equals(credentials.Key))
            {
                MessageBox.Show($"Não é permitido ao desenvolvedor alterar o seu cadastro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmUpdateUsuario frm = new frmUpdateUsuario(Racf);
            frm.ShowDialog();
        }

        private void projeçãoDeFluxoDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFluxoCaixa frm = new frmFluxoCaixa();
            frm.ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show($"Tem certeza que deseja sair?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result.Equals(DialogResult.No))
            {
                e.Cancel = true;
            }
        }
    }
}
