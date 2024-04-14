using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNotesEtudiants
{
    internal class Course
    {
        public int CourseNumber { get; set; }
        public string CourseCode { get; set; }
        public string Title { get; set; }

        public Course(int courseNumber, string courseCode, string title)
        {
            CourseNumber = courseNumber;
            CourseCode = courseCode;
            Title = title;
        }
    }
}
