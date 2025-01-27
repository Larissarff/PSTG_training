using System;
using System.Collections.Generic;

namespace Solution {

  class Kata{
    public static Dictionary<string, int> get_animals_count(int legs_number, int heads_number, int horns_number){
        
      int quantidadeDeVacas = horns_number / 2;
      
      heads_number = heads_number - quantidadeDeVacas;
      legs_number = legs_number - (quantidadeDeVacas * 4);
      
      int quantidadeDeCoelhos = (legs_number / 2) - heads_number;
      
      int quantidadeDeGalinhas = heads_number - quantidadeDeCoelhos;

      return new Dictionary<string, int>() {
        {"rabbits", quantidadeDeCoelhos},
        {"chickens", quantidadeDeGalinhas},
        {"cows", quantidadeDeVacas}
      };
    }
  }
}
