namespace Oppgave_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //en ny tall liste med eksempel tallene
            List<int> tallListe = new List<int>()
            {
                3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 8, 9, 7, 9, 3, 2, 3, 8, 4, 6, 2, 6, 4, 3, 3, 8, 3, 2, 7, 9, 5, 0, 2, 8, 8, 4, 1, 9, 7, 1, 6, 9, 3, 9, 9, 3, 7, 5, 1, 0, 5, 8, 2, 0, 9, 7, 4, 9, 4, 4, 5, 9, 2, 3, 0, 7, 8, 1, 6, 4, 0, 6, 2, 8, 6, 2, 0, 8, 9, 9, 8, 6, 2, 8, 0, 3, 4, 8, 2, 5, 3, 4, 2, 1, 1
            };

            //grupperer tall listen og sorterer det basert på antall forekomst
            var group = tallListe.GroupBy(i => i);
            var sortetGroup = group.OrderByDescending(i => i.Count());

            //looper gjennom alle elementer i listen og skriver dem ut
            foreach (var item in sortetGroup)
            {
                Console.WriteLine($"Tall {item.Key} forekommer {item.Count()} ganger.");
            }
        }
    }
}