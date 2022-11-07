using System;
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

            txtID.Enabled = true;
            txtNome.Enabled = true;
            txtCidade.Enabled = true;
            txtUF.Enabled = true;

            btnBuscar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            btnBuscar.Enabled = true;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }
    }
}
