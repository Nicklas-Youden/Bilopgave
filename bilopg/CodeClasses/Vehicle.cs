using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilopg.CodeClasses {
	internal class Vehicle {

		public string lave { get; set; }
		public string Model { get; set; }
		public string Nummerplade { get; set; }
		public string Mærke { get; set; }
		public string Størrelse { get; set; }
		public string Dato { get; set; }

		public Customer BilEjer { get; set; }

		public Vehicle(string kundeForNavn, string kundeEfternavn, string Tel)
		{
			BilEjer = new() { FirstName = kundeForNavn, LastName = kundeEfternavn, Tel = Tel };

		}
	}
}
