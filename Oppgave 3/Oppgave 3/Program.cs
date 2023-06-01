namespace Oppgave_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definerer en ny liste som inneholder tall fra 1-10
            List<int> list = new List<int>() 
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };   

            //En for løkke som looper basert på hvor mange elementer det er i listen
            for (int i = 0; i < list.Count; i++)
            {
                //Skriver ut det nåværende tallet 
                Console.WriteLine(list[i]);
            }
        }
    }
}