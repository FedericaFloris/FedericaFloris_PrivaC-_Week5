using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione.Week5
{
    internal class Immatricolazione
    {
        private static double matricola = 4500;
        public int Matricola { get; }

        public DateTime DataInizio { get; set; }

        public CorsoDiLaurea CorsoDiLaurea { get; set; } = new CorsoDiLaurea();

        public bool FuoriCorso { get; set; }

        public int CFUAccumulati { get; set; }


        public Immatricolazione()
        {

        }

        public Immatricolazione(DateTime dataInizio, bool fuoricorso,int cfuAccumulati)
        {
            Matricola++;
            DataInizio = dataInizio;
            FuoriCorso = fuoricorso;
            CFUAccumulati = cfuAccumulati;
        }
            

       
    }

    
}
