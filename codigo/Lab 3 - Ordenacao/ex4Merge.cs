using System;

class Program {

  public static void Merge(int [] V, int inicio, int fim){ 
    
    if(inicio < fim){
        int meio = (inicio + fim) /2; 
        Merge(V, inicio, meio);  
        Merge(V, meio +1, fim);  
        V = intercalar(V, inicio, fim);
    }
    
  }

  public static int [] intercalar(int [] V, int inicio, int fim){
   int [] aux = new int[V.Length];
    for(int t = inicio; t<=fim; t++){
      aux[t] = V[t];
    }

    int i = inicio; //Lado esquedo
    int j = inicio; //Vetor novo
    int meio = (inicio + fim)/2; //Meio do vetor que chegou
    int k = meio + 1; //Lugar onde vai comecar o vetor da direita

    while(i <= meio && k <= fim){

      if(aux[i] > aux[k]){
        V[j] = aux[k];
        k++;
      }else{
        V[j] = aux[i];
        i++;
      }
      j++;   
    }

    while(i <= meio){
      V[j] = aux[i];
      j++;
      i++;
    }

    while(k <= fim){

      V[j] = aux[k];
      k++;
      j++;
    }

    return V;

    
    
  }
  
  public static void Main (string[] args) {
    Console.Write("Digite o tamanho do vetor: ");
      int  max = int.Parse(Console.ReadLine());
    
    int [] Vetor = new int[max];
      Console.Write("Digite o numero: ");
    for(int i=0; i<max; i++){
        
        Vetor[i] = int.Parse(Console.ReadLine());
    }

    Merge(Vetor, 0, max-1);
      for(int i=0; i< Vetor.Length; i++){
        Console.Write($"{Vetor[i]}, ");
      }

    

    
    
  }
}