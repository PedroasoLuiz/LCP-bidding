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
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbCadastros = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDlic = new RJCodeAdvance.RJControls.RJTextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtTipoLic = new RJCodeAdvance.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataLic = new CustomControls.RJControls.RJDatePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalvar = new RJCodeAdvance.RJControls.RJButton();
            this.btnCancelar = new RJCodeAdvance.RJControls.RJButton();
            this.cmbCliente = new RJCodeAdvance.RJControls.RJComboBox();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(154)))), ((int)(((byte)(175)))));
            this.panel6.Location = new System.Drawing.Point(-73, 108);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(688, 3);
            this.panel6.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(-73, 110);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1182, 2);
            this.panel2.TabIndex = 21;
            // 
            // lbCadastros
            // 
            this.lbCadastros.AutoSize = true;
            this.lbCadastros.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadastros.Location = new System.Drawing.Point(30, 53);
            this.lbCadastros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCadastros.Name = "lbCadastros";
            this.lbCadastros.Size = new System.Drawing.Size(149, 36);
            this.lbCadastros.TabIndex = 25;
            this.lbCadastros.Text = "Licitação";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 252);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 15, 4, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.txtIDlic.Location = new System.Drawing.Point(206, 246);
            this.txtIDlic.Margin = new System.Windows.Forms.Padding(15, 15, 8, 15);
            this.txtIDlic.Multiline = false;
            this.txtIDlic.Name = "txtIDlic";
            this.txtIDlic.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.txtIDlic.PasswordChar = false;
            this.txtIDlic.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIDlic.PlaceholderText = "";
            this.txtIDlic.Size = new System.Drawing.Size(123, 36);
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
            this.lbNome.Location = new System.Drawing.Point(55, 303);
            this.lbNome.Margin = new System.Windows.Forms.Padding(4, 15, 4, 15);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(132, 21);
            this.lbNome.TabIndex = 30;
            this.lbNome.Text = "Tipo Licitação:";
            this.lbNome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTipoLic
            // 
            this.txtTipoLic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTipoLic.AutoScroll = true;
            this.txtTipoLic.BackColor = System.Drawing.SystemColors.Window;
            this.txtTipoLic.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(154)))), ((int)(((byte)(175)))));
            this.txtTipoLic.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTipoLic.BorderRadius = 5;
            this.txtTipoLic.BorderSize = 1;
            this.txtTipoLic.Enabled = false;
            this.txtTipoLic.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoLic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTipoLic.Location = new System.Drawing.Point(206, 299);
            this.txtTipoLic.Margin = new System.Windows.Forms.Padding(15, 15, 8, 15);
            this.txtTipoLic.MaximumSize = new System.Drawing.Size(1800, 0);
            this.txtTipoLic.MinimumSize = new System.Drawing.Size(339, 0);
            this.txtTipoLic.Multiline = false;
            this.txtTipoLic.Name = "txtTipoLic";
            this.txtTipoLic.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.txtTipoLic.PasswordChar = false;
            this.txtTipoLic.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTipoLic.PlaceholderText = "";
            this.txtTipoLic.Size = new System.Drawing.Size(375, 36);
            this.txtTipoLic.TabIndex = 29;
            this.txtTipoLic.Texts = "";
            this.txtTipoLic.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(583, 261);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 15, 4, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "Data:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataLic
            // 
            this.dataLic.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dataLic.BorderSize = 0;
            this.dataLic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dataLic.Location = new System.Drawing.Point(587, 299);
            this.dataLic.MinimumSize = new System.Drawing.Size(0, 35);
            this.dataLic.Name = "dataLic";
            this.dataLic.Size = new System.Drawing.Size(403, 35);
            this.dataLic.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(154)))), ((int)(((byte)(175)))));
            this.dataLic.TabIndex = 32;
            this.dataLic.TextColor = System.Drawing.Color.White;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 374);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 15, 4, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 34;
            this.label3.Text = "Cliente:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btnSalvar.Location = new System.Drawing.Point(664, 598);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(156, 49);
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
            this.btnCancelar.Location = new System.Drawing.Point(822, 598);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(156, 49);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbCliente
            // 
            this.cmbCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbCliente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(154)))), ((int)(((byte)(175)))));
            this.cmbCliente.BorderSize = 3;
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbCliente.ForeColor = System.Drawing.Color.DimGray;
            this.cmbCliente.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbCliente.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbCliente.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbCliente.Location = new System.Drawing.Point(206, 362);
            this.cmbCliente.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Padding = new System.Windows.Forms.Padding(3);
            this.cmbCliente.Size = new System.Drawing.Size(304, 51);
            this.cmbCliente.TabIndex = 38;
            this.cmbCliente.Texts = "";
            // 
            // frmLicitacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 880);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataLic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.txtTipoLic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDlic);
            this.Controls.Add(this.lbCadastros);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLicitacao";
            this.Text = "frmLicitacao";
            this.Load += new System.EventHandler(this.frmLicitacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lbCadastros;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJTextBox txtIDlic;
        public System.Windows.Forms.Label lbNome;
        private RJCodeAdvance.RJControls.RJTextBox txtTipoLic;
        public System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJDatePicker dataLic;
        private System.Windows.Forms.Label label3;
        private RJCodeAdvance.RJControls.RJButton btnSalvar;
        private RJCodeAdvance.RJControls.RJButton btnCancelar;
        private RJCodeAdvance.RJControls.RJComboBox cmbCliente;
    }
}