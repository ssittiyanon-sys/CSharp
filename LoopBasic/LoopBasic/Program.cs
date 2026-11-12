/////////// Logical ////////////
/*


bool isRainy = false;
bool hasUmbrella = false;

// Logical Operator
// AND &&
// OR ||
// NOT !

if (!isRainy || hasUmbrella)
{
    Console.WriteLine("i'M GETTING WET!");
}
Console.WriteLine("Ay oOK!");


int num1 = 5;
int num2 = 6;

*/


/*
// relational operator < <= > >=
// !=

bool isGreater = num1 < num2;    // 5 < 6 = true;
bool isLesstan = num1 > num2;     // 5 > 6 = false;

int age = 15;
bool isWithParents = true;

if(age >= 13 && isWithParents)
{
    Console.WriteLine("Go party in the Club with your parents");
}
else if (age >= 18)
{
    Console.WriteLine("Go party in Club!!");
}
else 
{
    Console.WriteLine("Go party in school!!");
}
*/


//////// if else and switch case //////////

/*
using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void SimpleCalculator()
        {
            int num1;
            int num2;
            int result = 0;
            string inputOperator;
            string inputNumber;
            bool isNumber;

            Console.WriteLine("Enter the first number:");
            inputNumber = Console.ReadLine();
            isNumber = int.TryParse(inputNumber, out num1);
            if (isNumber == true)
            {
                Console.WriteLine("Enter your second number:");
                inputNumber = Console.ReadLine();
                isNumber = int.TryParse(inputNumber, out num2);
                if (isNumber == true)
                {
                    Console.WriteLine("Choose an operation: +, -, *, /");
                    inputOperator = Console.ReadLine();
                    switch (inputOperator)
                    {
                        case "+":
                            result = num1 + num2;
                            break;
                        case "-":
                            result = num1 - num2;
                            break;
                        case "*":
                            result = num1 * num2;
                            break;
                        case "/":
                            if (num2 == 0)
                            {
                                Console.WriteLine("Error: Division by zero is not allowed.");
                            }
                            else
                            {
                                result = num1 / num2;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
                            break;
                    }
                    Console.WriteLine($"result: {result}");
                }
                else
                {
                    Console.WriteLine("Invalid Please enter Number");
                }
            }
            else
            {
                Console.WriteLine("Invalid Please enter Number");
            }

        }
    }
}
*/




//////////// For loop ///////////////
//for loop
/*int landingCounter = 10;

Console.WriteLine("Times Count!!");

    for (landingCounter = 10; landingCounter >= 0; landingCounter--)
    {
        Console.WriteLine($"Counter is : {landingCounter}");
        Thread.Sleep(1000);
    }


    Console.WriteLine("End!!!");
*/
/*
Console.WriteLine("Enter go or stay");
string userChoice = Console.ReadLine();
while (userChoice == "go")
{
    Console.WriteLine("Go for a mile");
    Console.WriteLine("Wanna keep going? Enter go.");
    userChoice = Console.ReadLine();
}
Console.WriteLine("Finally you're stay");
*/

//////////// Guessing Game ///////////////
/*
using System.Diagnostics;
using System.Transactions;
namespace Coding.Exercise
{
    public class Excercise
    {
        public static void Main(string[] args)
        {
            var myGame = new Excercise();
            myGame.GuessingGame();
        }

        public void GuessingGame()
        {
            Random oracle = new Random();
            int secretNumber = oracle.Next(1, 101);
            int userGuess = 0;
            int counter = 0;
            Console.WriteLine("Guess the number I'm thinking of between 1 and 100");
            while (userGuess != secretNumber)
            {
                counter++;
                Console.WriteLine("Enter the number your guess:");
                userGuess = int.Parse(Console.ReadLine() ?? "0");
                if (userGuess < secretNumber)
                {
                    Console.WriteLine("Too low! Try again.");

                }
                else if (userGuess > secretNumber)
                {
                    Console.WriteLine("Too High! Try again.");
                }
                else
                {
                    Console.WriteLine($"Congrat you're guess right one!! {secretNumber}!!! it's took {counter} tries!!");
                }
            }
            Console.ReadKey();
        }
    }
}
*/




