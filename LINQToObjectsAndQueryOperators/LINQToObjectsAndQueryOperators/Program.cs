namespace LINQToObjectsAndQueryOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UniversityManager um = new UniversityManager();
            um.MaleStudents();
            um.FemaleStudents();
            um.SortStudentByAge();
            um.AllStudentsFromRangsit();
            um.AllStudentsFromChula();
            um.AllStudentsFromMahidol();
            um.AllStudentsFromPSU();

            int[] someInts = { 30, 12, 4, 3, 12 };
            IEnumerable<int> sortedInts = from i in someInts 
                                          orderby i 
                                          select i;
            IEnumerable<int> reversedInts = sortedInts.Reverse();

            foreach (int i in reversedInts) {
                Console.WriteLine(i);
            }
            um.StudentAndUniversityNameCollection();

            /*
            string input = Console.ReadLine();
           
            try
            {
                int inputAsInt = Convert.ToInt32(input);
                um.AllStudentsFromThatUni(inputAsInt);
            }
            catch (Exception)
            {

                Console.WriteLine("Wrong value");
            }
            */
            Console.ReadKey();
        }
    }
    class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;
        
        //constructor
        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            //lets add some universities
            universities.Add(new University { Id = 1, Name = "Prince of Songkhla" });
            universities.Add(new University { Id = 2, Name = "Chulalongkorn" });
            universities.Add(new University { Id = 3, Name = "Rangsit" });
            universities.Add(new University { Id = 4, Name = "Mahidol" });
            //lets add some students
            students.Add(new Student { Id = 1, Name = "Anna", Gender = "female",Age = 17, UniversityId = 1 });
            students.Add(new Student { Id = 2, Name = "Jeff", Gender = "male", Age = 18, UniversityId = 3 });
            students.Add(new Student { Id = 3, Name = "Jah", Gender = "female", Age = 20, UniversityId = 2 });
            students.Add(new Student { Id = 4, Name = "Jib", Gender = "male", Age = 21, UniversityId = 4 });
            students.Add(new Student { Id = 5, Name = "Jack", Gender = "female", Age = 15, UniversityId = 1 });
        }
        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students
                                                where student.Gender == "male"
                                                select student;
            Console.WriteLine("Male - Students: ");
            foreach(Student student in maleStudents)
            {
                student.Print();
            }
        }
        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudent = from student in students
                                                 where student.Gender == "female"
                                                 select student;
            Console.WriteLine("Female - Students: ");
            foreach(Student student in femaleStudent)
            {
                student.Print();
            }
        }
        public void SortStudentByAge()
        {
            var sortedStudents = from student in students
                                 orderby student.Age descending
                                 select student;
            Console.WriteLine("Students sorted by Age: ");
            foreach (Student student in sortedStudents)
            {
                student.Print();
            }
        }
        public void AllStudentsFromRangsit()
        {
            IEnumerable<Student> rsuStudents = from student in students
                                               join university in universities on student.UniversityId equals university.Id
                                               where university.Name == "Rangsit"
                                               select student;
            Console.WriteLine("Students from Rangsit University: ");
            foreach(Student student in rsuStudents)
            {
                student.Print();
            }
        }
        public void AllStudentsFromMahidol()
        {
            IEnumerable<Student> mhdStudents = from student in students
                                               join university in universities on student.UniversityId equals university.Id
                                               where university.Name == "Mahidol"
                                               select student;
            Console.WriteLine("Students from Mahidol University: ");
            foreach (Student student in mhdStudents)
            {
                student.Print();
            }
        }

        public void AllStudentsFromChula()
        {
            IEnumerable<Student> chulaStudents = from student in students
                                               join university in universities on student.UniversityId equals university.Id
                                                 where university.Name == "Chulalongkorn"
                                                 select student;
            Console.WriteLine("Students from Chulalongkorn University: ");
            foreach (Student student in chulaStudents)
            {
                student.Print();
            }
        }
        public void AllStudentsFromPSU()
        {
            IEnumerable<Student> psuStudents = from student in students
                                                 join university in universities on student.UniversityId equals university.Id
                                                 where university.Name == "Prince of Songkhla"
                                               select student;
            Console.WriteLine("Students from Prince of Songkhla University: ");
            foreach (Student student in psuStudents)
            {
                student.Print();
            }
        }
        public void AllStudentsFromThatUni(int Id)
        {
            IEnumerable<Student> myStudents = from student in students
                                               join university in universities on student.UniversityId equals university.Id
                                               where university.Id == Id
                                               select student;
            Console.WriteLine("Students from that uni {0} ", Id);
            foreach (Student student in myStudents)
            {
                student.Print();
            }
        }

        public void StudentAndUniversityNameCollection()
        {
            var newCollection = from student in students
                                join university in universities on student.UniversityId equals university.Id
                                orderby student.Name
                                select new { StudentName = student.Name, UniversityName = university.Name };

            Console.WriteLine("New Collection: ");
            foreach ( var col in newCollection)
            {
                Console.WriteLine("Student {0} from Universoty {1}", col.StudentName,col.UniversityName);
            }
        }



    }
    class University
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public void Pirnt()
        {
            Console.WriteLine("University {0} with Id {1}",Name,Id);
        }
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        
        // Foreign Key
        public int UniversityId { get; set; }
        public void Print()
        {
            Console.WriteLine("Student {0} with Id {1}, Gender {2} "+
                                "and Age {3} from University with Id {4}"
                                , Name , Id, Gender, Age, UniversityId);
        }
    }
}
