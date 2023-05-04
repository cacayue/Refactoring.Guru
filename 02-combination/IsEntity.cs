using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_combination
{

    /// <summary>
    /// 多层级类嵌套，子类数量爆炸
    /// </summary>
    public class Transport
    {
       
    }

    public class Car: Transport
    {
    }

    public class ElectricCar: Car
    {

    }

    public class CombustionCar: Car
    {

    }

    public class AutopilotElectricCar: ElectricCar
    {

    }

    public class ManualCombustionCar: CombustionCar
    {

    }
}
