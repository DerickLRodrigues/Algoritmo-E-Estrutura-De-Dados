using System;

class Program {

   public static void adcTopo(int[] n, ref int contador, int numero)
        {

            n[contador] = numero;
            contador++;

        }

   public static int removeTopo( int[] n, ref int contador)
        {
          
           contador--;
          return n[contador];
          
        

        }  

  public static int pilhaTopo(int[] n, int contador)
        {
            return n[contador - 1];
            
        }
  public static void mostrarPilha(int [] n, int contador){
    for(int i=0; i<contador; i++){
      Console.Write($"{n[i]} ");
    }
    Console.WriteLine("");
  }

  public static int Menu(){
    int retorno =0;
    Console.WriteLine("1 adicionar topo");
    Console.WriteLine("2 remover topo");
    Console.WriteLine("3 mostrar topo");
     Console.WriteLine("4 mostrar pilha");
    Console.WriteLine("0 sair");
    retorno = int.Parse(Console.ReadLine());
    return retorno;
  }
  
  public static void Main (string[] args) {

    int op =0;
    int [] pilha = new int[5];
    int pos =0;
    do{

      switch(op = Menu()){
    case 1:
       Console.WriteLine("Digite o numero: ");
       int numero = int.Parse(Console.ReadLine());
      adcTopo(pilha, ref pos, numero);
      break;
      case 2:
        
        Console.WriteLine($"o topo era { removeTopo(pilha, ref pos)}");
        break;
      case 3:
        Console.WriteLine($"o topo é {pilhaTopo(pilha, pos)}");
        break;
      case 4:
        mostrarPilha(pilha, pos);
        break;
      default:
        Console.WriteLine("Adeus");
        break;
        
        }
    }while(op !=0);
    
  }
}