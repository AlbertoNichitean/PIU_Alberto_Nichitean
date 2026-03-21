namespace ModeleAuto
{
    public class Masina
    {
        public string Marca { get; set; }
        public string Model { get; set; }
        public int AnFabricatie { get; set; }
        public string NumarInmatriculare { get; set; }
        public bool EsteDisponibila { get; set; }

        // Proprietăți noi din Tema acasă (Cerința 2)
        public CuloareMasina Culoare { get; set; }
        public OptiuniMasina Dotari { get; set; }

        // CONSTRUCTORUL CARE REPARĂ EROAREA:
        // Trebuie să primească EXACT 6 parametri, în această ordine:
        public Masina(string marca, string model, int an, string numar, CuloareMasina culoare, OptiuniMasina dotari)
        {
            Marca = marca;
            Model = model;
            AnFabricatie = an;
            NumarInmatriculare = numar;
            Culoare = culoare;
            Dotari = dotari;
            EsteDisponibila = true;
        }

        // Metoda Info actualizată
        public string Info()
        {
            return $"Masina: {Marca} {Model} ({AnFabricatie}) | Culoare: {Culoare} | Dotari: {Dotari} | Nr: {NumarInmatriculare}";
        }
    }
}