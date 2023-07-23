using System;

class Program {
  static int Fun(ref int X,  int Y){
      if(Y==0){
        return 1;
      }else{
        
      return  X * Fun(ref X,  Y-1);
      }
    
    
  }
  
  public static void Main (string[] args) {
    Console.WriteLine("Digite o X");
    int X = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o Y");
    int Y = int.Parse(Console.ReadLine());
    Console.WriteLine($"{Fun(ref X, Y)}");
  }
}