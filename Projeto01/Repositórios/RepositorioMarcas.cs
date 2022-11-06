using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Model;
using System.Data.SqlClient;

namespace Projeto01.Repositórios
{
    internal class RepositorioMarcas:IRepositorio<Marcas>
    {
        public void Add(Marcas obj)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Server=.\\SQLEXPRESS;Database=LCP;UID=sa;PWD=123;";
            cn.Open();

            SqlCommand cd = new SqlCommand();
            cd.Connection = cn;
            cd.CommandText = "Insert into Fornecedores (nome)" +
                "values ('" + obj.Nome + "')";
            cd.ExecuteNonQuery();
            cn.Close();
        }
        public void Delete(Marcas obj)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Server=.\\SQLEXPRESS;Database=LCP;UID=sa;PWD=123;";
            cn.Open();

            SqlCommand cd = new SqlCommand();
            cd.Connection = cn;
            cd.CommandText = $"Delete Cliente where idCliente= {obj.IdMarca}";
            cd.ExecuteNonQuery();
            cn.Close();
        }
        public void Update(Marcas obj)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Server=.\\SQLEXPRESS;Database=LCP;UID=sa;PWD=123;";
            cn.Open();

            SqlCommand cd = new SqlCommand();
            cd.Connection = cn;
            cd.CommandText = $"Update Cliente " +
                             $"set nome = {obj.Nome}" +
                             $"where idCliente = {obj.IdMarca};";
            cd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
