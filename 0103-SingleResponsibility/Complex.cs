using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0103_SingleResponsibility
{
    /// <summary>
    /// 包含多个职能
    /// </summary>
    public class Employee
    {
        public string Name { get; set; }

        public string GetName()
        {
            return Name;
        }

        public void PrintTimeSheetReport()
        {
            Console.WriteLine("111");
        }
    }
}
