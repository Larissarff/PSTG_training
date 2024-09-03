using System;   // Importando namespace

public class Kata   // Declarando a classe
{
  public static int SquareDigits(int numero) //Função principal
  {
    string concatenado = "";   // Criando a função que vai armazenar o novo numero

    while (numero > 0) {       // Enquanto o numero não for 0
            // Obtém o dígito mais à direita
            int digito = numero % 10;

            // Eleva o dígito ao quadrado
            int quadrado = digito * digito;
            concatenado = quadrado.ToString() + concatenado; // funcionalidade 'variavel.ToString()' transforma a variavel int em string, para que não se somem os resultados, e sim, sejam clocados lado a lado

            // Remove o dígito mais à direita
            numero /= 10;
        }
      return int.Parse(concatenado); // numero veio como string e dessa forma, é transformado para inteiro, para ser retornado ao final da função.
  }
    
    public static void Main ()
    {
    Console.WriteLine("Digite sua sequência numérica: \n"); // Pede ao usuário o numero
    string numeroString = Console.ReadLine();

    // Converte a string em inteiro
    int numero = int.Parse(numeroString);
    
    int resultado = SquareDigits(numero);

    Console.WriteLine("A sequência numerica fica: " + resultado);
  }
}   
