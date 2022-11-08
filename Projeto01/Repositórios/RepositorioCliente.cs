using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Model;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projeto01.Repositórios
{
    internal class RepositorioCliente : IRepositorio<Cliente>
    {
        Conexao conn = null;
        public void Add(Cliente obj)
        {
            conn = new Conexao();               // Chama a classe conexão
            conn.OpenConnection();              // Abre a conexão

            // Define a query a ser executada
            string Query = 
                $"INSERT INTO Cliente " +
                $"SET codCliente = {obj.CodCliente}, Nome = {obj.Nome}, " +
                $"Cidade = {obj.Cidade}, Estado = {obj.Estado}";

            conn.ExecuteQuery(Query);           // Executa a query
            conn.CloseConnection();             // Encerra conexão

        }

        public void Delete(Cliente obj)
        {
            conn = new Conexao();               // Chama a classe conexão
            conn.OpenConnection();              // Abre a conexão

            // Define a query a ser executada
            string Query =
                $"DELETE Cliente WHERE idCliente= {obj.IdCliente}";

            conn.ExecuteQuery(Query);           // Executa a query
            conn.CloseConnection();             // Encerra conexão
        }

        public void Update(Cliente obj)
        {
            conn = new Conexao();               // Chama a classe conexão
            conn.OpenConnection();              // Abre a conexão

            // Define a query a ser executada
            string Query = 
                $"UPDATE Cliente " +
                $"SET nome = {obj.Nome}, cidade = {obj.Cidade}, estado ={obj.Estado} "+
                $"WHERE idCliente = {obj.IdCliente} ";

            conn.ExecuteQuery(Query);           // Executa a query
            conn.CloseConnection();             // Encerra conexão

        }
    }
}
