namespace ConstraintesForGenericsClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Box<int> boxInt = new Box<int>();
            //generic ที่เป็นแบบอื่นยกเว้น class ไม่สามารถใช้ได้

            Box<Book> bookBox = new Box<Book>();
        }
    }
    class Book
    {

    }
}
