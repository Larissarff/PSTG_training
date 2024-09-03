using System;
using System.Linq;

public static class Kata
{
    public static string HighAndLow(string numbers)
    {
        // Dividindo a string em partes delimitando com os espaços(.Split(' ')), transformando cada delimitação em um int(.Select(int.Parse)) e adicionando em um array (.ToArray())
        int[] numerosInt = numbers.Split(' ').Select(int.Parse).ToArray();
        
        // Encontrando o maior(.Max()) e o menor número (Min())
        int high = numerosInt.Max();
        int low = numerosInt.Min();
        
        // Retornando o resultado em formato de string, juntando elas em um retorno apernas.
        return $"{high} {low}";
    }
  
    public static void Main()
    {
        string numbers = Console.ReadLine();
        string resultado = HighAndLow(numbers);
        Console.WriteLine(resultado);  
    }
