using System;

public class MaiorNumero
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro número:");

        string textoDoPrimeiroNumero = Console.ReadLine();

        double primeiroNumero = double.Parse(textoDoPrimeiroNumero);

        Console.WriteLine("Digite o segundo número:");
        string textoDoSegundoNumero = Console.ReadLine();
        double segundoNumero = double.Parse(textoDoSegundoNumero);

        if (primeiroNumero > segundoNumero)
        {
            Console.WriteLine("O maior número é: " + primeiroNumero);
        }
        else if (segundoNumero > primeiroNumero)
        {
            Console.WriteLine("O maior número é: " + segundoNumero);
        }
        else
        {
            Console.WriteLine("Os dois números são iguais.");
        }
    }
}