using System;
using Projeto01.Model;
using Projeto01.Repositórios;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto01
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }
        
        public int operacaoInterna;
        // Operação Interna é a variável que determinará se o reposítorio
        // de trabalho da chamada
        // [RepositorioCliente], [RepositorioFornecedores]

        public int operacao;
        // Operação será a variável que atribuirá o tipo da ação
        // quer será realizada ao executar o comando
        // [Buscar], [Alterar], [Cadastrar], [Excluir]




        RepositorioCliente RepCli = null;
        RepositorioFornecedores RepForn = null;

        private void frmCliente_Load(object sender, EventArgs e)
        {
            frmPrincipal frmPrin = new frmPrincipal();
            this.Top = frmPrin.Top +6;
            this.Width = ActiveForm.Width - 208;
            this.Height = ActiveForm.Height -6;
            this.Left = frmPrin.Left + 208;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            txtCidade.Enabled = true;
            txtUF.Enabled = true;

            btnBuscar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (operacaoInterna)
                {
                    // Operação realizada para o repositório {CLIENTE}
                    case 1:
                        RepCli = new RepositorioCliente();
                        
                        switch (operacao)
                        {
                            // Operaç
                            case 1:
                                break;

                            default:
                                break;
                        }


                        break;

                    // Operação realizada para o repositório {FORNECEDOR}
                    case 2:
                        RepForn = new RepositorioFornecedores();

                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            btnBuscar.Enabled = true;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }
    }
}
