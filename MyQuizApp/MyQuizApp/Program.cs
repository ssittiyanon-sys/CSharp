namespace MyQuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Question[] questions = new Question[]
            {
                new Question
                (
                    "What is the capital of Thailand ❓", //Question Text
                    new string[] {"Bankok","Berlin","London","Madrid"}, //Answer Array
                    0 // CorrectAnswerIndex
                ),
                new Question
                (
                    "What is 2+2 🤔",
                    new string[] {"1","2","3","4"},
                    3
                )
            };
            Quiz myQuiz = new Quiz(questions);
            myQuiz.StartQuiz();
            Console.ReadLine();
        }
    }
}
