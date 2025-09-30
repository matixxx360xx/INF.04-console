using System;

public class Zadanie
{
    public int[] tab = new int[50];

    public void WypelnienieTablicy()
    {
        Random r = new Random();
        for (int i = 0; i < tab.Length; i++)
        {
            tab[i] = r.Next(1, 101);
        }
    }
    public void WyswietlenieTablicy()
    {

        Console.WriteLine(string.Join(",", tab));
    }

    public void znajdz(int i)
    {
        int j = 0;
        int[] NewTab = new int[tab.Length + 1];
        Array.Copy(tab, NewTab, tab.Length);
        NewTab[NewTab.Length - 1] = i;
        while (NewTab[j] != i)
        {
            j++;
        }
        if (j < tab.Length)
        {
            Console.WriteLine($"Znaleziono liczbę {i} na indeksie {j}");
        }
        else
        {

            Console.WriteLine("Nie znaleziono!");
        }
    }

    public static void Main(string[] args)
    {
        Zadanie z = new Zadanie();
        z.WypelnienieTablicy();
        z.WyswietlenieTablicy();
        z.znajdz(4);

    }
}