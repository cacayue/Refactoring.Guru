using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Interface
{
    public abstract class CompanyAbstract
    {
        public abstract IEnumerable<Employee> GetEmployee();
        public void CreateSoftwave()
        {
            var employees = GetEmployee();
            foreach (var employee in employees)
            {
                employee.DoWork();
            }

            Console.WriteLine("CreateSoftwave...");
        }
    }

    public class Company: CompanyAbstract
    {

        public override IEnumerable<Employee> GetEmployee()
        {
            return new List<Employee>()
            {
                new Designer(),new Programmer(),new Tester()
            };
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
