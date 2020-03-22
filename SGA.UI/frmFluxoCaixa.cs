using SGA.BLL;
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
    public partial class frmFluxoCaixa : Form
    {
        public frmFluxoCaixa()
        {
            InitializeComponent();
            InitializeFields();
        }

        public void ClearFileds()
        {
            mtbAnual.Focus();

            mtbFinish.Text = string.Empty;
            mtbBegin.Text = string.Empty;
            cbMes.SelectedItem = cbMes.Items[0];
        }

        private void InitializeFields()
        {
            cbMes.DataSource = new List<string>(CommonBusiness.EnumToList<Mes>());
            cbMes.SelectedItem = cbMes.Items[0];
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            GenerateProjection(mtbBegin.Text, mtbFinish.Text);
            mtbBegin.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ClearFileds();
            mtbBegin.Focus();
        }

        private bool CanGenerateCashFlowPerDate(string begin, string finish)
        {
            if (string.IsNullOrEmpty(begin) && !string.IsNullOrEmpty(finish))
            {
                MessageBox.Show($"Informe a data de início para prosseguir.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!string.IsNullOrEmpty(begin) && string.IsNullOrEmpty(finish))
            {
                MessageBox.Show($"Informe a data fim para prosseguir.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (string.IsNullOrEmpty(begin) && string.IsNullOrEmpty(finish))
            {
                return false;
            }
            else 
                return true;
        }


        private void GenerateProjection(string begin, string finish)
        {
            decimal anual = CommonBusiness.YearCashFlow();
            decimal mensal = CommonBusiness.MonthCashFlow();

            if (CanGenerateCashFlowPerDate(begin, finish))
            {
                int inicio = Convert.ToInt32(begin);
                int fim = Convert.ToInt32(finish);

                decimal porData = CommonBusiness.CashFlowPerDate(inicio, fim);
                mtbFaturamentoDatas.Text = porData.ToString();
            }

            mtbAnual.Text = anual.ToString();
            mtbMensal.Text = mensal.ToString();
        }

        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            mtbBegin.Focus();
        }
    }
}
