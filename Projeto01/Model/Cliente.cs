using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Model
{
    internal class Cliente
    {
        private int codCliente;
        private string nome;
        private string cidade;
        private string estado;

        public int CodCliente { get => codCliente; set => codCliente = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
