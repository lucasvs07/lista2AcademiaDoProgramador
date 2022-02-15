using System;

namespace Ex1L2LucasVinicius.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um algoritmo que leia os valores A, B, C e imprima na tela se a
            soma de A + B é menor que C.*/

            //Entrada de dados.

            Console.WriteLine("Digite o primeiro número: ");
            float numA = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            float numB = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número: ");
            float numC = float.Parse(Console.ReadLine());

            //Conversão para string p/ poder mostrar na saída.

            string strnumA = Convert.ToString(numA);
            string strnumB = Convert.ToString(numB);
            string strnumC = Convert.ToString(numC);

            //processamento e saída.

         if ( (numA + numB) < numC)
            {
                Console.WriteLine(strnumA + "+" + strnumB + " é menor que " + strnumC);
            }
         else
            {
                Console.WriteLine(strnumA + "+" + strnumB + " é maior que " + strnumC);
            }
            Console.WriteLine("Pressione enter para sair.");
            Console.ReadKey();

        }
    }
}
