namespace DelegatesAndEvents
{
    public delegate void LogHandler(string message);
    public class Logger
    {
        public void LogToConsole(string message)
        {
            Console.WriteLine("Console Log: " + message);
        }
        public void LogToFile(string message)
        {
            Console.WriteLine("File Log: " + message);
        }
    }


    // Combining Generics with Delegates to make a sorting algorithm

    public delegate int Comparison<T>(T x, T y);


    //บรรทัดนี้คือการสร้าง "ใบสัญญาผู้พิพากษา" ครับ 
    //มันบอกว่า: "ใครก็ตามที่จะมาทำหน้าที่ตัดสิน ต้องรับของ 2 ชิ้น (x, y) ไปเทียบกัน แล้วคืนค่ากลับมาเป็นตัวเลข (int) นะ"
    //ถ้าคืนค่า บวก(> 0) แปลว่า $x > y$ (x ควรอยู่หลัง y)ถ้าคืนค่า ลบ(< 0) 
    //แปลว่า $x<y$ (x ควรอยู่ก่อน y)ถ้าคืนค่า ศูนย์(0) แปลว่า $x = y$ (เท่ากัน)


    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
    public class PersonSorter
    {
        // เมธอดนี้รับ "อาร์เรย์คน" และรับ "ผู้พิพากษา (comparison)" เข้ามา
        public void Sort(Person[] people, Comparison<Person> comparison)
        {
            // ลูป i และ j คือการจับคู่คนมาเทียบกันทีละคู่
            for (int i = 0; i < people.Length - 1; i++)
            {
                for (int j = i + 1; j < people.Length; j++)
                {
                    // 🌟 จุดไคลแมกซ์: ให้ผู้พิพากษาตัดสินใจ!
                    if (comparison(people[i], people[j]) > 0)
                    {
                        // ถ้าผู้พิพากษาบอกว่าคนที่ i "มากกว่า" คนที่ j (คืนค่า > 0)
                        // แปลว่าผิดลำดับ (เราอยากเรียงน้อยไปมาก) เลยต้อง "สลับที่ (Swap)"
                        Person temp = people[i];
                        people[i] = people[j];
                        people[j] = temp;
                    }
                }
            }
        }
    }

    // Events - Publishers and Subscribers
    public delegate void Notify(string message);
    public class EventPublisher
    {
        // The "On" prefix makes it immediately clear that the method
        // is associated with an event.
        // It signifies that the method is not just a regular method but
        // one that is called when a specific event occurs.
        public event Notify OnNotify;
        public void RaiseEvent(string message)
        {
            OnNotify?.Invoke(message); // Invoke the event if there 
        }
    }
    public class EventSubscriber
    {
        public void OnEventRaised(string message)
        {
            Console.WriteLine("Event received: " + message);
        }
    }

    internal class Program
        {
            static void Main(string[] args)
            {
            Logger logger = new Logger();
            LogHandler logHandler = logger.LogToConsole;
            logHandler("Logging to Console");

            logHandler = logger.LogToFile;
            logHandler("Logging to File");

            Console.WriteLine("\n");
            logHandler = logger.LogToConsole;
            logHandler += logger.LogToFile;
            logHandler("Log this info!");

            Console.WriteLine("\n");
            foreach (LogHandler handler in logHandler.GetInvocationList())
            {
                try
                {
                    handler("Event occured with error handling");

                }
                catch (Exception ex) 
                {
                    Console.WriteLine("Exception caught: "+ ex.Message);
                }

            }

            Console.WriteLine("\n");
            if (IsMethodDelegate(logHandler, logger.LogToFile))
            {
                logHandler -= logger.LogToFile;
                Console.WriteLine("LogToFile method removed");
            }
            else
            {
                Console.WriteLine("LogToFile is not found");
            }
            
            logHandler("After removing Log to File");
            Console.WriteLine("\n");
            //GetInvocationList seeing which methods are in a multicast delegate
            InvokeSafely(logHandler, "InvokeSafely");



            Console.WriteLine("\n");
            int[] intArray = [1, 2, 3, 4, 5];
            string[] stringArray = { "one", "two", "three", "four", "five" };
            PrintArray(intArray);
            PrintArray(stringArray);

            Person[] people =
            {
                new Person { Name = "Alice", Age = 30 },
                new Person { Name = "Bob", Age = 29 },
                new Person { Name = "Charlie", Age = 31 }
            };
            // 2. ตอนใช้งานจริง
            PersonSorter sorter = new PersonSorter();
            Console.WriteLine("\nCompare By Age");
            sorter.Sort(people, CompareByAge);
            foreach (Person person in people)
            {
                Console.WriteLine($"{person.Name},{person.Age}");
            }

            Console.WriteLine("\nCompare By Name");
            sorter.Sort(people, CompareByName);
            foreach (Person person in people)
            {
                Console.WriteLine($"{person.Name},{person.Age}");
            }

            // Events
            Console.WriteLine("\nEvents Notify");
            EventPublisher publisher = new EventPublisher();
            EventSubscriber subscriber = new EventSubscriber();
            publisher.OnNotify += subscriber.OnEventRaised; //OnNotify = Indicate
            publisher.OnNotify += subscriber.OnEventRaised;
            publisher.RaiseEvent("test");

            Console.ReadKey();
            }
       
        // 1. นี่คือสมองที่เราสร้างขึ้นมาทำหน้าที่เป็น "ผู้พิพากษา"
        static int CompareByAge(Person x, Person y)
        {
            // ใช้เมธอด CompareTo ของ C# เพื่อเทียบเลข
            // ถ้าอายุ x (เช่น 30) ไปเทียบกับอายุ y (เช่น 29) มันจะคืนค่า 1 (เป็นบวก)
            return x.Age.CompareTo(y.Age);
        }
        static int CompareByName(Person x,Person y)
        {
            return x.Name.CompareTo(y.Name);
        }
        static bool IsMethodDelegate(LogHandler logHandler,LogHandler method)
        {
            if(logHandler == null)
            {
                return false;
            }
            foreach (var d in logHandler.GetInvocationList())
            {
                if(d == (Delegate)method)
                {
                    return true;
                }
            }
            return false;
        }

        public static void PrintIntArray(int[] array)
            {
                foreach (int item in array)
                {
                    Console.WriteLine(item);
                }
            }
        public static void PrintStringArray(string[] array)
        {
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }
        }

        //a generic Method, that accepts a generic datatype
        public static void PrintArray<T>(T[] array)
        {
            foreach (T item in array)
            {
                Console.WriteLine(item);
            }
        }
        //GetInvocationList seeing which methods are in a multicast delegate
        static void InvokeSafely(LogHandler logHandler , string message)
        {
            LogHandler tempLogHandler = logHandler;
            if (tempLogHandler != null)
            {
                tempLogHandler(message);
            }
        }

    }

}
