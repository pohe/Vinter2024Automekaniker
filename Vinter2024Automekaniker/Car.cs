using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinter2024Automekaniker
{
    public class Car
    {
		private Dictionary<int, AutoRepair> _autoRepairs; 

		private string _regNr;
        private int _year;
        private string _make;
        private string _model;
        private int _milage;

        public string Regnr
		{
			get { return _regNr; }
			set { _regNr = value; }
		}

		public int Year
		{
			get { return _year; }
			set { _year = value; }
		}


		public string Make
		{
			get { return _make; }
			set { _make = value; }
		}

		

		public string Model
		{
			get { return _model; }
			set { _model = value; }
		}

		
		public int Milage
		{
			get { return _milage; }
			set { _milage = value; }
		}

        public Owner Owner { get; set; }

        public Car(string regNr, int year, string make, string model, int milage)
        {
			if (regNr.Length != 7)
				throw new ArgumentException("Registreringsnummer skal være på nøjagtig 7 karakterer");
            _regNr = regNr;
			_year = year;
			_make = make;
			_model = model;
			_milage = milage;
            _autoRepairs = new Dictionary<int, AutoRepair>();
        }

        public Car(string regNr, int year, string make, string model, int milage, Owner owner): this(regNr, year, make, model, milage)
        {
            Owner = Owner;
        }


		public void AddOwner(Owner owner)
		{
            Owner = Owner;
        }
        public void AddRepair(AutoRepair autoRepair)
		{
			if (_autoRepairs.ContainsKey(autoRepair.Id))
				_autoRepairs.Add(autoRepair.Id, autoRepair);
		}

        public double TotalAutoRepairCost()
        {
			double totalCost = 0;
            foreach (var item in _autoRepairs.Values)
            {
				totalCost += item.Price;
            }
			return totalCost;
        }
        public override string ToString()
		{
			string repairString = ""; 
			foreach(AutoRepair autoRepair in _autoRepairs.Values )
			{
                repairString += "\n\t\t" + autoRepair.ToString();
			}
			return $"Car RegNr {_regNr} Year {_year} Make {_make} Model {_model} Milage {_milage}   {repairString}"  ;
		}

    }
}
