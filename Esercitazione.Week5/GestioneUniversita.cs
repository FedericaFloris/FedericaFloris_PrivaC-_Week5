using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione.Week5
{
    internal class GestioneUniversita
    {
        public void Inizializazione() {
            Corso corso1 = new Corso("Fisica1", 7);
            Corso corso2 = new Corso("Analisi1", 12);
            Corso corso3 = new Corso("ElementiDiInformatica", 5);
            Corso corso4 = new Corso("Latino", 8);
            Corso corso5 = new Corso("MatematicaApplicata", 10);
            Immatricolazione Immatricolazione1 = new Immatricolazione(new DateTime(2021, 9, 26), false, 30);
            Immatricolazione Immatricolazione2 = new Immatricolazione(new DateTime(2020, 9, 26), false, 60);

            CorsoDiLaurea corsoLaurea1 = new CorsoDiLaurea(TipoNome.Ingegneria, 3, 50);
            corsoLaurea1.Corso.Add(corso1);
            corsoLaurea1.Corso.Add(corso2);
            corsoLaurea1.Corso.Add(corso5);

            

            Studente Studente1 = new Studente("Federica", "Floris", new DateTime(1992, 12, 21), false);
            Studente1.Immatricolazione = Immatricolazione1;
            Immatricolazione1.CorsoDiLaurea=corsoLaurea1;
            Studente Studente2 = new Studente("Mario", "Rossi", new DateTime(1993, 4, 4), true);

            

           




        }

        public List<Studente> studenti = new List<Studente>
        {
             new Studente("Federica", "Floris", new DateTime(1992, 12, 21), false)
        };

        public List<Corso> corsi = new List<Corso>
        {
              new Corso("Fisica1", 7),
              new Corso("Analisi1", 12),
              new Corso("ElementiDiInformatica", 5),
              new Corso("Latino", 8),
              new Corso("MatematicaApplicata", 10)
        };

        public List<Immatricolazione> immatricolazioni = new List<Immatricolazione>
        {
            new Immatricolazione(new DateTime(2021, 9, 26), false, 30)
        };

        public List<CorsoDiLaurea> corsiLaurea = new List<CorsoDiLaurea>
        {
            new CorsoDiLaurea(TipoNome.Ingegneria, 3, 50)
        };

        //public static bool IsAutenticato(Studente s)    //non mi va
        //{
        //    foreach (var item in studenti)
        //    {
        //        if (item.Nome == s.Nome && item.Cognome == s.Cognome && item.AnnoDiNascita== s.AnnoDiNascita && item.RichiestaDiLaurea==s.RichiestaDiLaurea)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
    }
    


}
