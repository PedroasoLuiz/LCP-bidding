using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Model
{
    internal class Fornecedores
    {
        private int idFornecedores;
        private string cidade;
        private string estado;
        private string nome;
        private string tipo;

        public int IdFornecedores { get => idFornecedores; set => idFornecedores = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
