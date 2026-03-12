using System;

namespace ProiectInchirieriAuto
{
    class Program
    {
        static void Main(string[] args)
        {

            Angajat angajat1 = new Angajat("Popescu", "Ion", "ion_admin", "parola123");
            Console.WriteLine($"Sistem accesat de: {angajat1.Info()}");


            Masina masina1 = new Masina("Dacia", "Logan", 2022, "B 123 ABC");
            Console.WriteLine("\nStare initiala:");
            Console.WriteLine(masina1.Info());


            Client client1 = new Client("Alexandru", "Vasile", "1234567890123");


            Console.WriteLine("\nSe realizeaza inchirierea...");
            ContractInchiriere contract1 = new ContractInchiriere(
                masina1,
                client1,
                DateTime.Now,
                DateTime.Now.AddDays(7)
            );


            Console.WriteLine(contract1.Info());

            Console.WriteLine("\nStare masina dupa inchiriere:");
            Console.WriteLine(masina1.Info());

            Console.WriteLine("\nApasati orice tasta pentru a inchide.");
            Console.ReadKey();
        }
    }
}