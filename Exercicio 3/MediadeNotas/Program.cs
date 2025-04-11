using System;

public class MediadeNotas
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite a primeira nota:");
        string primeiraNotaTexto = Console.ReadLine();

        bool primeiraNotaEhNumero = double.TryParse(primeiraNotaTexto, out double primeiraNota);

        Console.WriteLine("Digite a segunda nota:");
        string segundaNotaTexto = Console.ReadLine();

        bool segundaNotaEhNumero = double.TryParse(segundaNotaTexto, out double segundaNota);

        Console.WriteLine("Digite a terceira nota:");
        string terceiraNotaTexto = Console.ReadLine();

        bool terceiraNotaEhNumero = double.TryParse(terceiraNotaTexto, out double terceiraNota);

        if (primeiraNotaEhNumero && segundaNotaEhNumero && terceiraNotaEhNumero)
        {
            double media = (primeiraNota + segundaNota + terceiraNota) / 3;

            Console.WriteLine("A média das notas é: " + media);
        }
        else
        {
            Console.WriteLine("Você digitou algo que não é um número. Por favor, tente novamente e digite apenas números para as notas.");
        }
    }
}