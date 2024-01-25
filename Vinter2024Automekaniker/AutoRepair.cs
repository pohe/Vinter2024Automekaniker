using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinter2024Automekaniker
{
    public class AutoRepair
    {
		private static int _counter =1; 
		private int _id;

		public int Id
		{
			get { return _id; }
		}

		private DateTime _dateTime;

		public DateTime DateTime
		{
			get { return _dateTime; }
			set { _dateTime = value; }
		}

		private string _description;

		public string Description
		{
			get { return _description; }
			set { _description = value; }
		}

		private double  _price;

		public double  Price
		{
			get { return _price; }
			set { _price = value; }
		}


		public AutoRepair(string description, double price)
        {
            _id = _counter++;
			_dateTime = DateTime.Now;
			_description = description;
			_price = price;
        }

        public override string ToString()
        {
            return $"ID {_id}  DateTime {_dateTime}  Description {_description} Price {_price}";
        }

    }
}
