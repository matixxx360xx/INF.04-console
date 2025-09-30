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

    public int Znajdz(int i)
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
            return j;
        }
        return -1;
    }

    public static void Main(string[] args)
    {
        Zadanie z = new Zadanie();
        z.WypelnienieTablicy();
        z.WyswietlenieTablicy();
        int value = 4;
        if (z.Znajdz(value) > -1)
        {
            Console.WriteLine("Liczbe "+value+ " znaleziono na indeksie" + " " + z.Znajdz(value));
        }
        else {
            Console.WriteLine("Nie znaleziono!");
        }
    }
}