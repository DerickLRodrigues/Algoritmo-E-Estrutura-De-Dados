using System;

class Program {
  public static void Main (string[] args) {
    Console.Write("Digite o numero: ");
    int num = int.Parse(Console.ReadLine());
    if(num % 2 == 0 && num !=0){
      Console.Write("Numero Par");
    }else{
      if(num % 2 !=0 && num !=0 ){
        Console.Write("Impar");
      }else{
        Console.Write("Zero é neutro");
      }
    }
    
  }
}