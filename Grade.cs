using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNotesEtudiants
{
    internal class Grade
    {
        public int StudentNumber { get; set; }
        public int CourseNumber { get; set; }
        public double Score { get; set; }

        public Grade(int studentNumber, int courseNumber, double score)
        {
            StudentNumber = studentNumber;
            CourseNumber = courseNumber;
            Score = score;
        }
    }
}

