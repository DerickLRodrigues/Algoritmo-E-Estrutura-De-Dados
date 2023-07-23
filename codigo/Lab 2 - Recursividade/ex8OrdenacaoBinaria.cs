using System;

class Program {

  public static void BuscaBinariaOrdenada(int [] V, int inicio, int fim){
    
    if(inicio < fim){
        int meio = (inicio + fim) /2;
        BuscaBinariaOrdenada(V, inicio, meio);
        BuscaBinariaOrdenada(V, meio +1, fim);
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
    Console.WriteLine("Qual sera o tamanho do vetor");
    int max= int.Parse(Console.ReadLine());
    int [] Vetor = new int [10] {12,43,54,23,65,23,54,65,76,87};
     Console.WriteLine("Digite os numeros a serem recebidos: ");
      for(int i=0; i<Vetor.Length;i++){
      Console.WriteLine($"{Vetor[i]}");
    } 
    BuscaBinariaOrdenada(Vetor, 0, 9);
    for(int i=0; i<Vetor.Length;i++){
      Console.Write($"{Vetor[i]} - ");
    }
      
  }
}