using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3001HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage
            {
                _vehicls = new Vehicle[]
                {
                    new Car { _model = "Ferrari Testa Rossa", _numberOfDoors = 3, _numberOfWheels = 4 },
                    new Motorcycle { _model = "Yamaha MT09", _numberOfWheels = 2, _numberOfHandBreakes = 1},
                    new Motorcycle { _model = "Yamaha MT07", _numberOfWheels = 2},

                }
            };

            Console.WriteLine(garage);

            Car c = new Car { _model = "Ferrari Testa Rossa", _numberOfDoors = 3, _numberOfWheels = 4 };
            Motorcycle m = new Motorcycle { _model = "Yamaha MT07", _numberOfWheels = 2 };

            Console.WriteLine();
            PrintVehicle( c );

            Console.WriteLine();
            PrintVehicle( m );

            Vehicle[] myVehiclsArray = new Vehicle[]
            {
                    new Car { _model = "Ferrari Testa Rossa", _numberOfDoors = 3, _numberOfWheels = 4 },
                    new Motorcycle { _model = "Yamaha MT09", _numberOfWheels = 2, _numberOfHandBreakes = 1},
                    new Motorcycle { _model = "Yamaha MT07", _numberOfWheels = 2},

            };

            PrintVehicle(myVehiclsArray[0]);

            PrintManyVehicles( myVehiclsArray );
        }

        private static void PrintVehicle(Vehicle v)
        {
            Console.WriteLine(v);
        }

        private static void PrintManyVehicles(Vehicle[] v)
        {

            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine( v[i] );
            }
        }
    }
}
