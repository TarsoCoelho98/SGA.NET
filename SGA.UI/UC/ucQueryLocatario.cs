using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGA.DAL;
using SGA.DAL.Enums;
using SGA.DAL.Entity;
using SGA.BLL;
using SGA.DAL.Facade;

namespace SGA.UI.UC
{
    public partial class ucQueryLocatario : UserControl
    {
        public string Racf { get; set; }
        public List<int> LocatarioCobrado { get; set; }
        private static string monetaryLog = "Forneça valores válidos nos campos monetários para consulta.";
        private static string charLimitLog = "O limite de caracteres foi excedido em um ou mais campos.";
        private static string floatingPointLimitLog = "Os campos monetários aceitam, no máximo, duas casas decimais. Forneça um valor válido para inserção.";

        public ucQueryLocatario(string racf)
        {
            Racf = racf;
            LocatarioCobrado = new List<int>();

            InitializeComponent();
            InitializeFields();

            Search();
        }


        public void FillComboBoxes()
        {
            List<string> cbStatus = new List<string>() { "Todos" };
            cbStatus.AddRange(GeneralMethods.EnumToList<StatusCalcao>());
            cbStatusCalcao.DataSource = cbStatus;

            List<string> cboSexo = new List<string>() { "Todos" };
            cboSexo.AddRange(GeneralMethods.EnumToList<Sexo>());
            cbSexo.DataSource = cboSexo;

            List<string> cboPagamento = new List<string>() { "Todos" };
            cboPagamento.AddRange(GeneralMethods.EnumToList<StatusPagamento>());
            cbPagamento.DataSource = cboPagamento;
        }

        public void InitializeFields()
        {
            FillComboBoxes();
        }

