using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateChallengeTaskManagement
{
    /*
    internal class ReportTask : ITask<string>
    {
        public string ReportName { get; set; }
        public string Perform()
        {
            return $"\nReport \n{ReportName}";
        }
    }
    */
    internal class ReportTask : ITask<string>
    {
        public string ReportName { get; set; }
        public string Perform()
        {
            
            return $"\nReport: {ReportName} successfully";
        }
    }
}
