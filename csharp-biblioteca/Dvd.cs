using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    
       public class Dvd : Documenti
        {
            public double Durata { get; set; }
            public Dvd(string codice, string titolo, int anno, string settore, int scaffale, string nomeAutore, string cognomeAutore, double durata) : base(codice, titolo, anno, settore, scaffale, nomeAutore, cognomeAutore)
            {
                this.Durata = durata ;
            }
        }
    }

