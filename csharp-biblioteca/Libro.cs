using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Libro : Documenti
    {
        public int Pagine { get; set; }
        public Libro(string codice, string titolo, int anno, string settore, int scaffale, string nomeAutore, string cognomeAutore, int pagine) : base (codice, titolo, anno, settore, scaffale, nomeAutore, cognomeAutore)
        {
            this.Pagine = pagine;
        }
    }
}
