using System;

namespace Solution
{
  public class Kata
    {
      public static int binaryArrayToNumber(int[] BinaryArray){
        
        int DecimalNumber = 0;
        for(int j = 0; j < BinaryArray.Length; j++){
            DecimalNumber += BinaryArray[BinaryArray.Length - 1 - j] * (int)Math.Pow(2, j);
            // '.Length' = mapeia o tamanho do array
        
        }
        return DecimalNumber;
      }
   }
    class Program{
        
    public static void Main(){
       
       int[] Number;
       Number = new int[] {0,1,0,1};
       string ExporNumeroBinario;
       ExporNumeroBinario = string.Join("", Number);
       
       int resultado = Kata.binaryArrayToNumber(Number);
       Console.Write("Testing: [" + ExporNumeroBinario + "] ==> " + resultado);
   }
}
}
