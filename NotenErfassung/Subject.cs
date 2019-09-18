using System;
using System.Collections.Generic;
using System.Text;

namespace NotenErfassung
{
    class Subject
    {
        public string name { get; set; }
        public static List<Mark> listOfMarks { get; private set; } = new List<Mark>();

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

        public void AddMark(int SubjectIndex)
        {
            Console.Clear();
            var newMark = Mark.CreateMark(SubjectIndex);

            listOfMarks.Add(newMark);            
        }

        public void EditMark(int SubjectIndex)
        {
            Console.Clear();
            Console.WriteLine($"-Alle Noten des Faches {Program.listOfSubjects[SubjectIndex].name}-\n");
            Console.WriteLine("Note zum Bearbeiten auswählen");

            int i = 1;

            foreach (var mark in Subject.listOfMarks)
            {
                if (mark.NameOfSubject.Equals(Program.listOfSubjects[SubjectIndex].name))
                {
                    Console.WriteLine($"[{i}]\t{mark.Value}\t{mark.Date}");
                    i++;
                }
            }

            int MarkIndex = ConsoleHelper.ReadInt(1, i) - 1;

            Console.Clear();

            Console.WriteLine("-Bearbeiten der Note-\n");

            Console.WriteLine($"Alt:\n{listOfMarks[MarkIndex].Value}\t{listOfMarks[MarkIndex].Date}");

            Console.WriteLine("Neu:\n");

            listOfMarks[MarkIndex] = Mark.CreateMark(SubjectIndex);
        }
    }
}
