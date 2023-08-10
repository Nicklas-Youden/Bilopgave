
class Program
{
    static void Main(string[] args)
    {
        List<Customer> customers = new List<Customer>();

        bool running = true;
        while (running)
        {
            Console.WriteLine("Registrerede kunder:");
            for (int i = 0; i < customers.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i, customers[i].FirstName);
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

                    Console.Write("Indtast kundens Dato: ");
                    newCar.Dato = Console.ReadLine();


                    customers.Add(newCustomer);

                    Console.Clear();

                    Console.WriteLine("Kunde registreret!");




                    
                    break;




                case "2":
                    Console.Write("Indtast kundens nummer (0 - {0}): ", customers.Count - 1);
                    int customerNumber;
                    if (int.TryParse(Console.ReadLine(), out customerNumber) && customerNumber >= 0 && customerNumber < customers.Count)
                    {
                        Console.Clear();
                        Console.WriteLine("Kontaktinfo: ");
                        Customer customer = customers[customerNumber];
                        Console.WriteLine("Navn: {0}\nKontaktinfo: {1}", customer.FirstName, customer.Phone);
                        //Console.WriteLine("Registrerede biler: ");
                        /*foreach (Car cars in ShowCar.bil)
                        {
                            Console.WriteLine("Mærke: {0}, Model: {1}", cars.lave, cars.Model);
                        }*/
                    }
                    else
                    {
                        Console.WriteLine("Ugyldigt kundenummer.");
                    }
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