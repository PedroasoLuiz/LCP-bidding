using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Model;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projeto01.Model
{
    class Conexao
    {
        private string string_conexao = "Server=LocalHost; Database=LCP;UID=sa;PWD=123;";

        public SqlConnection cn;
        public SqlCommand comand;
        public SqlDataReader dr;

        public Conexao()
        {
        }

        public void CloseConnection()
        {
            cn.Close();
        }

        public SqlConnection OpenConnection()
        {
            cn = new SqlConnection();
            cn.ConnectionString = string_conexao;
            cn.Open();
            return cn;
        }

        public void ExecuteQuery(string Query)
        {
            comand = new SqlCommand();
            comand.Connection = OpenConnection();
            comand.CommandText = Query;
            comand.ExecuteNonQuery();
            dr = comand.ExecuteReader();
        }
        
    }
}
