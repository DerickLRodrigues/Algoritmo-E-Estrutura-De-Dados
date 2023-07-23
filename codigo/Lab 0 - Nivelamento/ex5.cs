using System;

class Program {

  static int menu(){
    Console.WriteLine("1- Subtração");
    Console.WriteLine("2- Soma");
    Console.WriteLine("3- Multiplicação");
    Console.WriteLine("4- Divição");
    Console.WriteLine("0- Sair");
    int E = int.Parse(Console.ReadLine());
    return E;
  }

  
  public static void Main (string[] args) {
    int op=0;
    double operacao =0, n1=0, n2=0;
    do{
      op=menu();
      switch(op){
      case 1:
        Console.Write("Digite o numero: ");
        n1 = double.Parse(Console.ReadLine());
        Console.Write("Digite o numero: ");
        n2 = double.Parse(Console.ReadLine());
        operacao = n1 - n2;
        Console.WriteLine($"O resultado foi {operacao}");
        break;
      case 2:
        Console.Write("Digite o numero: ");
        n1 = double.Parse(Console.ReadLine());
        Console.Write("Digite o numero: ");
        n2 = double.Parse(Console.ReadLine());
        operacao = n1 + n2;
        Console.WriteLine($"O resultado foi {operacao}");
        break;
      case 3:
        Console.Write("Digite o numero: ");
        n1 = double.Parse(Console.ReadLine());
        Console.Write("Digite o numero: ");
        n2 = double.Parse(Console.ReadLine());
        operacao = n1 * n2;
        Console.WriteLine($"O resultado foi {operacao}");
        break;
      case 4:
        Console.Write("Digite o numero: ");
        n1 = double.Parse(Console.ReadLine());
        Console.Write("Digite o numero: ");
        n2 = double.Parse(Console.ReadLine());
        operacao = n1 / n2;
        Console.WriteLine($"O resultado foi {operacao}");
        break;
      case 0:
        Console.WriteLine("Obrigado por utilizar ");
        break;
      default:
        Console.WriteLine("OPÇÃO INVALIDA");
        break;
      }
      
    }while(op != 0);
    
  }
}