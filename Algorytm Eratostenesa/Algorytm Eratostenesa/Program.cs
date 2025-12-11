class Algorytm {

    public int[] tablica;
    public void WypelnienieTablicy(int[] tablica) {
        this.tablica = tablica;
        for (int i = 0; i < tablica.Length; i++)
        {
            tablica[i] = i+2;
        }

    }

    public void SprawdzanieLiczbPierwszych() {
        for (int i = 0; i < tablica.Length; i++) {
            if (tablica[i] != 0) {
                for (int j = i + tablica[i]; j < tablica.Length; j += tablica[i]) {
                    tablica[j] = 0;
                }
            }
        }

        Console.WriteLine("Liczby pierwsze:");
        for (int i = 0; i < tablica.Length; i++)
        {
            if (tablica[i] != 0)
                Console.Write(tablica[i] + " ");
        }
        Console.WriteLine();

    }

    public static void Main() {
        var prorgam = new Algorytm();
        int[] tablica = new int[98];  
        prorgam.WypelnienieTablicy(tablica);
        prorgam.SprawdzanieLiczbPierwszych();

    }
}