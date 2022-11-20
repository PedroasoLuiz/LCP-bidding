using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using RJCodeAdvance.RJControls;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto01.Properties;
using Projeto01.Model;
using Projeto01.Views;

namespace Projeto01
{
    public partial class frmPrincipal : MetroFramework.Forms.MetroForm
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        public int opcoes = 0;
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lCPDataSet.Mapa'. Você pode movê-la ou removê-la conforme necessário.
            this.mapaTableAdapter.Fill(this.lCPDataSet.Mapa);
            picOP.Left = 3;
        }
        private void frmPrincipal_Resize(object sender, EventArgs e)
        {
            panelOpcoes.Height = this.Height;
        }

        private void picOP_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                switch (opcoes)
                {
                    // Recolhe o menu de opções
                    case 0:
                        int l = 0;
                        while (l > (-210))
                        {
                            panelOpcoes.Left = l;
                            l--;                            
                        }
                        picOP.Image = Resources.op1;
                        picOP.Left = 3;
                        opcoes = 1;
                        break;

                    // Mostra o menu de opções
                    case 1:
                        int j = -210;
                        while (j !=0)
                        {
                            panelOpcoes.Left = j;
                            j++;
                        }
                        picOP.Image = Resources.op0;
                        picOP.Left = 3;
                        opcoes = 0;
                        break;

                    default:

                        break;
                }
                timer1.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        { Def_Clientes(); }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        { Def_Fornecedor(); }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        { Def_Produtos(); }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        { Def_Marcas(); }

        private void Def_Clientes()
        {
            frmCadastro fc = new frmCadastro();

            // Define a operação como cliente
            fc.operacaoInterna = 1;
            fc.lbCadastros.Text = "Cadastros: CLIENTES"; // Defino o título do módulo

            fc.etiqueta = "Fornecedor";
            fc.lbCodExt.Visible = true;             // Ativo a label cod externo
            fc.txtCodigoExterno.Visible = true;     // Ativo o textbox cod externo
            fc.lbCidade.Visible = true;             // Ativo a label cidade
            fc.txtCidade.Visible = true;            // Ativo o textbox cidade
            fc.lbUF.Visible = true;                 // Ativo a label estado
            fc.txtUF.Visible = true;                // Ativo o textbox 

            fc.ShowDialog();
        }

        private void Def_Fornecedor()
        {
            frmCadastro fc = new frmCadastro();

            // Define a operação como fornecedores
            fc.operacaoInterna = 2;
            fc.lbCadastros.Text = "Cadastros: FORNECEDORES";
            fc.btnatvEtiqueta1.Text = "                 Cliente";

            fc.etiqueta = "Cliente";
            fc.lbTipo.Visible = true;
            fc.txtTipo.Visible = true;
            fc.lbCidade.Visible = true;
            fc.txtCidade.Visible = true;
            fc.lbUF.Visible = true;
            fc.txtUF.Visible = true;
            fc.ShowDialog();
        }
        
        private void Def_Marcas()
        {
            frmCadastro fc = new frmCadastro();

            // Define a operação como Marcas
            fc.operacaoInterna = 3;
            fc.lbCadastros.Text = "Cadastro: MARCAS";
            fc.lbNome.Text = "Descrição:";
            fc.pEtiquetas.Visible = false;
            fc.ShowDialog();
        }

        private void Def_Produtos()
        {
            frmCadastro fc = new frmCadastro();

            // Define a operação como produtos
            fc.operacaoInterna = 4;
            fc.lbCadastros.Text = "Cadastros: PRODUTOS";
            fc.lbNome.Text = "Descrição:";
            fc.panelProduto.Visible = true;
            fc.lbCodExt.Visible = true;
            fc.txtCodigoExterno.Visible = true;
            fc.pEtiquetas.Visible = false;
            fc.ShowDialog();
        }

        private void mapaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMapa fm = new frmMapa();
            fm.ShowDialog();
        }

        private void licitaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void novaLicitaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLicitacao fl = new frmLicitacao();
            fl.ShowDialog();

        }
    }
}
