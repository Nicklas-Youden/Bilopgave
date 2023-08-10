using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;


namespace bilopg.CodeClasses {
	internal class Customer {
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public string Phone { get; set; }
		public record Kontraktinfo(string firstName, string lastName);
		public Kontraktinfo BilEjerKontaktInfo { get; set; }
		public List<Vehicle> bil { get; } = new List<Vehicle>();

		public Customer()
		{
			BilEjerKontaktInfo = new Kontraktinfo(FirstName, LastName);

		}
	}
}
