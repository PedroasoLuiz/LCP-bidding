using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Model;
using System.Data.SqlClient;
using System.Collections;
using Microsoft.Win32.SafeHandles;
using System.Windows.Forms;

namespace Projeto01.Repositórios
{
    internal class RepositorioProduto:IRepositorio<Produto>
    {
        Conexao conn = null;
        public void Add(Produto obj)
        {
            conn = new Conexao();               // Chama a classe conexão
            string Query =
                $"EXEC Produto_Cadastro " +
                $"{obj.CodProduto}," +
                $"'{obj.Descricao.ToUpper()}'," +
                $"{obj.Custo}," +
                $"'{obj.Unidade.ToUpper()}'," +
                $"{int.Parse(obj.Marca)}";

            conn.ExecuteQuery(Query);           // Executa a query
            conn.CloseConnection();             // Encerra conexão
        }
        public void Delete(Produto obj)
        {
            conn = new Conexao();               // Chama a classe conexão
            string Query =
                $"EXEC Produto_Exclui " +
                $"{obj.IdProduto} ";

            conn.ExecuteQuery(Query);           // Executa a query
            conn.CloseConnection();             // Encerra conexão
        }

        public void Update(Produto obj)
        {
            conn = new Conexao();               // Chama a classe conexão
            string Query =
                $"EXEC Produto_Update " +
                $"{obj.IdProduto}, " +
                $"{obj.CodProduto}, " +
                $"'{obj.Descricao.ToUpper()}', " +
                $"{obj.Custo}, " +
                $"'{obj.Unidade.ToUpper()}', " +
                $"{int.Parse(obj.Marca)}";

            conn.ExecuteQuery(Query);           // Executa a query
            conn.CloseConnection();             // Encerra conexão
        }

        public IEnumerable<Produto> GetAll()
        {
            RepositorioMarcas rp = new RepositorioMarcas();

            Conexao conn = new Conexao();
            conn.ExecuteQuery("EXEC Produto_BuscaGeral");
            List<Produto> lp = new List<Produto>();

            while (conn.dr.Read())
            {
                Produto p = new Produto();
                Marcas m = new Marcas();
                
                p.IdProduto = int.Parse(conn.dr[0].ToString());
                p.CodProduto = int.Parse(conn.dr[1].ToString());
                p.Descricao = conn.dr[2].ToString();
                p.Custo = double.Parse(conn.dr[3].ToString());
                p.Unidade = conn.dr[4].ToString();
                m = rp.BuscaID(int.Parse(conn.dr[5].ToString()));
                p.Marca = m.Nome;
                lp.Add(p);
            }

            conn.CloseConnection();
            //lc.Sort();
            return lp;
        }

        public Produto BuscaID(int find)
        {
            RepositorioMarcas rp = new RepositorioMarcas();

            Conexao conn = new Conexao();
            conn.ExecuteQuery($"EXEC Produto_BuscaID {find}");
            Produto p = new Produto();

            while (conn.dr.Read())
            {
                Marcas m = new Marcas();
                p.IdProduto = int.Parse(conn.dr[0].ToString());
                p.CodProduto  = int.Parse(conn.dr[1].ToString());
                p.Descricao = conn.dr[2].ToString();
                p.Custo = double.Parse(conn.dr[3].ToString());
                p.Unidade = conn.dr[4].ToString();
                m = rp.BuscaID(int.Parse(conn.dr[5].ToString()));
                p.Marca = m.Nome;
            }
            if (p == null)
                MessageBox.Show("Produto não encontrado!");

            conn.CloseConnection();
            return p;
        }


    }
}
