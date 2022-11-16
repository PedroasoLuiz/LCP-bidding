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
    internal class RepositorioLicitacao : IRepositorio<Licitacao>
    {
        Conexao conn = null;
        public void Add(Licitacao obj)
        {
            conn = new Conexao();               // Chama a classe conexão

            string Query =
                "INSERT INTO Licitacao (codLicitacao,Tipo,Data, fkCliente) " +
               $"VALUES ('{ obj.CodLicitacao}','{ obj.Tipo }','{ DateTime.Now }','{ obj.FkCliente}')";

            conn.ExecuteQuery(Query);           // Executa a query
            conn.CloseConnection();             // Encerra conexão

        }

        public void Delete(Licitacao obj)
        {
            conn = new Conexao();               // Chama a classe conexão

            string Query = 
                 "DELETE Licitacao " +
                $"WHERE idLicitacao= {obj.IdLicitacao} ";

            conn.ExecuteQuery(Query);           // Executa a query
            conn.CloseConnection();             // Encerra conexão
        }

        public IEnumerable<Licitacao> GetAll()
        {
            conn = new Conexao();              
            conn.OpenConnection();

            SqlCommand li = new SqlCommand();
            li.CommandText = "Select *from Licitacao";

            SqlDataReader dr = li.ExecuteReader();
            List<Licitacao> Listacao = new List<Licitacao>();
            while (dr.Read())
            {
                Licitacao da = new Licitacao();
                da.IdLicitacao = int.Parse(dr[0].ToString());
                da.FkCliente = int.Parse(dr[1].ToString());

                Listacao.Add(da);

            }
            return Listacao;
        }

        public void Update(Licitacao obj)
        {
            conn = new Conexao();               // Chama a classe conexão

            string Query =
                $"UPDATE Licitacao " +
                $"SET codLicitacao = {obj.CodLicitacao}, Tipo = {obj.Tipo}, data ={DateTime.Now}" +
                $"WHERE idLicitacao = {obj.IdLicitacao};";

            conn.ExecuteQuery(Query);           // Executa a query
            conn.CloseConnection();             // Encerra conexão
        }
    }
}
