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
    internal class RepositorioMapa:IRepositorio<Mapa>
    {
        Conexao conn = null;
        public void Add(Mapa obj)
        {
            conn = new Conexao();               // Chama a classe conexão

            string Query =
                "INSERT INTO Mapa (PrecoMax, PrecoMin, Quantidade, Unidade, fkProduto, ValorFinal, fkFornecedor, fkLicitacao) " +
               $"VALUES ('{obj.PrecoMax}','{obj.PrecoMin}','{obj.Quantidade}','{obj.Unidade}',"+ 
               $"{obj.FkProduto}','{obj.ValorFinal}','{obj.FkFornecedor}','{obj.FkLicitacao}') ";


            conn.ExecuteQuery(Query);           // Executa a query
            conn.CloseConnection();             // Encerra conexão
        }
        public void Delete(Mapa obj)
        {
            conn = new Conexao();               // Chama a classe conexão

            string Query =
                $"DELETE Mapa " +
                $"WHERE idCliente= {obj.IdMapa}";

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
                $"UPDATE Mapa " +
                $"SET PrecoMax = {obj.PrecoMax}, PrecoMin = {obj.PrecoMin}, Quantidade = {obj.Quantidade}, Unidade = {obj.Unidade}, " +
                $"fkProduto = {obj.FkProduto}, ValorFinal = {obj.ValorFinal}, fkFornecedor = {obj.FkFornecedor}, fkLicitacao = {obj.FkLicitacao}" +
                $"WHERE idMapa = {obj.IdMapa};";


            conn.ExecuteQuery(Query);           // Executa a query
            conn.CloseConnection();             // Encerra conexão
        }
    }
}
