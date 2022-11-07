namespace Projeto01
{
    partial class frmCadastro
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtID = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtNome = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtCidade = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtUF = new RJCodeAdvance.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNovo = new RJCodeAdvance.RJControls.RJButton();
            this.btnAlterar = new RJCodeAdvance.RJControls.RJButton();
            this.btnExcluir = new RJCodeAdvance.RJControls.RJButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.identificadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.códigoExternoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nomeRazãoSocialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancelar = new RJCodeAdvance.RJControls.RJButton();
            this.btnSalvar = new RJCodeAdvance.RJControls.RJButton();
            this.lbCadastros = new System.Windows.Forms.Label();
            this.txtCodigoExterno = new RJCodeAdvance.RJControls.RJTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.txtTipo = new RJCodeAdvance.RJControls.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 309);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(638, 159);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Window;
            this.txtID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(154)))), ((int)(((byte)(175)))));
            this.txtID.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtID.BorderRadius = 5;
            this.txtID.BorderSize = 1;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtID.Location = new System.Drawing.Point(161, 135);
            this.txtID.Margin = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.txtID.Multiline = false;
            this.txtID.Name = "txtID";
            this.txtID.Padding = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txtID.PasswordChar = false;
            this.txtID.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtID.PlaceholderText = "";
            this.txtID.Size = new System.Drawing.Size(82, 26);
            this.txtID.TabIndex = 2;
            this.txtID.Texts = "";
            this.txtID.UnderlinedStyle = false;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.AutoScroll = true;
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(154)))), ((int)(((byte)(175)))));
            this.txtNome.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNome.BorderRadius = 5;
            this.txtNome.BorderSize = 1;
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNome.Location = new System.Drawing.Point(161, 171);
            this.txtNome.Margin = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.txtNome.MaximumSize = new System.Drawing.Size(1200, 0);
            this.txtNome.MinimumSize = new System.Drawing.Size(226, 0);
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.Padding = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txtNome.PasswordChar = false;
            this.txtNome.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNome.PlaceholderText = "";
            this.txtNome.Size = new System.Drawing.Size(250, 26);
            this.txtNome.TabIndex = 3;
            this.txtNome.Texts = "";
            this.txtNome.UnderlinedStyle = false;
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCidade.BackColor = System.Drawing.SystemColors.Window;
            this.txtCidade.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(154)))), ((int)(((byte)(175)))));
            this.txtCidade.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCidade.BorderRadius = 5;
            this.txtCidade.BorderSize = 1;
            this.txtCidade.Enabled = false;
            this.txtCidade.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCidade.Location = new System.Drawing.Point(161, 207);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.txtCidade.MaximumSize = new System.Drawing.Size(1200, 0);
            this.txtCidade.MinimumSize = new System.Drawing.Size(226, 0);
            this.txtCidade.Multiline = false;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Padding = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txtCidade.PasswordChar = false;
            this.txtCidade.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCidade.PlaceholderText = "";
            this.txtCidade.Size = new System.Drawing.Size(250, 26);
            this.txtCidade.TabIndex = 5;
            this.txtCidade.Texts = "";
            this.txtCidade.UnderlinedStyle = false;
            // 
            // txtUF
            // 
            this.txtUF.BackColor = System.Drawing.SystemColors.Window;
            this.txtUF.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(154)))), ((int)(((byte)(175)))));
            this.txtUF.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUF.BorderRadius = 5;
            this.txtUF.BorderSize = 1;
            this.txtUF.Enabled = false;
            this.txtUF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUF.Location = new System.Drawing.Point(161, 240);
            this.txtUF.Margin = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.txtUF.Multiline = false;
            this.txtUF.Name = "txtUF";
            this.txtUF.Padding = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txtUF.PasswordChar = false;
            this.txtUF.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUF.PlaceholderText = "";
            this.txtUF.Size = new System.Drawing.Size(82, 26);
            this.txtUF.TabIndex = 6;
            this.txtUF.Texts = "";
            this.txtUF.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome/Razão social:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cidade:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 245);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "UF:";
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Transparent;
            this.btnNovo.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnNovo.BorderColor = System.Drawing.Color.White;
            this.btnNovo.BorderRadius = 5;
            this.btnNovo.BorderSize = 0;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNovo.Location = new System.Drawing.Point(93, 75);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(5);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(65, 26);
            this.btnNovo.TabIndex = 12;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Transparent;
            this.btnAlterar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAlterar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(154)))), ((int)(((byte)(175)))));
            this.btnAlterar.BorderRadius = 5;
            this.btnAlterar.BorderSize = 0;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlterar.Location = new System.Drawing.Point(165, 75);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(65, 26);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnExcluir.BorderColor = System.Drawing.Color.White;
            this.btnExcluir.BorderRadius = 5;
            this.btnExcluir.BorderSize = 0;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluir.Location = new System.Drawing.Point(236, 75);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(65, 26);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(23, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(631, 1);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(91, 83);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 10);
            this.panel3.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Location = new System.Drawing.Point(159, 83);
            this.panel4.Margin = new System.Windows.Forms.Padding(5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 10);
            this.panel4.TabIndex = 18;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Location = new System.Drawing.Point(234, 83);
            this.panel5.Margin = new System.Windows.Forms.Padding(5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 10);
            this.panel5.TabIndex = 19;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(154)))), ((int)(((byte)(175)))));
            this.panel6.Location = new System.Drawing.Point(23, 65);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(301, 2);
            this.panel6.TabIndex = 20;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBuscar});
            this.menuStrip1.Location = new System.Drawing.Point(25, 77);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(62, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSize = false;
            this.btnBuscar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.identificadorToolStripMenuItem,
            this.códigoExternoToolStripMenuItem,
            this.nomeRazãoSocialToolStripMenuItem,
            this.cidadeToolStripMenuItem,
            this.uFToolStripMenuItem});
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(54, 20);
            this.btnBuscar.Text = "Buscar";
            // 
            // identificadorToolStripMenuItem
            // 
            this.identificadorToolStripMenuItem.Name = "identificadorToolStripMenuItem";
            this.identificadorToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.identificadorToolStripMenuItem.Text = "Identificador";
            // 
            // códigoExternoToolStripMenuItem
            // 
            this.códigoExternoToolStripMenuItem.Name = "códigoExternoToolStripMenuItem";
            this.códigoExternoToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.códigoExternoToolStripMenuItem.Text = "Código externo";
            // 
            // nomeRazãoSocialToolStripMenuItem
            // 
            this.nomeRazãoSocialToolStripMenuItem.Name = "nomeRazãoSocialToolStripMenuItem";
            this.nomeRazãoSocialToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.nomeRazãoSocialToolStripMenuItem.Text = "Nome/Razão social";
            // 
            // cidadeToolStripMenuItem
            // 
            this.cidadeToolStripMenuItem.Name = "cidadeToolStripMenuItem";
            this.cidadeToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.cidadeToolStripMenuItem.Text = "Cidade";
            // 
            // uFToolStripMenuItem
            // 
            this.uFToolStripMenuItem.Name = "uFToolStripMenuItem";
            this.uFToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.uFToolStripMenuItem.Text = "UF";
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
            this.btnCancelar.Location = new System.Drawing.Point(557, 512);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 32);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnSalvar.Location = new System.Drawing.Point(452, 512);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(104, 32);
            this.btnSalvar.TabIndex = 23;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextColor = System.Drawing.Color.White;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lbCadastros
            // 
            this.lbCadastros.AutoSize = true;
            this.lbCadastros.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadastros.Location = new System.Drawing.Point(23, 31);
            this.lbCadastros.Name = "lbCadastros";
            this.lbCadastros.Size = new System.Drawing.Size(113, 22);
            this.lbCadastros.TabIndex = 24;
            this.lbCadastros.Text = "Cadastros: ";
            // 
            // txtCodigoExterno
            // 
            this.txtCodigoExterno.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigoExterno.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(154)))), ((int)(((byte)(175)))));
            this.txtCodigoExterno.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodigoExterno.BorderRadius = 5;
            this.txtCodigoExterno.BorderSize = 1;
            this.txtCodigoExterno.Enabled = false;
            this.txtCodigoExterno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoExterno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodigoExterno.Location = new System.Drawing.Point(329, 135);
            this.txtCodigoExterno.Margin = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.txtCodigoExterno.Multiline = false;
            this.txtCodigoExterno.Name = "txtCodigoExterno";
            this.txtCodigoExterno.Padding = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txtCodigoExterno.PasswordChar = false;
            this.txtCodigoExterno.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodigoExterno.PlaceholderText = "";
            this.txtCodigoExterno.Size = new System.Drawing.Size(82, 26);
            this.txtCodigoExterno.TabIndex = 25;
            this.txtCodigoExterno.Texts = "";
            this.txtCodigoExterno.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(247, 140);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Cód. externo:";
            // 
            // lbTipo
            // 
            this.lbTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTipo.AutoSize = true;
            this.lbTipo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipo.Location = new System.Drawing.Point(269, 245);
            this.lbTipo.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(32, 16);
            this.lbTipo.TabIndex = 28;
            this.lbTipo.Text = "Tipo:";
            this.lbTipo.Visible = false;
            // 
            // txtTipo
            // 
            this.txtTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTipo.BackColor = System.Drawing.SystemColors.Window;
            this.txtTipo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(154)))), ((int)(((byte)(175)))));
            this.txtTipo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTipo.BorderRadius = 5;
            this.txtTipo.BorderSize = 1;
            this.txtTipo.Enabled = false;
            this.txtTipo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTipo.Location = new System.Drawing.Point(305, 240);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.txtTipo.Multiline = false;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Padding = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txtTipo.PasswordChar = false;
            this.txtTipo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTipo.PlaceholderText = "";
            this.txtTipo.Size = new System.Drawing.Size(106, 26);
            this.txtTipo.TabIndex = 27;
            this.txtTipo.Texts = "";
            this.txtTipo.UnderlinedStyle = false;
            this.txtTipo.Visible = false;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 572);
            this.Controls.Add(this.lbTipo);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCodigoExterno);
            this.Controls.Add(this.lbCadastros);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCadastro";
            this.Text = "Cadastros: CLIENTES";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RJCodeAdvance.RJControls.RJTextBox txtID;
        private RJCodeAdvance.RJControls.RJTextBox txtNome;
        private RJCodeAdvance.RJControls.RJTextBox txtCidade;
        private RJCodeAdvance.RJControls.RJTextBox txtUF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private RJCodeAdvance.RJControls.RJButton btnNovo;
        private RJCodeAdvance.RJControls.RJButton btnAlterar;
        private RJCodeAdvance.RJControls.RJButton btnExcluir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnBuscar;
        private System.Windows.Forms.ToolStripMenuItem identificadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nomeRazãoSocialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uFToolStripMenuItem;
        private RJCodeAdvance.RJControls.RJButton btnCancelar;
        private RJCodeAdvance.RJControls.RJButton btnSalvar;
        public System.Windows.Forms.Label lbCadastros;
        private RJCodeAdvance.RJControls.RJTextBox txtCodigoExterno;
        private System.Windows.Forms.ToolStripMenuItem códigoExternoToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lbTipo;
        public RJCodeAdvance.RJControls.RJTextBox txtTipo;
    }
}