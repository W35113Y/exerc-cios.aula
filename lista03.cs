using System;

class Program
{
    static void Main()
    {
        double valor;

        do
        {
            Console.Write("Digite um valor positivo: ");
            valor = Convert.ToDouble(Console.ReadLine());

            if (valor <= 0)
                Console.WriteLine("Erro! Digite apenas valores positivos.");
        }
        while (valor <= 0);

        Console.WriteLine($"Valor informado: {valor}");
    }
}