using System;

public class CalculandoaIdade
{
    public static void Main(string[] args)
    {
        int anoAtual = 2024;

        Console.WriteLine("Por favor, digite o seu ano de nascimento:");
        string anoNascimentoString = Console.ReadLine();


        if (int.TryParse(anoNascimentoString, out int anoNascimento))
        {

            if (anoNascimento > 0 && anoNascimento <= anoAtual)
            {
                int idade = anoAtual - anoNascimento;
                Console.WriteLine($"Considerando o ano atual como {anoAtual}, sua idade é: {idade} anos.");
            }
        }
    }
}