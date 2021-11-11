//Frederico Guilherme Camilli Proença RA:200925

namespace POO_Loja_de_Produtos
{
    //Declaração da classe produto, que será a base das classes ProdutoImportado e ProdutoUsado.
    class Produto
    {
        //Declaração das variáveis Nome e Preco (string e double, respectivamente), que são definidas utilizando automatic properties.
        public string Nome { get; private set; }
        public double Preco { get; private set; }
        //Declaração do construtor padrão baseado na classe produto.
        public Produto() { }
        //Declaração do construtor com parâmetros da classe Produto, com suas variáveis nome e preco.
        public Produto(string nome, double preco)
        {
            //Associação das variáveis declaradas na classe às variáveis do construtor.
            Nome = nome;
            Preco = preco;
        }

        //Método que retorna a etiqueta. É definido como virtual para ser sobrescrito em outras classes.
        public virtual string PrecoTag()
        {
            //Código que retorna a etiqueta (Nome + Preço, em R$).
            return Nome + " - R$ " + Preco;
        }

    }
}
