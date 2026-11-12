namespace FuncGenericDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Action เป็น void ไม่สามารถ return อะไรได้ มีแค่ขาเข้า
            // Action = ผู้ลงมือทำ
            /*
            Action action = () =>
            {
                Console.WriteLine("Jeff Func");
            };
            var result = action(); //error
            */

            // Func มีทั้งขาเข้า และขาออก มี return
            // Func = ผู้ส่งมอบผลลัพธ์
            Func<string> getName = () =>
            {
                return "Jeffrey Func";
            };

            var myName = getName();
            Console.WriteLine(myName);

            // Provide Func int
            Func<int, int, string> sum = (x, y) => //int ตัวที่ 3 คือ return type
            {
                //ได้หลายแบบ ถ้าตัวสุดท้ายเป็น int ก็ไม่จำเป็นต้องทำเป็น string
                //return (x + y).ToString(); 

                //หรือถ้ามีข้อความแล้วก็ไม่จำเป็นต้องมี .ToString();
                //return "your result is " + (x + y); 

                // To be Obvoius ใช้แบบนี้ดีกว่า
                return "your result is " + (x + y).ToString();
            };

            Console.WriteLine(sum(3,5));


            Console.ReadKey();
        }

        string GetName()
        {
            return "KKK";
        }
    }
}
