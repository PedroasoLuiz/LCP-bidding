namespace Projeto01
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelOpcoes = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.txtProcurar = new RJCodeAdvance.RJControls.RJTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licitaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaLicitaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picImagemUser = new CustomControls.RJControls.RJCircularPictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picOP = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lCPDataSet = new Projeto01.LCPDataSet();
            this.mapaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mapaTableAdapter = new Projeto01.LCPDataSetTableAdapters.MapaTableAdapter();
            this.panelOpcoes.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagemUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lCPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOpcoes
            // 
            this.panelOpcoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelOpcoes.Controls.Add(this.panel3);
            this.panelOpcoes.Controls.Add(this.lbUsuario);
            this.panelOpcoes.Controls.Add(this.txtProcurar);
            this.panelOpcoes.Controls.Add(this.menuStrip1);
            this.panelOpcoes.Controls.Add(this.picImagemUser);
            this.panelOpcoes.Location = new System.Drawing.Point(-3, 4);
            this.panelOpcoes.Name = "panelOpcoes";
            this.panelOpcoes.Size = new System.Drawing.Size(208, 566);
            this.panelOpcoes.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel3.Location = new System.Drawing.Point(9, 227);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(190, 1);
            this.panel3.TabIndex = 2;
            // 
            // lbUsuario
            // 
            this.lbUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbUsuario.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.ForeColor = System.Drawing.Color.White;
            this.lbUsuario.Location = new System.Drawing.Point(9, 132);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(190, 44);
            this.lbUsuario.TabIndex = 2;
            this.lbUsuario.Text = "<usuário>";
            this.lbUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProcurar
            // 
            this.txtProcurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtProcurar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProcurar.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProcurar.BorderRadius = 6;
            this.txtProcurar.BorderSize = 1;
            this.txtProcurar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProcurar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcurar.ForeColor = System.Drawing.Color.White;
            this.txtProcurar.Location = new System.Drawing.Point(8, 180);
            this.txtProcurar.Margin = new System.Windows.Forms.Padding(4);
            this.txtProcurar.Multiline = false;
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtProcurar.PasswordChar = false;
            this.txtProcurar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtProcurar.PlaceholderText = "Procurar...";
            this.txtProcurar.Size = new System.Drawing.Size(191, 32);
            this.txtProcurar.TabIndex = 2;
            this.txtProcurar.Texts = "";
            this.txtProcurar.UnderlinedStyle = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.cadastrosToolStripMenuItem,
            this.licitaçõesToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip1.Location = new System.Drawing.Point(17, 240);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 20, 0, 20);
            this.menuStrip1.Size = new System.Drawing.Size(176, 152);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.dashboardToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dashboardToolStripMenuItem.Image")));
            this.dashboardToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(108, 41);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.fornecedoresToolStripMenuItem,
            this.marcasToolStripMenuItem,
            this.produtosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cadastrosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastrosToolStripMenuItem.Image")));
            this.cadastrosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(102, 41);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem_Click);
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.marcasToolStripMenuItem.Text = "Marcas";
            this.marcasToolStripMenuItem.Click += new System.EventHandler(this.marcasToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // licitaçõesToolStripMenuItem
            // 
            this.licitaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mapaToolStripMenuItem,
            this.novaLicitaçãoToolStripMenuItem});
            this.licitaçõesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.licitaçõesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("licitaçõesToolStripMenuItem.Image")));
            this.licitaçõesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.licitaçõesToolStripMenuItem.Name = "licitaçõesToolStripMenuItem";
            this.licitaçõesToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.licitaçõesToolStripMenuItem.Size = new System.Drawing.Size(100, 41);
            this.licitaçõesToolStripMenuItem.Text = "Licitações";
            this.licitaçõesToolStripMenuItem.Click += new System.EventHandler(this.licitaçõesToolStripMenuItem_Click);
            // 
            // mapaToolStripMenuItem
            // 
            this.mapaToolStripMenuItem.Name = "mapaToolStripMenuItem";
            this.mapaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.mapaToolStripMenuItem.Text = "Mapa";
            this.mapaToolStripMenuItem.Click += new System.EventHandler(this.mapaToolStripMenuItem_Click);
            // 
            // novaLicitaçãoToolStripMenuItem
            // 
            this.novaLicitaçãoToolStripMenuItem.Name = "novaLicitaçãoToolStripMenuItem";
            this.novaLicitaçãoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.novaLicitaçãoToolStripMenuItem.Text = "Nova licitação";
            this.novaLicitaçãoToolStripMenuItem.Click += new System.EventHandler(this.novaLicitaçãoToolStripMenuItem_Click);
            // 
            // picImagemUser
            // 
            this.picImagemUser.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.picImagemUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(154)))), ((int)(((byte)(175)))));
            this.picImagemUser.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.picImagemUser.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.picImagemUser.BorderSize = 3;
            this.picImagemUser.GradientAngle = 50F;
            this.picImagemUser.Image = ((System.Drawing.Image)(resources.GetObject("picImagemUser.Image")));
            this.picImagemUser.Location = new System.Drawing.Point(48, 19);
            this.picImagemUser.Name = "picImagemUser";
            this.picImagemUser.Size = new System.Drawing.Size(110, 110);
            this.picImagemUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagemUser.TabIndex = 2;
            this.picImagemUser.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picOP
            // 
            this.picOP.Image = global::Projeto01.Properties.Resources.op0;
            this.picOP.Location = new System.Drawing.Point(211, 6);
            this.picOP.Name = "picOP";
            this.picOP.Size = new System.Drawing.Size(34, 34);
            this.picOP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOP.TabIndex = 2;
            this.picOP.TabStop = false;
            this.picOP.Click += new System.EventHandler(this.picOP_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.mapaBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(252, 82);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(154)))), ((int)(((byte)(175)))))};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "ValorFinal";
            series1.YValueMembers = "PrecoMax";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(503, 173);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Mapa";
            this.chart1.Titles.Add(title1);
            // 
            // lCPDataSet
            // 
            this.lCPDataSet.DataSetName = "LCPDataSet";
            this.lCPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 568);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.picOP);
            this.Controls.Add(this.panelOpcoes);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Resize += new System.EventHandler(this.frmPrincipal_Resize);
            this.panelOpcoes.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagemUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lCPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelOpcoes;
        private RJCodeAdvance.RJControls.RJTextBox txtProcurar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        public System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.ToolStripMenuItem licitaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapaToolStripMenuItem;
        private System.Windows.Forms.PictureBox picOP;
        private System.Windows.Forms.Timer timer1;
        public CustomControls.RJControls.RJCircularPictureBox picImagemUser;
        private System.Windows.Forms.ToolStripMenuItem novaLicitaçãoToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private LCPDataSet lCPDataSet;
        private System.Windows.Forms.BindingSource mapaBindingSource;
        private LCPDataSetTableAdapters.MapaTableAdapter mapaTableAdapter;
    }
}