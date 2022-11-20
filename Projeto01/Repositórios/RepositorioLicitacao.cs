using System.Collections.Generic;
using Projeto01.Model;

namespace Projeto01.Repositórios
{
    internal class RepositorioLicitacao : IRepositorio<Licitacao>
    {
        Conexao conn = null;
        public void Add(Licitacao obj)
        {
            conn = new Conexao();               // Chama a classe conexão

            string Query =
                $"EXEC Licitacao_Cadastro " +
                $"{obj.CodLicitacao}, " +
                $"'{obj.Tipo.ToUpper()}', " +
                $"'{obj.Data}', " +
                $"{obj.FkCliente}";

            conn.ExecuteQuery(Query);           // Executa a query
            conn.CloseConnection();             // Encerra conexão

        }

        public void Delete(Licitacao obj)
        {
            conn = new Conexao();               // Chama a classe conexão

            string Query = 
                 "EXEC Licitacao_Exclui " +
                $"{obj.IdLicitacao} ";

            conn.ExecuteQuery(Query);           // Executa a query
            conn.CloseConnection();             // Encerra conexão
        }

        public IEnumerable<Licitacao> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Update(Licitacao obj)
        {
            conn = new Conexao();               // Chama a classe conexão

            string Query =
                "EXEC Licitacao_Update " +
               $"{obj.IdLicitacao}, " +
               $"{obj.CodLicitacao}, " +
               $"'{obj.Tipo.ToUpper()}', " +
               $"'{obj.Data}', " +
               $"{obj.FkCliente}";

            conn.ExecuteQuery(Query);           // Executa a query
            conn.CloseConnection();             // Encerra conexão
        }
    }
}
