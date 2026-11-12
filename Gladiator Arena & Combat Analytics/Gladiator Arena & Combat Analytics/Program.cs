/*
🎒 โปรเจกต์ที่ 1: Gladiator Arena & Combat Analytics (สาย Game Dev + Data Science)
คอนเซปต์: เกมต่อสู้แบบ Turn-based สลับกันโจมตีระหว่างผู้กล้ากับมอนสเตอร์ แต่ตอนจบเกมต้องมีหน้าจอวิเคราะห์สถิติตามวิถีนักวิเคราะห์ข้อมูล!

สิ่งที่ท่านจะได้ฝึกฝน: การใช้ ref, Arrays, Loop, และอัลกอริทึมหาค่าสูงสุด/ความถี่ (ที่ท่านเพิ่งเขียนผ่านมา)

ข้อกำหนดของระบบ:

มีตัวแปรพลังชีวิต playerHP และ monsterHP ตั้งต้น

สร้างฟังก์ชัน PlayerTurn(ref int monsterHP, out string actionUsed) และ MonsterTurn(ref int playerHP)

ในแต่ละเทิร์น ผู้เล่นสามารถเลือกคำสั่งได้ 3 แบบ (เช่น โจมตีธรรมดา, ใช้เวทมนตร์, ร่ายฮีล) ให้สุ่มดาเมจตามความเหมาะสม

ระบบจดบันทึก (Analytics): ต้องสร้าง Array มารับข้อมูลเก็บไว้ทุกเทิร์นว่า ผู้เล่นทำดาเมจได้เท่าไหร่ และ ใช้คำสั่งอะไรไปบ้าง

หน้าจอสรุปผล: เมื่อมีฝ่ายใดฝ่ายหนึ่ง HP เหลือ 0 ให้จบเกม แล้วแสดงสถิติ:

ดาเมจรวมทั้งหมดที่ทำได้

ดาเมจเฉลี่ยต่อเทิร์น

ดาเมจที่แรงที่สุดในหนึ่งเทิร์น (หาค่า Max)

คำสั่งที่ผู้เล่นกดใช้บ่อยที่สุด (หาความถี่แบบ My Style ที่ท่านคิดค้นขึ้นมา!)

💀 โปรเจกต์ที่ 2: Fallout Terminal Cyber-Hacker (สาย Darkside Hacker + Logic)
คอนเซปต์: จำลองระบบเจาะเข้ารหัสคอมพิวเตอร์เมนเฟรม (อ้างอิงจากมินิเกมแฮกเทอร์มินอลในเกม Fallout) ผู้เล่นต้องเดาคำรหัสลับให้ถูกต้องภายในโอกาสที่จำกัด!

สิ่งที่ท่านจะได้ฝึกฝน: การจัดการข้อความ (String Manipulation), ลูปซ้อนลูป (Nested Loops), และเงื่อนไขที่ซับซ้อน

ข้อกำหนดของระบบ:

กำหนดคำรหัสลับความยาว 4 ตัวอักษรเอาไว้ในระบบ (เช่น "CODE")

ให้ระบบแสดงรายการคำใบ้มา 5 คำบนหน้าจอ (โดย 1 ในนั้นต้องมีคำที่ถูกต้อง และคำอื่นๆ ต้องยาว 4 ตัวอักษรเหมือนกัน เช่น "COOL", "MODE", "FIRE", "GATE")

ผู้เล่นมีโอกาสพิมพ์เดาได้ 4 ครั้ง

ระบบตรวจจับช่องโหว่: ทุกครั้งที่ผู้เล่นพิมพ์คำใบ้ผิด ระบบต้องใช้ลูปเพื่อตรวจเช็คว่า "มีตัวอักษรในตำแหน่งที่ตรงกับรหัสลับเป๊ะๆ กี่ตัว" แล้วแจ้งให้ผู้เล่นทราบ

ตัวอย่าง: ถ้ารหัสลับคือ "CODE" แล้วผู้เล่นเดาว่า "MODE" -> ระบบต้องแจ้งว่า Likelihood=3/4 (เพราะ O, D, E ตรงตำแหน่ง)

ถ้าเดาถูกใน 4 ครั้งให้แสดงคำว่า [ACCESS GRANTED] 🟩 ถ้าหมดสิทธิ์ก่อนให้แสดง [TERMINAL LOCKED] 🟥

🏰 โปรเจกต์ที่ 3: Deep Dungeon Crawler (สาย Game Dev ขั้นสูง + โลจิกดั้งเดิม)
คอนเซปต์: เกมจำลองการเดินลุยเข้าไปในเขาวงกตใต้ดินที่ลึกขึ้นเรื่อยๆ ยิ่งลึกยิ่งอันตราย เพื่อค้นหาศิลาเวทมนตร์ระดับตำนาน

สิ่งที่ท่านจะได้ฝึกฝน: Recursion (การเรียกซ้ำ) และตัวปรับแต่งพารามิเตอร์ out

ข้อกำหนดของระบบ:

สร้างฟังก์ชันสำหรับลุยดันเจี้ยนแบบเรียกใช้ตัวเอง: static void DiveIntoDungeon(int currentDepth, out string finalLoot)

ในแต่ละชั้น (Depth) ให้สุ่มเหตุการณ์ (เช่น เจอหน้าผา, เจอหีบสมบัติ, เจอทางแยก) และให้ผู้เล่นเลือกว่าจะเดินหน้าลุยต่อ หรือพอแค่นี้แล้วถอยกลับ

เงื่อนไขการใช้ Recursion: * Recursive Case: ถ้าผู้เล่นเลือกเดินหน้าต่อ และยังไม่ตาย ให้ฟังก์ชันเรียกตัวเองขยับไปชั้นถัดไป DiveIntoDungeon(currentDepth + 1, out finalLoot);

Base Case (จุดหยุด): ถ้าผู้เล่นเลือกถอยกลับ, พลังชีวิตหมด, หรือเดินทางไปถึงชั้นที่ 5 (ชั้นลึกสุด) ให้ระบบหยุดทำงานทันที

การส่งไอเทมกลับ: เมื่อฟังก์ชันชน Base Case (ไม่ว่าจะจบแบบไหน) ให้ใช้ out finalLoot ปั้นชื่อไอเทมที่ระลึกที่ได้จากชั้นนั้นๆ (เช่น เศษหิน, ดาบโบราณ, หรือศิลาเวทมนตร์) ส่งกลับไปปริ้นท์แสดงความยินดีที่ประตู Main

*/

