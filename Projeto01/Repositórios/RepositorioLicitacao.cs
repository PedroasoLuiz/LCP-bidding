using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Model;
using System.Data.SqlClient;

namespace Projeto01.Repositórios
{
    internal class RepositorioLicitacao : IRepositorio<Licitacao>
    {
        public void Add(Licitacao obj)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Server=.\\SQLEXPRESS;Database=LCP;UID=sa;PWD=123;";
            cn.Open();

            SqlCommand cd = new SqlCommand();
            cd.Connection = cn;
            cd.CommandText = "Insert into Licitacao (codLicitacao, nome, cidade, estado)" +
                "values ('" + obj.CodCliente + "','" + obj.Nome + "','" + obj.Cidade + "','" + obj.Estado + "')";
            cd.ExecuteNonQuery();
            cn.Close();

        }

        public void Delete(Licitacao obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Licitacao obj)
        {
            throw new NotImplementedException();
        }
    }
}
