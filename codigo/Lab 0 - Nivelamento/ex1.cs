using System;

class Program {
  public static void Main (string[] args) {
    int [] idade = new int[5]; 
    double media=0;
    for(int i=0; i < 5; i++){
      Console.Write("Digite a idade: ");
      idade[i] = int.Parse(Console.ReadLine());
      media += idade[i];
    }
    media /= 5;
  Console.Write($"A media foi: {media}");

    
  }
}