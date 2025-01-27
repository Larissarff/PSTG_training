using System;

public class Kata
{
    public static string GimmeTheLetters(string sp)
    {
        // Separar o intervalo com base no hífen
        char letraInicial = sp[0];
        char letraFinal = sp[2];

        // Verifica se a letra inicial está em maiúsculas
        bool isMaiusculo = char.IsUpper(letraInicial);

        // Criar uma string com as letras no intervalo
        string resultado = "";
        for (char letra = letraInicial; letra <= letraFinal; letra++)
        {
            resultado += letra;
        }

        // Retorna o resultado em maiúsculas ou minúsculas conforme o caso da letra inicial
        return isMaiusculo ? resultado.ToUpper() : resultado.ToLower();
    }
}
