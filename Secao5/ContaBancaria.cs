using System;
using System.Globalization;

namespace Secao5
{
    internal class ContaBancaria
    {
        // Atributos com propriedades get e set
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        // Construtores com sobrecarga
        public ContaBancaria(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }
        // Método para não ter que repetir os valores no programa principal
        public override string ToString()
        {
            return "Conta " + Numero + ", Titular: " + Titular + ", Saldo: $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

        // Métodos/funções
        public void Deposito (double valorNovo)
        {
            Saldo += valorNovo;
        }

        public void Saque (double valorRetirado)
        {
            Saldo = (Saldo - valorRetirado) - 5;
        }
    }
}