        public void Search()
        {
            string id = mtbId.Text.Trim();
            string nome = mtbNome.Text.Trim();
            string aluguelFormat = mtbAluguel.Text.Replace(",", ".").Trim();
            string calcaoFormat = mtbCalcao.Text.Replace(",", ".").Trim();
            string casa = mtbCasa.Text.Trim();
            string diaPagamento = mtbDtPagamento.Text.Trim();
            string quarto = mtbQuarto.Text.Trim();
            string cbCalcao = cbStatusCalcao.SelectedItem.ToString().Trim();
            string cboSexo = cbSexo.SelectedItem.ToString().Trim();
            string cboPagamento = cbPagamento.SelectedItem.ToString().Trim();

            if (cboPagamento.Equals("Todos"))
                cboPagamento = string.Empty;

            if (cbCalcao.Equals("Todos"))
                cbCalcao = string.Empty;

            if (cboSexo.Equals("Todos"))
                cboSexo = string.Empty;

            if (CanQuery(aluguelFormat, calcaoFormat, nome))
            {
                try
                {
                    List<Locatario> locatarios = new List<Locatario>();
                    locatarios = LocatarioBusiness.QueryAll(id, nome, aluguelFormat, calcaoFormat, cbCalcao, diaPagamento, casa, quarto, cboSexo, cboPagamento);
                    dgvLocatario.DataSource = locatarios;
                    EnforceDateTimeFormatChange(dgvLocatario);
                    lblCount.Text = locatarios.Count.ToString();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Ocorreu um erro pesquisar. Erro: " + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void ClearFields()
        {
            mtbId.Text = string.Empty;
            mtbNome.Text = string.Empty;
            mtbAluguel.Text = string.Empty;
            mtbCalcao.Text = string.Empty;
            mtbCasa.Text = string.Empty;
            mtbDtPagamento.Text = string.Empty;
            mtbQuarto.Text = string.Empty;
            cbStatusCalcao.SelectedItem = cbStatusCalcao.Items[0];
            cbSexo.SelectedItem = cbSexo.Items[0];
            cbPagamento.SelectedItem = cbPagamento.Items[0];
        }
        private bool CanQuery(string aluguel, string calcao, string nome)
        {
            decimal result;

            if (calcao.Length > 12 || aluguel.Length > 12 || nome.Length > 100)
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
            else
                return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            mtbId.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
            mtbId.Focus();
        }

        private void dgvLocatario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == columnEditar.Index && e.RowIndex > -1)
            {
                var loc = (Locatario)dgvLocatario.Rows[e.RowIndex].DataBoundItem;

                frmUpdateLocatario frm = new frmUpdateLocatario(loc);
                frm.ShowDialog();
                Search();
            }
            else if (e.ColumnIndex == columnRemover.Index && e.RowIndex > -1)
            {
                var loc = (Locatario)dgvLocatario.Rows[e.RowIndex].DataBoundItem;

                DialogResult result = MessageBox.Show("Tem certeza de que deseja remover este item?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (result.Equals(DialogResult.Yes))
                {
                    try
                    {
                        LocatarioBusiness.Delete(loc.IdLocatario);
                        Search();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao remover. Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (e.ColumnIndex == columnCobranca.Index && e.RowIndex > -1)
            {
                mtbId.Focus();

                KeyValuePair<string, string> credentials = Configuracao.ReturnDeveloperCredentials();
                var loc = (Locatario)dgvLocatario.Rows[e.RowIndex].DataBoundItem;

                if (Racf.Equals(credentials.Key))
                {
                    MessageBox.Show("O desenvolvedor não está habilitado a enviar e-mails.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (loc.StatusPagamento.Equals("Pago") || loc.StatusPagamento.Equals("Receber"))
                {
                    MessageBox.Show("O status de pagamento deste locatário está sinalizado como Pago ou Receber. Para enviar um e-mail de cobrança, atualize para Devendo.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (LocatarioCobrado.Contains(loc.IdLocatario))
                {
                    DialogResult result = MessageBox.Show($"Um e-mail de cobrança já foi enviado a este locatário. Tem certeza que deseja prosseguir?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                    if (result.Equals(DialogResult.No))
                        return;
                }
                else
                {
                    DialogResult result = MessageBox.Show($"Tem certeza que deseja disparar um e-mail de cobrança para este inquilino?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                    if (result.Equals(DialogResult.No))
                        return;
                }

                Usuario user = UsuarioBusiness.UserData(Racf);

                try
                {
                    EmailBusiness.EmailCharge(user.Nome, loc.Nome, loc.Email, user.Email, user.SenhaEmail);
                    LocatarioCobrado.Add(loc.IdLocatario);

                    MessageBox.Show($"E-mail enviado com sucesso.", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Falha no envio do e-mail: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void EnforceDateTimeFormatChange(DataGridView grid)
        {
            for (int i = 0; i <= grid.Rows.Count - 1; i++)
            {
                string dataHora = "d";

                for (int j = 0; j < grid.Columns.Count; j++)
                {
                    if (grid.Rows[i].Cells[j].OwningColumn.HeaderText == "Data de Pagamento")
                    {
                        grid.Rows[i].Cells[j].OwningColumn.DefaultCellStyle.Format = dataHora;
                    }
                    else if (grid.Rows[i].Cells[j].OwningColumn.HeaderText == "Data de Nascimento")
                    {
                        grid.Rows[i].Cells[j].OwningColumn.DefaultCellStyle.Format = dataHora;
                    }
                }
            }
        }

        private void cbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            mtbId.Focus();
        }

        private void cbStatusCalcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            mtbId.Focus();
        }

        private void cbPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            mtbId.Focus();
        }

        public void ExtractToExcel()
        {
            KeyValuePair<bool, string> keyValue = CommonBusiness.ExtractToExcel(dgvLocatario);

            if (keyValue.Key.Equals(false))
                MessageBox.Show("Ocorreu um erro exportar para excel. Erro: " + keyValue.Value, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnExcel_Click_1(object sender, EventArgs e)
        {
            mtbId.Focus();
            ExtractToExcel();
        }

        private void btnResetarStatusPagamento_Click(object sender, EventArgs e)
        {
            mtbId.Focus();
            DialogResult result = MessageBox.Show($"Deseja que todos os inquilinos com status Pago recebam status Receber?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result.Equals(DialogResult.Yes))
            {
                GeneralMethods.ResetPaymentStatus();
                MessageBox.Show($"Status alterado com sucesso.", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
