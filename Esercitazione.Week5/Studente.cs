using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione.Week5
{
    internal class Studente
    {
        public string Nome { get; set; }

        public string Cognome { get; set; }

        public DateTime AnnoDiNascita { get; set; }

        public Immatricolazione Immatricolazione { get; set; } = new Immatricolazione();

        public List<Esame> Esami { get; set; }= new List<Esame>(){ };

        public bool RichiestaDiLaurea { get; set; }

        public Studente()
        {

        }

        public Studente(string nome, string cognome, DateTime annoDiNascita, bool richiestaDiLaurea)
        {
            Nome = nome;
            Cognome = cognome;
            
            AnnoDiNascita = annoDiNascita;
            RichiestaDiLaurea = richiestaDiLaurea;

        }



    }
}