namespace Gladiator_Arena___Combat_Analytics
{
    internal class Program
    {
        static string playerName = "";
        static string[] playerSkill = ["Normal Attack", "Magic Attack", "Defense"];
        static float playerHPBase = 100;
        static float playerHPCurrent = 100;
        static string[] monstersName = ["Slime", "Goblin", "Orc", "Gargoy", "Dragon"];
        static float[] monstersHPBase = [45,55,65,75,85];
        static string monsterNameCurrent = "";
        static int currentMonsterIndex = 0;
        static float monsterHPCurrent;
        static float[] monstersATKBase = [5, 10, 15, 20, 35];
        static string action = "";
        static Random random = new Random();

        // 📦 กระเป๋าเก็บสถิติ เผื่อไว้สูงสุด 100 เทิร์น
        static int[] damageHistory = new int[100];
        static string[] actionHistory = new string[100];
        static int turnCount = 0; // ตัวนับเทิร์นปัจจุบัน

        /*
        static string[] randomEvent = ["Found a Monster","Found a Treasure","Found a Heal Potion","Found a Mana Potion"];
        static string[] selectedEvent = [""];
        */
        static void Main(string[] args)
        {
            /*
            🎒 โปรเจกต์ที่ 1: Gladiator Arena & Combat Analytics (สาย Game Dev + Data Science)
            คอนเซปต์: เกมต่อสู้แบบ Turn-based สลับกันโจมตีระหว่างผู้กล้ากับมอนสเตอร์ แต่ตอนจบเกมต้องมีหน้าจอวิเคราะห์สถิติตามวิถีนักวิเคราะห์ข้อมูล!

            สิ่งที่ท่านจะได้ฝึกฝน: การใช้ ref, Arrays, Loop, และอัลกอริทึมหาค่าสูงสุด/ความถี่ (ที่ท่านเพิ่งเขียนผ่านมา)

            ข้อกำหนดของระบบ:
            มีตัวแปรพลังชีวิต playerHP และ monsterHP ตั้งต้น
            สร้างฟังก์ชัน PlayerTurn(ref int monsterHP, out string actionUsed) และ MonsterTurn(ref int playerHP)
            ในแต่ละเทิร์น ผู้เล่นสามารถเลือกคำสั่งได้ 3 แบบ (เช่น โจมตีธรรมดา, ใช้เวทมนตร์, ร่ายฮีล) ให้สุ่มดาเมจตามความเหมาะสม
            ระบบจดบันทึก (Analytics): ต้องสร้าง Array มารับข้อมูลเก็บไว้ทุกเทิร์นว่า ผู้เล่นทำดาเมจได้เท่าไหร่ และ ใช้คำสั่งอะไรไปบ้าง
            หน้าจอสรุปผล: เมื่อมีฝ่ายใดฝ่ายหนึ่ง HP เหลือ 0 ให้จบเกม แล้วแสดงสถิติ:
            ดาเมจรวมทั้งหมดที่ทำได้
            ดาเมจเฉลี่ยต่อเทิร์น
            ดาเมจที่แรงที่สุดในหนึ่งเทิร์น (หาค่า Max)
            คำสั่งที่ผู้เล่นกดใช้บ่อยที่สุด (หาความถี่แบบ My Style ที่ท่านคิดค้นขึ้นมา!)
            */
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Hello, Adventurer!");
            EnterPlayerName();
            Console.WriteLine($"=== ⚔️ Welcome to the Arena! ⚔️ ===");
            MonsterAppeared();
            Console.WriteLine($"=== Your HP ===\n(Player HP {playerHPBase})");
            FightingScene();
            Console.ReadLine();
        }
        static void EnterPlayerName()
        {
            while (string.IsNullOrWhiteSpace(playerName))
            {
                Console.WriteLine("Tell me your Name?");
                playerName = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(playerName))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error! The system not allow 'Empty Name'");
                    Console.ResetColor();
                }
            }
            Console.WriteLine($"Welcome {playerName} to the Adventure!");
        }
        static void MonsterAppeared()
        {
            int roll = random.Next(1, 101);
            currentMonsterIndex = 0;
            if (roll <= 50)
            {
                currentMonsterIndex = 0;
            }
            else if (roll <= 80)
            {
                currentMonsterIndex = 1;
            }
            else if(roll <= 90)
            {
                currentMonsterIndex = 2;
            }
            else if ( roll <= 97)
            {
                currentMonsterIndex = 3;
            }
            else
            {
                currentMonsterIndex = 4;
            }

            monsterNameCurrent = monstersName[currentMonsterIndex];
            monsterHPCurrent = monstersHPBase[currentMonsterIndex];
            Console.WriteLine($"🎲 Now we roll {roll}\nBehold!! the monster {monsterNameCurrent} appeared!!\n=== Monster HP ===\n(Monster HP : {monsterHPCurrent})");
        }
        static void FightingScene()
        {
            while(playerHPCurrent > 0 && monsterHPCurrent > 0)
            {
                Console.WriteLine($"\n🛡️ Player {playerName} HP {playerHPCurrent}/{playerHPBase}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Choose your action: (1) Attack (2) Magic Attack (3) Defend");
                Console.Write("Your command: ");
                action = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(action) || (action != "1" && action != "2" && action != "3"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("❌ Invalid command! Please press 1 , 2 or 3");
                    Console.ResetColor();
                    continue; // Skip the code below and instantly restart the loop
                }
                else
                {
                    // ⚔️ ผู้เล่นโจมตี และส่งค่าดาเมจกลับมาเก็บไว้ในตัวแปรตัวแปรหนึ่ง
                    int dmgDealt = PlayerAttackLogic(action);

                    // 🌟 ระบบ Analytics ทำงาน: จดบันทึกสถิติลง Array ประจำเทิร์นนั้นๆ
                    // (แปลงเลขคำสั่งเป็นชื่อสกิลสวยๆ จากตัวแปร playerSkill ที่ตั้งไว้)
                    actionHistory[turnCount] = playerSkill[int.Parse(action) - 1];
                    damageHistory[turnCount] = dmgDealt > 0 ? dmgDealt : 0; // ถ้าดาเมจติดลบ (ร่ายพลาด) ให้บันทึกเป็น 0 ดาเมจต่อมอนสเตอร์

                    turnCount++; // ขยับไปเทิร์นถัดไป

                    if (monsterHPCurrent > 0)
                    {
                        Console.WriteLine("\n😈 Monster Turn: ");
                        MonsterAttackLogic();
                    }
                }

            }
            Console.WriteLine("--------------------------------------------------");
            if (playerHPCurrent > 0 && monsterHPCurrent <= 0)
            {
                Console.WriteLine($"🏆 Victory! The Monster {monstersName[currentMonsterIndex]} Eliminated by {playerName}!!");
            }
            else if (playerHPCurrent <= 0 && monsterHPCurrent > 0)
            {
                Console.WriteLine($"☠️☠️☠️ You're DEATH {playerName} ☠️☠️☠️");
            }
            ShowBattleAnalytics();
        }
        static int PlayerAttackLogic(string choice)
        {
            int roll = 0;

            switch (choice)
            {
                // 🗡️ Normal Attack
                case "1":
                    Console.WriteLine("\n🔪 You choose to attack the monster physically!");
                    roll = random.Next(0, 36); // 🛠️ แก้ให้สุ่มถึง 35 เพื่อให้คริติคอล (>= 30) ทำงานได้!

                    if (roll >= 30)
                    {
                        Console.WriteLine($"💥 CRITICAL HIT! {playerName} smashed the monster!");
                        Console.WriteLine($"Damage dealt: {roll}");
                        monsterHPCurrent -= roll;
                    }
                    else if (roll >= 10)
                    {
                        Console.WriteLine($"⚔️ {playerName} hit the monster!");
                        Console.WriteLine($"Damage dealt: {roll}");
                        monsterHPCurrent -= roll;
                    }
                    else if (roll >= 1)
                    {
                        Console.WriteLine($"💨 {playerName} hit the monster, but only grazed its skin!");
                        Console.WriteLine($"Damage dealt: {roll}");
                        monsterHPCurrent -= roll;
                    }
                    else
                    {
                        Console.WriteLine($"❌ {playerName} try to hit the monster but it dodged! You missed!");
                        Console.WriteLine($"Damage dealt: {roll}"); // ดาเมจ 0
                    }
                    break;

                // 🌠 Magic Attack
                case "2":
                    Console.WriteLine($"\n🌠 {playerName} choose the risky path and cast a spell!");
                    roll = random.Next(-15, 56);

                    if (roll >= 30)
                    {
                        Console.WriteLine($"🌟 MAGIC CRITICAL! {playerName} cast spell obliterates the monster!");
                        Console.WriteLine($"Damage dealt: {roll}");
                        monsterHPCurrent -= roll;
                    }
                    else if (roll > 0) // 🛠️ รวบเงื่อนไขที่ว่างเปล่าเข้าด้วยกัน
                    {
                        Console.WriteLine($"✨ {playerName}'s magic hits the monster!");
                        Console.WriteLine($"Damage dealt: {roll}");
                        monsterHPCurrent -= roll;
                    }
                    else if (roll == 0)
                    {
                        Console.WriteLine("💨 The magic fizzles out... It only grazed the monster!");
                        Console.WriteLine($"Damage dealt: {roll}");
                    }
                    else
                    {
                        // 🛠️ กรณีติดลบ (เช่น -15)
                        Console.WriteLine($"💥 BACKFIRE! The monster attacks {playerName} while you are casting!");
                        // หักเลือดตัวเอง (ใช้ += เพราะ roll เป็นค่าติดลบอยู่แล้ว)
                        playerHPCurrent += roll;
                        Console.WriteLine($"{playerName} take damage: {Math.Abs(roll)}"); // Math.Abs ช่วยเปลี่ยนตัวเลข -15 ให้แสดงผลเป็น 15 สวยๆ
                    }
                    break;

                // 🛡️ Defend
                case "3":
                    Console.WriteLine($"\n🛡️ {playerName} choose to defend against the monster!");
                    roll = random.Next(-5, 36);

                    if (roll > 0)
                    {
                        Console.WriteLine($"⚔️ PARRY! {playerName} successfully blocked and counter-attacked!");
                        Console.WriteLine($"Counter damage dealt: {roll}");
                        monsterHPCurrent -= roll;
                    }
                    else if (roll == 0)
                    {
                        Console.WriteLine($"🛡️ {playerName} perfectly defended against the monster's attack!");
                    }
                    else
                    {
                        // 🛠️ กรณีติดลบ
                        Console.WriteLine("💥 GUARD BREAK! The attack was too heavy to defend!");
                        playerHPCurrent += roll; // ใช้ += เพื่อเอาค่าติดลบไปลดเลือด
                        Console.WriteLine($"{playerName} take damage: {Math.Abs(roll)}");
                    }
                    break;
            }
            return roll;
        }
        static void MonsterAttackLogic()
        {
            // ดึงชื่อและพลังโจมตีของมอนสเตอร์ตัวปัจจุบันออกมาจากกระเป๋า
            string mName = monstersName[currentMonsterIndex];
            float baseAtk = monstersATKBase[currentMonsterIndex];

            Console.WriteLine($"\n👹 Turn of [{mName}]!");

            // บรรยายท่าโจมตีตามประเภทมอนสเตอร์ (ใส่ลูกเล่นเกมเพลย์)
            switch (currentMonsterIndex)
            {
                case 0: // Slime
                    Console.WriteLine($"💧 {mName} bounces and slams into you!");
                    break;
                case 1: // Goblin
                    Console.WriteLine($"🗡️ {mName} quickly stabbed you with a rusty knife!");
                    break;
                case 2: // Orc
                    Console.WriteLine($"🪓 {mName} swung the giant axe down wildly, hacking at it!");
                    break;
                case 3: // Gargoy
                    Console.WriteLine($"🪨 {mName} It swooped down from the sky and struck with its stone claws!");
                    break;
                case 4: // Dragon
                    Console.WriteLine($"🔥 {mName} It spewed forth a torrent of fire, incinerating everything!");
                    break;
            }

            // 🎲 สุ่มความแกว่งของดาเมจ (ดาเมจไม่ควรตายตัว)
            // สุ่มตั้งแต่ -5 ถึง +10 เพื่อเอาไปบวกกับ Base ATK
            int damageRoll = random.Next(-5, 11);
            float finalDamage = baseAtk + damageRoll;

            // 🛡️ ป้องกันบั๊กดานเมจติดลบ (ถ้าสุ่มแล้ว finalDamage น้อยกว่า 0 ให้กลายเป็น 0)
            if (finalDamage < 0)
            {
                finalDamage = 0;
            }

            // ลดเลือดผู้เล่น
            playerHPCurrent -= finalDamage;

            if (finalDamage == 0)
            {
                Console.WriteLine($"💨 {playerName} dodged the attack from {mName} perfectly!");
            }
            else
            {
                Console.WriteLine($"💥 {playerName} got attacked! lose HP: {finalDamage}");
            }
        }
        static void ShowBattleAnalytics()
        {
            Console.WriteLine("\n📊 === BATTLE ANALYTICS ===");

            // ดักเงื่อนไขเผื่อเกิดบั๊กไม่มีการต่อสู้เลย
            if (turnCount == 0)
            {
                Console.WriteLine("Theres no fighting here!");
                return;
            }

            int totalDamage = 0;
            int maxDamage = 0;

            // 🐎 ม้าวิ่งรอบที่ 1: หาดาเมจรวม (Total) และดาเมจสูงสุด (Max)
            for (int i = 0; i < turnCount; i++) // วิ่งถึงแค่จำนวนเทิร์นที่ต่อสู้จริง
            {
                totalDamage += damageHistory[i]; // บวกสะสมดาเมจ

                if (damageHistory[i] > maxDamage)
                {
                    maxDamage = damageHistory[i]; // อัปเดตแชมป์ดาเมจ
                }
            }

            // 🪄 คำนวณค่าเฉลี่ย (ต้องแปลงเป็น double ก่อนหาร เพื่อให้มีทศนิยม)
            double averageDamage = (double)totalDamage / turnCount;

            // ⚔️ วิชาดาบ My Style: หาคำสั่งที่ใช้บ่อยที่สุด (Most Frequent Action)
            int maxActionCount = 0;
            string mostUsedAction = actionHistory[0]; // สมมติให้คำสั่งแรกเป็นแชมป์ไปก่อน

            for (int i = 0; i < turnCount; i++)
            {
                int currentCount = 0;
                for (int j = 0; j < turnCount; j++)
                {
                    if (actionHistory[j] == actionHistory[i])
                    {
                        currentCount++;
                    }
                }

                if (currentCount > maxActionCount)
                {
                    maxActionCount = currentCount;
                    mostUsedAction = actionHistory[i];
                }
            }

            // 🖨️ แสดงผลลัพธ์ทั้งหมดออกสู่หน้าจอ
            Console.WriteLine($"⏳ Total turn: {turnCount} turn");
            Console.WriteLine($"💥 Total damage: {totalDamage} point");
            Console.WriteLine($"📈 Average damage per turn: {averageDamage:F1} point"); // :F1 คือเอาทศนิยม 1 ตำแหน่ง
            Console.WriteLine($"🔥 Damage dealt (Max): {maxDamage} point");
            Console.WriteLine($"⭐ Most used action: [{mostUsedAction}] (used {maxActionCount} times)");
            Console.WriteLine("=============================================\n");
        }
    }
}
