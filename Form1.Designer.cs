namespace GestionNotesEtudiants
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null; // Conteneur pour les composants

        //Text Boxes

        private System.Windows.Forms.TextBox txtStudentName;        // Champ de texte pour le nom de l'étudiant
        private System.Windows.Forms.TextBox txtStudentFirstName;   // Champ de texte pour le prénom de l'étudiant
        private System.Windows.Forms.TextBox txtStudentNumber;      // Champ de texte pour le numéro de l'étudiant
        private System.Windows.Forms.TextBox txtCourseTitle;        // Champ de texte pour le titre du cours
        private System.Windows.Forms.TextBox txtCourseNumber;       // Champ de texte pour le numéro du cours
        private System.Windows.Forms.TextBox txtCourseCode;         // Champ de texte pour le code du cours
        private System.Windows.Forms.TextBox txtScore;              // Champ de texte pour saisir la note

        //Buttons

        private System.Windows.Forms.Button btnAddStudent;          // Bouton pour ajouter un étudiant
        private System.Windows.Forms.Button btnAddCourse;           // Bouton pour ajouter un cours
        private System.Windows.Forms.Button btnRecordGrade;         // Bouton pour enregistrer la note
        private System.Windows.Forms.Button btnShowGrades;          // Bouton pour afficher les notes

        //Combo Boxes

        private System.Windows.Forms.ComboBox ddlStudents;          // Liste déroulante des étudiants
        private System.Windows.Forms.ComboBox ddlCourses;           // Liste déroulante des cours

        //Labels

        private System.Windows.Forms.Label EtudiantSelectionne;     // Libellé pour afficher l'étudiant sélectionné
        private System.Windows.Forms.Label CoursSelectionne;        // Libellé pour afficher le cours sélectionné
        private System.Windows.Forms.Label NoteSaisie;              // Libellé pour afficher la saisie de la note
        private System.Windows.Forms.Label NomEtudiant;             // Libellé pour le nom de l'étudiant
        private System.Windows.Forms.Label PrenomEtudiant;          // Libellé pour le prénom de l'étudiant
        private System.Windows.Forms.Label NumeroEtudiant;          // Libellé pour le numéro de l'étudiant
        private System.Windows.Forms.Label TitreCours;              // Libellé pour le titre du cours
        private System.Windows.Forms.Label NumeroCours;             // Libellé pour le numéro du cours
        private System.Windows.Forms.Label CodeCours;               // Libellé pour le code du cours

        //Panel

        private System.Windows.Forms.Panel panel;                   // Panel pour la mise en page


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnRecordGrade = new System.Windows.Forms.Button();
            this.btnShowGrades = new System.Windows.Forms.Button();
            this.ddlStudents = new System.Windows.Forms.ComboBox();
            this.ddlCourses = new System.Windows.Forms.ComboBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.EtudiantSelectionne = new System.Windows.Forms.Label();
            this.CoursSelectionne = new System.Windows.Forms.Label();
            this.NoteSaisie = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentFirstName = new System.Windows.Forms.TextBox();
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.txtCourseNumber = new System.Windows.Forms.TextBox();
            this.txtCourseCode = new System.Windows.Forms.TextBox();
            this.txtCourseTitle = new System.Windows.Forms.TextBox();
            this.NomEtudiant = new System.Windows.Forms.Label();
            this.PrenomEtudiant = new System.Windows.Forms.Label();
            this.NumeroEtudiant = new System.Windows.Forms.Label();
            this.TitreCours = new System.Windows.Forms.Label();
            this.NumeroCours = new System.Windows.Forms.Label();
            this.CodeCours = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(49, 123);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(120, 23);
            this.btnAddStudent.TabIndex = 0;
            this.btnAddStudent.Text = "Ajouter le étudiant";
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(281, 123);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(120, 23);
            this.btnAddCourse.TabIndex = 1;
            this.btnAddCourse.Text = "Ajouter le cours";
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnRecordGrade
            // 
            this.btnRecordGrade.Location = new System.Drawing.Point(164, 415);
            this.btnRecordGrade.Name = "btnRecordGrade";
            this.btnRecordGrade.Size = new System.Drawing.Size(75, 23);
            this.btnRecordGrade.TabIndex = 2;
            this.btnRecordGrade.Text = "Enregistrer la note";
            this.btnRecordGrade.Click += new System.EventHandler(this.btnRecordGrade_Click);
            // 
            // btnShowGrades
            // 
            this.btnShowGrades.Location = new System.Drawing.Point(343, 257);
            this.btnShowGrades.Name = "btnShowGrades";
            this.btnShowGrades.Size = new System.Drawing.Size(114, 23);
            this.btnShowGrades.TabIndex = 3;
            this.btnShowGrades.Text = "Afficher les notes";
            this.btnShowGrades.Click += new System.EventHandler(this.btnShowGrades_Click);
            // 
            // ddlStudents
            // 
            this.ddlStudents.Location = new System.Drawing.Point(203, 258);
            this.ddlStudents.Name = "ddlStudents";
            this.ddlStudents.Size = new System.Drawing.Size(121, 21);
            this.ddlStudents.TabIndex = 4;
            this.ddlStudents.SelectedIndexChanged += new System.EventHandler(this.ddlStudents_SelectedIndexChanged);
            // 
            // ddlCourses
            // 
            this.ddlCourses.Location = new System.Drawing.Point(199, 326);
            this.ddlCourses.Name = "ddlCourses";
            this.ddlCourses.Size = new System.Drawing.Size(121, 21);
            this.ddlCourses.TabIndex = 5;
            this.ddlCourses.SelectedIndexChanged += new System.EventHandler(this.ddlCourses_SelectedIndexChanged);
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(199, 363);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(40, 20);
            this.txtScore.TabIndex = 6;
            // 
            // EtudiantSelectionne
            // 
            this.EtudiantSelectionne.Location = new System.Drawing.Point(86, 260);
            this.EtudiantSelectionne.Name = "EtudiantSelectionne";
            this.EtudiantSelectionne.Size = new System.Drawing.Size(111, 23);
            this.EtudiantSelectionne.TabIndex = 7;
            this.EtudiantSelectionne.Text = "Étudiant sélectionné : ";
            // 
            // CoursSelectionne
            // 
            this.CoursSelectionne.Location = new System.Drawing.Point(93, 329);
            this.CoursSelectionne.Name = "CoursSelectionne";
            this.CoursSelectionne.Size = new System.Drawing.Size(100, 23);
            this.CoursSelectionne.TabIndex = 8;
            this.CoursSelectionne.Text = "Cours sélectionné : ";
            // 
            // NoteSaisie
            // 
            this.NoteSaisie.Location = new System.Drawing.Point(93, 363);
            this.NoteSaisie.Name = "NoteSaisie";
            this.NoteSaisie.Size = new System.Drawing.Size(100, 23);
            this.NoteSaisie.TabIndex = 9;
            this.NoteSaisie.Text = "Saisir la note : ";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(113, 20);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(100, 20);
            this.txtStudentName.TabIndex = 10;
            // 
            // txtStudentFirstName
            // 
            this.txtStudentFirstName.Location = new System.Drawing.Point(113, 51);
            this.txtStudentFirstName.Name = "txtStudentFirstName";
            this.txtStudentFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtStudentFirstName.TabIndex = 11;
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Location = new System.Drawing.Point(113, 81);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(100, 20);
            this.txtStudentNumber.TabIndex = 12;
            // 
            // txtCourseNumber
            // 
            this.txtCourseNumber.Location = new System.Drawing.Point(343, 20);
            this.txtCourseNumber.Name = "txtCourseNumber";
            this.txtCourseNumber.Size = new System.Drawing.Size(100, 20);
            this.txtCourseNumber.TabIndex = 13;
            // 
            // txtCourseCode
            // 
            this.txtCourseCode.Location = new System.Drawing.Point(343, 53);
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.Size = new System.Drawing.Size(100, 20);
            this.txtCourseCode.TabIndex = 14;
            // 
            // txtCourseTitle
            // 
            this.txtCourseTitle.Location = new System.Drawing.Point(343, 84);
            this.txtCourseTitle.Name = "txtCourseTitle";
            this.txtCourseTitle.Size = new System.Drawing.Size(100, 20);
            this.txtCourseTitle.TabIndex = 15;
            // 
            // NomEtudiant
            // 
            this.NomEtudiant.AutoSize = true;
            this.NomEtudiant.Location = new System.Drawing.Point(0, 23);
            this.NomEtudiant.Name = "NomEtudiant";
            this.NomEtudiant.Size = new System.Drawing.Size(96, 13);
            this.NomEtudiant.TabIndex = 16;
            this.NomEtudiant.Text = "Nom de l\'Etudiant :";
            // 
            // PrenomEtudiant
            // 
            this.PrenomEtudiant.AutoSize = true;
            this.PrenomEtudiant.Location = new System.Drawing.Point(0, 54);
            this.PrenomEtudiant.Name = "PrenomEtudiant";
            this.PrenomEtudiant.Size = new System.Drawing.Size(110, 13);
            this.PrenomEtudiant.TabIndex = 17;
            this.PrenomEtudiant.Text = "Prenom de l\'Etudiant :";
            // 
            // NumeroEtudiant
            // 
            this.NumeroEtudiant.AutoSize = true;
            this.NumeroEtudiant.Location = new System.Drawing.Point(0, 84);
            this.NumeroEtudiant.Name = "NumeroEtudiant";
            this.NumeroEtudiant.Size = new System.Drawing.Size(111, 13);
            this.NumeroEtudiant.TabIndex = 18;
            this.NumeroEtudiant.Text = "Numero de l\'Etudiant :";
            // 
            // TitreCours
            // 
            this.TitreCours.AutoSize = true;
            this.TitreCours.Location = new System.Drawing.Point(242, 87);
            this.TitreCours.Name = "TitreCours";
            this.TitreCours.Size = new System.Drawing.Size(79, 13);
            this.TitreCours.TabIndex = 19;
            this.TitreCours.Text = "Titre du Cours :";
            // 
            // NumeroCours
            // 
            this.NumeroCours.AutoSize = true;
            this.NumeroCours.Location = new System.Drawing.Point(242, 23);
            this.NumeroCours.Name = "NumeroCours";
            this.NumeroCours.Size = new System.Drawing.Size(95, 13);
            this.NumeroCours.TabIndex = 20;
            this.NumeroCours.Text = "Numero du Cours :";
            // 
            // CodeCours
            // 
            this.CodeCours.AutoSize = true;
            this.CodeCours.Location = new System.Drawing.Point(242, 56);
            this.CodeCours.Name = "CodeCours";
            this.CodeCours.Size = new System.Drawing.Size(83, 13);
            this.CodeCours.TabIndex = 21;
            this.CodeCours.Text = "Code du Cours :";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.LightGray;
            this.panel.Location = new System.Drawing.Point(3, 193);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(796, 10);
            this.panel.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.CodeCours);
            this.Controls.Add(this.NumeroCours);
            this.Controls.Add(this.TitreCours);
            this.Controls.Add(this.NumeroEtudiant);
            this.Controls.Add(this.PrenomEtudiant);
            this.Controls.Add(this.NomEtudiant);
            this.Controls.Add(this.txtCourseTitle);
            this.Controls.Add(this.txtCourseCode);
            this.Controls.Add(this.txtCourseNumber);
            this.Controls.Add(this.txtStudentNumber);
            this.Controls.Add(this.txtStudentFirstName);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.btnRecordGrade);
            this.Controls.Add(this.btnShowGrades);
            this.Controls.Add(this.ddlStudents);
            this.Controls.Add(this.ddlCourses);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.EtudiantSelectionne);
            this.Controls.Add(this.CoursSelectionne);
            this.Controls.Add(this.NoteSaisie);
            this.Name = "Form1";
            this.Text = "Gestion des Notes des Étudiants";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       
    }

}
