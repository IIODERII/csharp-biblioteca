using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Utente
    {
        public string Cognome {  get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Telefono { get; set; }

        public Utente (string cognome, string nome, string email, string password, string telefono)
        {
            this.Cognome = cognome;
            this.Nome = nome;
            this.Email = email;
            this.Password = password;
            this.Telefono = telefono;
        }
    }
    public class Prestito
    {
        public DateOnly A { get; set;}
        public DateOnly Da { get; set;}
        public Utente Utente { get; set;}
        public Documenti Documento { get; set;}

        public Prestito(Documenti documento, Utente utente, DateOnly da, DateOnly a)
        {
            this.Documento = documento;
            this.Utente = utente;
            this.A = a;
            this.Da = da;
        }

        public void PrendiInPrestito(Documenti doc)
        {
            Biblioteca.AggiungiPrestito(this.Utente, doc);
        }
    }
}
