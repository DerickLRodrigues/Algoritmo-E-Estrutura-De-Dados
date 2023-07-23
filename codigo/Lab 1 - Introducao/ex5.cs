using System;

class Program {
  static int Fatorial(int N){
    if(N==0){
      return 1;
    }else{
      return N * Fatorial(N-1);
    }
  }
  
  public static void Main (string[] args) {
    Console.WriteLine("Digite o numero do fatorial: ");
    int N = int.Parse(Console.ReadLine());
    Console.WriteLine($"O numero foi {Fatorial(N)}");
  }
}