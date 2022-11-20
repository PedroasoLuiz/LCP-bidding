using System;
using System.Collections.Generic;
using Projeto01.Model;

namespace Projeto01.Repositórios
{
    internal class RepositorioMapa:IRepositorio<Mapa>
    {
        Conexao conn = null;
        public void Add(Mapa obj)
        {
            conn = new Conexao();               // Chama a classe conexão

            string Query =
                "EXEC Mapa_Cadastro " +
               $"{obj.PrecoMax}, " +
               $"{obj.PrecoMin}, " +
               $"{obj.Quantidade}, " +
               $"'{obj.Unidade.ToUpper()}', " +
               $"{obj.FkProduto}, " +
               $"{obj.ValorFinal}, " +
               $"{obj.FkFornecedor}, " +
               $"{obj.FkLicitacao}";


            conn.ExecuteQuery(Query);           // Executa a query
            conn.CloseConnection();             // Encerra conexão
        }
        public void Delete(Mapa obj)
        {
            conn = new Conexao();               // Chama a classe conexão

            string Query =
                $"EXEC Mapa_Exclui {obj.IdMapa}";

            conn.ExecuteQuery(Query);
            conn.CloseConnection();
        }

        public IEnumerable<Mapa> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Mapa obj)
        {
            conn = new Conexao();               // Chama a classe conexão

            string Query =
                "EXEC Mapa_Update " +
               $"{obj.IdMapa}" +
               $"{obj.PrecoMax}, " +
               $"{obj.PrecoMin}, " +
               $"{obj.Quantidade}, " +
               $"'{obj.Unidade.ToUpper()}', " +
               $"{obj.FkProduto}, " +
               $"{obj.ValorFinal}, " +
               $"{obj.FkFornecedor}, " +
               $"{obj.FkLicitacao}";


            conn.ExecuteQuery(Query);           // Executa a query
            conn.CloseConnection();             // Encerra conexão
        }
    }
}
