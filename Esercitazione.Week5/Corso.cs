using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione.Week5
{
    internal class Corso
    {
       public string Nome { get; set; }

        public int CFU { get; set; }



        public Corso()
        {

        }

        public Corso(string nome, int cfu)
        {
            Nome = nome;
            CFU = cfu;
        }
    }

    
}
