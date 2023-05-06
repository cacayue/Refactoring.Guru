using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0203_Builder
{
    #region Entity

    public class Car
    {
        public int Seats { get; set; }

        public string Engine { get; set; } = "";

        public bool GPS { get; set; }
        public bool TripComputer { get; set; }

        public override string ToString()
        {
            return $"this car is {this.Engine},Seats {Seats}, GPS：{this.GPS},TripComputer:{TripComputer} ";
        }

    }

    public class CarManual
    {
        public int Seats { get; set; }

        public string Engine { get; set; } = "";

        public bool GPS { get; set; }

        public bool TripComputer { get; set; }

        public override string ToString()
        {
            return $"this manual is {this.Engine},Seats {Seats}, GPS：{this.GPS},TripComputer:{TripComputer} ";
        }
    }

    #endregion

    #region Builder

    public interface Builder
    {
        public Builder Reset();

        public Builder SetSeats(int number);

        public Builder SetEngine(string engine);

        public Builder SetTripComputer();

        public Builder SetGPS();

    }


    public class CarBuilder : Builder
    {
        private Car Car { get; set; } = new Car();

        public Builder Reset()
        {
            Car = new Car();
            return this;
        }

        public Builder SetEngine(string engine)
        {
            Car.Engine = engine;
            return this;
        }

        public Builder SetGPS()
        {
            Car.GPS = true;
            return this;
        }

        public Builder SetSeats(int number)
        {
            Car.Seats = number;
            return this;
        }

        public Builder SetTripComputer()
        {
            Car.TripComputer = true;
            return this;
        }

        public Car GetResult()
        {
            return Car;
        }
    }

    public class CarManualBuilder : Builder
    {
        private CarManual CarManual { get; set; } = new CarManual();

        public Builder Reset()
        {
            CarManual = new CarManual();
            return this;
        }

        public Builder SetEngine(string engine)
        {
            CarManual.Engine = engine;
            return this;
        }

        public Builder SetGPS()
        {
            CarManual.GPS = true;
            return this;
        }

        public Builder SetSeats(int number)
        {
            CarManual.Seats = number;
            return this;
        }

        public Builder SetTripComputer()
        {
            CarManual.TripComputer = true;
            return this;
        }

        public CarManual GetResult()
        {
            return CarManual;
        }
    }

    #endregion

    #region Director

    public class Director
    {
        public void MakeSUV(Builder builder)
        {
            builder.Reset()
                .SetSeats(2)
                .SetEngine("SUV")
                .SetGPS();
        }

        public void MakeSportsCar(Builder builder)
        {
            builder.Reset()
                .SetSeats(3)
                .SetEngine("SportsCar")
                .SetTripComputer();
        }
    }

    #endregion
}
