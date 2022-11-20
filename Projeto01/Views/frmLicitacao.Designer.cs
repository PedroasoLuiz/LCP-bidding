namespace Projeto01.Views
{
    partial class frmLicitacao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDlic = new RJCodeAdvance.RJControls.RJTextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtTipoLic = new RJCodeAdvance.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalvar = new RJCodeAdvance.RJControls.RJButton();
            this.btnCancelar = new RJCodeAdvance.RJControls.RJButton();
            this.lbCadastros = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rjTextBox1 = new RJCodeAdvance.RJControls.RJTextBox();
            this.rjTextBox2 = new RJCodeAdvance.RJControls.RJTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.licitacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lCPDataSet = new Projeto01.LCPDataSet();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new Projeto01.LCPDataSetTableAdapters.ClienteTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodExterno = new RJCodeAdvance.RJControls.RJTextBox();
            this.dataLic = new System.Windows.Forms.DateTimePicker();
            this.licitacaoTableAdapter = new Projeto01.LCPDataSetTableAdapters.LicitacaoTableAdapter();
            this.tipoToolStrip = new System.Windows.Forms.ToolStrip();
            this.tipoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.tipoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.tipoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMostraTudo = new System.Windows.Forms.ToolStripButton();
            this.idLicitacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codLicitacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licitacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lCPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.tipoToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIDlic
            // 
            this.txtIDlic.BackColor = System.Drawing.SystemColors.Window;
            this.txtIDlic.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(154)))), ((int)(((byte)(175)))));
            this.txtIDlic.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIDlic.BorderRadius = 5;
            this.txtIDlic.BorderSize = 1;
            this.txtIDlic.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDlic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIDlic.Location = new System.Drawing.Point(146, 110);
            this.txtIDlic.Margin = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.txtIDlic.Multiline = false;
            this.txtIDlic.Name = "txtIDlic";
            this.txtIDlic.Padding = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txtIDlic.PasswordChar = false;
            this.txtIDlic.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIDlic.PlaceholderText = "";
            this.txtIDlic.Size = new System.Drawing.Size(81, 26);
            this.txtIDlic.TabIndex = 27;
            this.txtIDlic.Texts = "";
            this.txtIDlic.UnderlinedStyle = false;
            // 
            // lbNome
            // 
            this.lbNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(51, 153);
            this.lbNome.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(85, 16);
            this.lbNome.TabIndex = 30;
            this.lbNome.Text = "Tipo Licitação:";
            this.lbNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTipoLic
            // 
            this.txtTipoLic.AutoScroll = true;
            this.txtTipoLic.BackColor = System.Drawing.SystemColors.Window;
            this.txtTipoLic.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(154)))), ((int)(((byte)(175)))));
            this.txtTipoLic.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTipoLic.BorderRadius = 5;
            this.txtTipoLic.BorderSize = 1;
            this.txtTipoLic.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoLic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTipoLic.Location = new System.Drawing.Point(146, 148);
            this.txtTipoLic.Margin = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.txtTipoLic.MaximumSize = new System.Drawing.Size(1200, 0);
            this.txtTipoLic.MinimumSize = new System.Drawing.Size(226, 0);
            this.txtTipoLic.Multiline = false;
            this.txtTipoLic.Name = "txtTipoLic";
            this.txtTipoLic.Padding = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txtTipoLic.PasswordChar = false;
            this.txtTipoLic.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTipoLic.PlaceholderText = "";
            this.txtTipoLic.Size = new System.Drawing.Size(291, 26);
            this.txtTipoLic.TabIndex = 29;
            this.txtTipoLic.Texts = "";
            this.txtTipoLic.UnderlinedStyle = false;
            this.txtTipoLic._TextChanged += new System.EventHandler(this.txtTipoLic__TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 229);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Data:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Cliente:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnSalvar.Location = new System.Drawing.Point(447, 448);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(104, 32);
            this.btnSalvar.TabIndex = 37;
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
            this.btnCancelar.Location = new System.Drawing.Point(552, 448);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 32);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbCadastros
            // 
            this.lbCadastros.AutoSize = true;
            this.lbCadastros.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadastros.Location = new System.Drawing.Point(23, 31);
            this.lbCadastros.Name = "lbCadastros";
            this.lbCadastros.Size = new System.Drawing.Size(100, 22);
            this.lbCadastros.TabIndex = 42;
            this.lbCadastros.Text = "Licitações";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(154)))), ((int)(((byte)(175)))));
            this.panel6.Location = new System.Drawing.Point(23, 65);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(301, 2);
            this.panel6.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(23, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(642, 1);
            this.panel2.TabIndex = 40;
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
            this.rjTextBox1.Location = new System.Drawing.Point(146, 184);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.rjTextBox1.MaximumSize = new System.Drawing.Size(1200, 100);
            this.rjTextBox1.MinimumSize = new System.Drawing.Size(226, 28);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "";
            this.rjTextBox1.Size = new System.Drawing.Size(291, 28);
            this.rjTextBox1.TabIndex = 29;
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
            this.rjTextBox2.Location = new System.Drawing.Point(146, 224);
            this.rjTextBox2.Margin = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.rjTextBox2.MaximumSize = new System.Drawing.Size(1200, 0);
            this.rjTextBox2.MinimumSize = new System.Drawing.Size(226, 0);
            this.rjTextBox2.Multiline = false;
            this.rjTextBox2.Name = "rjTextBox2";
            this.rjTextBox2.Padding = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.rjTextBox2.PasswordChar = false;
            this.rjTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox2.PlaceholderText = "";
            this.rjTextBox2.Size = new System.Drawing.Size(291, 26);
            this.rjTextBox2.TabIndex = 29;
            this.rjTextBox2.Texts = "";
            this.rjTextBox2.UnderlinedStyle = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(154)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.NullValue = "...";
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(154)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeight = 26;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLicitacaoDataGridViewTextBoxColumn,
            this.codLicitacaoDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.fkClienteDataGridViewTextBoxColumn,
            this.btnExcluir});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.licitacaoBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.NullValue = "...";
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(236)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(27, 380);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.NullValue = "...";
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(236)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(629, 55);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.Click += new System.EventHandler(this.dtCLick);
            // 
            // licitacaoBindingSource
            // 
            this.licitacaoBindingSource.DataMember = "Licitacao";
            this.licitacaoBindingSource.DataSource = this.lCPDataSet;
            // 
            // lCPDataSet
            // 
            this.lCPDataSet.DataSetName = "LCPDataSet";
            this.lCPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbCliente
            // 
            this.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCliente.DataSource = this.clienteBindingSource;
            this.cmbCliente.DisplayMember = "Nome";
            this.cmbCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(149, 186);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(286, 24);
            this.cmbCliente.TabIndex = 44;
            this.cmbCliente.ValueMember = "idCliente";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.lCPDataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(235, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "Código externo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCodExterno
            // 
            this.txtCodExterno.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodExterno.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(154)))), ((int)(((byte)(175)))));
            this.txtCodExterno.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodExterno.BorderRadius = 5;
            this.txtCodExterno.BorderSize = 1;
            this.txtCodExterno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodExterno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodExterno.Location = new System.Drawing.Point(342, 110);
            this.txtCodExterno.Margin = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.txtCodExterno.Multiline = false;
            this.txtCodExterno.Name = "txtCodExterno";
            this.txtCodExterno.Padding = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txtCodExterno.PasswordChar = false;
            this.txtCodExterno.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodExterno.PlaceholderText = "";
            this.txtCodExterno.Size = new System.Drawing.Size(95, 26);
            this.txtCodExterno.TabIndex = 45;
            this.txtCodExterno.Texts = "";
            this.txtCodExterno.UnderlinedStyle = false;
            // 
            // dataLic
            // 
            this.dataLic.CustomFormat = "dd.MM.yyyy - hh:mm:ss";
            this.dataLic.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLic.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataLic.Location = new System.Drawing.Point(150, 227);
            this.dataLic.Name = "dataLic";
            this.dataLic.Size = new System.Drawing.Size(285, 21);
            this.dataLic.TabIndex = 47;
            this.dataLic.Value = new System.DateTime(2022, 11, 19, 21, 5, 6, 0);
            // 
            // licitacaoTableAdapter
            // 
            this.licitacaoTableAdapter.ClearBeforeFill = true;
            // 
            // tipoToolStrip
            // 
            this.tipoToolStrip.BackColor = System.Drawing.SystemColors.Control;
            this.tipoToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.tipoToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoToolStripLabel,
            this.tipoToolStripTextBox,
            this.tipoToolStripButton,
            this.toolStripSeparator1,
            this.btnMostraTudo,
            this.toolStripSeparator2});
            this.tipoToolStrip.Location = new System.Drawing.Point(23, 355);
            this.tipoToolStrip.Name = "tipoToolStrip";
            this.tipoToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tipoToolStrip.Size = new System.Drawing.Size(284, 25);
            this.tipoToolStrip.TabIndex = 49;
            this.tipoToolStrip.Text = "tipoToolStrip";
            // 
            // tipoToolStripLabel
            // 
            this.tipoToolStripLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoToolStripLabel.Name = "tipoToolStripLabel";
            this.tipoToolStripLabel.Size = new System.Drawing.Size(32, 22);
            this.tipoToolStripLabel.Text = "Tipo:";
            // 
            // tipoToolStripTextBox
            // 
            this.tipoToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tipoToolStripTextBox.Name = "tipoToolStripTextBox";
            this.tipoToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // tipoToolStripButton
            // 
            this.tipoToolStripButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(154)))), ((int)(((byte)(175)))));
            this.tipoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tipoToolStripButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoToolStripButton.ForeColor = System.Drawing.Color.White;
            this.tipoToolStripButton.Name = "tipoToolStripButton";
            this.tipoToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.tipoToolStripButton.Text = "Buscar";
            this.tipoToolStripButton.Click += new System.EventHandler(this.tipoToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnMostraTudo
            // 
            this.btnMostraTudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(154)))), ((int)(((byte)(175)))));
            this.btnMostraTudo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMostraTudo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostraTudo.ForeColor = System.Drawing.Color.White;
            this.btnMostraTudo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMostraTudo.Name = "btnMostraTudo";
            this.btnMostraTudo.Size = new System.Drawing.Size(80, 22);
            this.btnMostraTudo.Text = "Mostrar tudo";
            this.btnMostraTudo.Click += new System.EventHandler(this.btnMostraTudo_Click);
            // 
            // idLicitacaoDataGridViewTextBoxColumn
            // 
            this.idLicitacaoDataGridViewTextBoxColumn.DataPropertyName = "idLicitacao";
            this.idLicitacaoDataGridViewTextBoxColumn.HeaderText = "Chave primária";
            this.idLicitacaoDataGridViewTextBoxColumn.Name = "idLicitacaoDataGridViewTextBoxColumn";
            this.idLicitacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idLicitacaoDataGridViewTextBoxColumn.Width = 117;
            // 
            // codLicitacaoDataGridViewTextBoxColumn
            // 
            this.codLicitacaoDataGridViewTextBoxColumn.DataPropertyName = "codLicitacao";
            this.codLicitacaoDataGridViewTextBoxColumn.HeaderText = "Código externo";
            this.codLicitacaoDataGridViewTextBoxColumn.Name = "codLicitacaoDataGridViewTextBoxColumn";
            this.codLicitacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codLicitacaoDataGridViewTextBoxColumn.Width = 118;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDataGridViewTextBoxColumn.Width = 57;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data realizada";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataDataGridViewTextBoxColumn.Width = 113;
            // 
            // fkClienteDataGridViewTextBoxColumn
            // 
            this.fkClienteDataGridViewTextBoxColumn.DataPropertyName = "fkCliente";
            this.fkClienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.fkClienteDataGridViewTextBoxColumn.Name = "fkClienteDataGridViewTextBoxColumn";
            this.fkClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.fkClienteDataGridViewTextBoxColumn.Width = 73;
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // frmLicitacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 512);
            this.Controls.Add(this.tipoToolStrip);
            this.Controls.Add(this.dataLic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCodExterno);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbCadastros);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.rjTextBox1);
            this.Controls.Add(this.txtTipoLic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDlic);
            this.Controls.Add(this.rjTextBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLicitacao";
            this.Text = "frmLicitacao";
            this.Load += new System.EventHandler(this.frmLicitacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licitacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lCPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.tipoToolStrip.ResumeLayout(false);
            this.tipoToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJTextBox txtIDlic;
        public System.Windows.Forms.Label lbNome;
        private RJCodeAdvance.RJControls.RJTextBox txtTipoLic;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private RJCodeAdvance.RJControls.RJButton btnSalvar;
        private RJCodeAdvance.RJControls.RJButton btnCancelar;
        public System.Windows.Forms.Label lbCadastros;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox1;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbCliente;
        private LCPDataSet lCPDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private LCPDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.Label label4;
        private RJCodeAdvance.RJControls.RJTextBox txtCodExterno;
        private System.Windows.Forms.DateTimePicker dataLic;
        private System.Windows.Forms.BindingSource licitacaoBindingSource;
        private LCPDataSetTableAdapters.LicitacaoTableAdapter licitacaoTableAdapter;
        private System.Windows.Forms.ToolStrip tipoToolStrip;
        private System.Windows.Forms.ToolStripLabel tipoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox tipoToolStripTextBox;
        private System.Windows.Forms.ToolStripButton tipoToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnMostraTudo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLicitacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLicitacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}