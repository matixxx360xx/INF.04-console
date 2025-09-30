class Algorytm {

    public int NWD(int a, int b) {
        while (a != b) {
            if (a > b)
            {
                a = a - b;
            }
            else {
                b = b - a;
            }
        }
        return a;
    }

    static void Main() {
        Algorytm l = new Algorytm();
        string? input;

        Console.Write("Podaj pierwszą liczbę: ");
        input = Console.ReadLine();
        int b = int.Parse(input);

        Console.Write("Podaj drugą liczbę: ");
        input = Console.ReadLine();
        int a = int.Parse(input);


        Console.WriteLine(l.NWD(a, b));
    
    }

}