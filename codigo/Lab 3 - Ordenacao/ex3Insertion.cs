using System;

class Program {

  public static void insertion(int [] V){
     int menor = 0,j=0;
    for(int i=1; i<V.Length; i++){
      menor=V[i]; 
      j = i -1; 
      while(j >= 0 && V[j] > menor){
        V[j + 1] = V[j];
        j--;
        
      }
      V[j +1]= menor;
      
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
    insertion(Vetor);
    for(int i=0; i<Vetor.Length; i++){
      Console.Write($"{Vetor[i]}, ");
    }

    
  }
}