using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Model;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;
using DnsClient.Protocol;

namespace Projeto01.Repositórios
{
    internal class RepositorioCliente : IRepositorio<Cliente>
    {
        // Método de cadastro de clientes   
        public void Add(Cliente obj)
        {
            Conexao conn = new Conexao();
            string Query =
                $"EXEC Cliente_Cadastro " +
                $"{obj.CodCliente}, " +
                $"'{obj.Nome.ToUpper()}', " +
                $"'{obj.Cidade.ToUpper()}', " +
                $"'{obj.Estado.ToUpper()}' ";

            conn.ExecuteQuery(Query);
            conn.CloseConnection();             // Encerra conexão

        }

        
        // Método de exclusão de clientes
        public void Delete(Cliente obj)
        {
            Conexao conn = new Conexao();
            // Define a query a ser executada
            string Query =
                $"EXEC Cliente_Exclui " +
                $"{obj.IdCliente} ";

            conn.ExecuteQuery(Query);           // Executa a query
            conn.CloseConnection();             // Encerra conexão
        }

        
        // Método de atualização de informaç~es de clientes
        public void Update(Cliente obj)
        {
            Conexao conn = new Conexao();
            // Define a query a ser executada
            string Query =
                $"EXEC Cliente_Update " +
                $"{obj.IdCliente}, " +
                $"{obj.CodCliente}, " +
                $"'{obj.Nome.ToUpper()}', " +
                $"'{obj.Cidade.ToUpper()}', " +
                $"'{obj.Estado.ToUpper()}' ";

            conn.ExecuteQuery(Query);           // Executa a query
            conn.CloseConnection();             // Encerra conexão

        }

        public Cliente BuscaID(int find)
        {
            Conexao conn = new Conexao();
            conn.ExecuteQuery($"EXEC Cliente_BuscaID {find}");
            Cliente c = new Cliente();

            while (conn.dr.Read())
            {
                c.IdCliente = int.Parse(conn.dr[0].ToString());
                c.CodCliente = int.Parse(conn.dr[1].ToString());
                c.Nome = conn.dr[2].ToString();
                c.Cidade = conn.dr[3].ToString();
                c.Estado = conn.dr[4].ToString();
            }
            if (c == null)
                MessageBox.Show("Cliente não encontrado!");
      
            conn.CloseConnection();
            return c;
        }

        public IEnumerable<Cliente> GetAll()
        {
            Conexao conn = new Conexao();
            conn.ExecuteQuery("EXEC Cliente_BuscaGeral");
            List<Cliente> lc = new List<Cliente>();

            while (conn.dr.Read())
            {
                Cliente c = new Cliente();
                c.IdCliente = int.Parse(conn.dr[0].ToString());
                c.CodCliente = int.Parse(conn.dr[1].ToString());
                c.Nome = conn.dr[2].ToString();
                c.Cidade = conn.dr[3].ToString();
                c.Estado = conn.dr[4].ToString();

                lc.Add(c);
            }

            conn.CloseConnection();
            //lc.Sort();
            return lc;
        }
    }
}
