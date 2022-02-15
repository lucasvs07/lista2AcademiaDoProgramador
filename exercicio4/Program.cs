using System;

namespace Ex4L2LucasVinicius.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Faça um algoritmo para receber um número qualquer e informar na tela se
            é par ou ímpar.*/

            //Apresentação
            
            Console.WriteLine("Verifique se um número é par ou impar.");
            
            //Entrada de dados e declaração de variáveis.

            Console.WriteLine("Digite um número:");
            string strnum = Console.ReadLine();
            double dnum = Convert.ToDouble(strnum);

            //Teste de condições e saída.

            if (dnum % 2 == 0)
                Console.WriteLine(strnum + " é par.");

            else
                Console.WriteLine(strnum + " é ímpar.");

            //Finalização.

            Console.WriteLine("Pressione enter para sair.");
            Console.ReadKey();
        }
    }
}
