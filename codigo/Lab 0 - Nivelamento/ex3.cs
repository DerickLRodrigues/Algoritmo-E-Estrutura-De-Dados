using System;

class Program {
  public static void Main (string[] args) {
    int[] idade = new int [10];
    int cont=0;
    for(int i =0; i<10; i++){
      Console.Write("Digite a idade: ");
      idade[i] = int.Parse(Console.ReadLine());
      if(idade[i] >= 18){
        cont++;
      }
    }
    Console.Write("{0} Pessoas tem mais que 18", cont);
    
  }
}