using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Model;
using System.Data.SqlClient;

namespace Projeto01.Repositórios
{
    internal class RepositorioFornecedores: IRepositorio<Fornecedores>
    {
        public void Add(Fornecedores obj)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Server=.\\SQLEXPRESS;Database=LCP;UID=sa;PWD=123;";
            cn.Open();

            SqlCommand cd = new SqlCommand();
            cd.Connection = cn;
            cd.CommandText = "Insert into Fornecedores (nome, tipo)" +
                "values ('" + obj.Nome + "','" + obj.Tipo + "')";
            cd.ExecuteNonQuery();
            cn.Close();
        }
        public void Delete(Fornecedores obj)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Server=.\\SQLEXPRESS;Database=LCP;UID=sa;PWD=123;";
            cn.Open();

            SqlCommand cd = new SqlCommand();
            cd.Connection = cn;
            cd.CommandText = $"Delete Cliente where idCliente= {obj.IdFornecedores}";
            cd.ExecuteNonQuery();
            cn.Close();
        }
        public void Update(Fornecedores obj)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Server=.\\SQLEXPRESS;Database=LCP;UID=sa;PWD=123;";
            cn.Open();

            SqlCommand cd = new SqlCommand();
            cd.Connection = cn;
            cd.CommandText = $"Update Cliente " +
                             $"set nome = {obj.Nome}, tipo = {obj.Tipo}" +
                             $"where idCliente = {obj.IdFornecedores};";
            cd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
