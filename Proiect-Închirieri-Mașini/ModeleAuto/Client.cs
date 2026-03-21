using System;

namespace ModeleAuto
{
    public class Client
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string CNP { get; set; }

        public Client()
        {
            Nume = Prenume = CNP = string.Empty;
        }

        public Client(string _nume, string _prenume, string _cnp)
        {
            Nume = _nume;
            Prenume = _prenume;
            CNP = _cnp;
        }

        public string Info()
        {
            return $"Client: {Nume} {Prenume} (CNP: {CNP})";
        }
    }
}
