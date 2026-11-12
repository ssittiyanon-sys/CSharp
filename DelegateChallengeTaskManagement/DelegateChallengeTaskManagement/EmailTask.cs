using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateChallengeTaskManagement
{
    /*
    internal class EmailTask : ITask<string>
    {
        public string Recipient { get; set; }
        public string Message { get; set; }

        public string Perform()
        {
            return $"Sending an email to: \n{Recipient} \n\nMessage: \n{Message}";
        }

    }
    */
    internal class EmailTask : ITask<string>
    {
        public string Message { get; set; }
        public string Recipient { get; set; }
        public string Perform()
        {
            return $"To: {Recipient} \nMessage : {Message}";
        }
    }
}
