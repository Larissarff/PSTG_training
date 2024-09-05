using System;

namespace Solution
{
  public class SolutionClass
  {
    public static string Compare(int a, int b)
    {
      string aux1 = a.ToString();  // teste
      string aux2 = b.ToString();  // teste
      
      //string[] subdivision1 = aux1.Split("");
      //string[] subdivision2 = aux2.Split("");
      
      string percents = "";
      
      if (aux1[0] == aux2[0])
      {
        if(aux1[1] == aux2[1])
        {
          percents = "100%";
        } 
        else
        {
          percents = "50%";
        }
      } 
      else if (aux1[1] == aux2[1])
      {
        percents = "50%";
      }
      else
      {
        percents = "0%";
      }
      
      return percents;
    }
  }
}

/*
Test Failed
  Expected string length 4 but was 2. Strings differ at index 0.
  Expected: "100%"
  But was:  "0%"
  -----------^
*/
