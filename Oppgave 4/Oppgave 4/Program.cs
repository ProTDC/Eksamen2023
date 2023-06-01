namespace Oppgave_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //definerer en tom string, ber brukeren om å skrive inn en string og lagrer resultatet i en variabel
            string inputReverse = string.Empty;
            Console.Write("Enter a string: ");
            var input = Console.ReadLine();

            //Sjekker om input har en verdi, hvis den ikke har en avslutter den bare 
            if (input != null)
            {
                //Her bruker vi en omvendt for løkke til å gå gjennom inputtet baklengs også legger vi bokstavene til inputReverse på veien 
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    inputReverse += input[i].ToString();
                }

                //Skriver ut resultatet
                Console.WriteLine(inputReverse);
            }
        }
    }
}