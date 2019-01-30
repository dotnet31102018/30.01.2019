using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3001HW
{
    abstract class Vehicle
    {
        public int _numberOfWheels;
        public string _model;

        public abstract int GetMaxNumberOfPassengers();
        public abstract int GetMaxSpeed();

        public override string ToString()
        {
            return $"Max number of passengers : {GetMaxNumberOfPassengers()} Max speed : {GetMaxSpeed()} \nNumber of wheels : {_numberOfWheels} Model : {_model}";
        }
    }
}
