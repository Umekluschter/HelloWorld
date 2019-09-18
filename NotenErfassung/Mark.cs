using System;
using System.Collections.Generic;
using System.Text;

namespace NotenErfassung
{

    class Mark
    {
        public string NameOfSubject { get; set; }
        public decimal Value { get; set; }
        public string Date { get; set; }

        internal static Mark CreateMark(int SubjectIndex)
        {
            Console.WriteLine("Note eingeben: ");
            var value = ConsoleHelper.ReadDecimal(1, 6);

            var date = ConsoleHelper.ReadDate();

            var SubjectName = Program.listOfSubjects[SubjectIndex].name;

            return new Mark()
            {
                NameOfSubject = SubjectName,
                Value = value,
                Date = date
            };
        }
    }
}
