using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            Application.Run(new frmLogin());
            cn = new SqlConnection();
            cn.ConnectionString = "Server=LocalHost; Database=LCP;UID=sa;PWD=123;";
        }
        public static int acao;
        public static SqlConnection cn = null;

       
    }
}
