using System;

public class Kata{
    
    public static bool IsSquare(int n){
        double raizQuadrada = Math.Sqrt(n);
        bool ehInteiro = raizQuadrada % 1 == 0; // Verifica se não há parte decimal
        return ehInteiro;
    }
}


public class Program
{
    public static void Main()
    {
        Console.WriteLine("\tBem-vindo a calculadora de quadrados perfeitos");
        Console.WriteLine("Digite um numero e verifique se eh quadrado perfeito:");

        string input = Console.ReadLine();
        int num;
      
        Console.Write("\n");

        // Tenta converter a entrada para um número inteiro
        if (int.TryParse(input, out num))
        {
            bool resultado = Kata.IsSquare(num);
            if (resultado)
            {
                Console.WriteLine("O numero eh quadrado perfeito!");
            }
            else
            {
                Console.WriteLine("O numero não eh quadrado perfeito!");
            }
        }
        else
        {
            Console.WriteLine("Entrada invalida. Por favor, insira um número inteiro.");
        }
    }
}
