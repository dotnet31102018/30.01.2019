using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3001HW
{
    class Garage
    {
        public Vehicle[] _vehicls;

        public override string ToString()
        {
            string result = $"Class Garage. Number of vehicls : {_vehicls.Length}\n";

            for (int i = 0; i < _vehicls.Length; i++)
            {
                result = result + _vehicls[i].ToString() + "\n";
            }

            return result;
        }
    }
}
