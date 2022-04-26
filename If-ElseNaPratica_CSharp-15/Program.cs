using System;

namespace If_ElseNaPratica_CSharp_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva a sua idade idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva a sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            if (idade >= 6 & idade <= 10 && altura >= 1.00)
            {
                Console.WriteLine("CATEGORIA INFANTIL");
            }

            else if (idade >= 11 & idade <= 17 && altura >= 1.40)
            {
                Console.WriteLine("CATEGORIA JÚNIOR");
            }

            else if (idade >= 18 & idade <= 35 && altura >= 1.70)
            {
                Console.WriteLine("CATEGORIA PROFISSIONAL");
            }

            else if (idade >= 35 & altura >= 1.60)
            {
                Console.WriteLine("CATEGORIA SÊNIOR");
            }

            else
            {
                Console.WriteLine("SINTO MUITO, VOCÊ NÃO ESTÁ APTO PARA O TIME");
            }
        }
    }
}
