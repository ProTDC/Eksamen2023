namespace Oppgave_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Her definerer vi en ny person med verdier 
            Person person1 = new Person("Per", "123 45 678", 34);

            //Her skriver vi ut informasjon om den nye personen
            Console.WriteLine($"Hallo, jeg heter {person1.Navn}. \nJeg er {person1.Alder} år gammel og telefon nummeret mitt er {person1.Telefon}");
        }
    }

    //Her definerer vi klassen Person, den er public slik at andre klasser kan hente den
    public class Person
    {
        //Den inneholder attributes som Navn, Telefon og Alder
        public string Navn { get; set; }    
        public string Telefon { get; set; }
        public int Alder { get; set; }

        //Dette setter verdiene til attributene
        public Person(string navn, string telefon ,int alder) 
        {
            Navn = navn;
            Telefon = telefon;
            Alder = alder;
        }
    }
}