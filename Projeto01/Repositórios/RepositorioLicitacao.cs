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
            cd.CommandText = "Insert into Licitacao (codLicitacao,tipo,data, fkCliente)" +
                "values ('" + obj.CodLicitacao + "','" + obj.Tipo + "','" + obj.Data.ToString("yyyy-MM-dd") + "','" + obj.FkCliente + "')";
            cd.ExecuteNonQuery();
            cn.Close();

        }

        public void Delete(Licitacao obj)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Server=.\\SQLEXPRESS;Database=LCP;UID=sa;PWD=123;";
            cn.Open();

            SqlCommand cd = new SqlCommand();
            cd.Connection = cn;
            cd.CommandText = $"Delete Licitacao where idLicitacao= {obj.IdLicitacao}";
            cd.ExecuteNonQuery();
            cn.Close();
        }

        public void Update(Licitacao obj)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Server=.\\SQLEXPRESS;Database=LCP;UID=sa;PWD=123;";
            cn.Open();

            SqlCommand cd = new SqlCommand();
            cd.Connection = cn;
            cd.CommandText = $"Update Licitacao " +
                             $"set codLicitacao = {obj.CodLicitacao}, tipo= {obj.Tipo}, data ={obj.Data.ToString("yyyy-MM-dd")}" +
                             $"where idLicitacao = {obj.IdLicitacao};";
            cd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
