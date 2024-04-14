using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNotesEtudiants
{
    internal class Student
    {
        public int StudentNumber { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }

        public Student(int studentNumber, string name, string firstName)
        {
            StudentNumber = studentNumber;
            Name = name;
            FirstName = firstName;
        }
    }
}
