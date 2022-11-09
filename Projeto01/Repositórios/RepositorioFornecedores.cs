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
    internal class RepositorioFornecedores: IRepositorio<Fornecedores>
    {
        Conexao conn = null;
        public void Add(Fornecedores obj)
        {
            conn = new Conexao();               // Chama a classe conexão

            string Query = 
                $"INSERT INTO Fornecedores (nome,tipo) " +
                $"VALUES ('{obj.Nome}','{obj.Tipo}') ";

            conn.ExecuteQuery(Query);           // Executa a query
            conn.CloseConnection();             // Encerra conexão
        }
        public void Delete(Fornecedores obj)
        {
            conn = new Conexao();               // Chama a classe conexão

            string Query = 
                $"DELETE Fornecedores " +
                $"WHERE idFornecedores = {obj.IdFornecedores} ";

            conn.ExecuteQuery(Query);           // Executa a query
            conn.CloseConnection();             // Encerra conexão

        }

        public IEnumerable<Fornecedores> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Fornecedores obj)
        {
            conn = new Conexao();               // Chama a classe conexão

            string Query = 
                $"UPDATE Fornecedores " +
                $"SET nome = {obj.Nome}, tipo = {obj.Tipo} " +
                $"WHERE idFornecedores = {obj.IdFornecedores}; ";

            conn.ExecuteQuery(Query);           // Executa a query
            conn.CloseConnection();             // Encerra conexão
        }
    }
}
