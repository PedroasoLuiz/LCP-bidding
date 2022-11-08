using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Model;
using System.Data.SqlClient;

namespace Projeto01.Repositórios
{
    internal class RepositorioProduto:IRepositorio<Produto>
    {
        Conexao conn = null;
        public void Add(Produto obj)
        {
            conn = new Conexao();               // Chama a classe conexão
            conn.OpenConnection();              // Abre a conexão

            SqlCommand cd = new SqlCommand();
            cd.Connection = cn;
            cd.CommandText = $"Insert into Produto" +
                $"set codProduto = {obj.CodProduto}, descricao = {obj.Descricao}, custo = {obj.Custo}, " +
                $"unidade = {obj.Unidade}, fkMarcas = {obj.FkMarcas})";
            cd.ExecuteNonQuery();
            cn.Close();
        }
        public void Delete(Produto obj)
        {
            conn = new Conexao();               // Chama a classe conexão
            conn.OpenConnection();              // Abre a conexão

            SqlCommand cd = new SqlCommand();
            cd.Connection = cn;
            cd.CommandText = $"Delete Produto where idCliente= {obj.IdProduto}";
            cd.ExecuteNonQuery();
            cn.Close();
        }
        public void Update(Produto obj)
        {
            conn = new Conexao();               // Chama a classe conexão
            conn.OpenConnection();              // Abre a conexão

            SqlCommand cd = new SqlCommand();
            cd.Connection = cn;
            cd.CommandText = $"Update Produto " +
                             $"set codProduto = { obj.CodProduto }, descricao = { obj.Descricao }, custo = { obj.Custo }, " +
                             $"unidade = {obj.Unidade}, fkMarcas = {obj.FkMarcas})" +
                             $"where idCliente = {obj.IdProduto};";
            cd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
