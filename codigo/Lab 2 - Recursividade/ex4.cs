using System;

class Program {
  static int contaL(string frase, char letra ){
       if (frase.Length == 0)
    {
        return 0;
    }

    // Verifica se a primeira letra da string é igual à letra procurada
    int count = 0;
    if(frase[0] == letra){
      count++;
      }

    // Chama recursivamente o método para a string restante
    return count + contaL(frase.Substring(1), letra);
  }
  


  
  public static void Main (string[] args) {
    Console.WriteLine ("Digite a sua frase: ");
    string F = Console.ReadLine();
    Console.Write("Digite a letra: ");
    char L = Char.Parse(Console.ReadLine());

    Console.Write($"A letra {L}, repetiu {contaL(F, L)}");
  }
}

/*Escreva um método recursivo que receba 
uma frase e uma letra como parâmetros. 
Este método deve retornar a quantidade de 
ocorrências desta letra nesta frase.*/