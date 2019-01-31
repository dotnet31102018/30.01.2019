using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Car
    {
        public string _brand;
        public string _model;
        public int _km;

        public Car(int km)
        {
            _km = km;
        }

        public Car(string brand, string model, int km = 0)
        {
            _brand = brand;
            _model = model;
            _km = km;
        }

        public int TellMeTheKM()
        {
            return _km;
        }

        public override string ToString()
        {
            return $"Car Brand : {_brand} Model : {_model} KM : {_km}";
        }

    }
}
