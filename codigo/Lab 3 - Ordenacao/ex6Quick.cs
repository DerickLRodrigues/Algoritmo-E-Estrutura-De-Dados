using System;

class Program {

  public static void Quicksort(int [] V, int inicio, int fim){
     int part;
    if(inicio<fim){

        part = particao(V, inicio, fim);
        Quicksort(V, inicio, part-1);
        Quicksort(V, part+1, fim); 
      }
  }


  public static int particao(int [] V, int inicio, int fim){

    int pivo = V[fim];
    int part = inicio -1;
    int aux;
    for(int i=inicio; i<fim; i++){
      if(V[i] < pivo) {
      part ++;
      aux = V[part];
      V[part] = V[i];
      V[i] = aux;
        }
    }

    part++;
    aux = V[part];
    V[part] = V[fim];
    V[fim] = aux;

    return part;
    
  }

  
  
  public static void Main (string[] args) {

    Console.Write("Digite o tamanho do vetor: ");
      int  max = int.Parse(Console.ReadLine());
    
    int [] Vetor = new int[max];
      Console.Write("Digite o numero: ");
    for(int i=0; i<max; i++){
        
        Vetor[i] = int.Parse(Console.ReadLine());
    }
    Quicksort(Vetor, 0, max-1);
    for(int i=0; i<Vetor.Length; i++){
      Console.Write($"{Vetor[i]}, ");
    }
    
  }
}