using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Model
{
    internal class Licitacao
    {
        private int idLicitacao;
        private int codLicitacao;
        private string tipo;
        private DateTime data;
        private int fkCliente;

        public int CodLicitacao { get => codLicitacao; set => codLicitacao = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public DateTime Data { get => data; set => data = value; }
        public int FkCliente { get => fkCliente; set => fkCliente = value; }
        public int IdLicitacao { get => idLicitacao; set => idLicitacao = value; }
    }
}
