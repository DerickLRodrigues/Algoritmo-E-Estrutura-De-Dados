using System;

class Program {
    

 public static void Bolinha( int [] V){

   int max= V.Length-1;
   
   int aux=0;
   for(int i=max; i>=0; i--){
    
     for(int j=0; j<=i; j++){
       
       if(V[j] > V[i]){
            aux = V[j];
            V[j] = V[i];
            V[i] = aux;
       }
       
     }
     
   }  
  }
  
  public static void Main (string[] args) {

     Console.Write("Digite o tamanho do vetor: ");
      int  max = int.Parse(Console.ReadLine());
    
    int [] Vn = new int[max];
      Console.Write("Digite o numero: ");
    for(int i=0; i<max; i++){
        
        Vn[i] = int.Parse(Console.ReadLine());
    }

    Bolinha(Vn);
    for(int i=0; i<Vn.Length; i++){
      Console.Write($"{Vn[i]}, ");
     
   }
    
    

    
  }
}