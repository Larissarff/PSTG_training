using System;

public class Kata // Classe declarada 
{
  public int Num1;  // areas da classe (como uma struct)
  public int Num2;
  
  public int Soma(){
      return Num1 + Num2;
  }
    public static void Main(string[] args)
    {
        Kata numero = new Kata();  // Depois de criar uma nova classe "numero", referenciamos a ela nas atribuições
        numero.Num1 = 7;
        numero.Num2 = 8;
        
        int resultado = numero.Soma(); // variável para armazenar o resultado da função
        
        Console.WriteLine("A soma eh: " + resultado);
    }
  }
