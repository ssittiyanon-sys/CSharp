using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateChallengeTaskManagement
{
    /*
    internal interface ITask<TResult>
    {
        //add one method named Perform that returns a Type T
        TResult Perform();
    }
    */
    internal interface ITask<TResult>
    {
        TResult Perform();
    }

}