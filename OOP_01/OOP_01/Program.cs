using System.Data;
using System.Threading.Channels;

namespace OOP_01
{
    internal class Program
    {
        /*
         แนวคิดการเขียนโปรแกรมเชิงวัตถุ (Object-Oriented Programming - OOP)
        C# เป็นภาษาที่ออกแบบมาเพื่อการเขียนโปรแกรมแบบ OOP อย่างแท้จริง แนวคิดนี้คือการพยายามเปลี่ยนปัญหาในโค้ดให้สอดคล้องกับ "สิ่งของ" 
        ในโลกความเป็นจริง โดยมี 2 คำศัพท์หลักที่ต้องจำให้แม่นคือ:
        คลาส (Class): เปรียบเสมือน "พิมพ์เขียว" (Blueprint) 
        หรือแม่แบบของข้อมูลที่เราสร้างขึ้นมาเอง เพื่อกำหนดว่าสิ่งๆ หนึ่งควรประกอบด้วยข้อมูลอะไร 
        และทำงานอะไรได้บ้าง เช่น คุณอาจจะสร้างคลาส Car หรือคลาส Player ขึ้นมา
        อ็อบเจกต์ (Object): คือสิ่งของหรือตัวตนที่ถูกสร้างขึ้นมาจากพิมพ์เขียว (Class) นั้นๆ 
        ตัวอย่างเช่น 
        หากคลาสคือแม่แบบของ Car อ็อบเจกต์ก็คือ รถเฟอร์รารี่สีแดง 1 คัน และรถเบนซ์สีดำอีก 1 คัน 
        ทั้งคู่ถูกสร้างจากพิมพ์เขียวเดียวกัน //แต่เก็บข้อมูลสีและยี่ห้อต่างกันได้//
        การสร้างอ็อบเจกต์: ใน C# เราจะใช้คำสั่ง new เพื่อสร้างอ็อบเจกต์ออกมาจากคลาส (เช่น Car myCar = new Car();)

         */
        static void Main(string[] args)
        {
            string command = "";
            do
            {
                string inputBrand = "";
                string inputModel = "";

                Console.OutputEncoding = System.Text.Encoding.UTF8;
                while (string.IsNullOrWhiteSpace(inputBrand))
                {
                    Console.WriteLine("🚗 Please enter your Brand name: ");
                    inputBrand = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(inputBrand))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("❌ ERROR: Brand cannot be empty! Please try again.\n");
                        Console.ResetColor();
                    }
                    Console.WriteLine($"You entered Brand name: {inputBrand}\n");
                }
                while (string.IsNullOrWhiteSpace(inputModel))
                {
                    Console.WriteLine("📩 Please enter Car Model: ");
                    inputModel = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(inputModel))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("❌ ERROR: Model cannot be empty! Please try again.\n");
                        Console.ResetColor();
                    }
                    Console.WriteLine($"You entered Model: {inputModel}\n");
                }

               
                Car myNewCar = new Car(inputModel, inputBrand);
                Console.WriteLine("\n[Please ENTER to build another car, or Type 'EXIT' to stop]");
                    command = Console.ReadLine();
            } while (command.ToLower() != "exit");
            

            Console.WriteLine("\n👋 Thank for use our service");
            Console.ReadKey();
        }
    }
}
