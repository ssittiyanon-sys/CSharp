using System.Collections;
using System.Drawing;

namespace ListsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // Declaring a list and initializing
            List<string> colors = new List<string>();
            colors.Add("red");
            colors.Add("blue");
            colors.Add("green");
            colors.Add("red");
            Console.WriteLine("Current colors in the colors list!");
            foreach (string color in colors)
            {
                
                Console.WriteLine(color);
            }
            Console.WriteLine("I gonna remove 'red' out of the list!");
            colors.Remove("red");
            Console.WriteLine("Current colors in the colors list!");
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }
            Console.WriteLine("you will see the 1st occurence of a specific object from list only");
            Console.WriteLine("\nnow am gonna add red again and remove all red in this lists");
            colors.Add("red");
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }
            bool isColorRemovedSuccessful = colors.Remove("red");
            while (isColorRemovedSuccessful) // true until it false
            {
                isColorRemovedSuccessful = colors.Remove("red");
            }
            Console.WriteLine("\n now all red deleted");
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }
            Console.WriteLine("\nnow we gonna Declaring List and initializing in Square Bracket [] ");
            List<string> colors2 =
                [
                    // Adding items to list
                    "purple",
                    "magenta",
                    "brown",
                    "yellow",
                    "cyan"
                ];
            foreach (string color in colors2)
            {
                Console.WriteLine(color);
            }


            // Declaring List Every Style
            // 🦕 ยุคหิน (C# 2.0): ต้อง new ขึ้นมาโบ๋ๆ แล้วสั่ง .Add ทีละบรรทัด (เยิ่นเย้อมาก)
            Console.WriteLine("\nDeclaring Stone-Age style oldWayNumber By using .Add one by one");
            List<int> oldWayNumbers = new List<int>();
            oldWayNumbers.Add(1);
            oldWayNumbers.Add(2);
            foreach (int number in oldWayNumbers)
            {
                Console.WriteLine(number);
            }

            // 🏛️ ยุคคลาสสิก (C# 3.0 ถึง C# 11): ใช้ Collection Initializer (ปีกกาซ้อน)
            Console.WriteLine("\nDeclaring Classing-Age style classingWayNumber \nby using curly bracket(Collection Initializer)");
            List<int> classicWayNumbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
            foreach (int number in classicWayNumbers)
            {
                Console.WriteLine(number);
            }
            // 🚀 ยุคปัจจุบัน (C# 12+): Collection Expressions (วงเล็บเหลี่ยมตัวที่ท่านพิมพ์มา)
            Console.WriteLine("\nDeclaring Modern-Age style newStyleNumber \nby using only squre bracket");
            List<int> newStyleNumbers = [1, 2, 3, 4, 5, 6];

            // How to use Sort() in List<T>
            List<int> listNumbers = new List<int> {10,5,15,3,9,25,18};
            Console.WriteLine("\nnew Unsorted List!");
            foreach(int numbers in listNumbers) {
                Console.WriteLine(numbers);
            }
            
            Console.WriteLine("\nUse Any() to show is there number larger than 20\n");

            bool hasLargeNumber = listNumbers.Any(x => x > 20);
            if (hasLargeNumber)
            {
                Console.WriteLine("There are large numbers in the numbers list");
            }else
            {
                Console.WriteLine("No large numbers in the number list");
            }

            listNumbers.Sort();
            Console.WriteLine("\nSorted List!");
            foreach(int numbers in listNumbers)
            {
                Console.WriteLine(numbers);
            }
            Console.WriteLine("\nYou will see the sort() will arrange descendant from lower to higher number");

            // A lambda expression consists of 2 Parts
            // 1. Parameters
            // 2. Expression or Statement Block

            // Parameters are written on the left side of = >
            // (this symbol is read as "goes to" or "becomes"
            // The expression or action to perform is on the right side.

            // This read as:
            // "Take an input x and turn it into x multiplied by x"
            // x => x * x;

            Console.WriteLine("\nNow we will find number higher than or eqaul 10 using FindAll");
            List<int> higherEqualTen = listNumbers.FindAll(x => x >= 10);

            // Define the Predicate to check (variables in lamda expression)
            Predicate<int> greaterEqualTen = x => x >= 10;
            // นำ greaterEqualTen มาแทน lamda expression
            higherEqualTen = listNumbers.FindAll(greaterEqualTen);
            foreach (int numbers in higherEqualTen)
            {
                Console.WriteLine(numbers);
            }

            Console.WriteLine("\nNow we going to understand lambda");

            /*
            int finalInput = 0;
            bool isNumberValid = false;
            while (!isNumberValid)
            {
                Console.WriteLine("\nEnter number to find Area");
                string rawInput = Console.ReadLine();
                if (int.TryParse(rawInput, out finalInput))
                {
                    isNumberValid = true;
                }
                else
                {
                    Console.WriteLine("number invalid enter number again");
                }

            }
            Console.WriteLine($"the area will be: {Squaring(finalInput)}");
            */
            Console.WriteLine("\nFrom now on I will use Class product to show lists of products");
            List<Product> products = new List<Product>
            {
                new Product {Name = "Banana", Price = 0.70 },
                new Product {Name = "Apple", Price = 0.30 },
                new Product {Name = "Cherry", Price = 3.80 }
            };
            products.Add(new Product { Name = "Berries", Price = 1.30 });

            Console.WriteLine("\nAvailable Products");
            foreach (Product product in products) 
            {
                Console.WriteLine($"Product Name: {product.Name} Price: {product.Price}");
            }
            Console.WriteLine("\nCheap Products");
            List<Product> cheapProducts = products.Where(p => p.Price < 1.0).ToList();
            foreach (Product product in cheapProducts)
            {
                Console.WriteLine($"Product Name: {product.Name} Price: {product.Price}");
            }

            // #### Array List (Old Style and still exist ####
            Console.WriteLine("\nArray List is an Old Style (Legacy)");
            // Declaring an ArrayList ### Undefine amount of object
            ArrayList myArrayList = new ArrayList();
            // Declaring an ArrayList ### Define amount of object -> Contain 100 object
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(13.37);
            myArrayList.Add(13);
            myArrayList.Add(128);
            myArrayList.Add(25.3);
            myArrayList.Add(13);

            // delete element with specific value from the arraylist
            myArrayList.Remove(13);

            // delete element at specific position
            myArrayList.RemoveAt(0);

            Console.WriteLine(myArrayList.Count);

            double sum = 0;
            foreach ( object obj in myArrayList)
            {
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if ( obj is double)
                {
                    sum += (double)obj;
                }
                else if ( obj is string) 
                {
                    Console.WriteLine(obj);
                }
            }
            Console.WriteLine(sum);

            // Legacy Hashtables
            // Key - Value
            // Auto - Car
            Console.WriteLine("\nLegacy Hashyables Oldstyle like 20years ago");
            
            Hashtable studentsTable = new Hashtable();


            Student stud1 = new Student(1, "Jason", 98);
            Student stud2 = new Student(2, "Maria", 95);
            Student stud3 = new Student(3, "Clara", 43);
            Student stud4 = new Student(4, "Steve", 55);

            studentsTable.Add(stud1.Id, stud1);
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);
            studentsTable.Add(stud4.Id, stud4);

            // retrive individual item with known ID
            Student storeStudents1 = (Student)studentsTable[stud1.Id];

            // retrive all values from a Hashtable
            foreach (DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine("Student ID: {0}",temp.Id);
                Console.WriteLine("Studen Name: {0}",temp.Name);
                Console.WriteLine("Student GPA: {0}",temp.GPA);
            }
            foreach (Student value in studentsTable.Values)
            {
                Console.WriteLine("Student ID: {0}", value.Id);
                Console.WriteLine("Studen Name: {0}", value.Name);
                Console.WriteLine("Student GPA: {0}", value.GPA);
            }
            Console.WriteLine("Student Id:{0}, Name:{1}, GPA:{2}",storeStudents1.Id, storeStudents1.Name, storeStudents1.GPA);


            Console.WriteLine("\nNullables in C Sharp I declare int? age = null");

            // ใส่ ? หลัง variable type จะกลายเป็น int? is a nullable int
            int? age = null;
            int myAge = 33;
            if (age.HasValue)
            {
                Console.WriteLine("Age is: " + age.Value);
                int sumAge = age.Value + myAge; //.Value จะ
            }
            else
            {
                Console.WriteLine("Age is not specified");
            }

            Console.ReadKey();
        }
        static int Squaring(int num1)
        {
            return num1 * num1;
        }
        // แบบใช้ lamda expression สายย่อ
        static int Squaring2(int num1) => num1 * num1;

    }
    class Student // actually need to create new Class.cs but this is more simple
    {
        //property called ID
        public int Id { get; set; }
        //property called Name
        public string Name { get; set; }
        //property called GPA
        public float GPA { get; set; }
        //simple constuctor
        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
    }
}
