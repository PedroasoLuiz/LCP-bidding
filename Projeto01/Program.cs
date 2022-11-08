using System;
using System.Collections.Generic;
using MongoDB.Driver;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using MongoDB.Driver;
using Projeto01.Views;

namespace Projeto01
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLicitacao());
           // Application.Run(new frmLogin());
            cn = new SqlConnection();
            cn.ConnectionString = "Server=LocalHost; Database=LCP;UID=sa;PWD=123;";


            // CONEXÃO COM MONGODB
            //MongoClient dbClient = new MongoClient("mongodb+srv://lcpLicitacoes:<password>mongo123.ethffsk.mongodb.net/?retryWrites=true&w=majority");

            //var dbList = dbClient.ListDatabases().ToList();

            //Console.WriteLine("The list of databases on this server is: ");
            //foreach (var db in dbList)
            //{
            //    Console.WriteLine(db);
            //}
        }
        public static int acao;
        public static SqlConnection cn = null;





    }
}
