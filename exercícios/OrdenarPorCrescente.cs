// Sua tarefa é criar uma função que possa receber qualquer número inteiro não negativo como argumento e retorná-lo com seus 
// dígitos em ordem decrescente. Essencialmente, reorganize os dígitos para criar o número mais alto possível.
// Exemplos:

// Entrada: 42145 Saída: 54421

// Entrada: 145263 Saída: 654321

// Entrada: 123456789 Saída: 987654321
using System;
using System.Linq;

public static class Kata
{
    public static int DescendingOrder(int num)
    {
        // Passo 1: Converter o número para string
        string numeroComoTexto = num.ToString();

        // Passo 2: Converter a string para um array de caracteres
        char[] digitos = numeroComoTexto.ToCharArray();

        // Passo 3: Ordenar os dígitos em ordem decrescente
        digitos = digitos.OrderByDescending(c => c).ToArray();

        // Passo 4: Converter o array ordenado de volta para string
        string numeroOrdenado = new string(digitos);

        // Passo 5: Converter a string de volta para um número inteiro
        int resultado = int.Parse(numeroOrdenado);

        // Retornar o número final
        return resultado;
    }
}
