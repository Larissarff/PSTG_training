using System;

public class Metodo
{
    public static int CalculaFatorial (int numero)
    {
        if (numero == 0)
    {
        return 1;
    }
    else if (numero < 0)
    {
        return -1;
    }
    else
    {
        return numero * CalculaFatorial(numero - 1);
    }
    }
}

public class Principal
{
    
    public static void Main(){
        int numero = int.Parse(Console.ReadLine());
        
        int resultado = Metodo.CalculaFatorial(numero);
        
        Console.WriteLine("O resultado do fatorial de " + numero + " eh igual a: " + resultado);
    }
}
