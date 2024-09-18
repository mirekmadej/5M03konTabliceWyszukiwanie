namespace _5M03konWyszukiwanieDanegoElementu
{
    internal class Program
    {
        static int rozmiar = 20;
        const int maxLos = 100;
        static int[] tablica;
        // tablica jest indeksowana od zera, w zadaniu od 1

        private static void wypelnijTablice(int[] t)
        {
            Random r = new Random();
            for(int i = 1; i <= rozmiar; i++) 
                t[i] = r.Next(maxLos+1);
        }
        private static void wypiszTablice(int[] t)
        {
            for (int i = 1; i <= rozmiar; i++)
                Console.Write($"{t[i]}, ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Program do robienia czegoś na tablicach");
            Console.WriteLine("podaj rozmiar tablicy");
            string r = Console.ReadLine();
            if (int.TryParse(r, out rozmiar))
            {
                if (rozmiar <= 0)
                {
                    Console.WriteLine("zły rozmiar");
                    return;
                }
                tablica = new int[rozmiar + 1];
            }
            else
            {
                Console.WriteLine("zly rozmiar tablicy");
                return;
            }
            wypelnijTablice(tablica);
            Console.WriteLine("Zawartość tablicy:");
            wypiszTablice(tablica);
            
        }
    }
}