//////////// Adventure Game ///////////////
/*
Console.WriteLine("Welcome to the Adventure Game!");
Console.WriteLine("Enter your character's name:");
string playerName = Console.ReadLine();
Console.WriteLine($"Hello {playerName} dont forget to choose your Role! (Warrior, Wizard, Archer)");
string characterRole = Console.ReadLine();

Console.WriteLine($"You, {playerName} the {characterRole} find yourself at the the edge of a dark forest in the middle of the night!");
Console.WriteLine("Do you want to enter the forest or camp outside? (Enter/Camp)");

string playerChoice = Console.ReadLine();
bool gameContinues;

if (playerChoice.ToLower() == "enter")
{
    Console.WriteLine("You're bravely enter the forest!");
    gameContinues = true;
}
else
{
    Console.WriteLine("You decide to camp out and wait for daylight");
    gameContinues = false;
}



while (gameContinues)
{
    Console.WriteLine("You come to a fork in the road. Go Left or Right");
    playerChoice = Console.ReadLine();
    if (playerChoice.ToLower() == "left")
    {
        Console.WriteLine("You found a treasure chest!");
        gameContinues = false;
    }
    else
    {
        Console.WriteLine("You encounter a wild beast!!");
        Console.WriteLine("It look really angry do you decide to \nFight or Flee?");
        playerChoice = Console.ReadLine();
        if (playerChoice.ToLower() == "fight")
        {
            Random random = new Random();
            int luck = random.Next(1, 11);
            if (luck >= 5)
            {
                Console.WriteLine("You beat the wile beast! and walk pass the forest safely");
                gameContinues = false;
                if (luck >= 8)
                {
                    Console.WriteLine("You found a treasure chest!");
                    gameContinues = false;
                }
            }
            else
            {
                Console.WriteLine("The wild beast attacked you where you didnt expect it!");
                Console.WriteLine("It rammped it's tusk into your chest and you bleed out to die!");
                gameContinues = false;
            }

        }
        else
        {
            Console.WriteLine("You fleed from the beast and go camp outside until datlight comes");
            gameContinues = false;
        }
    }
}
Console.WriteLine("END!");
Console.ReadKey();
*/

/////// do while loop ///////////

/*
int number;
do
{
    Console.WriteLine("Enter a positive whole number");
    number = int.Parse(Console.ReadLine()?? "0");
} while (number <= 0);
Console.WriteLine("Finally");
Console.ReadKey();
*/
/*
int currentScore;
int sum = 0;
int counter = 0;
do
{

}while (true);

*/


////////// Simple Array and Foreach loop //////////

/*
int num1 = 0;
int num2 = 0;
int num3 = 0;
int num4 = 0;
int num5 = 0;

/// declare an array
Console.WriteLine("We add intArray in each of it");

int[] myIntArray = new int[5];

myIntArray[0] = 1;
myIntArray[1] = 2;
myIntArray[2] = 3;
myIntArray[3] = 4;
myIntArray[4] = 5;
Console.WriteLine("We added all of int in array and run in one CW console");
Console.WriteLine($"{myIntArray[0]} {myIntArray[1]} {myIntArray[2]} {myIntArray[3]} {myIntArray[4]}");
Console.WriteLine("We added all of int in array and run in for loop");
for ( int i = 0; i < 5; i++)
{
    Console.WriteLine($"{myIntArray[i]}");
}
Console.WriteLine("We added all of second int in array2 and run in for loop");
int[] myIntArray2 = [5, 4, 5, 1, 6, 7];
string[] weekDays = ["Monday", "Tuesday", "Wenesday", "Thursday", "Friday", "Saturday", "Sunday"];
for (int i = 0; i < 6; i++)
{
    Console.WriteLine($"{myIntArray2[i]}");
}
Console.WriteLine("The day in the weeks length is: " + weekDays.Length + " which are");
for (int i = 0; i < 7; i++)
{
    Console.WriteLine($"{weekDays[i]}");
}
Console.WriteLine("We added all of weeksday with foreach loop!");
foreach (var day in weekDays)
{
    Console.WriteLine($"the day is: {day}");
}
Console.ReadKey();
*/

////////// For กับ Foreach loop ต่างกันยังไง ///////////
/*
string[] inventory = { "ดาบไม้", "ดาบเหล็ก" };

// ❌ foreach ทำแบบนี้ไม่ได้! (Error)
foreach (string item in inventory)
{
    item = "ดาบเทพเจ้า"; // ระบบโวยวาย: "ไอเทมนี้ถูกล็อคไว้ ห้ามเปลี่ยน!"
}

// ✅ for ทำได้สบายมาก!
for (int i = 0; i < 2; i++)
{
    inventory[i] = "ดาบเทพเจ้า"; // ทิ้งของเก่า เอาของใหม่ยัดใส่ช่องเดิม!
}
*/


