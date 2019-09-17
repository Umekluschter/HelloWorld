using System;
using System.Collections.Generic;
using System.Text;

namespace NotenErfassung
{
    class Subject
    {
        public string name { get; set; }
        public static List<Mark> listOfMarks { get; private set; }


        public Subject()
        {
            listOfMarks = new List<Mark>();
        }

        public static Subject CreateSubject()
        {
            Console.WriteLine("Fach eingeben: ");
            var newSubjectName = Console.ReadLine();

            var fach = new Subject()
            {
                name = newSubjectName
            };

            return fach;
        }

        public void AddMark()
        {
            var newMark = Mark.CreateMark();

            listOfMarks.Add(newMark);            
        }
    }
}
