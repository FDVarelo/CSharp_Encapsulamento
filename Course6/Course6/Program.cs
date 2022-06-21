using System;
using System.Globalization;

namespace Course7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Produto p = new Produto();
            int qtd;

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (preco <= 0)
            {
                Console.WriteLine("Preço não pode ser igual ou inferior a $ 0, tente um novo valor.");
                Console.Write("Preço: ");
                preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());
            while(quantidade < 0)
            {
                Console.WriteLine("Quantidade não pode ser inferior a 0, tente um novo valor.");
                Console.Write("Quantidade: ");
                quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine("\nDados do Produto: " + p);

            int enquanto = 1;
            while (enquanto != 0)
            {
                if (p.GetQuantidade() < 0)
                {
                    Console.WriteLine("\n!ESTOQUE ESTA NEGATIVO, ADICIONAR MAIS PRODUTOS PARA SUPRIR A DEMANDA!\n");
                }
                Console.WriteLine("\n+---------------------+\n|1 → Adicionar produto|\n|2 → Retirar produto  |\n|0 → Sair do sistema  |\n+---------------------+\n");
                Console.Write("O que deseja fazer? ");
                enquanto = int.Parse(Console.ReadLine());
         
                if (enquanto == 1)
                {
                    Console.Write("Digite o número de produtos a serem adicionados no estoque: ");
                    //p.Getquantidade += p.Getquantidade = int.Parse(Console.ReadLine());
                    qtd = int.Parse(Console.ReadLine());
                    p.AdicionarQuantidade(qtd);

                    Console.WriteLine("\nDados atualizados do produto: " + p);
                }
                else if (enquanto == 2)
                {
                    Console.Write("Digite o número de produtos a serem retirados do estoque: ");
                    //p.Getquantidade -= p.Getquantidade = int.Parse(Console.ReadLine());
                    qtd = int.Parse(Console.ReadLine());
                    p.DiminuirQuantidade(qtd);

                    Console.WriteLine("\nDados atualizados do produto: " + p);
                }
                else if (enquanto == 0)
                {
                    Console.WriteLine("\nSaindo do Sistema!\n");
                }
                else
                {
                    Console.WriteLine("\nComando incorreto, tente novamente!\n");
                }
            }
        }
    }
}