using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Biblioteca
    {
        public static List<Documenti> Documenti { get; set; } = new List<Documenti>();
        public static List<Utente> Utenti { get; set; } = new List<Utente>();

        public static List<Prestito> Prestiti { get; set; } = new List<Prestito>();

        public static void AggiungiDocumento(Documenti doc)
        {
            if (Documenti != null)
            {
                Documenti.Add(doc);
            }
        }

        public static void RimuoviDocumento(Documenti doc)
        {
            Documenti.Remove(doc);
        }

        public static void RegistraUtente(Utente utente)
        {
            if (utente != null) {
                Utenti.Add(utente);
            }
        }
        public static void RimuoviUtente(Utente utente)
        {
            Utenti.Remove(utente);
        }

        public static void AggiungiPrestito(Prestito prestito)
        {
            Prestiti.Add(prestito);
        }

        public static void RimuoviPrestito(Prestito prestito)
        {
            Prestiti.Remove(prestito);
        }

        public static Documenti CercaDocumento(string ricerca)
        {
            foreach(Documenti documento in Documenti) { 
                if(documento.Titolo == ricerca || documento.Codice == ricerca)
                {
                    return documento;       
                }
            }
            Console.WriteLine("Non abbiamo questo documento nel nostro database :(");
            return null;
        }

        public static void AggiungiPrestito(Utente user, Documenti doc)
        {
            DateOnly today = DateOnly.FromDateTime(DateTime.Now);

            Prestiti.Add(new Prestito(doc, user, today, today.AddMonths(2)));
        }

        public static Prestito CercaPrestito(string nome, string cognome)
        {
            foreach(Prestito prestito in Prestiti)
            {
                if(nome == prestito.Utente.Nome && cognome == prestito.Utente.Cognome)
                {
                    return prestito;
                }
            }
            Console.WriteLine("Nessun utente con questo nume e cognome ha effettuato prestiti presso di noi");
            return null;
        }
    }
}
