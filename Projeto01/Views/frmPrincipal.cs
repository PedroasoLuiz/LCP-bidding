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

namespace Projeto01
{
    public partial class frmPrincipal : MetroFramework.Forms.MetroForm
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        frmLogin frmLogin = null;
        public int opcoes = 0;
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
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
        {
            frmCadastro fc = new frmCadastro();

            // Define a operação como cliente
            fc.operacaoInterna = 1;
            fc.lbCadastros.Text = "Cadastros: CLIENTES";
            fc.lbTipo.Visible = false;
            fc.txtTipo.Visible = false;
            fc.ShowDialog();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastro fc = new frmCadastro();

            // Define a operação como fornecedores
            fc.operacaoInterna = 2;
            fc.lbCadastros.Text = "Cadastros: FORNECEDORES";
            fc.lbTipo.Visible = true;
            fc.txtTipo.Visible = true;
            fc.ShowDialog();
        }
    }
}
