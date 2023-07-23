using System;

class Program {

  static void cp(int n){
    int n1 = n/100,n2 = n%100, soma = n1+n2;
    if(Math.Pow(soma,2) == n){
      Console.WriteLine($"O numero {n} possui essa caracteristica particular ");
    }
    
  }
  
  public static void Main (string[] args) {
     
    for(int i = 1000; i < 10000; i++){
      cp(i);
    }
    
  }
}