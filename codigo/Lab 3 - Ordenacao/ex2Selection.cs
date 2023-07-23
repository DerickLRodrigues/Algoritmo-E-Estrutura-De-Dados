using System;

class Program {

  public static void Selection(int []V){

    
    int aux=0;
    
    for(int i=0; i <  V.Length -1; i++){
     int menor =i;
      
      for(int j=i; j <= V.Length -1; j++){
          if(V[menor] > V[j]){
            menor = j;
          }
      }
      aux = V[i];
      V[i] = V[menor];
      V[menor] = aux;
      
      
    }  
  }
  
  public static void Main (string[] args) {
   Console.Write("Digite o tamanho do vetor: ");
      int  max = int.Parse(Console.ReadLine());
    
    int [] Vetor = new int[max];
      Console.Write("Digite o numero: ");
    for(int i=0; i<max; i++){
        
        Vetor[i] = int.Parse(Console.ReadLine());
    }
    Selection(Vetor);
    for(int i=0; i<Vetor.Length; i++){
      Console.Write($"{Vetor[i]}, ");
    }

    
  }
}