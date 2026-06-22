using System;

class Program
{
    static void Main()
    {
        double p1, p2Necessaria;

        Console.Write("Digite a nota P1: ");
        p1 = Convert.ToDouble(Console.ReadLine());

        p2Necessaria = (15 - p1) / 2;

        Console.WriteLine($"Necessita tirar {p2Necessaria:F2} na P2 para aprovação.");

        if (p2Necessaria > 10)
            Console.WriteLine("Mesmo tirando 10 não será possível atingir a média.");
    }
}