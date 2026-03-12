using System;

namespace Tema1_Salariu
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Declararea variabilelor conform cerintei
            int numarOre;      // numarul de ore va fi de tip int
            double tarifPeOra; // tariful pe ora va fi de tip double
            double salariu;

            Console.WriteLine("=== Aplicatie Calcul Salariu - Tema 1 ===");
            Console.WriteLine();

            // 2. Citirea datelor de la tastatura cu conversiile necesare
            try
            {
                Console.Write("Introduceti numarul de ore lucrate (numar intreg): ");
                numarOre = int.Parse(Console.ReadLine());

                Console.Write("Introduceti tariful pe ora (ex: 25,5): ");
                tarifPeOra = double.Parse(Console.ReadLine());

                // 3. Calculul salariului
                salariu = numarOre * tarifPeOra;

                Console.WriteLine();
                Console.WriteLine($"Rezultat: Pentru {numarOre} ore cu un tarif de {tarifPeOra} lei/ora...");
                Console.WriteLine($"Salariul total este: {salariu} lei");

                // 4. Verificarea pragului de 3000 lei
                if (salariu > 3000)
                {
                    Console.WriteLine("Mesaj: Salariu mare");
                }
                else
                {
                    Console.WriteLine("Mesaj: Ati lucrat prea putine ore pentru a avea un salariu mare!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare: Va rugam sa introduceti cifre valide!");
            }

            // Mentinem consola deschisa pentru a vedea rezultatul
            Console.WriteLine("\nApasati orice tasta pentru a iesi...");
            Console.ReadKey();
        }
    }
}