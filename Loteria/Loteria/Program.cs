

class Loteria
{   

    class Losowanie
    {
        private int kolumna = 6;
        private int[,] tablica;
     
        private int wiersze;
        Random r = new Random();

        public void losowanie(int wiersze)
        {
            this.wiersze = wiersze;
            tablica = new int[wiersze, kolumna];

            for (int i = 0; i < wiersze; i++)
            {
                for (int j = 0; j < kolumna; j++)
                {
                    int random = r.Next(1, 50);
                    if (Enumerable.Range(0, j).Any(k => tablica[i, k] == random))
                    {
                        j--;
                        continue;

                    }
                    tablica[i, j] = random;
                }
            }
        }

        public void wyswietl()
        {
            for (int i = 0; i < wiersze; i++)
            {
                Console.Write("Losowanie " + i+1 + ": ");
                for (int j = 0; j < kolumna; j++)
                {
                    Console.Write(tablica[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void ZliczanieWystompien()
        {
            var wystompienia = new Dictionary<int, int> { };
            for (int i = 0; i < 50; i++)
            {
                wystompienia[i] = 0;
            }

            for (int i = 0; i < wiersze; i++)
            {
                for (int j = 0; j < kolumna; j++)
                {
                    if (wystompienia.ContainsKey(tablica[i, j]))
                    {
                        wystompienia[tablica[i, j]]++;
                    }
                }
            }
            foreach (var para in wystompienia)
            {
                Console.WriteLine("Wystempowanie liczby " + para.Key + ": " + para.Value);
            }

        }
        public static void Main()
        {
            var losowanie = new Losowanie();
            Console.WriteLine("podaj ile wierszy chcesz miec");
            int wiersze;
            while (!int.TryParse(Console.ReadLine(), out wiersze))
            {
                Console.WriteLine("podaj ile wierszy chcesz miec");
                continue;
            }
            losowanie.losowanie(wiersze);

            losowanie.wyswietl();
            losowanie.ZliczanieWystompien();

        }

    }
}
