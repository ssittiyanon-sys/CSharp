namespace DateTimeT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaring Object DateTime
            DateTime datetime = new DateTime(1992, 7, 23);

            // declaring Object DateTime and hr minute second
            DateTime datetime2 = new DateTime(1992, 7, 23, 03, 45, 32);

            // Print
            Console.WriteLine($"My birthday is {datetime}");
            Console.WriteLine($"My birthday is {datetime2}");

            // write today on screen
            Console.WriteLine($"today is : {DateTime.Today}");

            // write current time on screen
            Console.WriteLine($"today is {DateTime.Now}");

            // get GetTomorrow Method return of DateTime
            DateTime tomorrow = GetTomorrow();
            Console.WriteLine($"tomorrow is {tomorrow}");

            Console.WriteLine("today is {0}", DateTime.Today.DayOfWeek);


            Console.WriteLine(GetFirstDayOfYear(1992));

            int days = DateTime.DaysInMonth(2000, 2);
            Console.WriteLine("Day in Feb 2000: {0}", days);
            days = DateTime.DaysInMonth(2001, 2);
            Console.WriteLine("Day in Feb 2001: {0}",days);
            days = DateTime.DaysInMonth(2004, 2);
            Console.WriteLine("Day in Feb 2004: {0}",days);

            DateTime now = DateTime.Now;
            Console.WriteLine("Minute: {0}",now.Minute);


            // display the time in this structure x o'clock and y minute and z seconds
            Console.WriteLine("{0} o'clock {1} minutes {2} seconds",now.Hour,now.Minute,now.Second);

            // Days passed to independent day method
            Console.WriteLine("Write a date in this format: yyyy-mm-dd");
            string input = Console.ReadLine();
            if (DateTime.TryParse(input, out datetime))
            {
                Console.WriteLine(datetime);
                TimeSpan daysPassed = now.Subtract(datetime);
                Console.WriteLine("Days passed since{0}", daysPassed.Days);
            }else
            {
                Console.WriteLine("Wrong input");
            }
            Console.ReadKey();
        }

        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }
}