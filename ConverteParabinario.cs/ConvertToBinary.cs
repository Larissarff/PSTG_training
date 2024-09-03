using System;

public class Kata // Classe declarada // public: pode ser acessada fora da classe
{
  public int Num1;  // areas da classe (como uma struct)
  public int Num2;
  
  public int Soma(){
      return Num1 + Num2;
  }
  
    public static string AddBinary(int a, int b){
         return Convert.ToString(a + b, 2); // Função que converte de int para string comando os dois parâmetros informados e converte em uma base 2.
      }
    public static void Main(string[] args)
    {
        Kata numero = new Kata();  // Depois de criar uma nova classe "numero", referenciamos a ela nas atribuições
        numero.Num1 = 3;
        numero.Num2 = 1;
        
        int resultado = numero.Soma(); 
        // variável int para armazenar o resultado da função de soma em decimal
        string resultadoBinary = AddBinary(numero.Num1, numero.Num2);
        // variável string que armazena o resultado da função em binário.
        
        Console.WriteLine(resultadoBinary);
    }
      
  }
