class Filmy {

    private int wypozyczenia;
    private string tytul;

    public Filmy() {
        wypozyczenia = 0;
        tytul = "";
    }

    public void Setter_Tytul(string Tytul){
       tytul = Tytul;
    }
    public string Getter_Tytul(){
        return tytul;
    }
    public int Getter_Wypozycznia(){
        return wypozyczenia;
    }

    public void Wypozyczenia(){
        wypozyczenia++;
    }

    public static void Main() {
        Filmy filmy = new();
        Console.WriteLine(filmy.Getter_Wypozycznia());
        filmy.Setter_Tytul("Pan Tadeusz");
        filmy.Wypozyczenia();
        Console.WriteLine(filmy.Getter_Tytul());
        Console.WriteLine(filmy.Getter_Wypozycznia());

    }
}