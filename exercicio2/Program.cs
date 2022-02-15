using System;

namespace Ex3L2LucasVinicius.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Escreva um algoritmo que leia três valores inteiros e diferentes e
               mostre-os em ordem decrescente.*/

            Console.WriteLine("Digite o valor de A:");
            string strnumA = Console.ReadLine();
            int numA = Convert.ToInt32(strnumA);

            Console.WriteLine("Digite o valor de B:");
            string strnumB = Console.ReadLine();
            int numB = Convert.ToInt32(strnumB);

            Console.WriteLine("Digite o valor de C:");
            string strnumC = Console.ReadLine();
            int numC = Convert.ToInt32(strnumC);
            //a>b e b>c Visto | b>a e a>c | b>a e b>c e c>a | c>b e b>a |c>b e a>b
            if (numA > numB && numB > numC)
                Console.WriteLine(strnumA + " A > " + strnumB + " B > " + strnumC + " C.");

            else if (numA > numC && numC > numB && numA > numB)
                Console.WriteLine(strnumA + " A > " + strnumC + " C > " + strnumB + " B.");

            else if (numB > numA && numA > numC)
                Console.WriteLine(strnumB + " B > " + strnumA + " A > " + strnumC + " C.");

            else if (numB > numC && numC > numA && numB > numA)
                Console.WriteLine(strnumB + " B > " + strnumC + " C > " + strnumA + " A.");
             
            else if (numC > numA && numA > numB)
                Console.WriteLine(strnumC + " C > " + strnumA + " A > " + strnumB + " B.");

            else if (numC > numB && numB > numA && numC > numA)
                Console.WriteLine(strnumC + " C > " + strnumB + " B > " + strnumA + " A.");

            Console.WriteLine("Pressione enter para sair.");
            Console.ReadKey();

        }
    }
}
