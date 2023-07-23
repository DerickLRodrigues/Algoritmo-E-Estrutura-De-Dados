using System;

class Program {

  static void EPrimo(int n){
      
        for(int i =2; i < n; i++){
          if(n%i == 0){
            Console.WriteLine($"O {n} não é primo");
            break;
          }
          
      }
    Console.WriteLine($"O Numero {n} é primo ");
  }

  static void NPerf(int n){
    int ac =0;
      for(int i=1; i<n; i++){
        if(n%i==0){
          ac += i;
        }
      }
     if(n == ac)
      Console.WriteLine($"O numero {n} é perfeito");  
    
    
  }
  static int menu(){
    Console.WriteLine("1- Checar se o numero é primo ");
    Console.WriteLine("2 - Numeros perfeitos de 1 a 1000");
    int op = int.Parse(Console.ReadLine());
    return op;
  }
  public static void Main (string[] args) {
   int op=0;
    do{
      op=menu();
      switch(op){
      case 1:
    Console.WriteLine("Digite o numero a ser checado ");
    int n = int.Parse(Console.ReadLine());
    EPrimo(n);
        break;
      case 2:
    for(int i=1; i<=1000; i++){
      NPerf(i);
    }
        break;
      default:
        Console.WriteLine("Invalido");
        break;
      }
      }while(op !=0);
  }
}