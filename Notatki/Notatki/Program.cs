class Notatka {

    private static int licznikNotatek = 0;
    private int uniklanyLicznik = 0;
    protected string tytul;
    protected string tresc;

    public Notatka(string tytul, string tresc)
    {
        licznikNotatek++;
        uniklanyLicznik = licznikNotatek;
        this.tytul = tytul;
        this.tresc = tresc;
    }

    public void wyswietl() {
        Console.WriteLine("Tytul: "+tytul+" "+"tresc: "+tresc);
    }

    public void Diagnostyczna() {
        Console.WriteLine(tytul+"; "+tresc+"; "+uniklanyLicznik);
    }







    public static void Main()
    {
        string tytul = "Pan tadeusz";
        string tresc = "Daleko za lasem";
        var notatka = new Notatka(tytul, tresc);

        string tytul_2 = "Chlopcy z Placu broni";
        string tresc_2 = "Bronic Warszawy!!!";
        var notatka2 = new Notatka(tytul_2, tresc_2);

        notatka.wyswietl();
        notatka.Diagnostyczna();

        notatka2.wyswietl();
        notatka2.Diagnostyczna();
    }

}