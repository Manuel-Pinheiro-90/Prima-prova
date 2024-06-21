using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prima_prova
{

    enum Sesso
    {
        Uomo,Donna,Robot
    }

    internal class Contribuente
   
    {


        public string Nome { get; set; }
      public string Cognome { get; set; }
        public DateTime DataNascita { get; set; }
        public Sesso Genere { get; set; }

        public string Codice { get; set; }
        public string Comune { get; set; }
        public int Reddito { get; set; }

       
        public double calcoloImposta ()
        {
            double imposta;
            if (Reddito <= 15000)
            {
                imposta = Reddito * 0.23;
            }
            else if (Reddito <= 28000)
            {
                imposta = 15000 * 0.23 + (Reddito - 15000) * 0.27;
            }
            else if (Reddito <= 55000)
            {
                imposta = 15000 * 0.23 + (28000 - 15000) * 0.27 + (Reddito - 28000) * 0.38;
            }
            else if (Reddito <= 75000)
            {
                imposta = 15000 * 0.23 + (28000 - 15000) * 0.27 + (55000 - 28000) * 0.38 + (Reddito - 55000) * 0.41;
            }
            else
            {
                imposta = 15000 * 0.23 + (28000 - 15000) * 0.27 + (55000 - 28000) * 0.38 + (75000 - 55000) * 0.41 + (Reddito - 75000) * 0.43;
            }

            return imposta;

        }


    }

}
