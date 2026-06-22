using System;

class Program
{
    static void Main()
    {
        double a, b, media;

        Console.Write("Digite o primeiro valor: ");
        a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo valor: ");
        b = Convert.ToDouble(Console.ReadLine());

        media = Math.Sqrt(a * b);

        Console.WriteLine($"Média geométrica: {media}");
    }
}