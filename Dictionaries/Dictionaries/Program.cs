namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this is Original Dictionary");
            // Key - value
            // Declaring and initializing a Dictionary Adding Items (1)
            Dictionary<int, string> employees = new Dictionary<int, string>();
            employees.Add(101,"John Doe");
            employees.Add(102, "Bob Smith");
            employees.Add(103, "Rob Smith");
            employees.Add(104, "Flob Smith");
            employees.Add(105, "Doby Smith");

            foreach (KeyValuePair<int, string> employee in employees)
            {
                Console.WriteLine($"ID: {employee.Key}, Name: {employee.Value}");
            }



            // Declaring and initializing a Dictionary Adding Items (2)
            // 🌟 ปีกกาซ้อนปีกกา (คลีนและสั้นกระชับ)
            Dictionary<int, string> employees2 = new Dictionary<int, string>()
            {
                { 101, "John Doe" },
                { 102, "Bob Smith" },
                { 103, "Alice Cooper" }
            };



            // Declaring and initializing a Dictionary Adding Items (3)
            Dictionary<int, string> employees3 = new Dictionary<int, string>();

            // 🌟 ยัดข้อมูลผ่าน Indexer []
            employees[101] = "John Doe";
            employees[102] = "Bob Smith";

            // Access the dictionary
            string name = employees[101];
            Console.WriteLine(name);




            // Updating,Removing entries and Iterating throgh Dictionary
            Console.WriteLine("\nUpdating data 102:");


            // Update data in a Dictionary
            employees[102] = "Jane Smith";

            foreach (KeyValuePair<int, string> employee in employees)
            {
                Console.WriteLine($"ID: {employee.Key}, Name: {employee.Value}");
            }



            // Remove an item from a dictionary
            Console.WriteLine("\nRemoving data 101:");
            employees.Remove(101);
            


            // Iterating over a dictionary
            foreach(KeyValuePair<int, string> employee in employees)
            {
                Console.WriteLine($"ID: {employee.Key}, Name: {employee.Value}");
            }



            //Gracfully Adding and Updating Dictionaries

            Console.WriteLine("\nCheck if data 101 exist will Update but if not will add data:");
            if (!employees.ContainsKey(101))
            {
                employees.Add(101, "Mike Jike");
            }
            else if(employees.ContainsKey(104))
            {
                employees[101] = "Mike Jike";
            }

            foreach (KeyValuePair<int, string> employee in employees)
            {
                Console.WriteLine($"ID: {employee.Key}, Name: {employee.Value}");
            }


            Console.WriteLine("\nDeclaing and initailizing a Dictionary of employee using class EmployeeClass");
            //Declaing and initailizing a Dictionary of employee using class EmployeeClass (1)
            Dictionary<int, EmployeeClass> employees4 = new Dictionary<int, EmployeeClass>()
            {
                {1, new EmployeeClass("Karra",35,100000) },
                {2, new EmployeeClass("John Doe",34,166000) },
                {3, new EmployeeClass("Suppakorn Sittiyanon",33,5000) }

            };



            //Declaing and initailizing a Dictionary of employee using class EmployeeClass (2)
            Dictionary<int, EmployeeClass> employees5 = new Dictionary<int, EmployeeClass>();
            employees5.Add(1, new EmployeeClass("Karra", 35, 100000));
            employees5.Add(2, new EmployeeClass("John", 34, 166000));
            employees5.Add(3, new EmployeeClass("Suppakorn", 33, 5000));



            //Declaing and initailizing a Dictionary of employee using class EmployeeClass (3)
            Dictionary<int, EmployeeClass> employees6 = new Dictionary<int, EmployeeClass>()
            {
                [1] = new("Karra", 35, 100000),
                [2] = new("John Doe", 34, 166000),
                [3] = new("Suppakorn Sittiyanon", 33, 5000)
            };

            foreach(var item in employees4)
            {
                Console.WriteLine($"ID: {item.Key} Name: {item.Value.Name} Age: {item.Value.Age} Salary: {item.Value.Salary} ");
            }

            //Another way to declare and initalize dicts plus string as key
            Console.WriteLine("\nAnother way to declare and initalize dicts plus string as key\nwhen you need to display use .TryGetValue");
            // btw you can declare dictionary this way
            var codes = new Dictionary<string, string>
            {
                ["NY"] = "New York",
                ["CA"] = "California",
                ["TX"] = "Texas"

            };

            if(codes.TryGetValue("NY", out string state)){
                Console.WriteLine(state);
            }
            foreach (var item in codes)
            {
                Console.WriteLine($"The statecode is {item.Key} and the state name is {item.Value}");
            }

            Console.ReadKey();
        }
    }
    class EmployeeClass
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int Salary { get; set; }
        public EmployeeClass(string name, int age, int salary) 
        {
            Name = name;
            Age = age;
            Salary = salary;
        }

    }
}
