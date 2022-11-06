using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Model;
using System.Data.SqlClient;

namespace Projeto01.Repositórios
{
    internal class RepositorioCliente : IRepositorio<Cliente>
    {
        public void Add(Cliente obj)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Server=.\\SQLEXPRESS;Database=LCP;UID=sa;PWD=123;";
            cn.Open();

            SqlCommand cd = new SqlCommand();
            cd.Connection = cn;
            cd.CommandText = $"Insert into Cliente" +
                $"set codCliente = {obj.CodCliente}, nome = {obj.Nome}, " +
                $"cidade = {obj.Cidade}, estado = {obj.Estado}";
            cd.ExecuteNonQuery();
            cn.Close();
        }

        public void Delete(Cliente obj)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Server=.\\SQLEXPRESS;Database=LCP;UID=sa;PWD=123;";
            cn.Open();

            SqlCommand cd = new SqlCommand();
            cd.Connection = cn;
            cd.CommandText = $"Delete Cliente where idCliente= {obj.IdCliente}";
            cd.ExecuteNonQuery();
            cn.Close();
        }

        public void Update(Cliente obj)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Server=.\\SQLEXPRESS;Database=LCP;UID=sa;PWD=123;";
            cn.Open();

            SqlCommand cd = new SqlCommand();
            cd.Connection = cn;
            cd.CommandText = $"Update Cliente " +
                             $"set nome = {obj.Nome}, cidade = {obj.Cidade}, estado ={obj.Estado}"+
                             $"where idCliente = {obj.IdCliente};";
            cd.ExecuteNonQuery();
            cn.Close();

        }
    }
}
