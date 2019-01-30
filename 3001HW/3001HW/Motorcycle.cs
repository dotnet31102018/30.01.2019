using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3001HW
{
    class Motorcycle : Vehicle
    {
        public int _numberOfHandBreakes = 2;

        public override int GetMaxNumberOfPassengers()
        {
            return 2;
        }

        public override int GetMaxSpeed()
        {
            return 320;
        }

        public override string ToString()
        {
            return $"Motorcycle Number of hand breakes : {_numberOfHandBreakes} {base.ToString()}";
        }
    }
}
