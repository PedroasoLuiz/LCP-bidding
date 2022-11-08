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
    internal class RepositorioProduto:IRepositorio<Produto>
    {
        Conexao conn = null;
        public void Add(Produto obj)
        {
            conn = new Conexao();               // Chama a classe conexão
            conn.OpenConnection();              // Abre a conexão

            string Query =
                $"INSERT INTO Produto (codProduto, Descricao, custo, unidade ,fkMarcas )" +
                $"VALUES ('{obj.CodProduto}','{obj.Descricao}','{obj.Custo}','{obj.Unidade}','{obj.FkMarcas}')";

            conn.ExecuteQuery(Query);           // Executa a query
            conn.CloseConnection();             // Encerra conexão
        }
        public void Delete(Produto obj)
        {
            conn = new Conexao();               // Chama a classe conexão
            conn.OpenConnection();              // Abre a conexão

            string Query =
                $"DELETE Produto " +
                $"WHERE idProduto= {obj.IdProduto}";

            conn.ExecuteQuery(Query);           // Executa a query
            conn.CloseConnection();             // Encerra conexão
        }

        public IEnumerable<Produto> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Produto obj)
        {
            conn = new Conexao();               // Chama a classe conexão
            conn.OpenConnection();              // Abre a conexão

            string Query =
                $"UPADTE Produto " +
                $"SET codProduto = {obj.CodProduto}, descricao = {obj.Descricao}, custo = {obj.Custo}, " +
                $"unidade = {obj.Unidade}, fkMarcas = {obj.FkMarcas})" +
                $"WHERE idProduto = {obj.IdProduto};";

            conn.ExecuteQuery(Query);           // Executa a query
            conn.CloseConnection();             // Encerra conexão
        }
    }
}
