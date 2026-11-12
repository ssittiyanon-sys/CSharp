namespace EnumsC
{
    enum Day { Mon,Tue,Wed,Thu,Fri,Sat,Sun}
    enum Month { Jan = 1,Feb,Mar,Apr,May,Jun,Jul =12,Aug,Sep,Oct,Nov,Dec}
    internal class Program
    {
        static void Main(string[] args)
        {
            Day fr = Day.Fri;
            Day su = Day.Sun;
            Day a = Day.Fri;
            Console.WriteLine(fr==a);
            Console.WriteLine(fr == su);
            Console.WriteLine(Day.Mon);
            Console.WriteLine((int)Day.Mon);
            Console.WriteLine(Month.Jan);
            Console.WriteLine((int)Month.Jan);
            Console.WriteLine((int)Month.Jun);
            Console.WriteLine((int)Month.Jul);
            Console.WriteLine((int)Month.Aug);
            Console.ReadKey();
        }
    }
}
