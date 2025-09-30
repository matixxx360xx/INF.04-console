class Pesel {


    class Sprawdzanie {

        public string JakaPlec(string Pesel) {

            if (int.Parse(Pesel[9].ToString()) % 2 == 0)
            {
                return "K";
            }
            else {
                return "M";
            }
                
        }
    
    }

    class Suma {

        public bool SprawdzanieSumy(string Pesel) {
            string waga = "1379137913";
            int S = 0;
            int R;

            for (int i = 0; i < waga.Length; i++) {
                S += int.Parse(Pesel[i].ToString()) * int.Parse(waga[i].ToString());
            }
            int M = S % 10;

            if (M == 0)
            {
                R = 0;
            }
            else {
                R = 10 - M;           
            }
            if (R == int.Parse(Pesel[10].ToString()))
            {
                return true;
            }
            else {
                return false;
            }
        }
    
    }


    static void Main() {

        string Pesel = "55030101193";


        Console.Write("Wprowadź numer PESEL: ");
        string? pesel = Console.ReadLine();
        while(pesel.Length > 11 || pesel.Length < 11) {
            Console.Write("Wprowadź numer PESEL: ");
            pesel = Console.ReadLine();
        }

        Sprawdzanie sprawdzanie = new Sprawdzanie();
        string plec = sprawdzanie.JakaPlec(pesel);
        Console.WriteLine(plec == "K" ? "Kobieta" : "Mężczyzna");

        Suma suma = new Suma();
        bool sumaPoprawna = suma.SprawdzanieSumy(pesel);
        Console.WriteLine($"Suma kontrolna {(sumaPoprawna ? "zgodna" : "niepoprawna")}");

    }
}