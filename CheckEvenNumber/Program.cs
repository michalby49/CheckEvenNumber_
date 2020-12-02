using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckEvennumber
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Podaj liczbe, a ja sprawdze czy jest parzysta");

                var number = GetNumber();

                if (number % 2 == 0)
                    Console.WriteLine("Twoja liczba jest parzysta");
                else
                    Console.WriteLine("Twoja liczba nie jest parzysta");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static int GetNumber()
        {
            if (!int.TryParse(Console.ReadLine(), out int input))
                throw new Exception("To nie jest liczba");
            return input;
        }

    }
}
