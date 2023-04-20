using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Interface
{
    public class Company
    {
        public void CreateSoftwave()
        {
            var des = new Designer();
            //des.Design();

            var prog = new Programmer();
            //prog.Code();

            var test = new Tester();
            //test.Test();

            var employees = new List<Employee>()
            {
                des,prog,test
            };

            foreach (var employee in employees)
            {
                employee.DoWork();
            }

            Console.WriteLine("CreateSoftwave...");
        }
    }

    public interface Employee
    {
        public void DoWork();
    }

    public class Designer: Employee
    {
        public void Design()
        {
            Console.WriteLine("Design...");
        }

        public void DoWork()
        {
            Design();
        }
    }

    public class Programmer:Employee
    {
        public void Code()
        {
            Console.WriteLine("Code...");
        }

        public void DoWork()
        {
            Code();
        }
    }

    public class Tester:Employee
    {
        public void Test()
        {
            Console.WriteLine("Test...");
        }

        public void DoWork()
        {
            Test();
        }
    }
}
