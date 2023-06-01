namespace Oppgave_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ber brukeren om å skrive inn et passord og lagrer resultatet i en variabel
            Console.WriteLine("Skriv inn et passord:");
            var input = Console.ReadLine();
            //Konverterer inputet til små bokstaver slik at det er lettere å se etter spesifike tegn
            var inputLower = input.ToLower();

            //Konverterer inputtet til en array med karakterer slik at det er lettere å finne spesifike bokstaver
            char[] charArray = inputLower.ToCharArray();
            //En bool for å se om passorded inneholder et tall eller ikke
            bool containsInt = false;

            //Dette tar inputtet og sjekker alle bokstavene for å se hvor mange ganger spesifike bokstaver dukker opp
            var result = inputLower.GroupBy(_ => _).Where(x => x.Count() > 0).Select(x => x.Key);

            //Sjekker om inputtet inneholder et tall, hvis ja så gjør boolen fra tidligere til true
            foreach (var s in charArray)
            {
                containsInt = input.Any(char.IsDigit);
            }

            //Sjekker først om passordet er større en 6 karakterer 
            if (charArray.Length > 6)
            {
                //Sjekker om passordet inneholder et tall med boolen, hvis ikke er passordet ikke gyldig
                if (containsInt)
                {
                    Console.WriteLine("Passordet er Gyldig!");
                }
                else
                {
                    Console.WriteLine("Passordet er UGyldig! (inneholder ikke tall)");
                }

                //Hvis passordet er lenger enn 15 karakterer skal passordet være gyldig 
                if (charArray.Length > 15)
                {
                    Console.WriteLine("Passordet er Gyldig!");
                }

                //Hvis passordet bruker kun 3 eller mindre karakterer er passordet ugyldig
                if (result.Count() < 3)
                {
                    Console.WriteLine("Passordet er UGyldig! (Bruk flere karakterer!)");
                }

                //Hvis passordet er passord skal passordet være ugyldig
                if (inputLower.Contains("passord"))
                {
                    Console.WriteLine("Passordet er Ugyldig! (inneholder passord)");
                }

            }
            //Hvis passordet er mindre enn 6 karakterer er det ugyldig
            else
            {
                Console.WriteLine("Passordet er Ikke Gyldig!");
            }
        }
        
    }
}