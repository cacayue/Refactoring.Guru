using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0103_SingleResponsibility_Single
{
    public class Employee
    {
        public string Name { get; set; }

        public string GetName()
        {
            return Name;
        }

    }

    public class TimeSheetReport
    {
        public void PrintTimeSheetReport()
        {
            Console.WriteLine("111");
        }
    }
}
