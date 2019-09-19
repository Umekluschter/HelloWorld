using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NotenErfassung
{
    class Subject
    {
        public string name { get; set; }
        public List<Mark> ListOfMarks { get; private set; } = new List<Mark>();

        public static Subject CreateSubject()
        {
            Console.WriteLine("Fach eingeben: ");
            var newSubjectName = Console.ReadLine();

            var newSubject = new Subject()
            {
                name = newSubjectName
            };
            return newSubject;
        }

        public void AddMark()
        {
            Console.Clear();
            var newMark = Mark.CreateMark();

            ListOfMarks.Add(newMark);            
        }

        public void EditMark()
        {
            Console.Clear();
            Console.WriteLine($"-Alle Noten des Faches {name}-\n");
            Console.WriteLine("Note zum Bearbeiten auswählen");

            int i = 0;

            foreach (var mark in ListOfMarks)
            {
                    Console.WriteLine($"[{++i}]\t{mark.Value}\t{mark.Date}");
            }

            int markIndex = ConsoleHelper.ReadInt(1, i) - 1;

            Console.Clear();

            Console.WriteLine("-Bearbeiten der Note-\n");

            Console.WriteLine($"Alt:\n{ListOfMarks[markIndex].Value}\t{ListOfMarks[markIndex].Date}");

            ListOfMarks[markIndex] = Mark.CreateMark();
        }

        public void ListMarks()
        {
            foreach (var mark in ListOfMarks)
            {
                Console.WriteLine($"{name}\t{mark.Value}\t{mark.Date}");
            }
        }
    }
}
