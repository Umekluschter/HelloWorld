using System;
using System.Collections.Generic;
using System.Text;

namespace NotenErfassung
{

    class Mark
    {
        public decimal Value { get; set; }
        public string Date { get; set; }

        internal static Mark CreateMark()
        {
            Console.WriteLine("Note eingeben: ");
            var value = ConsoleHelper.ReadDecimal(1, 6);

            var date = ConsoleHelper.ReadDate();

            return new Mark()
            {
                Value = value,
                Date = date
            };
        }
    }
}
