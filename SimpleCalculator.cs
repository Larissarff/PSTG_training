
using System;

public class SimpleCalculator
{
    public int Somar(int num1, int num2){
        return num1 + num2;
    }
    
    public int Subtrair(int num1, int num2){
        return num1 - num2;
    }
    
    public int Multiplicar(int num1, int num2){
        return num1 * num2;
    }
    
    public int Dividir(int num1, int num2){
        if (num2 == 0){
            return 0;
        }
        else{
            return num1 / num2;
        }
    }
    
    public static void Main()
    {
        SimpleCalculator calculadora = new SimpleCalculator(); // !!!!!
         
         
        Console.Write("\t Bem vindo á calculadora! \n Digite seu numero 1 a ser operacionado: \n");
        int Num1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite o segundo numero: ");
        
        int Num2 = int.Parse(Console.ReadLine());
        
        int soma = calculadora.Somar(Num1, Num2);
        int subtracao = calculadora.Subtrair(Num1, Num2);
        int multiplicacao = calculadora.Multiplicar(Num1, Num2);
        int divisao = calculadora.Dividir(Num1, Num2);
        
        Console.Write("As operações são: soma = " + soma + ", subtração = " + subtracao + ", multiplicacao = " + multiplicacao + " e divisao = " + divisao );
    }
}
