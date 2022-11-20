using System;
using System.Windows.Forms;
using Projeto01.Model;
using Projeto01.Repositórios;
using RJCodeAdvance.RJControls;

namespace Projeto01.Views
{
    public partial class frmMapa : Form
    {
        public frmMapa()
        {
            InitializeComponent();
        }
        RepositorioMapa RM = null;
      private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMapa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lCPDataSet.Mapa'. Você pode movê-la ou removê-la conforme necessário.
            this.mapaTableAdapter.Fill(this.lCPDataSet.Mapa);
            // TODO: esta linha de código carrega dados na tabela 'lCPDataSet.Licitacao'. Você pode movê-la ou removê-la conforme necessário.
            this.licitacaoTableAdapter.Fill(this.lCPDataSet.Licitacao);
            // TODO: esta linha de código carrega dados na tabela 'lCPDataSet.Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.lCPDataSet.Produto);
            // TODO: esta linha de código carrega dados na tabela 'lCPDataSet.Fornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedoresTableAdapter.Fill(this.lCPDataSet.Fornecedores);

            frmPrincipal frmPrin = new frmPrincipal();
            this.Top = frmPrin.Top + 6;
            this.Width = ActiveForm.Width - 208;
            this.Height = ActiveForm.Height - 6;
            this.Left = frmPrin.Left + 208;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            RM = new RepositorioMapa();
            Mapa M = new Mapa();
            M.PrecoMax = double.Parse(txtPrecMax.Texts);
            M.PrecoMin = double.Parse(txtPrecMin.Texts);
            M.ValorFinal = double.Parse(txtValorFin.Texts);
            M.Quantidade = int.Parse(txtQuant.Texts);
            M.Unidade = txtUnidade.Texts;
            M.FkFornecedor = int.Parse(cmbFornecedor.SelectedValue.ToString());
            M.FkLicitacao = int.Parse(cmbLicitacao.SelectedValue.ToString());
            M.FkProduto = int.Parse(cmbProduto.SelectedValue.ToString());
            RM.Add(M);
            LimpaCampos();
        }

        private void txtPrecMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite digitar apenas números
            try
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && (e.KeyChar != '.'))
                    e.Handled = true;
                if ((e.KeyChar == '.' && ((sender as RJTextBox).Texts.IndexOf('.') > -1)))
                    e.Handled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtIDMapa_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite digitar apenas números
            try
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                    e.Handled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpaCampos()
        {
            txtIDMapa.Texts = string.Empty;
            txtPrecMax.Texts = string.Empty;
            txtPrecMin.Texts = string.Empty;
            txtQuant.Texts = string.Empty;
            txtQuant.Texts = string.Empty;
            cmbProduto.Text = string.Empty;
            cmbLicitacao.Text = string.Empty;
            cmbFornecedor.Text = string.Empty;
            txtValorFin.Texts = string.Empty;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Mapa m = new Mapa();
            // Pegar o ID Funcionário
            m.IdMapa = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            RM = new RepositorioMapa();

            if (dataGridView1.Columns[e.ColumnIndex] ==
                dataGridView1.Columns[btnExcluir.Index])
            {
                DialogResult result =
                    MessageBox.Show($"Deseja excluir o mapa {m.IdMapa}?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    RM.Delete(m);
                    mostrar_TudoToolStripButton_Click(null, null);
                }

            }
        }

        private void mostrar_TudoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.mapaTableAdapter.Mostrar_Tudo(this.lCPDataSet.Mapa);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
