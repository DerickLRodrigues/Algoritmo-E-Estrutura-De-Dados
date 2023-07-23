using System;

class Program {

 static public  void RadixSortLSD(int [] V){
      int maior = V[0];
      for(int i=1; i<V.Length; i++){
        if(V[i] > maior){
          maior = V[i];
        }
      }

    for(int digitos = 1; maior/digitos > 0; digitos *=10){
      Contagem(V, digitos);
    }

    
  }

  static public void Contagem(int [] V, int Unidade){
     
    int [] V2 = new int [V.Length];  
    int [] con = new int[10]; // 0, 1, 2, 3, 4, 5, 6 ,7 ,8 ,9

  
    
    for(int i=0; i<V.Length; i++){

      int digitoUni = (V[i] / Unidade) % 10;
      con[digitoUni]++;      
      }

    for(int i = 1; i < con.Length; i++){

      con[i] += con[i - 1]; 
      
    }

    

     for(int i = V.Length - 1; i >=0; i--){

       int digitoUni = (V[i] / Unidade) % 10;
       V2[con[digitoUni] - 1 ] = V[i];
       con[digitoUni]--;
       
     }

    
    for(int i=0; i<V.Length;i++){
      V[i] = V2[i];
    }
   
    
  }

  
  public static void Main (string[] args) {
    /* int [] vetor = new int [40];

       Random preenche = new Random();
       for(int i=0; i< vetor.Length; i++){
         vetor[i] = preenche.Next(10000);
       }
    RadixSortLSD(vetor);
       for(int i=0; i< vetor.Length; i++){
         Console.Write($"{vetor[i]} - ");*/
    
   Console.Write("Digite o tamanho do vetor: ");
      int  max = int.Parse(Console.ReadLine());
    
    int [] Vetor = new int[max];
      Console.Write("Digite o numero: ");
    for(int i=0; i<max; i++){
        
        Vetor[i] = int.Parse(Console.ReadLine());
    }
    RadixSortLSD(Vetor);
    for(int i=0; i<Vetor.Length; i++){
      Console.Write($"{Vetor[i]}, ");
    }

    
    
       }
    

    
  }
