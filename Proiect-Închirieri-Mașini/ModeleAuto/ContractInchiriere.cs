using System;

namespace ModeleAuto
{
    public class ContractInchiriere
    {

        public Masina MasinaInchiriata { get; set; }
        public Client ClientContract { get; set; }
        public DateTime DataStart { get; set; }
        public DateTime DataFinal { get; set; }

        public ContractInchiriere(Masina _masina, Client _client, DateTime _start, DateTime _final)
        {
            MasinaInchiriata = _masina;
            ClientContract = _client;
            DataStart = _start;
            DataFinal = _final;


            MasinaInchiriata.EsteDisponibila = false;
        }

        public string Info()
        {
            return $"CONTRACT: Masina {MasinaInchiriata.Marca} inchiriata de {ClientContract.Nume} pana la data de {DataFinal.ToShortDateString()}";
        }
    }
}
