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

namespace Projeto01.Views
{
    public partial class frmLicitacao : Form
    {
        public frmLicitacao()
        {
            InitializeComponent();
        }
  
        RepositorioLicitacao RL = new RepositorioLicitacao();
        Licitacao L = new Licitacao();
        RepositorioCliente RepCli = new RepositorioCliente();
        private void btnSalvar_Click(object sender, EventArgs e)
        {
        
            RL = new RepositorioLicitacao();
            L = new Licitacao();  
            L.Data = dataLic.Value;
            L.CodLicitacao = int.Parse(txtIDlic.Texts);
            L.Tipo = txtTipoLic.Texts;
            L.FkCliente = (int)cmbCliente.SelectedValue;
            RL.Add(L);

        }

        private void frmLicitacao_Load(object sender, EventArgs e)
        {
            cmbCliente.DataSource = RepCli.GetAll();
            cmbCliente.DisplayMember = "Nome";
            cmbCliente.ValueMember = "idCliente";
            cmbCliente.AutoCompleteSource = AutoCompleteSource.ListItems;
            L.FkCliente = int.Parse(cmbCliente.ValueMember);
        
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbclient_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCliente.AutoCompleteSource = AutoCompleteSource.ListItems;
            L.FkCliente = int.Parse(cmbCliente.ValueMember);
        }
    }
}
