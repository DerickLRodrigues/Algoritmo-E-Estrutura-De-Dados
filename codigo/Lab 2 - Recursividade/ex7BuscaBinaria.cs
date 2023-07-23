using System;

class Program {

  public static int BuscaBinaria(int [] V, int Procurado){

    int meio =V.Length/2, fim = V.Length-1;

    if(V.Length == 0){
      if(V[0] == Procurado){
        return 0;
      }
      return -1;
    }
    
    if(Procurado == V[meio]){
      return meio;
    }
    if(Procurado == V[fim]){
      return fim;
    }

  
    if(V[meio] > Procurado){

      int [] Vaux = new int [meio];
      for(int i=0; i<meio;i++){
        Vaux[i] = V[i];
      }
      return BuscaBinaria(Vaux, Procurado);
    }
    if(Procurado > V[meio+1]){

      int [] Vaux = new int [meio +1];
      int aux=0;
      for(int i=meio+1; i<V.Length;i++){
        Vaux[aux] = V[i];
        aux++;
      }
      return BuscaBinaria(Vaux, Procurado);
    }
      
    return 0;
    
    
  }


  
  public static void Main (string[] args) {
    int [] Vetor = new int [11] {1,2,3,4,5,6,7,8,9,10,11};
      Console.WriteLine("Digite os numeros");
    for(int i=0; i<Vetor.Length; i++){
      Console.WriteLine($"{Vetor[i]}");
    }
      Console.WriteLine("Qual numero irá buscar: ");
      int busca = int.Parse(Console.ReadLine());
    Console.WriteLine($"{BuscaBinaria(Vetor, busca)}");
  }
}