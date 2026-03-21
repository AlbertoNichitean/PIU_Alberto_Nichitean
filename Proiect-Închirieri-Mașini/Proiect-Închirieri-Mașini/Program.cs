using System;
using System.Collections.Generic;
using ModeleAuto;
using NivelStocareDate;

namespace ProiectInchirieriAuto
{
    class Program
    {
        static AdministrareMasiniMemorie adminMasini = new AdministrareMasiniMemorie();

        static void Main(string[] args)
        {
            // --- 1. ACCES ANGAJAT (Cerinta: Date de conectare) ---
            Angajat angajatLogat = new Angajat("Popescu", "Ion", "admin_auto", "1234");
            Console.WriteLine("=== SISTEM BIROU INCHIRIERI AUTO ===");
            Console.WriteLine($"Acces autorizat pentru angajatul: {angajatLogat.Info()}");

            // Pre-populam cu o masina de test
            adminMasini.AddMasina(new Masina("Dacia", "Logan", 2022, "B 123 ABC", CuloareMasina.Alb, OptiuniMasina.AerConditionat));

            string optiune;
            do
            {
                Console.WriteLine("\n--- MENIU GESTIUNE ---");
                Console.WriteLine("L. Lista cu TOATE masinile firmei");
                Console.WriteLine("D. Afisare masini DISPONIBILE");
                Console.WriteLine("I. Efectuare INCHIRIERE (Client nou)");
                Console.WriteLine("C. Adaugare masina noua in flota");
                Console.WriteLine("X. Iesire");
                Console.Write("Optiune: ");
                optiune = Console.ReadLine().ToUpper();

                switch (optiune)
                {
                    case "L":
                        AfisareMasini(adminMasini.GetMasini());
                        break;

                    case "D":
                        var disponibile = adminMasini.GetMasini().FindAll(m => m.EsteDisponibila);
                        AfisareMasini(disponibile);
                        break;

                    case "I":
                        EfectueazaInchiriere();
                        break;

                    case "C":
                        adminMasini.AddMasina(CitireMasinaTastatura());
                        break;
                }
            } while (optiune != "X");
        }

        public static void EfectueazaInchiriere()
        {
            Console.WriteLine("\n--- CONTRACT NOU ---");
            Console.Write("Introduceti Marca masinii dorite: ");
            string marca = Console.ReadLine();

            var masina = adminMasini.GetMasini().Find(m => m.Marca.Equals(marca, StringComparison.OrdinalIgnoreCase) && m.EsteDisponibila);

            if (masina != null)
            {
                Console.Write("Nume Client: "); string nume = Console.ReadLine();
                Console.Write("Prenume Client: "); string prenume = Console.ReadLine();
                Console.Write("CNP Client: "); string cnp = Console.ReadLine();

                Client clientNou = new Client(nume, prenume, cnp);

                DateTime dataStart = DateTime.Now;
                DateTime dataSfarsit = DateTime.Now.AddDays(7);

                ContractInchiriere contract = new ContractInchiriere(masina, clientNou, dataStart, dataSfarsit);

                masina.EsteDisponibila = false;

                Console.WriteLine("\nSucces! Contract generat:");
                Console.WriteLine(contract.Info());
            }
            else
            {
                Console.WriteLine("Masina nu a fost gasita sau este deja inchiriata!");
            }
        }

        public static Masina CitireMasinaTastatura()
        {
            Console.WriteLine("\n--- Introducere date masina ---");
            Console.Write("Marca: "); string marca = Console.ReadLine();
            Console.Write("Model: "); string model = Console.ReadLine();
            Console.Write("An: "); int.TryParse(Console.ReadLine(), out int an);
            Console.Write("Nr Inmatriculare: "); string nr = Console.ReadLine();

            // 1. Alegere Culoare
            Console.WriteLine("Culori: 1-Rosu, 2-Alb, 3-Negru");
            Console.Write("Optiune culoare: ");
            int.TryParse(Console.ReadLine(), out int optCuloare);
            CuloareMasina culoareAlesa = (CuloareMasina)optCuloare;

            // 2. Alegere Dotari (Flags)
            Console.WriteLine("Dotari disponibile (alegeti numerele separate prin virgula, ex: 1,4):");
            Console.WriteLine("1: AerConditionat");
            Console.WriteLine("2: Navigatie");
            Console.WriteLine("4: CutieAutomata");
            Console.WriteLine("8: SenzoriParcare");
            Console.Write("Dotari: ");
            string inputDotari = Console.ReadLine();

            OptiuniMasina dotariAlese = OptiuniMasina.None;
            string[] selectii = inputDotari.Split(',');

            foreach (var s in selectii)
            {
                if (int.TryParse(s.Trim(), out int val))
                {
                    // Adaugam dotarea folosind operatorul OR (|) - specific pentru Flags
                    dotariAlese |= (OptiuniMasina)val;
                }
            }

            // Acum trimitem dotariAlese in loc de None
            return new Masina(marca, model, an, nr, culoareAlesa, dotariAlese);
        }

        public static void AfisareMasini(List<Masina> lista)
        {
            if (lista.Count == 0) Console.WriteLine("Nu sunt masini de afisat.");
            foreach (var m in lista) Console.WriteLine(m.Info());
        }
    }
}

