using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto01.Model;
using Projeto01.Repositórios;

namespace Projeto01.Views
{
    public partial class frmLicitacao : Form
    {
        public frmLicitacao()
        {
            InitializeComponent();
        }
    //    private DateTime Data;
        RepositorioLicitacao RL = new RepositorioLicitacao();
        Licitacao L = new Licitacao();
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //if (txtIDlic.Texts == string.Empty) return;

            RL = new RepositorioLicitacao();
            L = new Licitacao();  
            L.Data = dataLic.Value;
            L.CodLicitacao = int.Parse(txtIDlic.Texts);
            L.Tipo = txtTipoLic.Texts;

            cmbCliente.AutoCompleteSource = AutoCompleteSource.ListItems;
            L.FkCliente = int.Parse(cmbCliente.ValueMember);   
        }

        private void frmLicitacao_Load(object sender, EventArgs e)
        {
            cmbCliente.DataSource = RL.GetAll();
            cmbCliente.DisplayMember = "nome"; // Pedrin conf se o nome na tabela é nome
            cmbCliente.ValueMember = "idCliente"; // conf se o nome na tabela é IdCliente
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
