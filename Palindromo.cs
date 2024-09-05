using System;

class ProgramaPalindromo
{
    static void Main()
    {
        Console.WriteLine("Digite uma palavra:");
        string palavra = Console.ReadLine();

        if (EhPalindromo(palavra))
        {
            Console.WriteLine($"{palavra} é um palíndromo.");
        }
        else
        {
            Console.WriteLine($"{palavra} não é um palíndromo.");
        }
    }

    static bool EhPalindromo(string palavra)
    {
        // Remove espaços e converte para minúsculas para evitar erros de comparação
        palavra = palavra.Replace(" ", "").ToLower();

        int inicio = 0;
        int fim = palavra.Length - 1;

        while (inicio < fim)
        {
            if (palavra[inicio] != palavra[fim])
            {
                return false;
            }
            inicio++;
            fim--;
        }

        return true;
    }
}
