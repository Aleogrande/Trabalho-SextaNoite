using System;

public class DescobrirSeParOuImpar
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Por favor, digite um número inteiro:");

        string oQueUsuarioDigitou = Console.ReadLine();

        int numeroDigitado = 0;

        bool deuCerto = int.TryParse(oQueUsuarioDigitou, out numeroDigitado);

        if (deuCerto == true)
        {
            int restoDaDivisaoPorDois = numeroDigitado % 2;

            if (restoDaDivisaoPorDois == 0)
            {
                Console.WriteLine("O número " + numeroDigitado + " é par.");
            }
            else
            {
                Console.WriteLine("O número " + numeroDigitado + " é ímpar.");
            }
        }
        else
        {
            Console.WriteLine("Você não digitou um número inteiro! Tente novamente.");
        }
    }
}