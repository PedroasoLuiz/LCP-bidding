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
    internal class RepositorioMarcas:IRepositorio<Marcas>
    {
        Conexao conn = null;
        public void Add(Marcas obj)
        {
            conn = new Conexao();               // Chama a classe conexão
            string Query =
                $"EXEC Marca_Cadastro " +
                $"'{obj.Nome.ToUpper()}' ";

            conn.ExecuteQuery(Query);           // Executa a query
            conn.CloseConnection();             // Encerra conexão

        }
        public void Delete(Marcas obj)
        {
            conn = new Conexao();               // Chama a classe conexão
            string Query = 
                $"EXEC Marca_Exclui " +
                $"{obj.IdMarca}";

            conn.ExecuteQuery(Query);           // Executa a query
            conn.CloseConnection();             // Encerra conexão
        }
        public void Update(Marcas obj)
        {
            conn = new Conexao();               // Chama a classe conexão

            string Query =
                 $"EXEC Marca_Update " +
                 $"{obj.IdMarca}, " +
                 $"'{obj.Nome.ToUpper()}' ";

            conn.ExecuteQuery(Query);           // Executa a query
            conn.CloseConnection();             // Encerra conexão
        }

        public IEnumerable<Marcas> GetAll()
        {
            Conexao conn = new Conexao();
            conn.ExecuteQuery("EXEC Marca_BuscaGeral");
            List<Marcas> lm = new List<Marcas>();

            while (conn.dr.Read())
            {
                Marcas m = new Marcas();
                m.IdMarca = int.Parse(conn.dr[0].ToString());
                m.Nome = conn.dr[1].ToString();
                lm.Add(m);
            }

            conn.CloseConnection();
            //lc.Sort();
            return lm;
        }

        public Marcas BuscaID(int find)
        {
            Conexao conn = new Conexao();
            conn.ExecuteQuery($"EXEC Marca_Nomes {find}");
            Marcas m = new Marcas();

            while (conn.dr.Read())
                m.Nome = conn.dr[0].ToString();

            if (m == null)
                MessageBox.Show("Marca não encontrado!");

            conn.CloseConnection();
            return m;
        }


    }
}
