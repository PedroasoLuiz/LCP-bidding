using System;
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
using Projeto01.Model;
using Projeto01.Repositórios;

namespace Projeto01.Views
{
    public partial class frmMapa : Form
    {
        public frmMapa()
        {
            InitializeComponent();
        }
        Mapa M = new Mapa();
        RepositorioMapa RM = new RepositorioMapa();
        RepositorioLicitacao RepLic = new RepositorioLicitacao();
        RepositorioProduto RepProd = new RepositorioProduto();
        RepositorioFornecedores RepForn = new RepositorioFornecedores();
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMapa_Load(object sender, EventArgs e)
        {
            cmbLicitacao.DataSource = RepLic.GetAll();
            cmbLicitacao.DisplayMember = "Tipo";
            cmbLicitacao.ValueMember = "idLicitação";
            cmbLicitacao.AutoCompleteSource = AutoCompleteSource.ListItems;
            M.FkLicitacao = int.Parse(cmbLicitacao.ValueMember);

            cmbProduto.DataSource = RepProd.GetAll();
            cmbProduto.DisplayMember = "Descrição";
            cmbProduto.ValueMember = "idProduto";
            cmbProduto.AutoCompleteSource = AutoCompleteSource.ListItems;
            M.FkProduto = int.Parse(cmbProduto.ValueMember);

            cmbFornecedor.DataSource = RepLic.GetAll();
            cmbFornecedor.DisplayMember = "Nome";
            cmbFornecedor.ValueMember = "idFornecedores";
            cmbFornecedor.AutoCompleteSource = AutoCompleteSource.ListItems;
            M.FkFornecedor = int.Parse(cmbFornecedor.ValueMember);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            M = new Mapa();
            M.PrecoMax = double.Parse(txtPrecMax.Text);
            M.PrecoMin = double.Parse(txtPrecMin.Text);
            M.ValorFinal = double.Parse(txtValorFin.Text);
            M.Quantidade = int.Parse(txtQuant.Text);
            M.Unidade = txtUnidade.Text;
            M.FkFornecedor = (int)cmbFornecedor.SelectedValue;
            M.FkLicitacao = (int)cmbLicitacao.SelectedValue;
            M.FkProduto = (int)cmbProduto.SelectedValue;
            RM.Add(M);
        }
    }
}
