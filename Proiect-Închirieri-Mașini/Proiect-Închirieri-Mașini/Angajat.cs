using System;

namespace ProiectInchirieriAuto
{
    public class Angajat
    {

        public string Nume { get; set; }
        public string Prenume { get; set; }


        public string Utilizator { get; set; }
        public string Parola { get; set; }

        public Angajat()
        {
            Nume = Prenume = Utilizator = Parola = string.Empty;
        }

        public Angajat(string _nume, string _prenume, string _user, string _parola)
        {
            Nume = _nume;
            Prenume = _prenume;
            Utilizator = _user;
            Parola = _parola;
        }

        public string Info()
        {
            return $"Angajat: {Nume} {Prenume} (User: {Utilizator})";
        }
    }
}
