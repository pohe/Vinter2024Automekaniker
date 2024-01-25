using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinter2024Automekaniker
{
    public class CarCatalog
    {
        private List<Car> cars;

        private string _name;
        private int _cvr;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Cvr
        {
            get { return _cvr; }
            set { _cvr = value; }
        }


        public CarCatalog(string name, int cvr)
        {
            _name= name;
            _cvr = cvr;
            cars = new List<Car>();
        }


        public void AddCar(Car car)
        {
            foreach (var item in cars)
            {
                if (item.Regnr == car.Regnr)
                {
                    throw new ArgumentException("There can't be two cars with the same RegNr");
                }
            }
            cars.Add(car);
        }

        public void AddRepairToCar(string regNr, AutoRepair newAutoRepair)
        {
            foreach (var car in cars) 
            {
                if (car.Regnr == regNr)
                {
                    car.AddRepair(newAutoRepair);
                }
            }
        }

        public double TotalEarnings()
        {
            double total = 0;
            foreach (var car in cars)
            {
                total = total + car.TotalAutoRepairCost();
            }
            return total;
        }

        public override string ToString()
        {
            string returString = "";
            foreach (Car car in cars)
            {
                returString += "\t"+ car.ToString() + "\n";
            }
            return $"Owner {_name} CVR {_cvr} \n" + returString; 
        }
    }
}
