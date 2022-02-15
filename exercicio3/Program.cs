using System;

namespace Ex3._1L2LucasVinicius.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /** Exercício 03
             O IMC – Índice de Massa Corporal é um critério da Organização Mundial
            de Saúde para dar uma indicação sobre a condição de peso de uma pessoa
            adulta
            A fórmula é IMC = peso / (altura) ²
            Elabore um algoritmo que leia o peso e a altura de um adulto e mostre
            sua condição de acordo com a tabela abaixo.
            IMC em adultos Condição
            Abaixo de 18,5 Abaixo do peso
            Entre 18,5 e 25 Peso normal
            Entre 25 e 30 Acima do peso
            Acima de 30 obeso
            */

            //Apresentação

            Console.WriteLine("Calculadora de IMC");

            //Entrada de dados.

            Console.WriteLine("Digite o peso: ");
            string strpeso = Console.ReadLine();
            double peso = Convert.ToDouble(strpeso);

            Console.WriteLine("Digite a altura: ");
            float altura = float.Parse(Console.ReadLine());

            //Processamento do IMC

            double imc = peso / (altura * altura);

            //Saída do IMC
            string strimc = Convert.ToString(imc);
            Console.WriteLine("IMC é " + imc);

            //Processamento e saída dos parametros do IMC

            if (imc < 18.5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Está abaixo do peso.");
                Console.ResetColor();
            }

            else if (imc >= 18.5 && imc < 25)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Está com peso normal.");
                Console.ResetColor();
            }

            else if (imc >= 25 && imc <= 30)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Está acima do peso.");
                Console.ResetColor();
            }

            else if (imc > 30)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O IMC atual indica obesidade.");
                Console.ResetColor();
            }

            //Finalização

            Console.WriteLine("Pressione enter para sair.");
            Console.ReadKey();

        }
    }
}
