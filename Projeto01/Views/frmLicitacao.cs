using System;
using Projeto01.Model;
using Projeto01.Repositórios;
using System.Windows.Forms;

namespace Projeto01.Views
{
    public partial class frmLicitacao : Form
    {
        public frmLicitacao()
        {
            InitializeComponent();
        }
  
        RepositorioLicitacao RL = null;
        
        //RepositorioCliente RepCli = new RepositorioCliente();
        private void btnSalvar_Click(object sender, EventArgs e)
        {
        
            RL = new RepositorioLicitacao();
            Licitacao L = new Licitacao();
            L.CodLicitacao = int.Parse(txtCodExterno.Texts);
            L.Tipo = txtTipoLic.Texts;
            L.Data = dataLic.Value;
            L.FkCliente = int.Parse(cmbCliente.SelectedValue.ToString());
            RL.Add(L);

        }

        private void frmLicitacao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lCPDataSet.Licitacao'. Você pode movê-la ou removê-la conforme necessário.
            this.licitacaoTableAdapter.Fill(this.lCPDataSet.Licitacao);
            // TODO: esta linha de código carrega dados na tabela 'lCPDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.lCPDataSet.Cliente);

            frmPrincipal frmPrin = new frmPrincipal();
            this.Top = frmPrin.Top + 6;
            this.Width = ActiveForm.Width - 208;
            this.Height = ActiveForm.Height - 6;
            this.Left = frmPrin.Left + 208;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void fillTipoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.licitacaoTableAdapter.FillTipo(this.lCPDataSet.Licitacao, tipoToolStripTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void tipoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.licitacaoTableAdapter.Tipo(this.lCPDataSet.Licitacao, tipoToolStripTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnMostraTudo_Click(object sender, EventArgs e)
        {
            try
            {
                this.licitacaoTableAdapter.MostraTudo(this.lCPDataSet.Licitacao);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Licitacao L = new Licitacao();
            // Pegar o ID Funcionário
            L.IdLicitacao = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            RL = new RepositorioLicitacao();
            
            if (dataGridView1.Columns[e.ColumnIndex] == 
                dataGridView1.Columns[btnExcluir.Index])
            {
                DialogResult result = 
                    MessageBox.Show($"Deseja excluir a licitação {L.IdLicitacao}?","Excluir",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    RL.Delete(L);
                    btnMostraTudo_Click(null,null);
                }
                    
            }

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
        }

        private void dtCLick(object sender, EventArgs e)
        {
           
        }

        private void txtTipoLic__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
