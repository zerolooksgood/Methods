using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Oppg 1
            Console.WriteLine($"3 + 4 = {adder(3,4)}");
            Console.WriteLine($"1 + 11 = {adder(1, 11)}");

            //Oppg 2
            Console.WriteLine("Hva er setningen du vil lete gjennom?");
            string tekst = Console.ReadLine();
            char bokstav;
            while (true)
            {
                try
                {
                    Console.WriteLine("Hvilken bokstav vil du lete etter?");
                    bokstav = Console.ReadKey().KeyChar;
                    Console.WriteLine($"\n{tekst}\nInneholder {tekst.Count(t => t == bokstav)}");
                    break;
                }
                catch
                {
                    Console.WriteLine("Vennligst oppgi en bokstav");
                }
            }

            //Oppg 3

            Console.ReadLine();
        }

        //Oppg 1
        static int adder(int num1, int num2)
        {
            return num1 + num2;
        }

        //Oppg 3
        //Det e rlettere å bare kopiere all koden inn i funksjonen enn å splitte den til en del i funksjonen og en del i hovedprogrammet
        static void tellForekomst()
        {
            Console.WriteLine("Hva er setningen du vil lete gjennom?");
            string tekst = Console.ReadLine();
            char bokstav;
            while (true)
            {
                try
                {
                    Console.WriteLine("Hvilken bokstav vil du lete etter?");
                    bokstav = Console.ReadKey().KeyChar;
                    Console.WriteLine($"\n{tekst}\nInneholder {tekst.Count(t => t == bokstav)}");
                    break;
                }
                catch
                {
                    Console.WriteLine("Vennligst oppgi en bokstav");
                }
            }
        }
    }
}
