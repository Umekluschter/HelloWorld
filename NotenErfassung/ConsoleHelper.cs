using System;
using System.Collections.Generic;
using System.Text;

namespace NotenErfassung
{
    class ConsoleHelper
    {
        public static int ReadInt(int min = int.MinValue, int max = int.MaxValue)
        {
            while (true)
            {
                string input = Console.ReadLine();
                int value;
                var parsed = int.TryParse(input, out value);
                if (parsed)
                {
                    if(value >= min && value <= max)
                    {
                        return value;
                    }
                    Console.WriteLine($"Wert muss zwischen {min} und {max} liegen!");
                }
                else
                {
                    Console.WriteLine("Keine gültige Zahl!");
                }

            }
        }

        public static decimal ReadDecimal(int min = int.MinValue, int max = int.MaxValue)
        {
            while (true)
            {
                string input = Console.ReadLine();
                decimal value;
                var parsed = decimal.TryParse(input, out value);
                if (parsed)
                {
                    if (value >= min && value <= max)
                    {
                        return value;
                    }
                    Console.WriteLine($"Wert muss zwischen {min} und {max} liegen!");
                }
                else
                {
                    Console.WriteLine("Keine gültige Zahl!");
                }

            }
        }

        public static DateTime ReadDate()
        {
            Console.WriteLine("\nJahr: ");
            var year= ReadInt(1900, 2100);

            Console.WriteLine("\nMonat: ");
            var month = ReadInt(1, 12);

            Console.WriteLine("\nTag: ");
            var day = ReadInt(1, 31);

            return new DateTime(year, month, day);
        }


    }
}
