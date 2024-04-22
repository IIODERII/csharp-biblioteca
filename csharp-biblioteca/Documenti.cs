using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Autore
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public Autore(string nome, string cognome) {
            this.Nome = nome;
            this.Cognome = cognome;
        }
    }
        public class Documenti
    {
        public string Codice { get; set; }
        public string Titolo { get; set; }
        public int Anno { get; set; }
        public string Settore { get; set; }
        public int Scaffale { get; set; }
        public Autore Autore { get; set; }

        public Documenti(string codice, string titolo, int anno, string settore, int scaffale, string nomeAutore, string cognomeAutore) { 
            this.Codice = codice;
            this.Titolo = titolo;
            this.Anno = anno;
            this.Settore = settore;
            this.Scaffale = scaffale;
            this.Autore = new Autore(nomeAutore, cognomeAutore);
        }
    }
}
