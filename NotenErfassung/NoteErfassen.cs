using System;
using System.Collections.Generic;
using System.Text;

namespace NotenErfassung
{
    class NoteErfassen
    {
        float mark;
        List<string> subjectContent = new List<string>(5);
        string desc;

        public void addMark(string subject, string mark, string desc)
        {
            int switchSubject = Int32.Parse(subject);
            switch(switchSubject)
            {
                case 1:
                    this.subjectContent[1] = mark + " " + subject + desc;
                    break;

                case 2:
                    this.subjectContent[2] = mark + " " + subject + desc;
                    break;

                case 3:
                    this.subjectContent[3] = mark + " " + subject + desc;
                    break;

            }
        }
    }
}
