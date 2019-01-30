using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3001HW
{
    class Car : Vehicle
    {
        public int _numberOfDoors;

        public override int GetMaxNumberOfPassengers()
        {
            return 4;
        }

        public override int GetMaxSpeed()
        {
            return 200;
        }

        public override string ToString()
        {
            return $"Car Number of doors : {_numberOfDoors} {base.ToString()}";
        }
    }
}