///////// ตัวอย่าง หยิบของขึ้นจาก foreach ใน if else และใช้ break ยกเลิก//////////
/*

using System;
using System.Threading;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static void Main(string[] args)
        {
            // 1. สร้างคลังอาวุธหลวง (Array) ที่มีดาบซ่อนอยู่ตรงกลาง!
            string[] royalArmory = { "ดาบขึ้นสนิม", "ธนูไม้", "หอกเหล็ก", "Excalibur", "ขวานคนแคระ", "โล่พังๆ" };

            // 2. สร้างตัวแปรเก็บสถานะว่า "เจอหรือยัง?" (ตอนแรกยังไม่เจอ ให้เป็น false ไปก่อน)
            bool isFound = false;

            Console.WriteLine("ภารกิจ: ค้นหาดาบ Excalibur ในคลังอาวุธหลวง!");
            Console.WriteLine("---------------------------------------------");

            // 3. ร่ายคาถา foreach เพื่อหยิบอาวุธขึ้นมาดูทีละชิ้น
            foreach (string weapon in royalArmory)
            {
                Console.WriteLine($"ท่านผู้กล้าเจฟหยิบ: [{weapon}] ขึ้นมาตรวจสอบ...");
                Thread.Sleep(800); // หยุดเวลาแป๊บนึงให้ตื่นเต้น!

                // 4. กางโล่ if-else ตรวจสอบว่าใช่ดาบที่ตามหาไหม?
                if (weapon == "Excalibur")
                {
                    Console.WriteLine("✨ โอ้วววว! แสงสว่างจ้า! ท่านเจอดาบ Excalibur แล้ว! ✨");
                    isFound = true; // อัปเดตสถานะว่าเจอแล้วนะ!
                    break; // ทุบลูปทิ้ง! เจอของแล้ว จะค้นต่อให้เหนื่อยทำไม สละยานเลย!
                }
                else
                {
                    Console.WriteLine("-> ไม่ใช่อันนี้... โยนทิ้งไป!");
                }
                Console.WriteLine();
            }

            Console.WriteLine("---------------------------------------------");

            // 5. สรุปผลภารกิจตอนจบ
            if (isFound == true)
            {
                Console.WriteLine("ภารกิจสำเร็จ! ท่านผู้กล้าเจฟพร้อมกู้โลกแล้ว!");
            }
            else
            {
                Console.WriteLine("ภารกิจล้มเหลว... ไม่พบดาบในคลังอาวุธนี้เลย");
            }

            Console.ReadKey();
        }
    }
}

*/

/*
using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static void Main(string[] args)
        {
            // 2. เรียกใช้สกิล! (ตะโกนชื่อคาถา และใส่วัตถุดิบลงไปในวงเล็บ)
            Console.WriteLine("กองทัพออร์คบุก! อัศวินบาดเจ็บ!");

            Heal("เจฟ");           // ร่ายเวทใส่ตัวเอง
            Heal("อัศวินอาเธอร์");   // ร่ายเวทเพื่อน
            Heal("สุนัขดุ๊กดิ๊ก");    // ร่ายเวทให้สัตว์เลี้ยงสุดที่รัก!

            Console.ReadKey();
        }

        // 1. สร้างคัมภีร์สกิล (จดคาถาไว้ด้านนอกประตู Main เสมอนะครับ!)
        // public: ใครๆ ก็เรียกใช้ได้
        // void: ร่ายเวทแล้วจบไป ไม่ได้คืนไอเทมอะไรกลับมาให้
        // string targetName: วัตถุดิบที่ขอรับ คือชื่อคน (string)
        public static void Heal(string targetName)
        {
            Console.WriteLine($"✨ ร่ายเวทฟื้นฟู! {targetName} ได้รับ HP +50! กลับมาแข็งแรงแล้ว!");
        }
    }
}
*/

//////// 2 Dimensional Array /////////


using System.Data;

///
///
///
int[,] array2DDeclaration = new int[3, 3];

// จะออกมาเป็นแบบนี้
// [0] [0] [0] -> แถวที่ 0
// [0] [0] [0] -> แถวที่ 1
// [0] [0] [0] -> แถวที่ 2

int[,,] array3DDeclaration = new int[3, 3, 3];
// แบบ 3D ไม่สามารถให้ดูใน 2D วิชวลได้

int[,] array2DInitialized = { {1,2}, {3,4} };
// จะออกมาเป็นแบบนี้
// [1] [2] -> แภวที่ 0
// [3] [4] -> แถวที่ 1


Console.WriteLine("Changed from square brackets [ ] to curly braces");
// Changed from square brackets [ ] to curly braces { }!
int[] arrayInitialized = [ 1, 2, 3, 4, 5 ];

