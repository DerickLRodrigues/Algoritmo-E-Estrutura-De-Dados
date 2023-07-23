using System;

class Program {

  public static void ShellSort(int [] V, int Hop){

    if (Hop == 1){
      
      for(int i=1; i<V.Length; i++){
      int j = i -1, menor = V[i];
        while(j >=0 && V[j] > menor ){
          V[j + 1] = V[j];
          j--;
        }
        V[j + 1] = menor;
      }
      
    }else{

      for(int i =0; i<V.Length; i++){
        int j = i - Hop, menor = V[i];
        while(j>=0 && V[j] > menor){
          V[j + Hop] = V[j];
          j -= Hop;
        }
        V[j + Hop] = menor;  
      }
      ShellSort(V, Hop/2);
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
   ShellSort(Vetor, 4);
    for(int i=0; i<Vetor.Length; i++){
      Console.Write($"{Vetor[i]}, ");
    }
    
  }
}