namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //aggiungo i documenti
            Biblioteca.AggiungiDocumento(new Libro("ABBA", "Titolo1", 2002, "Storia", 4, "Mario", "Rossi", 235));
            Biblioteca.AggiungiDocumento(new Libro("BVAS", "Titolo2", 2002, "Letteratura", 5, "Giovanni", "Bianchi", 135));
            Biblioteca.AggiungiDocumento(new Dvd("FFSDD", "Titolo3", 2002, "Matematica", 2, "Giorgio", "Verdi", 12.25));
            Biblioteca.AggiungiDocumento(new Libro("ASASX", "Titolo4", 2002, "Matematica", 1, "Armando", "Neri", 539));
            Biblioteca.AggiungiDocumento(new Dvd("WEQER", "Titolo5", 2002, "Filosofia", 10, "Alessandro", "Gialli", 6.45));
            Biblioteca.AggiungiDocumento(new Dvd("BBVZSX", "Titolo6", 2002, "Fisica", 8, "Mauro", "Blu", 59.36));

            //aggiungo gli utenti
            Biblioteca.RegistraUtente(new Utente("Rossi", "Mario", "mariorossi@gmail.com", "pw123", "3333223526"));
            Biblioteca.RegistraUtente(new Utente("Bianchi", "Giovanni", "bianchigiovanni@gmail.com", "12345", "33345242342"));
            Biblioteca.RegistraUtente(new Utente("Verdi", "Giorgio", "verdigiorgio@gmail.com", "54321", "342424224342"));
            Biblioteca.RegistraUtente(new Utente("Neri", "Armando", "neriarmando@gmail.com", "111111", "2235252134"));
            Biblioteca.RegistraUtente(new Utente("Gialli", "Alessandro", "giallialessandro@gmail.com", "222222", "3322124322"));
            Biblioteca.RegistraUtente(new Utente("Blu", "Mauro", "blumauro@gmail.com", "4444444", "33414112413"));

            Console.WriteLine("Buongiorno, Inserisca i suoi dati;");
            Console.WriteLine("Cognome: ");
            string cognome = Console.ReadLine();
            Console.Write("\nNome: ");
            string nome = Console.ReadLine();
            Console.Write("\nEmail: ");
            string email = Console.ReadLine();
            Console.Write("\nPassword: ");
            string password = Console.ReadLine();
            Console.Write("\nTelefono: ");
            string telefono = Console.ReadLine();

            Utente newUser = new Utente(cognome, nome, email, password, telefono);
            Biblioteca.RegistraUtente(newUser);

            Console.WriteLine("Accesso effettuato!");

            string choise = "";

            while(choise != "0")
            {
                Console.WriteLine("Inserire il numero relativo all'azione che si vuole eseguire:");
                Console.WriteLine("1. Cercare un documento");
                Console.WriteLine("2. Cercare un prestito");
                Console.WriteLine("0. Terminare il programma");
                choise = Console.ReadLine();

                if(choise == "1")
                {
                    string internalChoise = "";
                    Console.WriteLine("Inserire il titolo o il codice del Documento: ");
                    Documenti doc = Biblioteca.CercaDocumento(Console.ReadLine());
                    Console.WriteLine($"Documento trovato!\nTitolo: {doc.Titolo}, \nCodice: {doc.Codice}, \nAnno di pubblicazione: {doc.Anno}, \nSettore: {doc.Settore}, \nScaffale: {doc.Scaffale}, \nAutore: {doc.Autore.Cognome} {doc.Autore.Nome}");
                    while(internalChoise != "0") { 
                        Console.WriteLine("Inserire il numero relativo all'azione che si vuole eseguire:");
                        Console.WriteLine("1. Richiedere un prestito");
                        Console.WriteLine("0. Tornare alla schermata principale");
                        internalChoise = Console.ReadLine();
                        if(internalChoise == "1")
                        {
                            Biblioteca.AggiungiPrestito(newUser, doc);
                            Console.WriteLine("Prestito aggiunto correttamente");
                        }
                        else if(internalChoise == "0")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Valore inserito non valido");
                        }
                    }
                }
                else if(choise == "2") { 
                    Console.WriteLine("Inserire il Nome: ");
                    string nomeDaCercare = Console.ReadLine();
                    Console.WriteLine("Inserire il Cognome: ");
                    string CognomeDaCercare = Console.ReadLine();

                    Prestito pres = Biblioteca.CercaPrestito(nomeDaCercare, CognomeDaCercare);
                    Console.WriteLine($"Ecco, {nomeDaCercare} {CognomeDaCercare} ha in prestito questo titolo: {pres.Documento.Titolo} fino a {pres.A}");
                }
                else if(choise == "0")
                {}
                else
                {
                    Console.WriteLine("Valore inserito non valido, riprova");
                }
                
            }
        }
    }
}
