using System;

namespace Logica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Entrada de dados
            Console.WriteLine("Soma de dois números");
            Console.WriteLine("--------------------");
            Console.Write("Digite o primeiro valor: ");
            int valorUm = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            int valorDois = int.Parse(Console.ReadLine());

            //Processamento
            int soma = valorUm + valorDois;

            //Exibir
            Console.WriteLine("A soma de "+valorUm+" + "+valorDois+" = "+soma);

        }
    }
}
