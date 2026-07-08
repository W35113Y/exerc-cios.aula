using System;

class Program
{
    static void Main()
    {
        const int total = 10;
        double[] salario = new double[total];
        bool[] trabalhou = new bool[total];

        for (int i = 0; i < total; i++)
        {
            Console.Write("O motoboy " + (i + 1) + " trabalhou? (S/N): ");
            char resp = Convert.ToChar(Console.ReadLine().ToUpper());

            if (resp == 'S')
            {
                trabalhou[i] = true;

                Console.Write("Digite o valor recebido: R$ ");
                salario[i] = Convert.ToDouble(Console.ReadLine());
            }
            else
            {
                trabalhou[i] = false;
                salario[i] = 0;
            }
        }

        Console.Write("\nDigite o número do seu motoboy (1 a 10): ");
        int escolha = Convert.ToInt32(Console.ReadLine());

        if (trabalhou[escolha - 1])
        {
            double salarioFinal = salario[escolha - 1] * 1.10;

            Console.WriteLine("\nVocê trabalhou.");
            Console.WriteLine("Salário: R$ " + salario[escolha - 1].ToString("F2"));
            Console.WriteLine("Salário com 10%: R$ " + salarioFinal.ToString("F2"));
        }
        else
        {
            Console.WriteLine("\nVocê não trabalhou.");
            Console.WriteLine("Sua moto ficou parada e não houve ganho nesse período.");
        }

        Console.ReadKey();
    }
}