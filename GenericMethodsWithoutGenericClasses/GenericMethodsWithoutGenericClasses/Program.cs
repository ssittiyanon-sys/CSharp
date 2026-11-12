namespace GenericMethodsWithoutGenericClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            
            logger.Log<int>(10);
            logger.Log<string>("Jeffrey");

            // ในฐานะที่เป็น generic ไม่ต้องใส่ <> ก็ได้ ให้ C# เดาเอาเอง
            // แต่ถ้าเอาจริงต้องทำให้มันชัดเจนแบบอันบน
            logger.Log(22);
            logger.Log("Hi");

            logger.Log(new {Name = "Jeff", Age = 30});


            Console.ReadKey();

        }
    }
}
