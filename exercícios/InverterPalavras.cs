/* Preencha a função que aceita um parâmetro string e inverte cada palavra na cadeia de caracteres. Todos os espaços na corda devem ser mantidos.
   "This is an example!" ==> "sihT si na !elpmaxe"
   "double  spaces"      ==> "elbuod  secaps"
*/


using System;
using System.Linq;

public class Kata
{
  public static string ReverseWords(string text)
  {
     return string.Join(" ", text.Split(' ').Select(word => new string(word.Reverse().ToArray())));
  }
}

/* Step by step
   string.Join(" ") =  Junta as palavras de volta, separadas por espaços.
   text.Split(' ') = Separa as palavras dentro da string inteira quando acha um espaço.
   .Select(word => new string()) = cria uma nova string de armazenamento 
   word.Reverse() = inverte os elementos da string
   .ToArray() = dispõe esses novos caracteres para dentro de um array que, posteriormente, serão unificados em uma só string usando o 'string.Join(" ")'
*/
