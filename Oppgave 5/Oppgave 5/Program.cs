namespace Oppgave_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definerer en tom string, og et string som brukes for å teste programmet
            string inputFixed = string.Empty;

            string input = "Det,var,en,gang,en,konge,,og";

            //Sjekker om input har en verdi, hvis den ikke har en avslutter den bare 
            if (input != null)
            {
                //Her finner vi alle gangene en , dukker opp og bytter den ut med et mellomrom. Men hvis mellomrommet blir for langt så byttes det ut med en ,
                inputFixed = input.Replace(",", " ").Replace("  ", ", ");

                //Skriver ut resultatet
                Console.WriteLine(inputFixed);
            }
        }
    }
}