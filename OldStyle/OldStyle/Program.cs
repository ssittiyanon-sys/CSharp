/*
 * namespace OldStyle
{
    internal class Program
    {
        //Creating "field" which mean variable that
        //can also call in everysingle method in class
        //sometimes even called Global variables
        //need static to be Global so every method can use
        static int myResult;
        static int myResult1;
        static void Main(string[] args) //Main is the starting point of the code
        {

            Console.WriteLine("Enter first number.");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number.");
            int num2 = int.Parse(Console.ReadLine());

            myResult = AddTwoValues(num1, num2);
            Console.WriteLine($"The sum result is : {myResult}");
            
            //If dont have any "static" keyword
            Program program = new Program();
            myResult1 = program.SubtractTwoValues(num1, num2);
            Console.WriteLine($"The subtract result is : {myResult1}");

            //If we have "static" keyword
            myResult = MultiplyTwoValues(num1, num2);
            Console.WriteLine($"The multiply result is : {myResult}");
            Console.ReadKey();
        }

        //Moving Method outside of Main method

        // #1 With "static" keyword
        static int AddTwoValues(int value1, int value2)
        {
            myResult = value1 + value2;
            // จะเอา result ออกมา ก็ต้องใช้ return
            return myResult;
        }
        static int MultiplyTwoValues(int num1, int num2)
        {
            myResult = num1 * num2;
            return myResult;
        }

        // #2 Without "static" keyword
        int SubtractTwoValues(int value1, int value2)
        {
            myResult1 = value1 - value2;
            return myResult1;
        }


    }
}
*/
// Even Global class variable seems convenient because anyone can use them,
// world-class adventurer guilds rarely use them!
// The reason is: If the castle gets bigger and
// hundreds of people are working at the same time,
// if everyone tries to use the exact same myResult basket in the middle of the castle...
// people will definitely overwrite each other's items and cause a disaster!
// (This is called a State Mutation bug).

using System;

namespace ProStyle
{
    internal class Program
    {
        // ❌ สังเกตว่าเราลบ Global Variable ทิ้งไปหมดเลย! ปราสาทสะอาดกริ๊บ!

        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number.");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number.");
            int num2 = int.Parse(Console.ReadLine());

            // ✅ 1. สร้างกล่องส่วนตัวชื่อ sum ขึ้นมา "ณ วินาทีที่ต้องใช้" เลย
            int sum = AddTwoValues(num1, num2);
            Console.WriteLine($"The sum result is : {sum}");

            // ✅ 2. สร้างออบเจกต์เพื่อเรียกฟังก์ชันที่ไม่ใช่ static
            Program program = new Program();
            int diff = program.SubtractTwoValues(num1, num2); // สร้างกล่อง diff มารับค่า
            Console.WriteLine($"The subtract result is : {diff}");

            // ✅ 3. สร้างกล่องส่วนตัวชื่อ product มารับค่า
            int product = MultiplyTwoValues(num1, num2);
            Console.WriteLine($"The multiply result is : {product}");

            Console.ReadKey();
        }

        // --- สกิลต่างๆ จะเอาค่ามาบวกกัน แล้ว "โยน (return)" ค่าที่คำนวณเสร็จกลับไปให้ทันที ---

        static int AddTwoValues(int value1, int value2)
        {
            // ทำงานจบในบรรทัดเดียว ไม่ต้องพึ่งกล่องข้างนอก!
            return value1 + value2;
        }

        static int MultiplyTwoValues(int num1, int num2)
        {
            return num1 * num2;
        }

        int SubtractTwoValues(int value1, int value2)
        {
            return value1 - value2;
        }
    }
}