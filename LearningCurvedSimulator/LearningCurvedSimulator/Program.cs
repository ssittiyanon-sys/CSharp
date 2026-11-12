/*
namespace LearningCurvedSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== 📚 The Learning Journey Simulator 📚 ===");
            Console.WriteLine("Enter the Days of Progress to stimulate:");

            //รับค่าจำนวนวัน
            int totalDays = int.Parse(Console.ReadLine());

            //ค่ายกลวิชาต่างๆ และอีเว้นแบบสุ่ม
            string[] learningCurved = { "C#", "3D", "Unity", "IELT", "Art" };
            string[] randomEvent = {"Found a great tutorial!", "System Crash! (Minor setback)", "Focus Boost!", "Felt tired, took a break." };
            
            //กระเป๋าเก็บ exp รายวัน
            int[] dailyExpLog = new int[totalDays];

            Random random = new Random();
            int totalProgress = 0;

            Console.WriteLine("--- Starting your {totalDays} days Learning Journey  ---");

            //ลูปข้ามเวลาทีละวัน
            for (int i = 0; i < totalDays; i++)
            {
                //สุ่มวิชาที่จะเรียนวันนี้ 0-4 เพราะมี 5 อัน "C#", "3D", "Unity", "IELT", "Art"
                int skillIndex = random.Next(learningCurved.Length);

                //สุ่ม event ที่จะเจอในวันนี้ (0-3) เพราะมี 4 อัน
                int evenIndex = random.Next(randomEvent.Length);

                //ใส่ exp ตั้งต้น
                int expToday = 0;

                //ระบบจำลองความสมจริงให้ exp ตามอีเว้นที่เจอ
                if (evenIndex == 0) //"Found a great tutorial!" (30,51) <-- 30-50 exp
                {
                    expToday = random.Next(30, 51);
                }
                else if (evenIndex == 1) //"System Crash! (Minor setback)" (5,16) <-- 5-15 exp
                {
                    expToday = random.Next(5, 16);
                }
                else if (evenIndex == 2)//"Focus Boost!" (50,101) <-- 50-100 exp
                {
                    expToday = random.Next(50, 101);
                }
                else if (evenIndex == 3)//"Felt tired, took a break." = 0 <-- 0 exp
                {
                    expToday = 0;
                }

                //บันทึกข้อมูลลง Array และ สมุดรวม
                dailyExpLog[i] = expToday;
                totalProgress += expToday;

                //แสดงผลรายวัน
                Console.WriteLine($"Day {i + 1}: Studied [{learningCurved[skillIndex]}] -> [{randomEvent[evenIndex]}] -> you got [{expToday}] EXP");

                //หน่วงเวลาให้อ่านทัน
                Thread.Sleep(600);
            }
            //สรุปผลตอนจบลูป
            Console.WriteLine("\n===============================");
            Console.WriteLine($"\n🏆 {totalDays} Days Learning Summary 🏆");
            Console.WriteLine($"Total Knowledge Progess: {totalProgress} EXP");

            if (totalProgress >= (totalDays * 30))
            {
                Console.WriteLine("✨ You are a Master Scholar! Incredible focus! ✨");
            }
            else
            {
                Console.WriteLine("💪 Great effort! Consistency is key. Keep going! 🚀");
            }
            Console.WriteLine("\n==================================");

            double averageExp = (double)totalProgress / totalDays;
            Console.WriteLine($"\nAverage EXP per day: {averageExp:F1} EXP/Day ");

            Console.ReadKey();
        
        }
    }
}
*/

using System;
using System.Threading;
using System.Linq;

namespace LearningCurvedSimulator
{
    internal class Program
    {
        // 📦 1. สมบัติส่วนรวม (Global Variables) 
        static int totalProgress = 0;
        static int totalDays;

        //ประกาศ Global Learning และ Global Event
        static string[] learningCurved = { "C#", "3D", "Unity", "IELTS", "Art" };
        static string[] randomEvent = { "Found a great tutorial!", "System Crash! (Minor setback)", "Focus Boost!", "Felt tired, took a break." };
        // ⚠️ ประกาศชื่อกระเป๋าไว้ก่อน แต่ "อย่าเพิ่งระบุขนาด (new)" เพราะเรายังไม่รู้จำนวนวัน
        static int[] dailyExpLog;

