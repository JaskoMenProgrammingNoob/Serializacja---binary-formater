using System;
using System.IO;
using System.Text.Json;
class Serializacja
{
    double[] pomiary = [2.43, 5.23, 3.14, 4.56, 7.89, 9.12];
    public void Zapisz_i_wczytaj_dane()
    {
        for (int i = 0; i < pomiary.Length; i++)
        {
            Console.Write(pomiary[i] + " ");
        }
        Console.WriteLine();
        string tekst = JsonSerializer.Serialize(pomiary);
        File.WriteAllText("pomiary.txt", tekst);
        string odczyt = File.ReadAllText("pomiary.txt");
        pomiary = JsonSerializer.Deserialize<double[]>(odczyt);
        Console.WriteLine("Co drugi pomiar:");
        for (int i = 0; i < pomiary.Length; i += 2)
        {
            Console.WriteLine(pomiary[i]);
        }
    }
    static void Main(string[] args)
    {
        Serializacja serializacja = new Serializacja();
        serializacja.Zapisz_i_wczytaj_dane();
    }
}