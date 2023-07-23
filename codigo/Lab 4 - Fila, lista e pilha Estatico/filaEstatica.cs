using System;

class Program {

  //fila

  public static void adcElementoFila(int [] vetor, int numero, ref int posicao){

    vetor[posicao] = numero;
    posicao++;
    
  }

  public static int removeFila(ref int[] vetor, ref int posicao)
{
    int r = vetor[0];
    for (int i = 0; i < posicao - 1; i++)
    {
        vetor[i] = vetor[i + 1];
    }
    vetor[posicao - 1] = 0;
    posicao--;
    return r;
}

  public static int primeiroFila(int [] vetor){

    
    return vetor[0];
    
  }

  public static void imprimirFila(int [] vetor){

    for(int i=0; i< vetor.Length; i++){
      Console.Write($"{vetor[i]} ");
      
    }
    Console.WriteLine("");
    
  }

  public static int menu(){

    Console.WriteLine("1 - Adicionar elemento");
    Console.WriteLine("2 - remove Fila");
    Console.WriteLine("3 - Primeiro Da Fila");
    Console.WriteLine("4 - Imprimir Fila");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("Digite a opcao: ");
    int op = int.Parse(Console.ReadLine());
    return op;
  }
  

 

  
  
  public static void Main (string[] args) {
    int op =0;
    int [] fila = new int[3];
    int pos =0;
    do{

      switch(op = menu()){
      case 1:
        Console.WriteLine("Digite o numero: ");
        int n = int.Parse(Console.ReadLine());
        adcElementoFila(fila,n,ref pos);
        break;
      case 2:
        Console.WriteLine($"O primeiro era {removeFila(ref fila,ref pos)}"); 
        break;
      case 3:
        Console.WriteLine($"{primeiroFila(fila)}");
        break;
      case 4:
        imprimirFila(fila);
        break;
      default: 
        Console.WriteLine("Adeus");
        break;
      }

      
    }while(op != 0);
   

    
  }
}