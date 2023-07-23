using System;

class Program {

  static int somaV(int []Numeros, int pos){
     int soma=0;
    if(pos == Numeros.Length){
      return 0;
    }else{
      if(Numeros[pos]%2==0){
        return soma += Numeros[pos] + somaV(Numeros,pos+1);
      }else{
        return somaV(Numeros, pos+1);
      }
      
    } 
    
  }

 


  
  
  public static void Main (string[] args) {
    Console.Write("Quantos numeros terá o vetor: ");
    int Max = int.Parse(Console.ReadLine());
   
    int [] N = new int [Max];
    for(int i=0; i<Max;i++){
      Console.Write($"Digite o numero {i}: ");
      N[i] = int.Parse(Console.ReadLine());  
    }
   Console.Write($"A soma dos numeros foram {somaV(N,0)}");
    
  }
}

/*Escreva um método recursivo que calcule a 
soma dos elementos de valor par de um 
vetor de números inteiros positivos.*/