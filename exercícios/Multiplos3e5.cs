// Se listarmos todos os números naturais abaixo de 10 que são múltiplos de 3 ou 5, obtemos 3, 5, 6 e 9. A soma desses
// múltiplos é 23.

// Finalize a solução para que ela retorne a soma de todos os múltiplos de 3 ou 5 abaixo do número passado.

// Além disso, se o número for negativo, retorne 0.

// Observação: se o número for múltiplo de 3 e 5, conte-o apenas uma vez.

// Cortesia de projecteuler.net (Problema 1)

public static class Kata
{
  public static int Solution(int value)
  {
    if (value < 0) return 0;
    //ver quantos numeros faltam para value chegar até 0
    int somaCount = 0;
    
      for (int i = 0; i < value; i++) 
      {
        if( i  % 3 == 0 ||  i  % 5 == 0)
        {
        somaCount += i;
        } 
      }
        return somaCount;
  }
}