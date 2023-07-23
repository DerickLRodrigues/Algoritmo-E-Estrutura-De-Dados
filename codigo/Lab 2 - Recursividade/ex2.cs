using System;

class Program {

  static int Mult(int A, int B){
       if(B==0){
         return 0;
       }else{
         return A + Mult(A, B-1);
       }
  
  }

  
  public static void Main (string[] args) {
    Console.Write("Digite o numero base a ser multiplicado: ");
    int N1 = int.Parse(Console.ReadLine());
    Console.Write("Digte o numero de vezes: ");
    int N2= int.Parse(Console.ReadLine());
    Console.WriteLine($"O resultado foi {Mult(N1,N2)}");
  }
}

/*Uma multiplicação pode ser vista como uma 
sequência de somas. Escreva um método 
recursivo que realize a multiplicação de dois 
números inteiros, A e B, recebidos por 
parâmetro.*/