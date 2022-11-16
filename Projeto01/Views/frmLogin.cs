using Projeto01.Model;
using Projeto01.Repositórios;
using System;
using MongoDB.Driver;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Projeto01
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

        }


        //Instancia dos forms
        frmPrincipal frmPrin = new frmPrincipal();
        RepUserManager ru = null;
        UserManager uc = new UserManager();
        MongoClient mongoClient;
        IMongoDatabase mongoDatabase;
        IMongoCollection<UserManager> mongoCollection;
        private void btnImage_Click(object sender, EventArgs e)
        {
            mongoClient = new MongoClient("mongodb + srv://LCP-Licitacoes:<password>@cluster0.hztehbs.mongodb.net/?retryWrites=true&w=majority");
            mongoDatabase = mongoClient.GetDatabase("LCP-bidding");
            mongoCollection = mongoDatabase.GetCollection<UserManager>("Cadastro");

            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string nome = openFileDialog1.FileName;
                    picNewPicture.Image = Image.FromFile(nome);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ConverteFoto(PictureBox img)
        {
            if (img.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                img.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] foto_array = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(foto_array, 0, foto_array.Length);
                uc.Imagem = foto_array;
            }

        }

        private void btnSairC_Click(object sender, EventArgs e)
        { this.Close(); }

        private void btnSairL_Click(object sender, EventArgs e)
        { this.Close(); }

        private void btnChamaCadastro_Click_1(object sender, EventArgs e)
        {
            try
            {
                tabControl.SelectedTab = tabCadastro;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                ru = new RepUserManager();
                UserManager User = ru.Get(txtLoginEmail.Text, txtLoginSenha.Text);
                if (User != null)
                {
                    frmPrin.lbUsuario.Text = User.Nome.ToString();
                    if (!(User.Imagem is null))
                    {
                        MemoryStream ms = new MemoryStream();
                        ms.Write(User.Imagem, 0, User.Imagem.Length);
                        frmPrin.picImagemUser.Image = Image.FromStream(ms);
                    }
                    frmPrin.ShowDialog();
                }
                else
                    lbAlert.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Verifica se todos os campos estão preenchidos.
                if (txtCadastrarNome.Text != string.Empty && txtCadastrarEmail.Text != string.Empty && txtCadastrarSenha.Text != string.Empty)
                {
                    Program.acao = 1; //Define a acao de cadastrar
                    uc = new UserManager();
                    uc.Nome = txtCadastrarNome.Text.ToUpper();
                    uc.Email = txtCadastrarEmail.Text.ToLower();
                    uc.Senha = txtCadastrarSenha.Text;
                    uc.Cadastro = DateTime.Now;

                    ConverteFoto(picNewPicture);
                    ru = new RepUserManager();
                    ru.acoes(uc);

                    // Passa o e-mail cadastrado para o login
                    txtLoginEmail.Text = txtCadastrarEmail.Text;

                    txtCadastrarEmail.Text = string.Empty;
                    txtCadastrarNome.Text = string.Empty;
                    txtCadastrarSenha.Text = string.Empty;
                    picNewPicture.Image = null;

                    // Retorna a tela de login
                    tabControl.SelectedTab = tabLogin;
                }
                else
                {
                    MessageBox.Show("É necessario preencher todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnChamaLogin_Click_1(object sender, EventArgs e)
        {
            try
            {
                tabControl.SelectedTab = tabLogin;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
