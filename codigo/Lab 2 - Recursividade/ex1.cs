using System;

class Program {
   static int Fatorial(int n){
        if(n == 0){
          return 1;
        }else{
          return n*Fatorial(n-1);
        }
     
   }
  
  public static void Main (string[] args) {
    Console.Write("Digite o numero: ");
    int numero = int.Parse(Console.ReadLine());
    Console.WriteLine($"O resultado foi {Fatorial(numero)}");
  }
}

/*Escreva um método recursivo que retorne o 
fatorial de um número.*/