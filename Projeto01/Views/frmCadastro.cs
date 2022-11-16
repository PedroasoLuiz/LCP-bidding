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
using System.Runtime.CompilerServices;
using RJCodeAdvance.RJControls;
using System.Security.Policy;

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
        public string etiqueta;

        RepositorioCliente RepCli;
        RepositorioFornecedores RepForn;
        RepositorioProduto RepProd;
        RepositorioMarcas RepMarc;


        private void frmCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lCPDataSet1.Marcas'. Você pode movê-la ou removê-la conforme necessário.
            this.marcasTableAdapter1.Fill(this.lCPDataSet1.Marcas);
            frmPrincipal frmPrin = new frmPrincipal();
            this.Top = frmPrin.Top +6;
            this.Width = ActiveForm.Width - 208;
            this.Height = ActiveForm.Height -6;
            this.Left = frmPrin.Left + 208;
          
            CarregaGridView();

        }

        // ************** Botões de ações ******************

        private void btnNovo_Click(object sender, EventArgs e)
        {
            AtivaCampos();
            DesativaControles();
            operacao = 1;
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            txtID.Enabled = true;
            operacao = 2;
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            txtID.Enabled = true;
            DesativaControles();
            btnSalvar.Text = "Excluir";
            btnSalvar.BackColor = Color.FromArgb(255, 0, 0);
            operacao = 3;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Caso o campo de ID esteja nulo, nenhuma operação será realizada
                //if (txtID.Texts == string.Empty) return;

                switch (operacaoInterna)
                {
                    // Operação realizada para o repositório {CLIENTE}
                    case 1:
                        RepCli = new RepositorioCliente();
                        Cliente c = null;

                        switch (operacao)
                        {
                            // Operação de cadastro de clientes;
                            case 1:
                                c = new Cliente();
                                c.CodCliente = int.Parse(txtCodigoExterno.Texts);
                                c.Nome = txtNome.Texts;
                                c.Cidade = txtCidade.Texts;
                                c.Estado = txtUF.Texts;

                                RepCli.Add(c);

                                break;

                            // Operação de atualização de clientes
                            case 2:
                                c = new Cliente();

                                c.IdCliente = int.Parse(txtID.Texts);
                                c.CodCliente = int.Parse(txtCodigoExterno.Texts);
                                c.Nome = txtNome.Texts;
                                c.Cidade = txtCidade.Texts;
                                c.Estado = txtUF.Texts;

                                RepCli.Update(c);
                                break;

                            // Operação de exclusão de clientes
                            case 3:
                                c = new Cliente();
                                c.IdCliente = int.Parse(txtID.Texts);
                                RepCli.Delete(c);
                                break;

                            default:
                                MessageBox.Show("Não foi possível realizar a operação solicitada, tente novamente.", "Erro de operação", MessageBoxButtons.OK, MessageBoxIcon.Error);  
                                break;
                        }

                        if (atvEtiqueta1.Checked == true && etiqueta == "Fornecedor")
                        {
                            operacaoInterna = 2;
                            btnSalvar_Click(sender, e);
                        }
                        operacaoInterna = 1;
                        break;

                    // Operação realizada para o repositório {FORNECEDOR}
                    case 2:
                        RepForn = new RepositorioFornecedores();
                        Fornecedores f = new Fornecedores();

                        switch (operacao)
                        {
                            // Operação para cadastro de fornecedores
                            case 1:
                                f.Nome = txtNome.Texts;
                                f.Cidade = txtCidade.Texts;
                                f.Estado = txtUF.Texts;
                                f.Tipo = txtTipo.Texts;

                                RepForn.Add(f);
                                break;

                            // Operação para atualização de fornecedores
                            case 2:
                                f.IdFornecedores = int.Parse(txtID.Texts);
                                f.Nome = txtNome.Texts;
                                f.Cidade = txtCidade.Texts;
                                f.Estado = txtUF.Texts;
                                f.Tipo = txtTipo.Texts;

                                RepForn.Update(f);
                                break;

                            // Operação para exclusão de fornecedores
                            case 3:
                                f.IdFornecedores = int.Parse(txtID.Texts);
                                RepForn.Delete(f);
                                break;

                            default:
                                MessageBox.Show("Não foi possível realizar a operação solicitada, tente novamente.", "Erro de operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }
                        if (atvEtiqueta1.Checked ==true && etiqueta == "Cliente")
                        {
                            operacaoInterna = 1;
                            btnSalvar_Click(sender, e);
                        }
                        operacaoInterna = 2;
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
                                m.Nome = txtNome.Texts;

                                RepMarc.Add(m);
                                break;

                            // Operação para atualização de marcas
                            case 2:
                                m.IdMarca = int.Parse(txtID.Texts);
                                m.Nome = txtNome.Texts;

                                RepMarc.Update(m);
                                break;

                            // Operação para exclusão de marcas
                            case 3:
                                m.IdMarca = int.Parse(txtID.Texts);

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

                        switch (operacao)
                        {
                            // Operação para cadastro de marcas
                            case 1:
                                p.CodProduto = int.Parse(txtCodigoExterno.Texts);
                                p.Descricao = txtNome.Texts;
                                p.Custo = double.Parse(txtCusto.Texts);
                                p.Unidade = txtUnid.Texts;
                                p.Marca = cmbMarca.ValueMember;

                                RepProd.Add(p);
                                break;

                            // Operação para atualização de marcas
                            case 2:
                                p.IdProduto = int.Parse(txtID.Texts);
                                p.CodProduto = int.Parse(txtCodigoExterno.Texts);
                                p.Descricao = txtNome.Texts;
                                p.Custo = double.Parse(txtCusto.Texts);
                                p.Unidade = txtUnid.Texts;
                                p.Marca = cmbMarca.ValueMember;

                                MessageBox.Show(cmbMarca.ValueMember);

                                RepProd.Update(p);
                                break;

                            // Operação para exclusão de marcas
                            case 3:
                                p.IdProduto = int.Parse(txtID.Texts);

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
                LimpaCampos();
                DesativaCampos();
                CarregaGridView();

                EstadoOriginalSalvar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        // Métodos para alterações nos campos

        private void AtivaControles()
        {
            btnNovo.Enabled = true;     // Ativa o botão de novo cadastro
            btnAlterar.Enabled = true;  // Ativa o botão de alteração
            btnExcluir.Enabled = true;  // Ativa o botão de exclusão
        }

        private void AtivaCampos()
        {
            txtID.Enabled = true;
            txtCodigoExterno.Enabled = true;    // Ativa a edição do campo do código externo
            txtNome.Enabled = true;             // Ativa a edição do campo nome
            txtCidade.Enabled = true;           // Ativa a edição do campo cidade
            txtUF.Enabled = true;               // Ativa a edição do campo estado [UF]
            txtTipo.Enabled = true;             // Ativa a edição do campo tipo   [Para fornecedores]
            txtCusto.Enabled = true;
            txtUnid.Enabled = true;
            txtMarca.Enabled = true;
        }

        private void DesativaControles()
        {
            
            btnNovo.Enabled = false;     // Desativa o botão de novo cadastro
            btnAlterar.Enabled = false;  // Desativa o botão de alteração
            btnExcluir.Enabled = false;  // Desativa o botão de exclusão
        }

        private void DesativaCampos()
        {
            txtID.Enabled = false;
            txtCodigoExterno.Enabled = false;    // Desativa a edição do campo do código externo
            txtNome.Enabled = false;             // Desativa a edição do campo nome
            txtCidade.Enabled = false;           // Desativa a edição do campo cidade
            txtUF.Enabled = false;               // Desativa a edição do campo estado [UF]
            txtTipo.Enabled = false;             // Desativa a edição do campo tipo   [Para fornecedores]
            txtCusto.Enabled = false;
            txtUnid.Enabled = false;
            txtMarca.Enabled = false;
        }
        private void LimpaCampos()
        {

            txtNome.Texts = string.Empty;
            txtCodigoExterno.Texts = string.Empty;
            txtID.Texts = string.Empty;
            txtCidade.Texts = string.Empty;
            txtUF.Texts = string.Empty;
            txtTipo.Texts = string.Empty;
            txtCusto.Texts = string.Empty;
            txtUnid.Texts = string.Empty;
            txtMarca.Texts = string.Empty;

        }

        private void EstadoOriginalSalvar()
        {
            btnSalvar.Text = "Salvar";
            btnSalvar.BackColor = Color.FromArgb(27, 154, 175);
        }

        private void CarregaGridView()
        {
            try
            {
                switch (operacaoInterna)
                {
                    // Busca todos os cadastros de clientes
                    case 1:
                        RepCli = new RepositorioCliente();
                        dataGridView1.DataSource = RepCli.GetAll();
                        break;
                    // Busca todos os cadastros de fornecedores
                    case 2:
                        RepForn = new RepositorioFornecedores();
                        dataGridView1.DataSource = RepForn.GetAll();
                        break;
                    // Busca todos os cadastro de marcas
                    case 3:
                        RepMarc = new RepositorioMarcas();
                        dataGridView1.DataSource = RepMarc.GetAll();
                        break;
                    // Busca todos os cadastros de produtos
                    case 4:
                        RepProd = new RepositorioProduto();
                        dataGridView1.DataSource = RepProd.GetAll();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnatvEtiqueta1_Click(object sender, EventArgs e)
        {
            if (atvEtiqueta1.Checked == false)
                atvEtiqueta1.Checked = true;
            else
                atvEtiqueta1.Checked = false;
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            try
            {
                // Caso o campo esteja vazio, sai do método
                if (txtID.Texts == string.Empty) return;

                switch (operacaoInterna)
                {
                    case 1:
                        RepCli = new RepositorioCliente();
                        Cliente c = new Cliente();

                        c = RepCli.BuscaID(int.Parse(txtID.Texts));
                        if (c.IdCliente != 0)
                        {
                            AtivaCampos();
                            DesativaControles();
                            txtID.Texts = c.IdCliente.ToString();
                            txtCodigoExterno.Texts = c.CodCliente.ToString();
                            txtNome.Texts = c.Nome;
                            txtCidade.Texts = c.Cidade;
                            txtUF.Texts = c.Estado;
                        }
                        else
                            LimpaCampos();
                        break;

                    case 2:
                        RepForn = new RepositorioFornecedores();
                        Fornecedores f = new Fornecedores();

                        f = RepForn.BuscaID(int.Parse(txtID.Texts));
                        if (f.IdFornecedores != 0)
                        {
                            AtivaCampos();
                            DesativaControles();
                            txtID.Texts = f.IdFornecedores.ToString();
                            txtTipo.Texts = f.Tipo;
                            txtNome.Texts = f.Nome;
                            txtCidade.Texts = f.Cidade;
                            txtUF.Texts = f.Estado;
                        }
                        else
                            LimpaCampos();
                        break;
                    case 4:
                        RepProd = new RepositorioProduto();
                        Produto p = new Produto();

                        p = RepProd.BuscaID(int.Parse(txtID.Texts));
                        if (p.IdProduto != 0)
                        {
                            AtivaCampos();
                            DesativaControles();
                            txtID.Texts = p.IdProduto.ToString();
                            txtCodigoExterno.Texts = p.CodProduto.ToString();
                            txtNome.Texts = p.Descricao.ToString();
                            txtCusto.Texts = p.Custo.ToString();
                            txtUnid.Texts = p.Unidade;
                            cmbMarca.Text = p.Marca;
                        }
                        else
                            LimpaCampos();
                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                 
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Close();
        }   
        private void btnCancela_Click(object sender, EventArgs e)
        {
            AtivaControles();
            DesativaCampos();
            EstadoOriginalSalvar();
        }

        private void atvEtiqueta1_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (atvEtiqueta1.Checked == true)
                {
                    switch (operacaoInterna)
                    {
                        case 1:
                            txtTipo.Visible = true;
                            lbTipo.Visible = true;
                            break;
                        case 2:
                            lbCodExt.Visible = true;
                            txtCodigoExterno.Visible = true;
                            break;
                    }
                }
                else
                {
                    switch(operacaoInterna)
                    {
                        case 1:
                            txtTipo.Visible = false;
                            lbTipo.Visible = false;
                            break;
                        case 2:
                            lbCodExt.Visible = false;
                            txtCodigoExterno.Visible = false;
                            break;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCodigoExterno_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCusto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void lbCadastros_Click(object sender, EventArgs e)
        {

        }
    }
}
