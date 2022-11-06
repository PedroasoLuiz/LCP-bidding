using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Model;
using System.Data.SqlClient;

namespace Projeto01.Repositórios
{
    internal class RepositorioMapa:IRepositorio<Mapa>
    {
        public void Add(Mapa obj)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Server=.\\SQLEXPRESS;Database=LCP;UID=sa;PWD=123;";
            cn.Open();

            SqlCommand cd = new SqlCommand();
            cd.Connection = cn;
            cd.CommandText = "Insert into Fornecedores (precoMax, precoMin, quantidade, unidade, valorFinal, fkProduto, fkFornecedor, fkLicitacao)" 
                + "values ('" + obj.PrecoMax + "','" + obj.PrecoMin + "','" + obj.PrecoMin + "','" + obj.Quantidade + "','" 
                + obj.Unidade + "','" + obj.ValorFinal + "','" + obj.FkProduto + "','" + obj.FkFornecedor + "','" + obj.FkLicitacao + "')";
            cd.ExecuteNonQuery();
            cn.Close();
        }
        public void Delete(Mapa obj)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Server=.\\SQLEXPRESS;Database=LCP;UID=sa;PWD=123;";
            cn.Open();

            SqlCommand cd = new SqlCommand();
            cd.Connection = cn;
            cd.CommandText = $"Delete Cliente where idCliente= {obj.IdMapa}";
            cd.ExecuteNonQuery();
            cn.Close();
        }
        public void Update(Mapa obj)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Server=.\\SQLEXPRESS;Database=LCP;UID=sa;PWD=123;";
            cn.Open();

            SqlCommand cd = new SqlCommand();
            cd.Connection = cn;
            cd.CommandText = $"Update Cliente " +
                             $"set precoMax = {obj.PrecoMax}, precoMin = {obj.PrecoMin}, quantidade = { obj.Quantidade}, unidade = {obj.Unidade}, " +
                             $"valorFinal = {obj.ValorFinal}, fkProduto = {obj.FkProduto}, fkFornecedor = {obj.FkFornecedor}, fkLicitacao = {obj.FkLicitacao}" + 
                             $"where idCliente = {obj.IdMapa};";
            cd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
