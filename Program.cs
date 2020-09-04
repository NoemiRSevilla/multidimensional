using System;

namespace multidimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,,] multiplication_table = new int [9, 1, 9];
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + "\t");
                for (int j = 2; j <=10; j++)
                {
                    Console.Write(i * j + "\t");
                }
                Console.Write("\n");
            }
        }
    }
}
