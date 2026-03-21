using ModeleAuto; // OBLIGATORIU pentru a vedea clasa Masina
using System;
using System.Collections.Generic;
using System.Linq; // OBLIGATORIU pentru LINQ

namespace NivelStocareDate
{
    public class AdministrareMasiniMemorie
    {
        private List<Masina> masini = new List<Masina>();

        public void AddMasina(Masina masina) => masini.Add(masina);
        public List<Masina> GetMasini() => masini;

        // Implementare cautare cu LINQ (Cerinta 1 & 3)
        public List<Masina> CautaMasiniDupaMarca(string marca)
        {
            return masini.Where(m => m.Marca.Equals(marca, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}