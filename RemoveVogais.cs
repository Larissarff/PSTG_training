using System;

public static class Kata
{
    public static string Disemvowel(string str)
    {
        //Quando houver vogal a, deve ser excluida da string
        //Nova string para armazenar
        string newPhrase = "";
        foreach (char letra in str){
            if( letra == 'A' || letra == 'a' ||
                letra == 'E' || letra == 'e' ||
                letra == 'I' || letra == 'i' ||
                letra == 'O' || letra == 'o' ||
                letra == 'U' || letra == 'u'){
                //Não adiciona nada
            }
            else
            {   // Inclui a letra na nova string
                newPhrase += letra;
            }
        }
         
        
        return newPhrase;
    }
}

public class Program
{
    
    public static void Main(){
        string str = "Boa tarde";
        
        string resultado = Kata.Disemvowel(str);
        
        Console.WriteLine("A frase fica: " + resultado);
    }
}
