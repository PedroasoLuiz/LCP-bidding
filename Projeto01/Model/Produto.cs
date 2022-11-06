using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Model
{
    internal class Produto
    {
        private int codProduto;
        private string descricao;
        private double custo;
        private string unidade;
        private int fkMarcas;
        private int idProduto;

        public int CodProduto { get => codProduto; set => codProduto = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double Custo { get => custo; set => custo = value; }
        public string Unidade { get => unidade; set => unidade = value; }
        public int FkMarcas { get => fkMarcas; set => fkMarcas = value; }
        public int IdProduto { get => idProduto; set => idProduto = value; }
    }
}
