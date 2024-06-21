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

           Console.Write("Data di nascita (gg/mm/aaaa): ");
           string dataNascitaInput = Console.ReadLine();
           c.DataNascita = DateTime.ParseExact(dataNascitaInput, "dd/MM/yyyy", null);






            Console.Write("sesso (uomo/donna/robot): ");
            string sessoInput = Console.ReadLine();
            c.Genere = (Sesso)Enum.Parse(typeof(Sesso), sessoInput, true);


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
            Console.WriteLine($"reddito dichiarato: £ {c.Reddito:0.00}");
            Console.WriteLine($"IMPOSTA DA VERSARE: £ {imposta:0.00}");





        }
    }
}