        // ประกาศ event count
        static int[] eventCounts = new int[4]; //สมุดขีดแต้ม event (เพราะมี 4 event)
        // ประกาศ learning count
        static int[] subjectCounts = new int[5]; // สมุดขีดแต้มวิชา (เพราะมี 5 วิชา)

        // ประกาศ ลิสแบบจดรายชื่อวิชาเรียนในแต่ละวัน
        static string[] dailySubjectHistory;
        static void Main(string[] args)
        {
            // ซ่อมบั้ก emoji ?? ให้กลายเป็น emoji สีจริงๆ
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== 📚 The Learning Journey Simulator 📚 ===");
            Console.WriteLine("Enter the Days of Progress to simulate:");

            // รับค่าจำนวนวัน
            totalDays = int.Parse(Console.ReadLine());

            // พอรู้จำนวนวันแล้ว ค่อยเสกกระเป๋าให้ขนาดพอดีกับจำนวนวัน!
            dailyExpLog = new int[totalDays];

            // เสกกระเป๋าลิสจดรายชื่อให้พอดีกับจำนวนวัน
            dailySubjectHistory = new string[totalDays]; 

            Console.WriteLine($"\n--- Starting your {totalDays} days Learning Journey ---");

            // ⚔️ เรียกใช้สกิลจำลองเวลา! (ให้ฟังก์ชันไปจัดการลูปแทน Main)
            SimulateLearning();

            // สรุปผลตอนจบลูป
            Console.WriteLine("\n===============================");
            Console.WriteLine($"🏆 {totalDays} Days Learning Summary 🏆");
            Console.WriteLine($"Total Knowledge Progress: {totalProgress} EXP");

            if (totalProgress >= (totalDays * 30))
            {
                Console.WriteLine("✨ You are a Master Scholar! Incredible focus! ✨");
            }
            else
            {
                Console.WriteLine("💪 Great effort! Consistency is key. Keep going! 🚀");
            }
            Console.WriteLine("==================================");

            // ⚔️ เรียกใช้สกิลคำนวณค่าเฉลี่ย
            Console.WriteLine($"Average EXP per day: {CalculateAverage():F1} EXP/Day ");
            ShowMinMaxExp();
            ShowMinMaxExpLinQ();
            MostLearningCurvedOldStyle();
            MostEventOldStyle();
            MostLearningCurvedLinq();
            MostEventLinq();

            string myStyleMostCommon = MostCommonLearningCurvedMyStyle(dailySubjectHistory);
            Console.WriteLine($"My Style says: Most studied is {myStyleMostCommon}");

            MostLearningCurvedCoChampions();
            MostLearningCurvedLinqCoChampions();

            Console.ReadKey();
        }

        // ========================================================
        // 🪄 สกิลที่ 1: วิ่งลูปและสุ่มอีเวนต์ (ย้าย for กับ if-else มาไว้ที่นี่)
        // ========================================================
        static void SimulateLearning()
        {
            Random random = new Random();

            for (int i = 0; i < totalDays; i++)
            {
                int skillIndex = random.Next(learningCurved.Length);
                int evenIndex = random.Next(randomEvent.Length);

                // 🌟 จุดแก้ที่ 3: ต้องสั่งให้ม้าจดแต้มลงสมุดด้วย! ไม่งั้นสถิติจะเป็น 0
                subjectCounts[skillIndex]++;
                eventCounts[evenIndex]++;

                // 🌟 จดชื่อวิชาที่สุ่มได้ลงในประวัติ!
                dailySubjectHistory[i] = learningCurved[skillIndex];

                int expToday = 0;

                if (evenIndex == 0) // "Found a great tutorial!"
                {
                    expToday = random.Next(30, 51);
                }
                else if (evenIndex == 1) // "System Crash!"
                {
                    expToday = random.Next(5, 16);
                }
                else if (evenIndex == 2) // "Focus Boost!"
                {
                    expToday = random.Next(50, 101);
                }
                else if (evenIndex == 3) // "Felt tired"
                {
                    expToday = 0;
                }

                dailyExpLog[i] = expToday;
                totalProgress += expToday;

                Console.WriteLine($"Day {i + 1}: Studied [{learningCurved[skillIndex]}] -> [{randomEvent[evenIndex]}] -> you got [{expToday}] EXP");
                Thread.Sleep(600);
            }
        }