foreach (int number in arrayInitialized)
{
    Console.WriteLine(number);
}
Console.WriteLine("\nจะปริ้นท์เลข 0 ออกมา 3 ตัว มี string และ bool");
int[] goldChest = new int[3];       // หีบเก็บทองคำ (ตัวเลข)
string[] itemChest = new string[3]; // หีบเก็บอาวุธ (ข้อความ)
bool[] buffChest = new bool[3];     // หีบเก็บสถานะบัฟ (จริง/เท็จ)

Console.WriteLine("--- เปิดหีบทองคำ (int) ---");
foreach (int gold in goldChest)
{
    // จะปริ้นท์เลข 0 ออกมา 3 ตัว
    Console.WriteLine($"จำนวนทอง: {gold}");
}

Console.WriteLine("--- เปิดหีบอาวุธ (string) ---");
foreach (string item in itemChest)
{
    // ปกติ Console.WriteLine(null) มันจะไม่แสดงอะไรเลยเป็นบรรทัดว่างๆ
    // ช่างซ่อมยานเลยต้องกางโล่เช็คให้ท่านผู้กล้าเห็นภาพชัดๆ ครับ
    if (item == null)
    {
        Console.WriteLine("ช่องนี้ว่างเปล่า (null) !");
    }
}

Console.WriteLine("--- เปิดหีบสถานะ (bool) ---");
foreach (bool isBuffActive in buffChest)
{
    // จะปริ้นท์คำว่า False ออกมา 3 ตัว
    Console.WriteLine($"สถานะบัฟทำงานไหม?: {isBuffActive}");
}

Console.WriteLine("\nสร้างกิลล์ขึ้นมาแล้วสร้างที่ เก็บทีละอัน ทีละช่องของ array");
int[][] guildParties2 = new int[3][];

// ---------------------------------------------------
// Plot 0: The one you already built (2-person tent)
guildParties2[0] = new int[2];
// Put numbers to sleep in the tent
guildParties2[0][0] = 99; // Bed 0
guildParties2[0][1] = 50; // Bed 1

// ---------------------------------------------------
// Plot 1: Add it right here! Shift the number to 1
// This is a solo player, so we build a 1-person tent
guildParties2[1] = new int[1];
guildParties2[1][0] = 77; // Bed 0

// ---------------------------------------------------
// Plot 2: Just keep adding down the line!
// This is a big gang, 3-person tent.
// 💡 Magic Shortcut: Build the tent AND put them in bed at the exact same time!
guildParties2[2] = new int[] { 10, 20, 30 };

// ---------------------------------------------------
Console.WriteLine("--- Guild Members Summary ---");
Console.WriteLine($"Party 0's first member level: {guildParties2[0][0]}");
Console.WriteLine($"Party 1's first member level: {guildParties2[1][0]}");
Console.WriteLine($"Party 2's last member level: {guildParties2[2][2]}");


// เสกกิลด์ สร้างเต็นท์ และจัดคนเข้านอน จบในคาถาเดียว!
Console.WriteLine("\nเสกกิลด์ สร้างเต็นท์ และจัดคนเข้านอน จบในคาถาเดียว!");
int[][] guildParties = new int[][]
{
                new int[] { 99, 50 },      // ⛺ แปลงที่ 0 (มี 2 คน)
                new int[] { 77 },          // ⛺ แปลงที่ 1 (มี 1 คน)
                new int[] { 10, 20, 30 }   // ⛺ แปลงที่ 2 (มี 3 คน)
};

// ลองเรียกใช้งานดู
Console.WriteLine($"ปาร์ตี้ 0 คนแรกคือ: {guildParties[0][0]}"); // ได้ 99
Console.WriteLine($"ปาร์ตี้ 2 คนสุดท้ายคือ: {guildParties[2][2]}"); // ได้ 30


// 1. ชั้นวางอาวุธที่มีบางช่องว่างเปล่า (null)
string[] weaponRack = { "Excalibur", null, "Iron Bow", null, "Magic Staff" };

int index = 0; // เรียกม้าลาดตระเวนมาเตรียมที่จุดเริ่มต้น (ช่อง 0)

Console.WriteLine("\n--- เริ่มการลาดตระเวนชั้นวางอาวุธ! ---");

