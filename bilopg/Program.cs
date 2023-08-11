
class Program
{
    static void Main(string[] args)
    {
        List<Customer> customers = new List<Customer>();

        bool running = true;
        while (running)
        {
			// Viser registeret kunder + tæller
			Console.WriteLine("Registrerede kunder med nummerplade:");

			// Gennemløb hver registrerede kunde
			for(int i = 0; i < customers.Count; i++)
			{
				// Gennemløb hver bil for den nuværende kunde
				foreach(var car in customers[i].bil)
				{
					// Viser registeret nmummerplader
					Console.WriteLine("{0}. Nummerplade: {1}", i + 1, car.Nummerplade);
				}
			}

            Console.WriteLine("\nVelkommen til kundeadministrationssystemet!");
            Console.WriteLine("1. Registrer ny kunde");
            Console.WriteLine("2. Vis kunde kontraktinfo");
            Console.WriteLine("3. Afslut");

            Console.Write("Vælg en handling ( 1 / 2 / 3 ): ");
            string vælge = Console.ReadLine();

            switch (vælge)
            {
                case "1":
                    Console.Clear();


                    Customer newCustomer = new Customer();
                    Vehicle newCar = new Vehicle("", "", "");

                    Console.Write("Indtast kundens FirstName: ");
                    newCustomer.FirstName = Console.ReadLine();

                    Console.Write("Indtast kundens LastName: ");
                    newCustomer.LastName = Console.ReadLine();

                    Console.Write("Indtast kundens kontaktoplysninger: ");
                    newCustomer.Phone = Console.ReadLine();

                    Console.Write("Indtast kundens Nummerplade: ");
                    newCar.Nummerplade = Console.ReadLine();

                    Console.Write("Indtast kundens Mærke: ");
                    newCar.Mærke = Console.ReadLine();

                    Console.Write("Indtast kundens Model: ");
                    newCar.Model = Console.ReadLine();

                    Console.Write("Indtast kundens Moterstørrelse: ");
                    newCar.Størrelse = Console.ReadLine();

					Console.Write("Indtast en dato (dd-mm-yyyy): ");
					string inputDateStr = Console.ReadLine();


					customers.Add(newCustomer);

                    Console.Clear();

                    Console.WriteLine("Kunde registreret!");
                    break;

				// Indtast nummerplade for at fremvise kundeoplysninger
				case "2":
					// Indtast nummerplade
					Console.Write("Indtast nummerpladen: ");
					string plateNumber = Console.ReadLine();

					// Opret variabler til at holde styr på funden kunde og bil
					Customer foundCustomer = null;
					Vehicle foundCar = null;

					// Gennemgå hver kunde for at finde den passende bil
					foreach(var customer in customers)
					{
						// Gennemgå hver bil for den aktuelle kunde
						foreach(var car in customer.bil)
						{
							// Tjek om nummerpladen på den aktuelle bil matcher den indtastede nummerplade
							if(car.Nummerplade == plateNumber)
							{
								// Gem kunden og bilen, hvis en match er fundet
								foundCustomer = customer;
								foundCar = car;
								break;
							}
						}
						// Hvis en matchende bil allerede er fundet, afslutter vi også gennemgangen af kunder
						if(foundCar != null)
							if(foundCar != null)
								break;
					}
					// Hvis en matchende bil blev fundet - vis kundeoplysningerne
					if(foundCar != null)
					{
						Console.WriteLine($"Kunde: {foundCustomer.FirstName} {foundCustomer.LastName}, {foundCustomer.Phone}");
						Console.WriteLine($"Bil: {foundCar.Mærke} {foundCar.Model}, Nummerplade: {foundCar.Nummerplade}");
					}
					else
					{
						// Hvis ingen matchende bil blev fundet, vis en fejlmeddelelse
						Console.WriteLine("Bilen blev ikke fundet.");
					}

					Console.WriteLine("Tryk på en tast for at fortsætte...");
					Console.ReadKey();

					break;




				case "3":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Ugyldigt valg. Vælg en gyldig handling.");
                    break;
            }

            Console.WriteLine();
        }
    }
}