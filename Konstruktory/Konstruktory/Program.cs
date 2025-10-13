

class Osoba
{
    public static int licznik = 0; 


        private int id;
        private string imie;

    public Osoba() {
        id = 0;
        imie = " ";
        licznik += 1;
    }
        



    public Osoba(int id, string imie) {
        this.id = id;
        this.imie = imie;
        licznik += 1;

    }

    public Osoba(Osoba osoba) {
        this.id = osoba.id;
        this.imie = osoba.imie;
        licznik += 1;
    }
    public void wyswietl(string name) {
        if (string.IsNullOrWhiteSpace(imie))
        {
            Console.WriteLine("Brak danych");
        }
        else {
            Console.WriteLine($"Cześć {name}, mam na imię {imie}");
        }
    
    }



        static void Main() {
            Osoba osoba = new Osoba();
            Console.WriteLine("Podaj id");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj imie");
            string imie = Console.ReadLine();

            Osoba osoba2 = new Osoba(id,imie);
            Osoba osoba3 = new Osoba(osoba2);
            osoba.wyswietl("Jan");
            osoba2.wyswietl("Jan");
            osoba3.wyswietl("Jan");
            Console.WriteLine(Osoba.licznik);
          







        
    
    
    }






}