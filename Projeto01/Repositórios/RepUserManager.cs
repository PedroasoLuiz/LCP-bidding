using Projeto01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.CodeDom.Compiler;
using System.Data;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Data.SqlTypes;

namespace Projeto01.Repositórios
{
    internal class RepUserManager : InterUserManagerInterface
    {
        Conexao conn = null;
        public void acoes(UserManager Usuario)
        {
            conn = new Conexao();               // Chama a classe conexão
            conn.OpenConnection();              // Abre a conexão

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn.OpenConnection();
            //cmd.Parameters.Add("@Binario", SqlDbType.Image);
            if (Usuario.ImagemOID == null)
                cmd.Parameters.Add("@ImagemOID", DBNull.Value);
            else
                cmd.Parameters.Add("@ImagemOID", Usuario.ImagemOID);

            //if (Usuario.Imagem == null)
                //cmd.Parameters["@Binario"].Value = SqlBinary.Null;
            //else
                //cmd.Parameters["@Binario"].Value = Usuario.Imagem;


            switch (Program.acao)
            {
                case 1:
                    //cmd.CommandText =
                    //    "INSERT INTO Usuarios (Nome,Email,Senha,Cadastro,Imagem)" +
                    //    $"VALUES ('{Usuario.Nome}','{Usuario.Email}','{Usuario.Senha}','{DateTime.Now}',@Binario)";
                    cmd.CommandText =
                           "INSERT INTO Usuarios (Nome, Email, Senha, Cadastro, ImagemOID)" +
                           $" VALUES ('{Usuario.Nome}', '{Usuario.Email}', '{Usuario.Senha}', '{DateTime.Now}', @ImagemOID)";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"{Usuario.Nome} cadastrado com sucesso!");
                    break;
                case 2:
                    cmd.CommandText =
                        "UPDATE Usuarios " +
                       $"SET Nome = '{Usuario.Nome.ToUpper()}'," +
                          $" Email = '{Usuario.Email.ToLower()}'," +
                          $" Senha = '{Usuario.Senha}'," +
                          $" Alterações = '{DateTime.Now}'," +
                          $" ImagemOID = @Binario " +               // era só Imagem
                       $"WHERE idUser = {Usuario.IdUser}";
                    cmd.ExecuteNonQuery();
                    break;

                case 3:
                    cmd.CommandText =
                        "DELETE FROM Usuarios " +
                       $"WHERE idUser = {Usuario.IdUser}";
                    cmd.ExecuteNonQuery();
                    break;

            }
            conn.CloseConnection();
        }

        public UserManager Get(string email, string senha)
        {
            conn = new Conexao();               // Chama a classe conexão

            string query =
                "SELECT * " +
                "FROM Usuarios " +
                "WHERE Email = '" + email + "' and Senha = '" + senha + "'";
            conn.ExecuteQuery(query);

            List<UserManager> LU = new List<UserManager>();

            UserManager u = null;
            while (conn.dr.Read())
            {
                u = new UserManager();
                u.Nome = conn.dr[1].ToString();
                u.Email= conn.dr[2].ToString();
                u.Senha =conn. dr[3].ToString();
                u.Cadastro = DateTime.Parse(conn.dr[4].ToString());
                if (!(conn.dr[6] is System.DBNull))
                {
                    u.ImagemOID = conn.dr[6].ToString();

                    //MongoUtil MU = new MongoUtil();
                    //MU.MongoCollection.Find()

                    //u.Imagem = 
                }
                    
                      //u.Imagem = (byte[])conn.dr[6];
                LU.Add(u);
            }
            conn.CloseConnection();
            return u;
        }

        public UserManager RecuperaEmail(string email)
        {
            conn = new Conexao();               // Chama a classe conexão
            conn.OpenConnection();              // Abre a conexão

            SqlCommand comand = new SqlCommand();
            comand.Connection = conn.OpenConnection();
            comand.CommandText =
                "SELECT * " +
                "FROM Usuarios " +
                "WHERE Email = '" + email + "'";
            SqlDataReader dr = comand.ExecuteReader();
            List<UserManager> LU = new List<UserManager>();

            UserManager u = null;
            while (dr.Read())
            {
                u = new UserManager();
                u.Nome = dr[1].ToString();
                u.Email = dr[2].ToString();
                LU.Add(u);
            }

            conn.CloseConnection();
            return u;
        }
    }
}
