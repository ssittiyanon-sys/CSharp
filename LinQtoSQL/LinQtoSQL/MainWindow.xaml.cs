using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;

namespace LinQtoSQL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LinqToSqlDataClassesDataContext dataContext;
        public MainWindow()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["LinQtoSQL.Properties.Settings.JeffDBConnectionString"].ConnectionString;
            dataContext = new LinqToSqlDataClassesDataContext(connectionString);

            //InsertUniversityies();
            //InsertStudent();
            //InsertLectures();
            //InsertStudentLectureAssociations();
            //GetUniversityOfJeffrey();
            //GetLectureOfJeffrey();
            //GetAllStudentsFromChula();
            //GetAllUniversitiesWithTransgenders();
            //GetAllLectureFromChula();
            //UpdateJeffrey();
            //RemoveElectra();
        }
        public void InsertUniversityies()
        {
            dataContext.ExecuteCommand("delete from University");

            University mahidol = new University();
            mahidol.Name = "Mahidol";
            dataContext.Universities.InsertOnSubmit(mahidol);

            University chula = new University();
            chula.Name = "Chulalongkorn";
            dataContext.Universities.InsertOnSubmit(chula);

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Universities;

        }
        public void InsertStudent()
        {
            dataContext.ExecuteCommand("delete from Student");
            University mahidol = dataContext.Universities.First(un => un.Name.Equals("mahidol"));
            //มาจาก IEnumerable
            /*'
            from university in dataContext.University
            where universoty == "Mahidol"
            select university;
            */
            University chula = dataContext.Universities.First(un => un.Name.Equals("Chulalongkorn"));
            //มาจาก IEnumerable
            /*'
            from university in dataContext.University
            where universoty == "Chulalongkorn"
            select university;
            */

            List<Student> students = new List<Student>();
            students.Add(new Student { Name = "Jeffrey", Gender = "male", UniversityID = mahidol.Id });
            students.Add(new Student { Name = "Annaniya", Gender = "female", University = chula });
            students.Add(new Student { Name = "SSamol", Gender = "male", UniversityID = mahidol.Id });
            students.Add(new Student { Name = "Electra", Gender = "trans-gender", University = chula });
            students.Add(new Student { Name = "Kafka", Gender = "male", UniversityID = mahidol.Id });

            dataContext.Students.InsertAllOnSubmit(students);
            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.Students;

        }
        public void InsertLectures()
        {
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "Math" });
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "Art" });
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "History" });

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Lectures;
        }
        public void InsertStudentLectureAssociations()
        {
            Student Jeffrey = dataContext.Students.First(st => st.Name.Equals("Jeffrey"));
            Student Annaniya = dataContext.Students.First(st => st.Name.Equals("Annaniya"));
            Student SSamol = dataContext.Students.First(st => st.Name.Equals("SSamol"));
            Student Electra = dataContext.Students.First(st => st.Name.Equals("Electra"));
            Student Kafka = dataContext.Students.First(st => st.Name.Equals("Kafka"));

            Lecture Math = dataContext.Lectures.First(lc => lc.Name.Equals("Math"));
            Lecture Art = dataContext.Lectures.First(lc => lc.Name.Equals("Art"));
            Lecture History = dataContext.Lectures.First(lc => lc.Name.Equals("History"));

            dataContext.StudenLectures.InsertOnSubmit(new StudenLecture { Student = Jeffrey, Lecture = Art });
            dataContext.StudenLectures.InsertOnSubmit(new StudenLecture { Student = Annaniya, Lecture = Math });
            dataContext.StudenLectures.InsertOnSubmit(new StudenLecture { Student = SSamol, Lecture = Math });
            dataContext.StudenLectures.InsertOnSubmit(new StudenLecture { Student = Electra, Lecture = Art });
            dataContext.StudenLectures.InsertOnSubmit(new StudenLecture { Student = Kafka, Lecture = History });


            StudenLecture slJeffrey = new StudenLecture();
            slJeffrey.Student = Jeffrey;
            slJeffrey.LectureId = History.Id;
            dataContext.StudenLectures.InsertOnSubmit(slJeffrey);

            dataContext.StudenLectures.InsertOnSubmit(new StudenLecture { Student = Kafka, Lecture = Math });

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.StudenLectures;

        }
        public void GetUniversityOfJeffrey()
        {
            Student Jeffrey = dataContext.Students.First(st => st.Name.Equals("Jeffrey"));

            University JeffreyUniversity = Jeffrey.University;

            List<University> universities = new List<University>();
            universities.Add(JeffreyUniversity);

            MainDataGrid.ItemsSource = universities;
        }
        public void GetLectureOfJeffrey()
        {
            Student Jeffrey = dataContext.Students.First(st => st.Name.Equals("Jeffrey"));

            var JeffreyLecture = from sl in Jeffrey.StudenLectures select sl.Lecture;

            MainDataGrid.ItemsSource = JeffreyLecture;

        }
        public void GetAllStudentsFromChula()
        {
            var studentsFromChula = from student in dataContext.Students
                                    where student.University.Name == "Chulalongkorn"
                                    select student;
            MainDataGrid.ItemsSource = studentsFromChula;
        }
        public void GetAllUniversitiesWithTransgenders()
        {
            var studensTransgender = from student in dataContext.Students
                                     join university in dataContext.Universities
                                     on student.University equals university
                                     where student.Gender == "trans-gender"
                                     select university;
            MainDataGrid.ItemsSource = studensTransgender;
        }
        public void GetAllLectureFromChula()
        {
            var lectureFromChula = from sl in dataContext.StudenLectures
                                   join student in dataContext.Students
                                   on sl.StudentId equals student.Id
                                   where student.University.Name == "Chulalongkorn"
                                   select sl.Lecture;
            MainDataGrid.ItemsSource = lectureFromChula;
        }
        public void UpdateJeffrey()
        {
            Student Jeffrey = dataContext.Students.FirstOrDefault(st => st.Name == "Jeffrey");

            Jeffrey.Name = "Jefferson";

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;
        }
        public void RemoveElectra()
        {
            Student Electra = dataContext.Students.FirstOrDefault(st => st.Name == "Electra");
            dataContext.Students.DeleteOnSubmit(Electra);
            dataContext.SubmitChanges();


            MainDataGrid.ItemsSource = dataContext.Students;
        }
    }
}
