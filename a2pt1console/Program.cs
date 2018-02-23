using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;

namespace a2pt1console
{

    class Program
    {
       
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
           

            Activity workflow1 = new Workflow1();
            WorkflowInvoker.Invoke(workflow1);
        }
    }
}
