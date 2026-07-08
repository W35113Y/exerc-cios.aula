using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101); // Número entre 1 e 100

        int palpite;
        int errosInvalidos = 0;

        while (true)
        {
            Console.Write("Digite um palpite entre 1 e 100: ");
            palpite = int.Parse(Console.ReadLine());

            // Verifica se o palpite é inválido
            if (palpite < 1 || palpite > 100)
            {
                errosInvalidos++;

                if (errosInvalidos == 1)
                {
                    Console.WriteLine("Palpite inválido. Verifique.");
                }
                else if (errosInvalidos == 2)
                {
                    Console.WriteLine("Palpite continua inválido. Preste atenção no intervalo.");
                }
                else
                {
                    Console.WriteLine("Sem condição. Você não tem condição de continuar participando. Você perdeu!");
                    break;
                }

                continue;
            }

            // Verifica o palpite
            if (palpite == numeroSecreto)
            {
                Console.WriteLine("Parabéns! Você acertou!");
                break;
            }
            else if (palpite < numeroSecreto)
            {
                Console.WriteLine("O número é maior.");
            }
            else
            {
                Console.WriteLine("O número é menor.");
            }
        }
    }
}