using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Model
{
    internal class Fornecedores
    {
        private int idFornecedores;
        private string nome;
        private string tipo;

        public string Nome { get => nome; set => nome = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int IdFornecedores { get => idFornecedores; set => idFornecedores = value; }
    }
}
