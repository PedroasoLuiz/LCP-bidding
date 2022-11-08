using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Model;
using System.Data.SqlClient;
using System.Collections;

namespace Projeto01.Repositórios
{
    internal class RepositorioMarcas:IRepositorio<Marcas>
    {
        Conexao conn = null;
        public void Add(Marcas obj)
        {
            conn = new Conexao();               // Chama a classe conexão
            conn.OpenConnection();              // Abre a conexão

            string Query =
                "INSERT INTO Marcas (nome)" +
               $"VALUES ('{obj.Nome}')";

            conn.ExecuteQuery(Query);           // Executa a query
            conn.CloseConnection();             // Encerra conexão

        }
        public void Delete(Marcas obj)
        {
            conn = new Conexao();               // Chama a classe conexão
            conn.OpenConnection();              // Abre a conexão

           string Query = 
                $"DELETE Marcas " +
                $"WHERE idMarcas= {obj.IdMarca}";

            conn.ExecuteQuery(Query);           // Executa a query
            conn.CloseConnection();             // Encerra conexão
        }
        public void Update(Marcas obj)
        {
            conn = new Conexao();               // Chama a classe conexão
            conn.OpenConnection();              // Abre a conexão

           string Query = 
                $"UPDATE Marcas " +
                $"SET nome = {obj.Nome}" +
                $"WHERE idMarcas = {obj.IdMarca};";

            conn.ExecuteQuery(Query);           // Executa a query
            conn.CloseConnection();             // Encerra conexão
        }
    }
}
