namespace Prima_prova
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;// font per euro


            Contribuente c = new Contribuente();
            Console.WriteLine("inserisci i dati del contribuente");
            Console.Write("Nome: ");
            c.Nome = Console.ReadLine();

            Console.Write("Cognome: ");
            c.Cognome = Console.ReadLine();

           
            while (true)
            {
                Console.Write("Data di nascita (gg/mm/aaaa): ");
                string dataNascitaInput = Console.ReadLine();
                try
                {
                    c.DataNascita = DateTime.ParseExact(dataNascitaInput, "dd/MM/yyyy", null);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("errore data non valida");


                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Errore durante la conversione della data: {ex.Message}");
                }
            }

            while (true)
            {
                Console.Write("sesso scrivi uno di questi (uomo/donna/robot): ");
                string sessoInput = Console.ReadLine();

                try
                {
                    c.Genere = (Sesso)Enum.Parse(typeof(Sesso), sessoInput, true);
                    break;
                }
                catch(FormatException) 
                {
                    Console.WriteLine("errore genere non valido");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"errore dati: {ex.Message}");
                }




            }
            Console.WriteLine("Codice fiscale: ");
            c.Codice = Console.ReadLine(); 


            Console.Write("Comune di residenza: ");
            c.Comune = Console.ReadLine();


            Console.Write("Reddito annuale: ");
            c.Reddito = int.Parse(Console.ReadLine());

            double imposta = c.calcoloImposta();


            Console.WriteLine("================================ Cose di numeri ============================================");
            Console.WriteLine("Calcolo imposta da versare:");
            Console.WriteLine($"contribuente: {c.Nome} {c.Cognome}, ");
            Console.WriteLine($"nato il {c.DataNascita.ToString("dd/MM/yyyy")} ({c.Genere})");
            Console.WriteLine($"residente in {c.Comune}, ");
            Console.WriteLine($"codice fiscale: {c.Codice}, ");
            Console.WriteLine($"reddito dichiarato: £ {c.Reddito:0.00}"); //in sterline perchè si
            Console.WriteLine($"IMPOSTA DA VERSARE: £ {imposta:0.00}");





        }
    }
}