// weaponRack.Length คือความยาวของชั้นวาง (มี 5 ช่อง)
while (index < weaponRack.Length)
{
    // 2. ถ้าเจอความว่างเปล่า (null)
    if (weaponRack[index] == null)
    {
        Console.WriteLine($"[ช่อง {index}]: ว่างเปล่า... วาร์ปข้าม!");

        index++; // 🛡️ กฎเหล็ก!: ต้องบวกเลขให้ม้าเดินหน้า "ก่อน" ร่ายเวทข้ามเสมอ!
        continue; // ⚡ ร่ายเวทวาร์ปข้ามกลับไปเริ่มเช็คช่องต่อไปทันที!
    }

    // 3. ถ้าช่องนั้นมีของอยู่ (ไม่ null) ก็ทำงานตามปกติ
    Console.WriteLine($"[ช่อง {index}]: เจออาวุธ -> {weaponRack[index]}");

    index++; // บวกเลขให้ม้าเดินหน้าตามปกติ
}

Console.WriteLine("\nต้องเขียน null ลงไปตรงๆ ห้ามใช้ ,, เด็ดขาดครับ");
// 1. ต้องเขียน null ลงไปตรงๆ ห้ามใช้ ,, เด็ดขาดครับ
string[] weaponRack2 = { "Excalibur", null, "Iron Bow", null, "Magic Staff" };

int index2 = 0;

Console.WriteLine("--- เริ่มการลาดตระเวนด้วยโล่ศักดิ์สิทธิ์ ?? ---");

while (index2 < weaponRack2.Length)
{
    // 2. ร่ายคาถา ?? ตรงนี้เลย! 
    // ความหมาย: "ถ้าช่องนี้เป็น null ให้เสกคำว่า '🕸️ ใยแมงมุม (ว่างเปล่า)' ออกมาแทน!"
    string currentItem2 = weaponRack2[index2] ?? "🕸️ ใยแมงมุม (ว่างเปล่า)";

    // ปริ้นท์ออกมาได้เลยโดยที่เกมไม่พังแน่นอน!
    Console.WriteLine($"[ช่อง {index2}]: สำรวจพบ -> {currentItem2}");

    index2++;
}


Console.WriteLine("รวมแถว 123,456,789 ทีละแถวโดยใช้ [][] และ foreach");
int[][] intInitialized =
    {
    new int[] { 1, 2, 3 },
    new int[] { 4, 5, 6 },
    new int[] { 7, 8, 9 }

    };
    foreach (int[] party in intInitialized)
    {
        int sum = 0;
        foreach (int level in party)
        {
            sum += level;
        }
        Console.WriteLine($"{sum}");
    }

Console.WriteLine("รวมแถว 123,456,789 ทีละแถวโดนใช้ [,] และ for");

int[,] intInitialized2 = { {  1, 2, 3 }, { 4, 5, 6  }, { 7, 8, 9 } };
for (int row = 0; row < intInitialized2.GetLength(0); row++)
{
    int sum = 0;
    // GetLength(1) หมายถึง ขอเช็คหน่อยว่าแต่ละแถวมีกี่คอลัมน์ (แนวนอน)
    for (int colLevel = 0; colLevel < intInitialized2.GetLength(1); colLevel++)
    {
        // ดูดเข้าสู่กล่อง sum โดยระบุพิกัด [แถว, คอลัมน์]
        sum += intInitialized2[row, colLevel]; //
    }
    Console.WriteLine($"{sum}");
}
/*
 * ตัวเลขในวงเล็บของ GetLength() คือ หมายเลขมิติ (Dimension Index) ของ Array ครับ โดยใน C# ระบบจะเริ่มนับมิติแรกสุดที่เลข 0 เสมอ

ความหมายของมันจะขยายตามขนาดมิติของ Array ที่เราใช้งาน (1D, 2D, 3D) ดังนี้ครับ:

GetLength(0) (มิติที่ 1 - ชั้นนอกสุด)

ใน 1D Array (int[]): คือจำนวนสมาชิกทั้งหมด (แต่ในทางปฏิบัติ Array 1 มิติ นิยมใช้คำสั่ง .Length มากกว่า)

ใน 2D Array (int[,]): คือจำนวน "แถว (Row)" เหมือนในโค้ดตัวอย่างก่อนหน้านี้ของคุณ

ใน 3D Array (int[,,]): คือจำนวน "ชั้น (Layer/Depth)" ลองนึกภาพตึกที่มีหลายๆ ชั้น

GetLength(1) (มิติที่ 2)

ใน 2D Array (int[,]): คือจำนวน "คอลัมน์ (Column)"

ใน 3D Array (int[,,]): คือจำนวน "แถว (Row)" ที่อยู่บนแต่ละชั้นของตึก

GetLength(2) (มิติที่ 3)

ใน 3D Array (int[,,]): คือจำนวน "คอลัมน์ (Column)" ที่อยู่บนแต่ละแถวของตึกอีกที
*/


Console.ReadKey();