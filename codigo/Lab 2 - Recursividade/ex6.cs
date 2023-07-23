using System;

class Program {


  public static string RemoveVogal(string frase)
{
    if (string.IsNullOrEmpty(frase))
    {
        return frase;
    }
    
    char primeiraL = frase[0];
    string letras = frase.Substring(1);
    
    if ("AaEeIiOoUu".IndexOf(primeiraL) >= 0)
    {
        return RemoveVogal(letras);
    }
    else
    {
        return primeiraL + RemoveVogal(letras);
    }
}

  
   
  
  public static void Main (string[] args) {
    Console.WriteLine ("Digite a frase: ");
    string frase = Console.ReadLine();
    Console.WriteLine($"{RemoveVogal(frase)}");
  }
}

/*Escreva um método recursivo que receba 
uma frase e retorne a mesma frase, sem 
nenhuma vogal. */
//String.Replace
//Substring
