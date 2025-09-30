class Kostka
{

    class Losuj
    {
        Random r = new Random();
        public int[] tab;
        public Losuj(int ile)
        {
            tab = new int[ile];
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = r.Next(1, 7);
            }
        }
    }

    class Wyswietl
    {

        public void wyswietl(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                int j = i+1;
                Console.WriteLine("Kostka "+j+": "+tab[i] + "\n");
            }
           
        }
    }

    class Pkt {
        public int suma;
        Dictionary<int, int> liczbaWystapien = new Dictionary<int, int>();
        public Pkt(int[] tab){
            for(int i = 0; i < tab.Length; i++){
                if (liczbaWystapien.ContainsKey(tab[i]))
                {
                    liczbaWystapien[tab[i]]++;
                }
                else {
                    liczbaWystapien.Add(tab[i], 1);
                }
            }

            var klucze = new List<int>(liczbaWystapien.Keys);
            for (int i = 0; i < klucze.Count; i++)
            {
                if (liczbaWystapien[klucze[i]] > 1)
                {
                    suma += klucze[i] * liczbaWystapien[klucze[i]];
                }
            }
            

        }
        public int Suma() {
            return suma;
        }
    }



    class Program
    {
        static void Main()
        {


            Wyswietl wyswietl = new Wyswietl();
      
            while (true)
            {
                Console.WriteLine("Ile kostek chcesz rzucić? (3-10)");
                string? ile = Console.ReadLine();
                if (!int.TryParse(ile, out int n) || n < 3 || n > 10)
                {
                    continue;
                }
                else
                {
                    Losuj l = new Losuj(int.Parse(ile));
                    wyswietl.wyswietl(l.tab);
                    Pkt p = new Pkt(l.tab);
                    Console.WriteLine(p.Suma());
                    Console.WriteLine("Jeszcze raz (t,n)");
                    string? option;
                    option = Console.ReadLine()?.Trim().ToLower();
                    while (option != "t" && option != "n")
                    {
                        Console.WriteLine("Jeszcze raz (t,n)");
                        option = Console.ReadLine()?.Trim().ToLower();
                    }
                    if (option == "t")
                    {
                        continue;
                    }
                    else if (option == "n")
                    {
                        break;
                    }
                    
                }
            }
        }
    }

}
