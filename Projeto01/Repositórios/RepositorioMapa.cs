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
            conn.OpenConnection();              // Abre a conexão

            string Query = 
                "Insert into Fornecedores (precoMax, precoMin, quantidade, unidade, valorFinal, fkProduto, fkFornecedor, fkLicitacao)" 
                + "values ('" + obj.PrecoMax + "','" + obj.PrecoMin + "','" + obj.PrecoMin + "','" + obj.Quantidade + "','" 
                + obj.Unidade + "','" + obj.ValorFinal + "','" + obj.FkProduto + "','" + obj.FkFornecedor + "','" + obj.FkLicitacao + "')";


            conn.ExecuteQuery(Query);           // Executa a query
            conn.CloseConnection();             // Encerra conexão
        }
        public void Delete(Mapa obj)
        {
            conn = new Conexao();               // Chama a classe conexão
            conn.OpenConnection();              // Abre a conexão

            SqlCommand cd = new SqlCommand();
            cd.Connection = cn;
            cd.CommandText = $"Delete Cliente where idCliente= {obj.IdMapa}";
            cd.ExecuteNonQuery();
            cn.Close();
        }
        public void Update(Mapa obj)
        {
            conn = new Conexao();               // Chama a classe conexão
            conn.OpenConnection();              // Abre a conexão

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
