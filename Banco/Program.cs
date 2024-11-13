using System;

namespace Banco{
    class Program{
        static void Main(string[] args){

            ContaBancaria conta;

            Console.Write("Entre com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial? ");
            char resp = char.Parse(Console.ReadLine());

            if(resp == 's' || resp =='S'){
                Console.Write("Entre com o valor: ");
                double depInicial = double.Parse(Console.ReadLine());

                conta = new ContaBancaria(numero, titular, depInicial);
            }
            else{
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.Write("Dados da conta: " + conta);
            Console.WriteLine();

            Console.Write("Entre com valor do depósito: ");
            double quantia = double.Parse(Console.ReadLine());

            conta.Deposito(quantia);

            Console.WriteLine("Dados da conta: " + conta);

            Console.Write("Entre com valor do Saque: ");
            quantia = double.Parse(Console.ReadLine());

            conta.Saque(quantia);

            Console.Write("Dados da conta: " + conta);
            Console.ReadKey();
        }
    }
}