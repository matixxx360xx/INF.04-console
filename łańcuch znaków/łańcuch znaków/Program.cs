public class ChainTask
{
    public static int CountVolwes(string text)
    {
        string volwes = "aąeęiouyYóAĄEĘIOUÓY";
        int VolwesCount = 0;
        if (String.IsNullOrWhiteSpace(text)){
            return 0;
        }

        for (int i = 0; i < text.Length; i++){
            for (int j = 0; j < volwes.Length; j++){

                if (text[i] == volwes[j]){
                    VolwesCount += 1;
                }

            }
        }
        return VolwesCount;
    }
    public static string RemovingRepetitions(string text)
    {
        string TextWihoutRepetitions = "";
        if (String.IsNullOrWhiteSpace(text)){
            return "";
        }

        for (int i = 1; i < text.Length; i++)
        {
            if (text[i] != text[i - 1]){
                TextWihoutRepetitions += text[i];
            }

        }
        return text[0] + TextWihoutRepetitions;


    }

}

class Program
{
    public static void Main()
    {
        Console.WriteLine("Porsze wpisać jakikolwiek wyraz");
        string textToCheck = Console.ReadLine();
        Console.WriteLine("Liczba samoglosek");
        Console.WriteLine(ChainTask.CountVolwes(textToCheck));
        Console.WriteLine("tekst bez dupikatow");
        Console.WriteLine(ChainTask.RemovingRepetitions(textToCheck));
    }
}
