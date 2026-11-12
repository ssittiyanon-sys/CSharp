using System.Xml.Linq;

namespace LinqWithXML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentsXML =
                    @"<Students>
                        <Student>
                            <Name>Toni</Name>
                            <Age>21</Age>
                            <University>Yale</University>
                            <Semester>2</Semester>
                        </Student>
                        <Student>
                            <Name>Juan</Name>
                            <Age>22</Age>
                            <University>Havard</University>
                            <Semester>3</Semester>
                        </Student>
                        <Student>
                            <Name>Aris</Name>
                            <Age>20</Age>
                            <University>Beijing</University>
                            <Semester>1</Semester>
                        </Student>
                        <Student>
                            <Name>Byalan</Name>
                            <Age>19</Age>
                            <University>Chula</University>
                            <Semester>0</Semester>
                        <Student>
                            <Name>Anna</Name>
                            <Age>23</Age>
                            <University>Rangsit</University>
                            <Semester>4</Semester>
                        </Student>
                        </Student>
                     </Students>";
            XDocument studentsXdoc = new XDocument();
            studentsXdoc = XDocument.Parse(studentsXML);

            var students = from student in studentsXdoc.Descendants("Student")
                           select new
                           {
                               Name = student.Element("Name").Value,
                               Age = student.Element("Age").Value,
                               University = student.Element("University").Value,
                               Semester = student.Element("Semester").Value
                           };
            foreach (var student in students)
            {
                Console.WriteLine("Student {0} with age {1} from University {2} is in his/her {3} Semester",student.Name, student.Age, student.University, student.Semester);
            }

            Console.WriteLine("Sorted Students by Age: ");

            var sortedStudents = from student in students
                                 orderby student.Age
                                 select student;

            foreach (var student in sortedStudents)
            {
                Console.WriteLine("Student {0} with age {1} from University {2}", student.Name, student.Age, student.University);
            }

            Console.ReadKey();

        }
    }
}