        // ========================================================
        // 🪄 สกิลที่ 2: คำนวณค่าเฉลี่ย
        // ========================================================
        static double CalculateAverage()
        {
            // คำนวณ "ณ ตอนที่ถูกเรียกใช้" (ตอนที่ totalDays และ totalProgress มีค่าแล้วจริงๆ)
            return (double)totalProgress / totalDays;
        }

        // ========================================================
        // 🪄 สกิลที่ 3: ค้นหาค่า EXP สูงสุดและต่ำสุด (Classic Style)
        // ========================================================

        static void ShowMinMaxExp()
        {
            // 1. ตั้งค่าเริ่มต้นให้ "วันแรก (ช่อง 0)" เป็นทั้งแชมป์สูงสุดและต่ำสุดชั่วคราว
            int maxExp = dailyExpLog[0];
            int minExp = dailyExpLog[0];

            // 2. ให้ม้าเริ่มวิ่งเช็คตั้งแต่วันที่ 2 (ช่อง 1) เป็นต้นไป
            for (int i = 1; i < dailyExpLog.Length; i++)
            {
                // ถ้าเจอวันที่ได้ EXP มากกว่าแชมป์ปัจจุบัน -> ปลดแชมป์เก่า ตั้งแชมป์ใหม่!
                if (dailyExpLog[i] > maxExp)
                {
                    maxExp = dailyExpLog[i];
                }

                // ถ้าเจอวันที่น้อยกว่าคนแพ้ปัจจุบัน -> อัปเดตสถิติยอดแย่ใหม่!
                if (dailyExpLog[i] < minExp)
                {
                    minExp = dailyExpLog[i];
                }
            }

            Console.WriteLine($"Highest EXP in a single day: {maxExp} EXP 🌟 (Old Style)");
            Console.WriteLine($"Lowest EXP in a single day: {minExp} EXP 🐢 (Old Style)");
        }

        // ========================================================
        // 🪄 สกิลที่ 3: ค้นหาค่า EXP สูงสุดและต่ำสุด (Modern Style ด้วย LINQ)
        // ========================================================
        static void ShowMinMaxExpLinQ()
        {
            // ร่ายคาถา .Max() และ .Min() ใส่กระเป๋า Array ได้เลย จบในบรรทัดเดียว!
            int maxExp = dailyExpLog.Max();
            int minExp = dailyExpLog.Min();

            Console.WriteLine($"LINQ : Highest EXP in a single day: {maxExp} EXP 🌟");
            Console.WriteLine($"LINQ : Lowest EXP in a single day: {minExp} EXP 🐢");
        }
        // ==========================================
        // 🛡️ ค้นหาวิชาและอีเวนต์ที่ออกบ่อยสุด (Old Style)
        // ==========================================
        static void MostLearningCurvedOldStyle()
        {
            int maxCount = subjectCounts[0];
            int maxIndex = 0;

            for (int i = 1; i < subjectCounts.Length; i++)
            {
                if (subjectCounts[i] > maxCount)
                {
                    maxCount = subjectCounts[i];
                    maxIndex = i;
                }
            }
            Console.WriteLine($"📚 Most studied subject (Old Style): [{learningCurved[maxIndex]}] ({maxCount} times)");
        }

        static void MostEventOldStyle()
        {
            int maxCount = eventCounts[0];
            int maxIndex = 0;

            for (int i = 1; i < eventCounts.Length; i++)
            {
                if (eventCounts[i] > maxCount)
                {
                    maxCount = eventCounts[i];
                    maxIndex = i;
                }
            }
            Console.WriteLine($"🔥 Most frequent event (Old Style): [{randomEvent[maxIndex]}] ({maxCount} times)");
        }
        // ==========================================
        // 🪄 ค้นหาวิชาและอีเวนต์ที่ออกบ่อยสุด (LINQ Style)
        // ==========================================
        static void MostLearningCurvedLinq()
        {
            int maxCount = subjectCounts.Max(); // หาแต้มสูงสุด
            int maxIndex = Array.IndexOf(subjectCounts, maxCount); // หาว่าอยู่หน้าไหน

            Console.WriteLine($"LINQ : 📚 Most studied subject : [{learningCurved[maxIndex]}] ({maxCount} times)");
        }

