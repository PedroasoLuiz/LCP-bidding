using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Model
{
    internal class Mapa
    {
        private double precoMax;
        private double precoMin;
        private int quantidade;
        private string unidade;
        private int fkProduto;
        private double valorFinal;
        private int fkFornecedor;
        private int fkLicitacao;

        public double PrecoMax { get => precoMax; set => precoMax = value; }
        public double PrecoMin { get => precoMin; set => precoMin = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public string Unidade { get => unidade; set => unidade = value; }
        public int FkProduto { get => fkProduto; set => fkProduto = value; }
        public double ValorFinal { get => valorFinal; set => valorFinal = value; }
        public int FkFornecedor { get => fkFornecedor; set => fkFornecedor = value; }
        public int FkLicitacao { get => fkLicitacao; set => fkLicitacao = value; }
    }
}
