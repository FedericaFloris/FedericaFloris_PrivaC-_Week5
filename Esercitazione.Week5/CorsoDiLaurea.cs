using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione.Week5
{
    internal class CorsoDiLaurea
    {
        public TipoNome Nome { get; set; }

        public int AnnoDiCorso { get; set; }

        public int CFUPerLaurea { get; set; }

        public List<Corso> Corso { get; set; } = new List<Corso>();

       
        public CorsoDiLaurea()
        {

        }

        public CorsoDiLaurea(TipoNome nome, int annoDiCorso, int cfuPerLaurea)
        {
            Nome = nome;
            AnnoDiCorso = annoDiCorso;
            CFUPerLaurea = cfuPerLaurea;
        }
    }
    enum TipoNome
    {
        Matematica = 1,
        Fisica,
        Informatica,
        Ingegneria,
        Lettere
    }


}
