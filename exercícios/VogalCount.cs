// Return the number (count) of vowels in the given string.

// We will consider a, e, i, o, u as vowels for this Kata (but not y).

// The input string will only consist of lower case letters and/or spaces.

using System;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;

        // ler a string (palavra inteira) [ok]
        // quebrar a string em um array de char  [ok] - não precisa 
        // passar todos os elementos do array para minusculo [ok]
        str = str.ToLower(); 
       
        // comparar cada letra do array de char 
        foreach (char c in str) // Percorre cada caractere da string
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                vowelCount++;
            }
        }
        // toda vez que uma letra for igual, vowelCount += 1 [ok]
       
        return vowelCount;
    }
}
