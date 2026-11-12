using System.Security.Cryptography.X509Certificates;

namespace DelegateChallengeTaskManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            EmailTask emailTask = new EmailTask();
            ReportTask reportTask = new ReportTask();

            emailTask.Recipient = "jeff@hotmail.com";
            emailTask.Message = "Hello Jeff";

            reportTask.ReportName = "Monthly Payments";

            TaskProcessor<EmailTask, string>
                emailProcessor = new TaskProcessor<EmailTask, string>(emailTask);

            TaskProcessor<ReportTask, string>
                reportProcessor = new TaskProcessor<ReportTask, string>(reportTask);

            Console.WriteLine(emailProcessor.Execute());
            Console.WriteLine(reportProcessor.Execute());

            */
            var emailTask = new EmailTask()
            {
                Message = "Hello",
                Recipient = "jeff@example.com"
            };

            var reportTask = new ReportTask()
            {
                ReportName = "Test"
            };

            var emailProcessor = new TaskProcessor<EmailTask, string>(emailTask);
            var reportProcessor = new TaskProcessor<ReportTask, string>(reportTask);

            Console.WriteLine(emailProcessor.Execute());
            Console.WriteLine(reportProcessor.Execute()); 

            Console.ReadKey();
        }
    }
}
