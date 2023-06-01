namespace Oppgave_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Spør brukeren om to heltall og lagre resultatene i variabler
            Console.WriteLine("Skriv inn to heltall: ");
            int tall1 = Convert.ToInt32(Console.ReadLine());
            int tall2 = Convert.ToInt32(Console.ReadLine());

            //Summer tallene 
            int sum = tall1 + tall2;
            int diff = tall1 - tall2;
            int prod = tall1 * tall2;
            int kvo = tall1 / tall2;

            //Skriv ut resultatene
            Console.WriteLine("\nResultat:");
            Console.WriteLine("\n" + sum);
            Console.WriteLine(diff);
            Console.WriteLine(prod);
            Console.WriteLine(kvo);
        }
    }
}