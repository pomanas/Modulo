using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę");
            var number = GetNumber();
            var modulo = number % 2;
            if (modulo == 0)
            {
                Console.WriteLine("Twoja liczba jest parzysta.");
            }
            else
            {
                Console.WriteLine("Twoja liczba jest nieparzysta.");
            }
        }

        private static int GetNumber()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int userNumber))
                {
                    Console.WriteLine("Podałeś nieprawidłowe dane. Spróbuj ponownie.");
                        continue;
                }
                    return userNumber;
            }
        }
    }
}