        static void MostEventLinq()
        {
            int maxCount = eventCounts.Max(); // หาแต้มสูงสุด
            int maxIndex = Array.IndexOf(eventCounts, maxCount); // หาว่าอยู่หน้าไหน

            Console.WriteLine($"LINQ : 🔥 Most frequent event : [{randomEvent[maxIndex]}] ({maxCount} times)");
        }
        // ==========================================
        // 🪄 ค้นหาวิชาและอีเวนต์ที่ออกบ่อยสุด แบบ style string จดรายชื่อ
        // ==========================================
        // 🪄 วิชาหาคำซ้ำที่ออกบ่อยที่สุด (Custom Style)
        static string MostCommonLearningCurvedMyStyle(string[] learningHistory)
        {
            int count = 0;
            string mostCommonLC = learningHistory[0]; // สมมติให้คำแรกเป็นแชมป์ไปก่อน

            // 🐎 ม้าตัวที่ 1: หยิบคำขึ้นมาทีละคำเพื่อเป็น "ตัวตั้งต้น"
            for (int i = 0; i < learningHistory.Length; i++)
            {
                int learningCount = 0;

                // 🐎 ม้าตัวที่ 2: วิ่งสแกน "ทั้งกระเป๋า" เพื่อดูว่ามีคำไหนเหมือน "ตัวตั้งต้น" ไหม
                // ⚔️ แก้ไขแล้ว: ใช้ learningHistory.Length (ความยาวของกระเป๋า)
                for (int j = 0; j < learningHistory.Length; j++)
                {
                    if (learningHistory[j] == learningHistory[i])
                    {
                        learningCount++; // ถ้าเจอคำเหมือนกัน ให้นับแต้มเพิ่ม!
                    }
                }

                // ถ้าคำนี้มีจำนวนซ้ำมากกว่าแชมป์เก่า ให้ยึดตำแหน่งแชมป์ทันที
                if (learningCount > count)
                {
                    count = learningCount;
                    mostCommonLC = learningHistory[i];
                }
            }

            // ⚔️ แก้ไขแล้ว: โยนชื่อแชมป์กลับไปให้คนเรียกใช้
            return mostCommonLC;
        }
        // ==========================================
        // 🛡️ ค้นหาวิชาที่ออกบ่อยสุดแบบหา "แชมป์เปี้ยนร่วม" (Old Style)
        // ==========================================
        static void MostLearningCurvedCoChampions()
        {
            // 🐎 ม้าวิ่งรอบที่ 1: หาแต้มสูงสุด (Max) ของตาราง
            int maxCount = 0;
            for (int i = 0; i < subjectCounts.Length; i++)
            {
                if (subjectCounts[i] > maxCount)
                {
                    maxCount = subjectCounts[i]; // จดแต้มสูงสุดเอาไว้ (เช่น 3 แต้ม)
                }
            }

            // 🐎 ม้าวิ่งรอบที่ 2: ประกาศชื่อ "ทุกคน" ที่ได้แต้มเท่ากับ maxCount
            Console.Write($"📚 Most studied subjects ({maxCount} times): ");

            for (int i = 0; i < subjectCounts.Length; i++)
            {
                // ⚠️ เปลี่ยนจากเครื่องหมาย > เป็น == เพื่อหาคนที่แต้ม "เท่ากับ" แชมป์
                if (subjectCounts[i] == maxCount)
                {
                    Console.Write($"[{learningCurved[i]}] "); // ปริ้นท์ชื่อต่อๆ กันแบบไม่ขึ้นบรรทัดใหม่
                }
            }
            Console.WriteLine(); // จบการประกาศรายชื่อ ค่อยขึ้นบรรทัดใหม่
        }
        // ==========================================
        // 🪄 ค้นหาวิชาที่ออกบ่อยสุดแบบหา "แชมป์เปี้ยนร่วม" (LINQ Style)
        // ==========================================
        static void MostLearningCurvedLinqCoChampions()
        {
            int maxCount = subjectCounts.Max(); // หาแต้มสูงสุด

            Console.Write($"LINQ : 📚 Most studied subjects ({maxCount} times): ");

            // วิ่งลูปสั้นๆ เพื่อหาว่าช่องไหนมีแต้มเท่ากับ maxCount บ้าง
            for (int i = 0; i < subjectCounts.Length; i++)
            {
                if (subjectCounts[i] == maxCount)
                {
                    Console.Write($"[{learningCurved[i]}] ");
                }
            }
            Console.WriteLine();
        }

    }

}
