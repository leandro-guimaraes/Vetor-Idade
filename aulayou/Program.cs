using System;

namespace vetorIdade
{
    class Program
    {
        static void Main()
        {
            int[] idade = new int[4];

            Console.WriteLine("digite sua idade : " );
            idade[0] = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("digite sua idade : ");
            idade[1] = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("digite sua idade : ");
            idade[2] = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("digite sua idade : ");
            idade[3] = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Idade 01 coletada: " + idade[0]);
            Console.WriteLine("Idade 02 coletada: " + idade[1]);
            Console.WriteLine("Idade 03 coletada: " + idade[2]);
            Console.WriteLine("Idade 04 coletada: " + idade[3]);
        }
    }
}
