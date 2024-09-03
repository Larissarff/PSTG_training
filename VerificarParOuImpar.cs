using System; // Importação 

namespace Solution  // atribui contexto 
{
  public class Numero  // iniciando uma classe 
  // Public = pode ser acessado em qualquer parte do código
  // Private = só pode ser acessado na função que é declarada
  {
    public static string EvenOrOdd(int number)  // função do tipo string pois retorna uma string, mas tem como parametro um int
    {
      if (number % 2 == 0){
        return "Even";
      }
        
      else{
         return "Odd";
      }   
  }
 }
}
