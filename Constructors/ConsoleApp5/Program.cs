using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // IL dasm .exe

            //Car mit = new Car
            //{
            //    _brand = "Mitsubishi",
            //    _model = "Outlander",
            //    _km = 100
            //};

            Car honda = new Car("Mitsubishi", "Outlander", 100); // calls the constructor ctor

            Console.WriteLine(honda);

            Car ferrari = new Car(100)
            {
                _model = "ferrari"
            };
           
            //honda._brand = "Honda";
            //honda._model = "Kamry";
            //honda._km = 1000;

        }
    }
}
