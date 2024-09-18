
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
        private static int wyszukajElement(int[] t, int x)
        {
            for(int i = 1; i<=rozmiar; i++)
            {
                if(t[i] == x)
                    return i;
            }
            return -1;
        }
        private static int wyszukajStraznik(int[]t, int x)
        {
            t[rozmiar+1] = x;  //wartownik
            int i = 1;
            while(true)
            {
                if (t[i] == x)
                    return i;
                i++;
            }
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
                tablica = new int[rozmiar + 1 + 1];
                //rozmiar tablicy jest zwiększony o jeden 
                //dla algorytmu wyszukiwania ze strażnikiem
            }
            else
            {
                Console.WriteLine("zly rozmiar tablicy");
                return;
            }

            wypelnijTablice(tablica);
            Console.WriteLine("Zawartość tablicy:");
            wypiszTablice(tablica);

            Console.Write("podaj element do znalezienia: ");
            int el = int.Parse(Console.ReadLine());
            int poz = wyszukajElement(tablica, el);
            if (poz >= 0)
                Console.WriteLine($"znaleziono eleent na pozycji {poz}");
            else
                Console.WriteLine("elementu nie ma w tablicy");


            Console.Write("podaj element do znalezienia (wartownik: ");
            el = int.Parse(Console.ReadLine());
            poz = wyszukajElement(tablica, el);
            if (poz > rozmiar)
                Console.WriteLine("elementu nie ma w tablicy");
            else
                Console.WriteLine($"znaleziono eleent na pozycji {poz}");

        }
    }
}
