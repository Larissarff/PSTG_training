using System;

public class Kata
{
  public static string[] Reverse(string text)
  {
    string[] newText = text.Split(" ");
    
    Array.Reverse(newText);
    
    return newText;
  }
}
public class Programa{
    public static void Main(){
        Console.WriteLine("Digite o texto que deseja inverter: ");
        string text = Console.ReadLine();
        
        string[] resultado = Kata.Reverse(text);
        
        // Console.WriteLine( "resultado eh: " + resultado);
        // Console.Write não consegue imprimir na tela uma string[], precisa ser transformada em string unica!
        string resultadoComoString = string.Join(" ", resultado);
        Console.Write("\n");// Só pra separar visualmente no output a string de entrada e a de saída.
        Console.WriteLine( "resultado eh: " + resultadoComoString);
    }
}
  
