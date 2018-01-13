using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _051_operator_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskList tasks1 = new TaskList("My Tasks");
            tasks1.Add("Wake Up");
            tasks1.Add("Sleep");
            tasks1.Print();

            TaskList tasks2 = new TaskList("More Tasks");
            tasks2.Add("Dream");
            tasks2.Add("Wake Up");
            tasks2.Add("Make Coffee");
            tasks2.Print();

            TaskList tasks3 = tasks1 + tasks2;
            tasks3.Print();

            TaskList tasks4 = new TaskList("Forbidden Tasks");
            tasks4.Add("Sleep");
            tasks4.Add("Dream");
            tasks4.Print();

            tasks3 -= tasks4;
            tasks3.Print();

            Console.ReadKey();
        }
    }
}
