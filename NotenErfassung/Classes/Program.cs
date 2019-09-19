using System;
using System.Collections.Generic;
using System.Linq;

namespace NotenErfassung
{
    class Program
    {

        public static List<Subject> listOfSubjects = new List<Subject>();
        public int SubjectIndex = 0;

        public static void Main(string[] args)
        {
            Console.Title = "Notenerfassung";
            new Program().Start();
        }

        private void Start()
        {
            int a = 1;

            while (a == 1)
            {
                Console.Clear();
                Console.WriteLine("[1] Create Subject\n[2] Select Subject\n[3] List Subjects\n[4] List Marks\n[0] Exit");

                var input = ConsoleHelper.ReadInt(0, 4);

                switch (input)
                {
                    case 1:
                        Console.Clear();
                        CreateSubject();
                        Console.Clear();
                        break;

                    case 2:
                        Console.Clear();
                        SelectSubject();
                        Console.Clear();
                        break;

                    case 3:
                        Console.Clear();
                        ListSubjects();
                        Console.Clear();
                        break;

                    case 4:
                        Console.Clear();

                        Console.WriteLine($"-Alle Noten-\n");
                        Console.WriteLine("Fach\tNote\tDatum\n");

                        foreach (var subject in listOfSubjects)
                        {
                            subject.ListMarks();
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 0:
                        a = 0;
                        break;
                }
            }
        }

        public void CreateSubject()
        {
            {
                var newSubject = Subject.CreateSubject();

                listOfSubjects.Add(newSubject);

                Console.WriteLine($"Fach {newSubject.name} wurde erfolgreich erfasst!");
                Console.ReadKey();
            }
        }

        public void SelectSubject()
        {
            for (int i = 0; i < listOfSubjects.Count; i++)
            {
                Console.WriteLine($"[{i+1}] {listOfSubjects[i].name}");
            }

            SubjectIndex = ConsoleHelper.ReadInt(1, listOfSubjects.Count) - 1;

            Console.Clear();

            Console.WriteLine($"-{listOfSubjects[SubjectIndex].name}-\n");

            Console.WriteLine("[1] Add Mark\n[2] Edit Mark");

            int switchMark = ConsoleHelper.ReadInt(1, 2);

            //Verweist auf das Fach
            var selectetSubject = listOfSubjects[SubjectIndex];

            switch (switchMark)
            {
                case 1:
                    selectetSubject.AddMark();
                    break;

                case 2:
                    selectetSubject.EditMark();
                    break;
            }
        }

        public void ListSubjects()
        {
            foreach (var subject in listOfSubjects)
            {
                Console.WriteLine(subject.name);
            }
            Console.ReadKey();
        }        
    }
}
