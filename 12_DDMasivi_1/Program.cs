using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_DDMasivi_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] masivs = new int[10, 10];

            Random rand = new Random();
            for (int rinda = 0; rinda < 10; rinda++)
            {
                for (int kolonna = 0; kolonna < 10; kolonna++)
                {
                    masivs[rinda, kolonna] = rand.Next(1, 10); 
                }
            }

            Console.WriteLine("Masīvs:");
            for (int rinda = 0; rinda < 10; rinda++)
            {
                for (int kolonna = 0; kolonna < 10; kolonna++)
                {
                    Console.Write(masivs[rinda, kolonna] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nSummas katrā rindā:");
            for (int rinda = 0; rinda < 10; rinda++)
            {
                int rindasSumma = 0;
                for (int kolonna = 0; kolonna < 10; kolonna++)
                {
                    rindasSumma += masivs[rinda, kolonna];
                }
                Console.WriteLine($"Rinda {rinda + 1}: {rindasSumma}");
            }

            int visaMasivaSumma = 0;
            for (int rinda = 0; rinda < 10; rinda++)
            {
                for (int kolonna = 0; kolonna < 10; kolonna++)
                {
                    visaMasivaSumma += masivs[rinda, kolonna];
                }
            }
            Console.WriteLine($"\nVisa masīva summa: {visaMasivaSumma}");

            Console.ReadLine(); 
        }
    }
}
