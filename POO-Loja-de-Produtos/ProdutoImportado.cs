//Frederico Guilherme Camilli Proença RA:200925

namespace POO_Loja_de_Produtos
{
    class ProdutoImportado : Produto
    {
        //Declaração da variável double taxa, definida com automatic properties.
        public double Taxa { get; private set; }
        //Declaração de um construtor padrão.
        public ProdutoImportado() { }
        //Declaração do construtor baseado na classe, utilizando como base o nome e preco da classe produto e adicionando a double taxa.
        public ProdutoImportado(string nome, double preco, double taxa) : base(nome, preco)
        {
            //Associação da variável taxa com a da classe, Taxa.
            Taxa = taxa;
        }
        //Método para calcular o preço total.
        public double PrecoTotal()
        {
            //Cálculo matemático do preço total.
            return (Preco + Taxa);
        }
        //Método para sobrescrever o método já definido na classe Produto.
        public override string PrecoTag()
        {
            //Código que retorna a etiqueta sobrescrita, com taxa.
            return Nome + " - R$ " + Preco + "Taxa: " + Taxa + ")";
        }
    }
}
