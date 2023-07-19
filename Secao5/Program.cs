using Secao5;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dados da conta com um depósito inicial
            ContaBancaria conta;
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            // Dados sem depósito inicial 
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            // Saída dos dados (da conta com depósito ou da conta sem depósito)
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            // Depositar saldo na conta 
            Console.Write("Entre um valor para depósito:");
            double valorNovo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(valorNovo);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            // Retirar saldo na conta 
            Console.Write("Entre um valor para saque:");
            double valorRetirado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(valorRetirado);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }
    }
}
