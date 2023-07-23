using System;

class Program {
    static int Poten(int A, int B){
      if(B==0){
        return 1;
      }else{
        return A * Poten(A, B-1);
      }
      
    }
  
  public static void Main (string[] args) {
    Console.Write("Digite o numero base: ");
    int n1 = int.Parse(Console.ReadLine());
    Console.Write("Digite a potencializacao: ");
    int n2 = int.Parse(Console.ReadLine());
    Console.Write($"O resultado foi {Poten(n1, n2)}");
  }
}

/*Escreva um método recursivo que realize a 
potenciação entre dois números inteiros, A 
e B, recebidos por parâmetro. Seu método 
deve, portanto, retornar o resultado de AB*/