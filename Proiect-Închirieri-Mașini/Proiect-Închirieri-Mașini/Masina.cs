using System;

namespace ProiectInchirieriAuto
{
    public class Masina
    {

        public string Marca { get; set; }
        public string Model { get; set; }
        public int AnFabricatie { get; set; }
        public string NumarInmatriculare { get; set; }
        public bool EsteDisponibila { get; set; }


        public Masina()
        {
            Marca = string.Empty;
            Model = string.Empty;
            NumarInmatriculare = string.Empty;
            EsteDisponibila = true;
        }


        public Masina(string _marca, string _model, int _an, string _numar)
        {
            Marca = _marca;
            Model = _model;
            AnFabricatie = _an;
            NumarInmatriculare = _numar;
            EsteDisponibila = true;
        }


        public string Info()
        {

            if (string.IsNullOrEmpty(Marca))
            {
                return "EROARE: Date masina incomplete.";
            }

            string status = EsteDisponibila ? "Disponibila" : "Inchiriata";
            return $"Masina: {Marca} {Model} ({AnFabricatie}) | Nr: {NumarInmatriculare} | Status: {status}";
        }
    }
}
