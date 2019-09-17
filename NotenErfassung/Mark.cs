using System;
using System.Collections.Generic;
using System.Text;

namespace NotenErfassung
{
    /// <summary>
    /// Mark
    /// </summary>
    class Mark
    {
        public decimal Value { get; set; }
        public DateTime Date { get; set; }

        internal static Mark CreateMark()
        {
            Console.Clear();
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
