using System;

class Program {

  public static void adcElementoLista(int [] vetor, int pos, int numero){

    vetor[pos]=numero;
    
  }
  
  public static void excluirElementoPos ( int [] vetor, int excluir){

  
  vetor[excluir] = 0;
  for(int i=excluir; i<vetor.Length -1; i++){
   vetor[i] = vetor[i+1];
  }
    vetor[vetor.Length-1] = 0;    
   
  }

  public static bool procurarElemento(int [] vetor, int n){

    
    for(int i=0; i<vetor.Length;i++){

      if(vetor[i] == n){
        return true;
      }
      
    }
    return false;
    
  }

  public static void imprimirLista(int [] vetor){
    for(int i=0; i<vetor.Length;i++){
      Console.Write($"{vetor[i]} ");
    }
    Console.WriteLine(" ");
  }

   public static int menu(){

    Console.WriteLine("1 - Adicionar elemento");
    Console.WriteLine("2 - remover");
    Console.WriteLine("3 - Localizar elemento");
    Console.WriteLine("4 - Imprimir Lista");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("Digite a opcao: ");
    int op = int.Parse(Console.ReadLine());
    return op;
  }
  
  public static void Main (string[] args) {

    int op =0;
    int [] lista = new int[3];
    do{

      switch(op = menu()){
      case 1:
        Console.WriteLine("Digite o numero: ");
        int n = int.Parse(Console.ReadLine());
         Console.WriteLine("Digite a posicao: ");
        int p = int.Parse(Console.ReadLine());
        adcElementoLista(lista,p,n);
        break;
      case 2:
         Console.WriteLine("Digite a posicao a excluir: ");
        int e = int.Parse(Console.ReadLine());
        excluirElementoPos(lista, e);
        break;
      case 3:
        Console.WriteLine("Digite o numero a procurar: ");
        int np = int.Parse(Console.ReadLine());
        if(procurarElemento(lista, np)){
          Console.WriteLine("Numero encontrado");
        }else{
          Console.WriteLine("Numero nao encontrado");
        }
        break;
      case 4:
        imprimirLista(lista);
        break;
      default: 
        Console.WriteLine("Adeus");
        break;
      }

      
    }while(op != 0);
   

    
  }
}