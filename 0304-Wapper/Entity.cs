using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0304_Wapper
{
    public interface Component
    {
        void Execute();
    }

    public class ConcreteComponent : Component
    {
        public void Execute()
        {
            Console.WriteLine("ConcreteComponent Execute");
        }
    }

    public class BaseDecorator
    {
        public Component Wapper { get; set; }

        public BaseDecorator(Component wapper)
        {
            Wapper = wapper;
        }

        public virtual void Execute()
        {
            Wapper.Execute();
        }
    }

    public class ConcreteDecorators : BaseDecorator
    {
        public ConcreteDecorators(Component wapper) : base(wapper)
        {
        }

        public override void Execute()
        {
            base.Execute();
            Extra();
        }

        private void Extra()
        {
            Console.WriteLine("ConcreteDecorators Extra");
        }
    }
}
