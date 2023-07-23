using System;

class Program {
  public static void Main (string[] args) {
    Console.Write("Digite a sua idade: ");
    int idade= int.Parse(Console.ReadLine());
    if(idade < 18){
      Console.BackgroundColor = ConsoleColor.Red;
      Console.WriteLine("Sem permissão ");
    }else{
      Console.BackgroundColor = ConsoleColor.Green;
      Console.WriteLine("Permissão concedida");
    }
    
  }
}