namespace InheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee joe = new Employee("Joe", 36,"Main Street 1", "Software Engineer", 001, 15000);
            joe.DisplayEmployeeInfo();

            Manager carl = new Manager("Carl", 22,"Sub Street 2", "Manager", 000, 17000, 7);
            carl.DisplayManagerInfo();
            //Console.WriteLine(carl.ToString());
            carl.BecomeOlder(5);
            carl.DisplayPersonInfo();

            Exercise.PrintMessages(); // ใช้แบบมี static
            Exercise myEx = new Exercise();
            myEx.PrintMessagesWithoutStatic(); // ใช้แบบไม่มี static แต่สร้าง obj แทน
            Console.ReadKey();
        }
    }
    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Address { get; private set; }
        public Person(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Console.WriteLine("\n\nPerson (base class) constructer called");
            Address = address;
        }

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Address: {Address} ");

        }

        // XML Comments Documentation //
        /// <summary>Make our object older!</summary>
        /// <param name="years">The parameter that indicates the amount of years the object should age</param>
        /// <returns>Returns the new age after aging/becoming older</returns>
        public int BecomeOlder(int years)
        {
            Age = Age + years;
            return Age;
        }

    }

    public class Employee : Person
    {
        public string JobTitle { get; private set; }
        public int EmployeeID { get; private set; }
        public int Salary { get; private set; }
        public Employee(string name, int age,string address, string jobTitle, int employeeID, int salary) : base(name, age, address)
        {
            Console.WriteLine("Employee (derived class) constructor called");
            JobTitle = jobTitle;
            EmployeeID = employeeID;
            Salary = salary;
        }
        public void DisplayEmployeeInfo()
            {
                DisplayPersonInfo();
                Console.Write($"Job Title: {JobTitle}, ID: {EmployeeID}, Salary: {Salary} ");
            }
    }
    public class Manager : Employee
    {
        public int TeamSize {  get; private set; }

        public Manager(string name, int age,string address, string jobTitle, int employeeID, int salary, int teamsize) : base(name, age, address, jobTitle, employeeID, salary)
        {
            TeamSize = teamsize;
        }
        public void DisplayManagerInfo()
        {
            DisplayEmployeeInfo();
            Console.WriteLine($"Team size: {TeamSize}");
        }
    }
    public class Person2
    {
        public string Name { get; private set; }

        // 🌟 ใส่ Console.WriteLine ไว้ใน Constructor เลย
        public Person2(string name)
        {
            Name = name;
            Console.WriteLine($"\nPerson2 constructor: {Name}");
        }
    }

    public class Employee2 : Person2
    {
        public int Id { get; private set; }

        // 🌟 รับค่า ส่งต่อให้แม่ด้วย base(name) และปริ้นท์ข้อความตัวเอง
        public Employee2(string name, int id) : base(name)
        {
            Id = id;
            Console.WriteLine($"Employee2 constructor: {Name}, ID: {Id}");
        }
    }

    public class Exercise
    {
        public static void PrintMessages() // ต้องมี static ถึงจะนำไปใช้ใน class อื่้น ไม่งั้นจะต้องสร้างเป็น obj ในคลาสอื่น
        {
            // 🌟 สร้าง Employee แค่บรรทัดเดียว ข้อความจะเด้งออกมา 2 บรรทัดอัตโนมัติ!
            Employee2 john = new Employee2("Helen Karma", 123);
        }
        public void PrintMessagesWithoutStatic() // ใช้แบบไม่มี static แต่สร้าง obj แทน
        {
            Employee2 john = new Employee2("Jane Dimmo", 124);
        }
    }
}