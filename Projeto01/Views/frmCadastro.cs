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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }
        
        public int operacaoInterna;
        // Operação Interna é a variável que determinará se o reposítorio
        // de trabalho da chamada
        // [RepositorioCliente], [RepositorioFornecedores]

        private int operacao;
        // Operação será a variável que atribuirá o tipo da ação
        // quer será realizada ao executar o comando
        // [Buscar], [Alterar], [Cadastrar], [Excluir]


        RepositorioCliente RepCli = null;       
        RepositorioFornecedores RepForn = null;
        RepositorioProduto RepProd = null;
        RepositorioMarcas RepMarc = null;

        private void frmCliente_Load(object sender, EventArgs e)
        {
            frmPrincipal frmPrin = new frmPrincipal();
            this.Top = frmPrin.Top +6;
            this.Width = ActiveForm.Width - 208;
            this.Height = ActiveForm.Height -6;
            this.Left = frmPrin.Left + 208;

        }

        // ************** Botões de ações ******************

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AtivaControles();
            DesativaCampos();
            this.Close();
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            AtivaCampos();
            DesativaControles();
            operacao = 1;
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AtivaCampos();
            DesativaControles();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            txtID.Enabled = true;
            DesativaControles();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Caso o campo de ID esteja nulo, nenhuma operação será realizada
                if (txtID.Texts == string.Empty) return;

                switch (operacaoInterna)
                {
                    // Operação realizada para o repositório {CLIENTE}
                    case 1:
                        RepCli = new RepositorioCliente();
                        Cliente c = new Cliente();

                        c.IdCliente = int.Parse(txtID.Texts);
                        c.CodCliente = int.Parse(txtCodigoExterno.Texts);
                        c.Nome = txtNome.Texts;
                        c.Cidade = txtCidade.Texts;
                        c.Estado = txtUF.Texts;

                        switch (operacao)
                        {
                            // Operação de cadastro de clientes;
                            case 1:
                                RepCli.Add(c);
                                break;

                            // Operação de atualização de clientes
                            case 2:
                                RepCli.Update(c);
                                break;

                            // Operação de exclusão de clientes
                            case 3:
                                RepCli.Delete(c);
                                break;

                            default:
                                MessageBox.Show("Não foi possível realizar a operação solicitada, tente novamente.", "Erro de operação", MessageBoxButtons.OK, MessageBoxIcon.Error);  
                                break;
                        }


                        break;

                    // Operação realizada para o repositório {FORNECEDOR}
                    case 2:
                        RepForn = new RepositorioFornecedores();
                        Fornecedores f = new Fornecedores();

                        f.IdFornecedores = int.Parse(txtID.Texts);
                        f.CodFornecedores = int.Parse(txtCodigoExterno.Texts);
                        f.Nome = txtNome.Texts;
                        f.Cidade = txtCidade.Texts;
                        f.Estado = txtUF.Texts;
                        f.Tipo = txtTipo.Texts;

                        switch (operacao)
                        {
                            // Operação para cadastro de fornecedores
                            case 1:
                                RepForn.Add(f);
                                break;

                            // Operação para atualização de fornecedores
                            case 2:
                                RepForn.Update(f);
                                break;

                            // Operação para exclusão de fornecedores
                            case 3:
                                RepForn.Delete(f);
                                break;

                            default:
                                MessageBox.Show("Não foi possível realizar a operação solicitada, tente novamente.", "Erro de operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }

                        break;

                    // Operação realizada para o reposítório {MARCA}
                    case 3:
                        RepMarc = new RepositorioMarcas();
                        Marcas m = new Marcas();

                        m.IdMarca = int.Parse(txtID.Texts);
                        m.Nome = txtNome.Texts;

                        
                        switch (operacao)
                        {
                            // Operação para cadastro de marcas
                            case 1:
                                RepMarc.Add(m);
                                break;

                            // Operação para atualização de marcas
                            case 2:
                                RepMarc.Update(m);
                                break;

                            // Operação para exclusão de marcas
                            case 3:
                                RepMarc.Delete(m);
                                break;

                            default:
                                MessageBox.Show("Não foi possível realizar a operação solicitada, tente novamente.", "Erro de operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }

                        break;


                    // Operação realizada para repositório {PRODUTOS}
                    case 4:
                        RepProd = new RepositorioProduto();
                        Produto p = new Produto();

                        p.IdProduto = int.Parse(txtID.Texts);
                        p.CodProduto = int.Parse(txtCodigoExterno.Texts);
                        p.Descricao = txtNome.Texts;
                        p.Custo = double.Parse(txtCusto.Texts);
                        p.Unidade = txtUnid.Texts;
                        //p.FkMarcas = int.Parse();

                        switch (operacao)
                        {
                            // Operação para cadastro de marcas
                            case 1:
                                RepProd.Add(p);
                                break;

                            // Operação para atualização de marcas
                            case 2:
                                RepProd.Update(p);
                                break;

                            // Operação para exclusão de marcas
                            case 3:
                                RepProd.Delete(p);
                                break;

                            default:
                                MessageBox.Show("Não foi possível realizar a operação solicitada, tente novamente.", "Erro de operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }

                        break;

                    default:
                        break;

                }
                AtivaControles();
                DesativaCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }


        // Métodos para alterações nos campos

        private void AtivaControles()
        {
            btnBuscar.Enabled = true;   // Ativa o botão de pesquisa
            btnNovo.Enabled = true;     // Ativa o botão de novo cadastro
            btnAlterar.Enabled = true;  // Ativa o botão de alteração
            btnExcluir.Enabled = true;  // Ativa o botão de exclusão
        }

        private void AtivaCampos()
        {
            txtCodigoExterno.Enabled = true;    // Ativa a edição do campo do código externo
            txtNome.Enabled = true;             // Ativa a edição do campo nome
            txtCidade.Enabled = true;           // Ativa a edição do campo cidade
            txtUF.Enabled = true;               // Ativa a edição do campo estado [UF]
            txtTipo.Enabled = true;             // Ativa a edição do campo tipo   [Para fornecedores]
        }

        private void DesativaControles()
        {
            btnBuscar.Enabled = false;   // Desativa o botão de pesquisa
            btnNovo.Enabled = false;     // Desativa o botão de novo cadastro
            btnAlterar.Enabled = false;  // Desativa o botão de alteração
            btnExcluir.Enabled = false;  // Desativa o botão de exclusão
        }

        private void DesativaCampos()
        {
            txtCodigoExterno.Enabled = false;    // Desativa a edição do campo do código externo
            txtNome.Enabled = false;             // Desativa a edição do campo nome
            txtCidade.Enabled = false;           // Desativa a edição do campo cidade
            txtUF.Enabled = false;               // Desativa a edição do campo estado [UF]
            txtTipo.Enabled = false;             // Desativa a edição do campo tipo   [Para fornecedores]
        }


    }
}
