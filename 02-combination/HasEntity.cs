using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_combination.Has
{
    /// <summary>
    /// 只包含接口，方面扩展不同实现
    /// </summary>
    public abstract class Transport
    {
        public IEngine Engine { get; set; }
        public IDriver Driver { get; set; }

        public virtual void Deliver(IEngine destination, IDriver cargo)
        {
            Engine = destination;
            Driver = cargo;
        }
    }

    public interface IEngine
    {
        public void Move();
    }

    public interface IDriver
    {
        public void Navigate();
    }

    public class ElectricEngine: IEngine
    {
        public void Move()
        {
            Console.WriteLine("Electric Engine");
        }
    }

    public class CombustionEngine : IEngine
    {
        public void Move()
        {
            Console.WriteLine("Combustion Engine");
        }
    }

    public class Robot : IDriver
    {
        public void Navigate()
        {
            Console.WriteLine("Robot Driver");
        }
    }

    public class Human : IDriver
    {
        public void Navigate()
        {
            Console.WriteLine("Human Driver");
        }
    }
}
