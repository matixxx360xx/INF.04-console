class Sort {


    public int[] wypelnionaTablica;
    public int[] posortowanaTablica;
    public void WypelnieneiTablicy() {
        Random random = new Random();
        int[] tablicaLiczb = new int [100];
        for (int i = 0; i < tablicaLiczb.Length; i++) {
            tablicaLiczb[i] = random.Next(0, 1001);
        }
        wypelnionaTablica = tablicaLiczb;
    }
    public void BubbleSort(int[] tablica) {
        posortowanaTablica = (int[])tablica.Clone(); 
        for (int i = 0; i < posortowanaTablica.Length - 1; i++) {
            for (int j = 0; j < posortowanaTablica.Length - 1; j++) {
                if (posortowanaTablica[j] > posortowanaTablica[j + 1]) {
                    int tmp = posortowanaTablica[j];
                    posortowanaTablica[j] = posortowanaTablica[j + 1];
                    posortowanaTablica[j + 1] = tmp;
                }
            }
        }
      
    }

    public void Wyswietl() {
        Console.WriteLine("Nieposortowana tablica:");
        for (int i = 0; i < wypelnionaTablica.Length; i++) {
            Console.Write(wypelnionaTablica[i] + "-");
        }
        Console.WriteLine();
        Console.WriteLine("Posortowana tablica:");
        for (int i = 0; i < posortowanaTablica.Length; i++) {
            Console.Write(posortowanaTablica[i] + "-");
        }
    }



    public static void Main() {
        var sort = new Sort();
        sort.WypelnieneiTablicy();
        sort.BubbleSort(sort.wypelnionaTablica);
        sort.Wyswietl();


    }

}