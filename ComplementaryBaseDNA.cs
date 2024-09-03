using System;

public class DnaStrand // define a classe
    {
        public static string MakeComplement(string dna) // começa a função que tratará da complementar
        {
            string NovoDna = ""; // cria uma string para armazenar o novo dna espelhado
        
            foreach (char letra in dna){  // Loop para percorrer cada letra da string dna dada no parametro da função
                if ((letra == 'A') || (letra == 'a')) // condição no bloco condicional
                {
                    NovoDna += 'T'; // adiciona um a mais na nova string
                }
                else if ((letra == 'T') || (letra == 't'))
                {
                    NovoDna += 'A';
                }
                else if ((letra == 'G') || (letra == 'g'))
                {
                    NovoDna += 'C';
                }
                else
                {
                    NovoDna += 'G';
                }

            }
            return NovoDna;
        
        }

        public static void Main()
        {
            Console.WriteLine("Digite sua fileira de DNA: \n"); // exibe a mensagem para o usuário
            string dna = Console.ReadLine();  // lê o valor da string 

            string resultado = MakeComplement(dna);

            Console.WriteLine("A fileira complementar é: " + resultado);

        }
    }
