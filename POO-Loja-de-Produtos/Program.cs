//Frederico Guilherme Camilli Proença RA:200925

using System;
using System.Collections.Generic;

namespace POO_Loja_de_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração das diversas variáveis que serão utilizadas no programa.
            int N;
            char ch;
            string nome;
            double preco;
            //Declaração das listas de de produtos comununs, importados e usados.
            List<Produto> LPC = new();
            List<ProdutoImportado> LPI = new();
            List<ProdutoUsado> LPU = new();
            //Interação com o usuário requerindo o número de produtos a serem registrados.
            Console.WriteLine("Entre com número de produtos:");
            //Inserção do usuário sobre o número de produtos.
            N = int.Parse(Console.ReadLine());
            //Repetição que ocorrerá a cada número de produtos que o usuário necessita preencher.
            for (int i = 1; i <= N; i++)
            {
                //Interação com o usuário que anuncia o número do produto, e requer o tipo de produto a ser inserido.
                Console.WriteLine($"PRODUTO#{N}");
                Console.WriteLine("Comum, Usado ou Importado (C/U/I)?");
                //Inserção do usuário sobre o tipo de produto a ser inserido.
                ch = char.Parse(Console.ReadLine());
                ch = char.ToUpper(ch);//Aumento do caractere inserido ao usuário para maiuscula, para aumentar as inputs possíveis.
                //Caso de item comum.
                if (ch == 'C')
                {
                    //Interação e inserção do nome.
                    Console.WriteLine("Nome: ");
                    nome = Console.ReadLine();
                    //Interação e inserção do preço.
                    Console.WriteLine("Preço: ");
                    preco = double.Parse(Console.ReadLine());
                    //Inserção do produto criado na lista adequada.
                    LPC.Add(new Produto(nome, preco));

                }
                //Caso de item usado.
                else if (ch == 'U')
                {
                    //Declaração das variáveis int dia, mes e ano, que são utilizadas apenas caso o item seja usado.
                    int dia, mes, ano;
                    //Interação e inserção do nome.
                    Console.WriteLine("Nome: ");
                    nome = Console.ReadLine();
                    //Interação e inserção do preço.
                    Console.WriteLine("Preço: ");
                    preco = double.Parse(Console.ReadLine());
                    //Interação e inserção do dia, mes e ano pelo usuário.
                    Console.WriteLine("Sobre a data de fabricação, insira:");
                    Console.WriteLine("o dia (XX):");
                    dia = int.Parse(Console.ReadLine());
                    Console.WriteLine("o mês (XX):");
                    mes = int.Parse(Console.ReadLine());
                    Console.WriteLine("o ano (XXXX):");
                    ano = int.Parse(Console.ReadLine());
                    //Declaração do DateTime fabricacao;
                    DateTime fabricacao;
                    //Inserção dos dados préviamente inseridos pelo usuário no fabricacao.
                    fabricacao = new DateTime(ano, mes, dia);
                    //Inserção do produto criado na lista adequada.
                    LPU.Add(new ProdutoUsado(nome, preco, fabricacao));
                }
                //Caso de item importado.
                else if (ch == 'I')
                {
                    //Interação e inserção do nome.
                    Console.WriteLine("Nome: ");
                    nome = Console.ReadLine();
                    //Interação e inserção do preço.
                    Console.WriteLine("Preço: ");
                    preco = double.Parse(Console.ReadLine());
                    //Inserção da taxa.
                    Console.WriteLine("Taxa: ");
                    double taxa = double.Parse(Console.ReadLine());
                    //Inserção do produto criado na lista adequada.
                    LPI.Add(new ProdutoImportado(nome, preco, taxa));
                }
            }
            //Pré-interação com o usuário.
            Console.WriteLine("Etiquetas: ");
            //Repetição para demonstrar todos os itens preenchidos pelo usuário. (Não funciona).
            for (int i = 0; i < N; i++)
            {
                //Demonstração dos itens preenchidos pelo usuário (não funciona).
                    Console.WriteLine(LPC[i].PrecoTag());
                    Console.WriteLine(LPU[i].PrecoTag());
                    Console.WriteLine(LPI[i].PrecoTag());
            }
        }
    }
}
