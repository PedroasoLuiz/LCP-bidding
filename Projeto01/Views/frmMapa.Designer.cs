namespace Projeto01.Views
{
    partial class frmMapa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbCadastros = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtIDMapa = new RJCodeAdvance.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lCPDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lCPDataSet = new Projeto01.LCPDataSet();
            this.lbNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecMax = new RJCodeAdvance.RJControls.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecMin = new RJCodeAdvance.RJControls.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuant = new RJCodeAdvance.RJControls.RJTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUnidade = new RJCodeAdvance.RJControls.RJTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorFin = new RJCodeAdvance.RJControls.RJTextBox();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.fornecedoresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.cmbLicitacao = new System.Windows.Forms.ComboBox();
            this.licitacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.btnSalvar = new RJCodeAdvance.RJControls.RJButton();
            this.btnCancelar = new RJCodeAdvance.RJControls.RJButton();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornecedoresTableAdapter = new Projeto01.LCPDataSetTableAdapters.FornecedoresTableAdapter();
            this.produtoTableAdapter = new Projeto01.LCPDataSetTableAdapters.ProdutoTableAdapter();
            this.licitacaoTableAdapter = new Projeto01.LCPDataSetTableAdapters.LicitacaoTableAdapter();
            this.rjTextBox1 = new RJCodeAdvance.RJControls.RJTextBox();
            this.rjTextBox2 = new RJCodeAdvance.RJControls.RJTextBox();
            this.rjTextBox3 = new RJCodeAdvance.RJControls.RJTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idMapaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorFinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkLicitacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.mapaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mapaTableAdapter = new Projeto01.LCPDataSetTableAdapters.MapaTableAdapter();
            this.mostrar_TudoToolStrip = new System.Windows.Forms.ToolStrip();
            this.mostrar_TudoToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lCPDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lCPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licitacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapaBindingSource)).BeginInit();
            this.mostrar_TudoToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCadastros
            // 
            this.lbCadastros.AutoSize = true;
            this.lbCadastros.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadastros.Location = new System.Drawing.Point(40, 33);
            this.lbCadastros.Name = "lbCadastros";
            this.lbCadastros.Size = new System.Drawing.Size(66, 22);
            this.lbCadastros.TabIndex = 28;
            this.lbCadastros.Text = "Mapa";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(154)))), ((int)(((byte)(175)))));
            this.panel6.Location = new System.Drawing.Point(40, 70);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 2);
            this.panel6.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(40, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 1);
            this.panel2.TabIndex = 26;
            // 
            // txtIDMapa
            // 
            this.txtIDMapa.BackColor = System.Drawing.SystemColors.Window;
            this.txtIDMapa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(154)))), ((int)(((byte)(175)))));
            this.txtIDMapa.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIDMapa.BorderRadius = 5;
            this.txtIDMapa.BorderSize = 1;
            this.txtIDMapa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDMapa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIDMapa.Location = new System.Drawing.Point(168, 105);
            this.txtIDMapa.Margin = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.txtIDMapa.Multiline = false;
            this.txtIDMapa.Name = "txtIDMapa";
            this.txtIDMapa.Padding = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txtIDMapa.PasswordChar = false;
            this.txtIDMapa.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIDMapa.PlaceholderText = "";
            this.txtIDMapa.Size = new System.Drawing.Size(82, 26);
            this.txtIDMapa.TabIndex = 40;
            this.txtIDMapa.Texts = "";
            this.txtIDMapa.UnderlinedStyle = false;
            this.txtIDMapa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDMapa_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbProduto
            // 
            this.cmbProduto.DataSource = this.produtoBindingSource;
            this.cmbProduto.DisplayMember = "Descrição";
            this.cmbProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProduto.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(453, 246);
            this.cmbProduto.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(146, 20);
            this.cmbProduto.TabIndex = 47;
            this.cmbProduto.ValueMember = "idProduto";
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.lCPDataSetBindingSource;
            // 
            // lCPDataSetBindingSource
            // 
            this.lCPDataSetBindingSource.DataSource = this.lCPDataSet;
            this.lCPDataSetBindingSource.Position = 0;
            // 
            // lCPDataSet
            // 
            this.lCPDataSet.DataSetName = "LCPDataSet";
            this.lCPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(60, 156);
            this.lbNome.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(88, 16);
            this.lbNome.TabIndex = 43;
            this.lbNome.Text = "Preço Máximo:";
            this.lbNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Preço Mínimo:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPrecMax
            // 
            this.txtPrecMax.AutoScroll = true;
            this.txtPrecMax.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrecMax.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(154)))), ((int)(((byte)(175)))));
            this.txtPrecMax.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrecMax.BorderRadius = 5;
            this.txtPrecMax.BorderSize = 1;
            this.txtPrecMax.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrecMax.Location = new System.Drawing.Point(167, 151);
            this.txtPrecMax.Margin = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.txtPrecMax.MaximumSize = new System.Drawing.Size(1200, 0);
            this.txtPrecMax.MinimumSize = new System.Drawing.Size(26, 0);
            this.txtPrecMax.Multiline = false;
            this.txtPrecMax.Name = "txtPrecMax";
            this.txtPrecMax.Padding = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txtPrecMax.PasswordChar = false;
            this.txtPrecMax.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPrecMax.PlaceholderText = "";
            this.txtPrecMax.Size = new System.Drawing.Size(148, 26);
            this.txtPrecMax.TabIndex = 42;
            this.txtPrecMax.Texts = "";
            this.txtPrecMax.UnderlinedStyle = false;
            this.txtPrecMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecMax_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(354, 248);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "Produto:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPrecMin
            // 
            this.txtPrecMin.AutoScroll = true;
            this.txtPrecMin.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrecMin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(154)))), ((int)(((byte)(175)))));
            this.txtPrecMin.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrecMin.BorderRadius = 5;
            this.txtPrecMin.BorderSize = 1;
            this.txtPrecMin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrecMin.Location = new System.Drawing.Point(450, 151);
            this.txtPrecMin.Margin = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.txtPrecMin.MaximumSize = new System.Drawing.Size(1200, 0);
            this.txtPrecMin.MinimumSize = new System.Drawing.Size(26, 0);
            this.txtPrecMin.Multiline = false;
            this.txtPrecMin.Name = "txtPrecMin";
            this.txtPrecMin.Padding = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txtPrecMin.PasswordChar = false;
            this.txtPrecMin.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPrecMin.PlaceholderText = "";
            this.txtPrecMin.Size = new System.Drawing.Size(151, 26);
            this.txtPrecMin.TabIndex = 48;
            this.txtPrecMin.Texts = "";
            this.txtPrecMin.UnderlinedStyle = false;
            this.txtPrecMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecMax_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 50;
            this.label4.Text = "Quantidade:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtQuant
            // 
            this.txtQuant.AutoScroll = true;
            this.txtQuant.BackColor = System.Drawing.SystemColors.Window;
            this.txtQuant.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(154)))), ((int)(((byte)(175)))));
            this.txtQuant.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQuant.BorderRadius = 5;
            this.txtQuant.BorderSize = 1;
            this.txtQuant.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQuant.Location = new System.Drawing.Point(167, 197);
            this.txtQuant.Margin = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.txtQuant.MaximumSize = new System.Drawing.Size(1200, 0);
            this.txtQuant.MinimumSize = new System.Drawing.Size(26, 0);
            this.txtQuant.Multiline = false;
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Padding = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txtQuant.PasswordChar = false;
            this.txtQuant.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtQuant.PlaceholderText = "";
            this.txtQuant.Size = new System.Drawing.Size(148, 26);
            this.txtQuant.TabIndex = 49;
            this.txtQuant.Texts = "";
            this.txtQuant.UnderlinedStyle = false;
            this.txtQuant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecMax_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(354, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 52;
            this.label5.Text = "Unidade:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUnidade
            // 
            this.txtUnidade.AutoScroll = true;
            this.txtUnidade.BackColor = System.Drawing.SystemColors.Window;
            this.txtUnidade.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(154)))), ((int)(((byte)(175)))));
            this.txtUnidade.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUnidade.BorderRadius = 5;
            this.txtUnidade.BorderSize = 1;
            this.txtUnidade.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUnidade.Location = new System.Drawing.Point(450, 197);
            this.txtUnidade.Margin = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.txtUnidade.MaximumSize = new System.Drawing.Size(1200, 0);
            this.txtUnidade.MinimumSize = new System.Drawing.Size(26, 0);
            this.txtUnidade.Multiline = false;
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.Padding = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txtUnidade.PasswordChar = false;
            this.txtUnidade.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUnidade.PlaceholderText = "";
            this.txtUnidade.Size = new System.Drawing.Size(151, 26);
            this.txtUnidade.TabIndex = 51;
            this.txtUnidade.Texts = "";
            this.txtUnidade.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 248);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 54;
            this.label6.Text = "Valor Final:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtValorFin
            // 
            this.txtValorFin.AutoScroll = true;
            this.txtValorFin.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorFin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(154)))), ((int)(((byte)(175)))));
            this.txtValorFin.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtValorFin.BorderRadius = 5;
            this.txtValorFin.BorderSize = 1;
            this.txtValorFin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtValorFin.Location = new System.Drawing.Point(167, 243);
            this.txtValorFin.Margin = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.txtValorFin.MaximumSize = new System.Drawing.Size(1200, 0);
            this.txtValorFin.MinimumSize = new System.Drawing.Size(26, 0);
            this.txtValorFin.Multiline = false;
            this.txtValorFin.Name = "txtValorFin";
            this.txtValorFin.Padding = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txtValorFin.PasswordChar = false;
            this.txtValorFin.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtValorFin.PlaceholderText = "";
            this.txtValorFin.Size = new System.Drawing.Size(148, 26);
            this.txtValorFin.TabIndex = 53;
            this.txtValorFin.Texts = "";
            this.txtValorFin.UnderlinedStyle = false;
            this.txtValorFin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecMax_KeyPress);
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.DataSource = this.fornecedoresBindingSource1;
            this.cmbFornecedor.DisplayMember = "Nome";
            this.cmbFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFornecedor.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(172, 294);
            this.cmbFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(137, 20);
            this.cmbFornecedor.TabIndex = 56;
            this.cmbFornecedor.ValueMember = "idFornecedores";
            // 
            // fornecedoresBindingSource1
            // 
            this.fornecedoresBindingSource1.DataMember = "Fornecedores";
            this.fornecedoresBindingSource1.DataSource = this.lCPDataSetBindingSource;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 296);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 55;
            this.label7.Text = "Fornecedor:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbLicitacao
            // 
            this.cmbLicitacao.DataSource = this.licitacaoBindingSource;
            this.cmbLicitacao.DisplayMember = "Tipo";
            this.cmbLicitacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLicitacao.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLicitacao.FormattingEnabled = true;
            this.cmbLicitacao.Location = new System.Drawing.Point(454, 294);
            this.cmbLicitacao.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLicitacao.Name = "cmbLicitacao";
            this.cmbLicitacao.Size = new System.Drawing.Size(145, 20);
            this.cmbLicitacao.TabIndex = 58;
            this.cmbLicitacao.ValueMember = "idLicitacao";
            // 
            // licitacaoBindingSource
            // 
            this.licitacaoBindingSource.DataMember = "Licitacao";
            this.licitacaoBindingSource.DataSource = this.lCPDataSetBindingSource;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(354, 296);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 57;
            this.label8.Text = "Licitação:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(154)))), ((int)(((byte)(175)))));
            this.btnSalvar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(154)))), ((int)(((byte)(175)))));
            this.btnSalvar.BorderColor = System.Drawing.Color.White;
            this.btnSalvar.BorderRadius = 5;
            this.btnSalvar.BorderSize = 0;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(455, 451);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(104, 32);
            this.btnSalvar.TabIndex = 60;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextColor = System.Drawing.Color.White;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.Gray;
            this.btnCancelar.BackgroundColor = System.Drawing.Color.Gray;
            this.btnCancelar.BorderColor = System.Drawing.Color.White;
            this.btnCancelar.BorderRadius = 5;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(560, 451);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 32);
            this.btnCancelar.TabIndex = 59;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // fornecedoresBindingSource
            // 
            this.fornecedoresBindingSource.DataMember = "Fornecedores";
            this.fornecedoresBindingSource.DataSource = this.lCPDataSetBindingSource;
            // 
            // fornecedoresTableAdapter
            // 
            this.fornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // licitacaoTableAdapter
            // 
            this.licitacaoTableAdapter.ClearBeforeFill = true;
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.AutoScroll = true;
            this.rjTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(154)))), ((int)(((byte)(175)))));
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox1.BorderRadius = 5;
            this.rjTextBox1.BorderSize = 1;
            this.rjTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox1.Location = new System.Drawing.Point(167, 291);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.rjTextBox1.MaximumSize = new System.Drawing.Size(1200, 0);
            this.rjTextBox1.MinimumSize = new System.Drawing.Size(26, 0);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "";
            this.rjTextBox1.Size = new System.Drawing.Size(148, 26);
            this.rjTextBox1.TabIndex = 61;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // rjTextBox2
            // 
            this.rjTextBox2.AutoScroll = true;
            this.rjTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(154)))), ((int)(((byte)(175)))));
            this.rjTextBox2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox2.BorderRadius = 5;
            this.rjTextBox2.BorderSize = 1;
            this.rjTextBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox2.Location = new System.Drawing.Point(450, 243);
            this.rjTextBox2.Margin = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.rjTextBox2.MaximumSize = new System.Drawing.Size(1200, 0);
            this.rjTextBox2.MinimumSize = new System.Drawing.Size(26, 0);
            this.rjTextBox2.Multiline = false;
            this.rjTextBox2.Name = "rjTextBox2";
            this.rjTextBox2.Padding = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.rjTextBox2.PasswordChar = false;
            this.rjTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox2.PlaceholderText = "";
            this.rjTextBox2.Size = new System.Drawing.Size(151, 26);
            this.rjTextBox2.TabIndex = 62;
            this.rjTextBox2.Texts = "";
            this.rjTextBox2.UnderlinedStyle = false;
            // 
            // rjTextBox3
            // 
            this.rjTextBox3.AutoScroll = true;
            this.rjTextBox3.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(154)))), ((int)(((byte)(175)))));
            this.rjTextBox3.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox3.BorderRadius = 5;
            this.rjTextBox3.BorderSize = 1;
            this.rjTextBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox3.Location = new System.Drawing.Point(450, 291);
            this.rjTextBox3.Margin = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.rjTextBox3.MaximumSize = new System.Drawing.Size(1200, 0);
            this.rjTextBox3.MinimumSize = new System.Drawing.Size(26, 0);
            this.rjTextBox3.Multiline = false;
            this.rjTextBox3.Name = "rjTextBox3";
            this.rjTextBox3.Padding = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.rjTextBox3.PasswordChar = false;
            this.rjTextBox3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox3.PlaceholderText = "";
            this.rjTextBox3.Size = new System.Drawing.Size(151, 26);
            this.rjTextBox3.TabIndex = 63;
            this.rjTextBox3.Texts = "";
            this.rjTextBox3.UnderlinedStyle = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(154)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = "...";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(154)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 26;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMapaDataGridViewTextBoxColumn,
            this.precoMaxDataGridViewTextBoxColumn,
            this.precoMinDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.unidadeDataGridViewTextBoxColumn,
            this.fkProdutoDataGridViewTextBoxColumn,
            this.valorFinalDataGridViewTextBoxColumn,
            this.fkFornecedorDataGridViewTextBoxColumn,
            this.fkLicitacaoDataGridViewTextBoxColumn,
            this.btnExcluir});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.mapaBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.NullValue = "...";
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(236)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(35, 364);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.NullValue = "...";
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(236)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(629, 74);
            this.dataGridView1.TabIndex = 64;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idMapaDataGridViewTextBoxColumn
            // 
            this.idMapaDataGridViewTextBoxColumn.DataPropertyName = "idMapa";
            this.idMapaDataGridViewTextBoxColumn.HeaderText = "idMapa";
            this.idMapaDataGridViewTextBoxColumn.Name = "idMapaDataGridViewTextBoxColumn";
            this.idMapaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idMapaDataGridViewTextBoxColumn.Width = 76;
            // 
            // precoMaxDataGridViewTextBoxColumn
            // 
            this.precoMaxDataGridViewTextBoxColumn.DataPropertyName = "PrecoMax";
            this.precoMaxDataGridViewTextBoxColumn.HeaderText = "PrecoMax";
            this.precoMaxDataGridViewTextBoxColumn.Name = "precoMaxDataGridViewTextBoxColumn";
            this.precoMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.precoMaxDataGridViewTextBoxColumn.Width = 90;
            // 
            // precoMinDataGridViewTextBoxColumn
            // 
            this.precoMinDataGridViewTextBoxColumn.DataPropertyName = "PrecoMin";
            this.precoMinDataGridViewTextBoxColumn.HeaderText = "PrecoMin";
            this.precoMinDataGridViewTextBoxColumn.Name = "precoMinDataGridViewTextBoxColumn";
            this.precoMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.precoMinDataGridViewTextBoxColumn.Width = 87;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantidadeDataGridViewTextBoxColumn.Width = 99;
            // 
            // unidadeDataGridViewTextBoxColumn
            // 
            this.unidadeDataGridViewTextBoxColumn.DataPropertyName = "Unidade";
            this.unidadeDataGridViewTextBoxColumn.HeaderText = "Unidade";
            this.unidadeDataGridViewTextBoxColumn.Name = "unidadeDataGridViewTextBoxColumn";
            this.unidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.unidadeDataGridViewTextBoxColumn.Width = 80;
            // 
            // fkProdutoDataGridViewTextBoxColumn
            // 
            this.fkProdutoDataGridViewTextBoxColumn.DataPropertyName = "fkProduto";
            this.fkProdutoDataGridViewTextBoxColumn.HeaderText = "fkProduto";
            this.fkProdutoDataGridViewTextBoxColumn.Name = "fkProdutoDataGridViewTextBoxColumn";
            this.fkProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fkProdutoDataGridViewTextBoxColumn.Width = 86;
            // 
            // valorFinalDataGridViewTextBoxColumn
            // 
            this.valorFinalDataGridViewTextBoxColumn.DataPropertyName = "ValorFinal";
            this.valorFinalDataGridViewTextBoxColumn.HeaderText = "ValorFinal";
            this.valorFinalDataGridViewTextBoxColumn.Name = "valorFinalDataGridViewTextBoxColumn";
            this.valorFinalDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorFinalDataGridViewTextBoxColumn.Width = 90;
            // 
            // fkFornecedorDataGridViewTextBoxColumn
            // 
            this.fkFornecedorDataGridViewTextBoxColumn.DataPropertyName = "fkFornecedor";
            this.fkFornecedorDataGridViewTextBoxColumn.HeaderText = "fkFornecedor";
            this.fkFornecedorDataGridViewTextBoxColumn.Name = "fkFornecedorDataGridViewTextBoxColumn";
            this.fkFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.fkFornecedorDataGridViewTextBoxColumn.Width = 107;
            // 
            // fkLicitacaoDataGridViewTextBoxColumn
            // 
            this.fkLicitacaoDataGridViewTextBoxColumn.DataPropertyName = "fkLicitacao";
            this.fkLicitacaoDataGridViewTextBoxColumn.HeaderText = "fkLicitacao";
            this.fkLicitacaoDataGridViewTextBoxColumn.Name = "fkLicitacaoDataGridViewTextBoxColumn";
            this.fkLicitacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fkLicitacaoDataGridViewTextBoxColumn.Width = 93;
            // 
            // btnExcluir
            // 
            this.btnExcluir.DataPropertyName = "idLicitacao";
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.HeaderText = "Ações";
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.ReadOnly = true;
            this.btnExcluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseColumnTextForButtonValue = true;
            this.btnExcluir.Width = 50;
            // 
            // mapaBindingSource
            // 
            this.mapaBindingSource.DataMember = "Mapa";
            this.mapaBindingSource.DataSource = this.lCPDataSet;
            // 
            // mapaTableAdapter
            // 
            this.mapaTableAdapter.ClearBeforeFill = true;
            // 
            // mostrar_TudoToolStrip
            // 
            this.mostrar_TudoToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.mostrar_TudoToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrar_TudoToolStripButton});
            this.mostrar_TudoToolStrip.Location = new System.Drawing.Point(35, 340);
            this.mostrar_TudoToolStrip.Name = "mostrar_TudoToolStrip";
            this.mostrar_TudoToolStrip.Size = new System.Drawing.Size(127, 25);
            this.mostrar_TudoToolStrip.TabIndex = 65;
            this.mostrar_TudoToolStrip.Text = "mostrar_TudoToolStrip";
            // 
            // mostrar_TudoToolStripButton
            // 
            this.mostrar_TudoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mostrar_TudoToolStripButton.Name = "mostrar_TudoToolStripButton";
            this.mostrar_TudoToolStripButton.Size = new System.Drawing.Size(84, 22);
            this.mostrar_TudoToolStripButton.Text = "Mostrar_Tudo";
            this.mostrar_TudoToolStripButton.Click += new System.EventHandler(this.mostrar_TudoToolStripButton_Click);
            // 
            // frmMapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 512);
            this.Controls.Add(this.mostrar_TudoToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cmbLicitacao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbFornecedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtValorFin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUnidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQuant);
            this.Controls.Add(this.txtPrecMin);
            this.Controls.Add(this.cmbProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.txtPrecMax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDMapa);
            this.Controls.Add(this.lbCadastros);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.rjTextBox1);
            this.Controls.Add(this.rjTextBox2);
            this.Controls.Add(this.rjTextBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMapa";
            this.Text = "frmMapa";
            this.Load += new System.EventHandler(this.frmMapa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lCPDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lCPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licitacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapaBindingSource)).EndInit();
            this.mostrar_TudoToolStrip.ResumeLayout(false);
            this.mostrar_TudoToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbCadastros;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private RJCodeAdvance.RJControls.RJTextBox txtIDMapa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProduto;
        public System.Windows.Forms.Label lbNome;
        public System.Windows.Forms.Label label2;
        private RJCodeAdvance.RJControls.RJTextBox txtPrecMax;
        private System.Windows.Forms.Label label3;
        private RJCodeAdvance.RJControls.RJTextBox txtPrecMin;
        public System.Windows.Forms.Label label4;
        private RJCodeAdvance.RJControls.RJTextBox txtQuant;
        public System.Windows.Forms.Label label5;
        private RJCodeAdvance.RJControls.RJTextBox txtUnidade;
        public System.Windows.Forms.Label label6;
        private RJCodeAdvance.RJControls.RJTextBox txtValorFin;
        private System.Windows.Forms.ComboBox cmbFornecedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbLicitacao;
        private System.Windows.Forms.Label label8;
        private RJCodeAdvance.RJControls.RJButton btnSalvar;
        private RJCodeAdvance.RJControls.RJButton btnCancelar;
        private System.Windows.Forms.BindingSource lCPDataSetBindingSource;
        private LCPDataSet lCPDataSet;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private LCPDataSetTableAdapters.FornecedoresTableAdapter fornecedoresTableAdapter;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource1;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private LCPDataSetTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.BindingSource licitacaoBindingSource;
        private LCPDataSetTableAdapters.LicitacaoTableAdapter licitacaoTableAdapter;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox1;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox2;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource mapaBindingSource;
        private LCPDataSetTableAdapters.MapaTableAdapter mapaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMapaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorFinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkLicitacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnExcluir;
        private System.Windows.Forms.ToolStrip mostrar_TudoToolStrip;
        private System.Windows.Forms.ToolStripButton mostrar_TudoToolStripButton;
    }
}