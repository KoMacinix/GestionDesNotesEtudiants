using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionNotesEtudiants
{
    public partial class Form1 : Form
    {
        private string STUDENTS_FILE_PATH = "students.txt";
        private string COURSES_FILE_PATH = "courses.txt";
        private string GRADES_FILE_PATH = "grades.txt";

        private List<Student> students = new List<Student>();
        private List<Course> courses = new List<Course>();
        private List<Grade> grades = new List<Grade>();


        /*---------------------------------Initialization---------------------------------------*/

        public Form1()
        {
            InitializeComponent();
            InitializeControls();
            LoadDataFromFiles();
            InitializeComboBoxes();
        }

        private void InitializeControls()
        {
            EtudiantSelectionne.Text = "Étudiant sélectionné : ";
            CoursSelectionne.Text = "Cours sélectionné : ";
            NoteSaisie.Text = "Saisir la note : ";

            btnAddStudent.Text = "Ajouter un étudiant";
            btnAddCourse.Text = "Ajouter un cours";
            btnRecordGrade.Text = "Enregistrer la note";
            btnShowGrades.Text = "Afficher les notes";
        }


        private void InitializeComboBoxes()
        {
            ddlStudents.Items.AddRange(students.Select(s => s.StudentNumber.ToString()).ToArray());
            ddlCourses.Items.AddRange(courses.Select(c => c.Title).ToArray());
        }


        /*--------------------------------File Operations-----------------------------------------*/


        private void SaveDataToFiles()
        {
            SaveStudentsToFile();
            SaveCoursesToFile();
            SaveGradesToFile();
        }

        private void LoadDataFromFiles()
        {
            LoadStudentsFromFile();
            LoadCoursesFromFile();
            LoadGradesFromFile();
        }


        /*--------------------------------File Operations (Save)------------------------------------------*/


        private void SaveStudentsToFile()
        {
            using (StreamWriter writer = new StreamWriter(STUDENTS_FILE_PATH))
            {
                foreach (Student student in students)
                {
                    writer.WriteLine($"{student.StudentNumber},{student.Name},{student.FirstName}");
                }
            }
        }

        private void SaveCoursesToFile()
        {
            using (StreamWriter writer = new StreamWriter(COURSES_FILE_PATH))
            {
                foreach (Course course in courses)
                {
                    writer.WriteLine($"{course.CourseNumber},{course.CourseCode},{course.Title}");
                }
            }
        }

        private void SaveGradesToFile()
        {
            using (StreamWriter writer = new StreamWriter(GRADES_FILE_PATH))
            {
                foreach (Grade grade in grades)
                {
                    writer.WriteLine($"{grade.StudentNumber},{grade.CourseNumber},{grade.Score}");
                }
            }
        }


        /*---------------------------------File Operations (Load)------------------------------------------*/


        private void LoadStudentsFromFile()
        {
            if (File.Exists(STUDENTS_FILE_PATH))
            {
                students.Clear();
                using (StreamReader reader = new StreamReader(STUDENTS_FILE_PATH))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            string[] parts = line.Split(',');
                            if (parts.Length >= 3)
                            {
                                int studentNumber;
                                if (int.TryParse(parts[0], out studentNumber))
                                {
                                    string name = parts[1];
                                    string firstName = parts[2];
                                    students.Add(new Student(studentNumber, name, firstName));
                                }
                                else
                                {
                                    Console.WriteLine("Numéro d'étudiant invalide : " + parts[0]);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ligne mal formatée : " + line);
                            }
                        }
                    }
                }
            }
        }

        private void LoadCoursesFromFile()
        {
            if (File.Exists(COURSES_FILE_PATH))
            {
                courses.Clear();
                using (StreamReader reader = new StreamReader(COURSES_FILE_PATH))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        int courseNumber;
                        if (int.TryParse(parts[0], out courseNumber))
                        {
                            string courseCode = parts[1];
                            string title = parts[2];
                            courses.Add(new Course(courseNumber, courseCode, title));
                        }
                        else
                        {
                            Console.WriteLine("Numéro de cours invalide : " + parts[0]);
                        }
                    }
                }
            }
        }

        private void LoadGradesFromFile()
        {
            if (File.Exists(GRADES_FILE_PATH))
            {
                grades.Clear();
                using (StreamReader reader = new StreamReader(GRADES_FILE_PATH))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        int studentNumber = int.Parse(parts[0]);
                        int courseNumber = int.Parse(parts[1]);
                        double score = double.Parse(parts[2]);
                        grades.Add(new Grade(studentNumber, courseNumber, score));
                    }
                }
            }
        }



        /*---------------------------------Event Handlers-------------------------------------------*/



        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string name = txtStudentName.Text;
            string firstName = txtStudentFirstName.Text;
            int studentNumber;

            if (!int.TryParse(txtStudentNumber.Text, out studentNumber))
            {
                MessageBox.Show("Veuillez saisir un numéro d'étudiant valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Student newStudent = new Student(studentNumber, name, firstName);
            students.Add(newStudent);

            MessageBox.Show("Étudiant ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtStudentName.Text = "";
            txtStudentFirstName.Text = "";
            txtStudentNumber.Text = "";

            ddlStudents.Items.Clear();
            foreach (Student student in students)
            {
                ddlStudents.Items.Add(student.StudentNumber);
            }
            SaveDataToFiles();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            int courseNumber;

            if (!int.TryParse(txtCourseNumber.Text, out courseNumber))
            {
                MessageBox.Show("Veuillez saisir un numéro de cours valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string courseCode = txtCourseCode.Text;
            string title = txtCourseTitle.Text;

            Course newCourse = new Course(courseNumber, courseCode, title);
            courses.Add(newCourse);

            MessageBox.Show("Cours ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtCourseNumber.Text = "";
            txtCourseCode.Text = "";
            txtCourseTitle.Text = "";

            ddlCourses.Items.Clear();
            foreach (Course course in courses)
            {
                ddlCourses.Items.Add(course.Title);
            }
            SaveDataToFiles();
        }

        private void btnRecordGrade_Click(object sender, EventArgs e)
        {
            if (ddlStudents.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un étudiant.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int studentNumber;
            if (!int.TryParse(ddlStudents.SelectedItem.ToString(), out studentNumber))
            {
                MessageBox.Show("Veuillez sélectionner un étudiant valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ddlCourses.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un cours.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int courseNumber;
            string selectedCourseTitle = ddlCourses.SelectedItem.ToString();
            Course selectedCourse = courses.FirstOrDefault(c => c.Title == selectedCourseTitle);
            if (selectedCourse == null)
            {
                MessageBox.Show("Veuillez sélectionner un cours valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            courseNumber = selectedCourse.CourseNumber;

            double score;
            if (!double.TryParse(txtScore.Text, out score))
            {
                MessageBox.Show("Veuillez saisir une note valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (grades.Any(g => g.StudentNumber == studentNumber && g.CourseNumber == courseNumber))
            {
                MessageBox.Show("L'étudiant a déjà une note pour ce cours.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Grade newGrade = new Grade(studentNumber, courseNumber, score);
            grades.Add(newGrade);

            MessageBox.Show("Note enregistrée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtScore.Text = "";
            SaveDataToFiles();
        }

        private void btnShowGrades_Click(object sender, EventArgs e)
        {
            if (ddlStudents.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un étudiant.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int studentNumber;

            if (!int.TryParse(ddlStudents.SelectedItem.ToString(), out studentNumber))
            {
                MessageBox.Show("Veuillez sélectionner un étudiant.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Student selectedStudent = students.FirstOrDefault(s => s.StudentNumber == studentNumber);
            if (selectedStudent == null)
            {
                MessageBox.Show("Étudiant non trouvé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var studentGrades = grades.Where(g => g.StudentNumber == studentNumber).ToList();

            if (studentGrades.Count == 0)
            {
                MessageBox.Show("L'étudiant n'a aucune note enregistrée.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Notes de l'étudiant {selectedStudent.Name} {selectedStudent.FirstName} :");

            foreach (var grade in studentGrades)
            {
                Course course = courses.FirstOrDefault(c => c.CourseNumber == grade.CourseNumber);
                if (course != null)
                {
                    sb.AppendLine($"Cours : {course.Title}, Note : {grade.Score}");
                }
                else
                {
                    sb.AppendLine($"Cours (numéro {grade.CourseNumber}), Note : {grade.Score}");
                }
            }

            MessageBox.Show(sb.ToString(), "Notes de l'étudiant", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        /*---------------------------Drop Down List (ddl)----------------------------------------*/


        private void ddlStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedStudentNumber;
            if (!int.TryParse(ddlStudents.SelectedItem.ToString(), out selectedStudentNumber))
            {
                MessageBox.Show("Veuillez sélectionner un étudiant valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Student selectedStudent = students.FirstOrDefault(s => s.StudentNumber == selectedStudentNumber);
            if (selectedStudent != null)
            {
                EtudiantSelectionne.Text = $"Étudiant sélectionné : {selectedStudent.Name} {selectedStudent.FirstName}";
            }
            LoadDataFromFiles();
        }




        private void ddlCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCourseTitle = ddlCourses.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedCourseTitle))
            {
                MessageBox.Show("Veuillez sélectionner un cours valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Course selectedCourse = courses.FirstOrDefault(c => c.Title == selectedCourseTitle);
            if (selectedCourse != null)
            {
                CoursSelectionne.Text = $"Cours sélectionné : {selectedCourse.CourseCode} - {selectedCourse.Title}";
            }
            LoadDataFromFiles();
        }
    }
}
