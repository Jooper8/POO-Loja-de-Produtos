//Frederico Guilherme Camilli Proença RA:200925

using System;

namespace POO_Loja_de_Produtos
{
    class ProdutoUsado : Produto
    {
        //Declaração do DateTime Fabricacao, definido com automatic properties.
        public DateTime Fabricacao { get; private set; }

        //Declaração do construtor padrão.
        public ProdutoUsado() { }
        //Declaração do construtor da classe, tento nome e preco baseado na classe Produto, e adicionando o DateTime fabricacao.
        public ProdutoUsado(string nome, double preco, DateTime fabricacao) : base(nome, preco)
        {
            Fabricacao = fabricacao;
        }
        //Método para sobrescrever o método já definido na classe Produto.
        public override string PrecoTag()
        {
            //Código que retorna a etiqueta sobrescrita, com data de fabricação.
            return Nome + " (usado) - R$ " + Preco + (" (fabricado:" + Fabricacao.Day.ToString() + "/" + Fabricacao.Month.ToString() + "/" + Fabricacao.Year.ToString() + ")");
        }
    }
}
