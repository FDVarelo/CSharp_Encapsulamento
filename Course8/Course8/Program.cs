using System;
using System.Globalization;

namespace Course8
{
    class Program
    {
        static void Main()
        {
            Console.Write("Entre o número da conta: ");
            string num_conta = Console.ReadLine();
            Console.Write("Entre o Titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("\nHaverá depósito inicial (s/n)? ");
            char resposta = char.Parse(Console.ReadLine());
            while(resposta != 's' && resposta != 'n')
            {
                Console.Write("Você escolheu uma opção inexistente, tente novamente.\n\nHaverá depósito inicial (s/n)? ");
                resposta = char.Parse(Console.ReadLine());
            }
            double v_inicial = 0;
            if(resposta == 's')
            {
                Console.Write("Entre o valor de depósito inicial:");
                v_inicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Conta c = new Conta(num_conta, titular, v_inicial);

            Console.WriteLine("\nDados da Conta:");
            Console.WriteLine(c);

            int valor = 1;
            while (valor != 0)
            {
                Console.Write("\n1→ Deposito\n2→ Saque\n0→ sair\n\n→ ");
                valor = int.Parse(Console.ReadLine());
                double saldo;
                if (valor == 1)
                {
                    Console.Write("Entre um valor para depósito: ");
                    saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    c.Deposito(saldo);
                }else if(valor == 2)
                {
                    Console.Write("Entre um valor para saque: ");
                    saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    c.Saque(saldo+5.0);
                    if(c.Saldo < 0)
                    {
                        Console.WriteLine("\nSaque não pode ser efetuado pois ira ficar com saldo negativo");
                        Console.Write("Ficando assim com $ " + c.Saldo + ", caso deseje efetuar o saldo máximo");
                        c.Deposito(saldo+5.0);
                        Console.WriteLine(" o valor disponivel é: $ " + c.Saldo + "\n");
                    }
                }
                else if( valor == 0)
                {
                    Console.WriteLine("Saindo do Sistema!\n");
                }
                else
                {
                    Console.WriteLine("Comando incorreto, tente novamente!\n");
                }
                Console.WriteLine(c);
            }
            
        }
    }
}
