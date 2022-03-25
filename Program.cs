using System;

namespace Astric_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int le = 1;
            Console.WriteLine("Enter A Number : ");
            int no = int.Parse(Console.ReadLine());
            int sp = no - 1;
            for ( int i = 1; i<= no; i++)
            {
                for (int j = 1; j<= sp; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 1; k<= le; k++)
                {
                    Console.Write("*");
                }
                sp--;
                le += 2;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
