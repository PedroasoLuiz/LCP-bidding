using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Model;
using System.Data.SqlClient;
using System.Collections;
using System.Windows.Forms;

namespace Projeto01.Repositórios
{
    internal class RepositorioFornecedores: IRepositorio<Fornecedores>
    {
        Conexao conn = null;
        public void Add(Fornecedores obj)
        {
            conn = new Conexao();               // Chama a classe conexão
            string Query = 
                $"EXEC Fornecedor_Cadastro " +
                $"'{obj.Tipo.ToUpper()}', " +
                $"'{obj.Nome.ToUpper()}', " +
                $"'{obj.Cidade.ToUpper()}', " +
                $"'{obj.Estado.ToUpper()}' ";

            conn.ExecuteQuery(Query);           // Executa a query
            conn.CloseConnection();             // Encerra conexão
        }

        
        public void Delete(Fornecedores obj)
        {
            conn = new Conexao();               // Chama a classe conexão
            string Query = 
                $"EXEC Fornecedor_Exclui " +
                $"{obj.IdFornecedores} ";

            conn.ExecuteQuery(Query);           // Executa a query
            conn.CloseConnection();             // Encerra conexão

        }
        public void Update(Fornecedores obj)
        {
            conn = new Conexao();               // Chama a classe conexão
            string Query =
                $"EXEC Fornecedor_Update " +
                $"{obj.IdFornecedores}, " +
                $"'{obj.Tipo.ToUpper()}', " +
                $"'{obj.Nome.ToUpper()}', " +
                $"'{obj.Cidade.ToUpper()}', " +
                $"'{obj.Estado.ToUpper()}' ";

            conn.ExecuteQuery(Query);           // Executa a query
            conn.CloseConnection();             // Encerra conexão
        }
        public Fornecedores BuscaID(int find)
        {
            Conexao conn = new Conexao();
            conn.ExecuteQuery($"EXEC Fornecedor_BuscaID {find}");
            Fornecedores f = new Fornecedores();

            while (conn.dr.Read())
            {
                f.IdFornecedores = int.Parse(conn.dr[0].ToString());
                f.Tipo = conn.dr[1].ToString();
                f.Nome = conn.dr[2].ToString();
                f.Cidade = conn.dr[3].ToString();
                f.Estado = conn.dr[4].ToString();
            }
            if (f == null)
                MessageBox.Show("Cliente não encontrado!");

            conn.CloseConnection();
            return f;
        }
        public IEnumerable<Fornecedores> GetAll()
        {
            Conexao conn = new Conexao();
            conn.ExecuteQuery("EXEC Fornecedor_BuscaGeral");
            List<Fornecedores> lf = new List<Fornecedores>();

            while (conn.dr.Read())
            {
                Fornecedores f = new Fornecedores();
                f.IdFornecedores = int.Parse(conn.dr[0].ToString());
                f.Tipo = conn.dr[1].ToString();
                f.Nome = conn.dr[2].ToString();
                f.Cidade = conn.dr[3].ToString();
                f.Estado = conn.dr[4].ToString();

                lf.Add(f);
            }

            conn.CloseConnection();
            //lc.Sort();
            return lf;
        }

       
    }
}
