using System;
using System.Collections.Generic;
using System.Linq;

namespace NotenErfassung
{
    class Program
    {

        private List<Subject> listOfSubjects = new List<Subject>();

        static void Main(string[] args)
        {
            new Program().Start();
        }

        private void Start()
        {

            int a = 1;

            while (a == 1)
            {
                Console.Clear();
                Console.WriteLine("[1] Create Subject\n[2] Select Subject\n[3] List Subjects\n[4] List Marks\n[0] Exit");

                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Clear();
                        CreateSubject();
                        Console.Clear();
                        break;

                    case "2":
                        Console.Clear();
                        SelectSubject();
                        Console.Clear();
                        break;

                    case "3":
                        Console.Clear();
                        ListSubjects();
                        Console.Clear();
                        break;

                    case "4":
                        Console.Clear();
                        ListMarks();
                        Console.Clear();
                        break;

                    case "0":
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
                Console.WriteLine($"[{i}] {listOfSubjects[i].name}");
            }

            int index = ConsoleHelper.ReadInt(0, listOfSubjects.Count -1);

            Console.Clear();

            Console.WriteLine($"-{listOfSubjects[index].name}-\n");

            Console.WriteLine("[1] Add Mark\n[2] Edit Mark");

            int switchMark = ConsoleHelper.ReadInt(1, 2);

            var selectetSubject = listOfSubjects[index];

            switch (switchMark)
            {
                case 1:
                    selectetSubject.AddMark();
                    break;

                case 2:

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

        public static void ListMarks()
        {
            Console.WriteLine("-Noten-\n");
            foreach (var mark in Subject.listOfMarks)
            {
                int i = 0;
                Console.WriteLine($"{mark.Value}\t{mark.Date}");
                i++;
            }
            Console.ReadKey();
        }
    }
}
