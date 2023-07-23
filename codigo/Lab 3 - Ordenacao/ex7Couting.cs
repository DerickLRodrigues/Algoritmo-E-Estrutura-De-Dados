using System;

class Program {

  public static void Contagem(int [] V){
     int maior=V[0];
    

    
    for(int i=1; i<V.Length;i++){
      if(V[i] > maior){
        maior = V[i];
      }
      
    }
    
    int [] con = new int[maior + 1];
    int [] V2 = new int [V.Length];
  
    
    for(int i=0; i<V.Length; i++){
    con[V[i]] += 1;
      }

    for(int i = 1; i < con.Length; i++){

      con[i] += con[i -1]; 
      
    }

    

     for(int i = V.Length - 1; i >=0; i--){

       V2[con[V[i]] - 1 ] = V[i];
       con[V[i]]--;
       
     }

    for(int i=0; i <V.Length; i++){
      V[i] = V2[i];
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
    Contagem(Vetor);
    for(int i=0; i<Vetor.Length; i++){
      Console.Write($"{Vetor[i]}, ");
    }
    
  }
}