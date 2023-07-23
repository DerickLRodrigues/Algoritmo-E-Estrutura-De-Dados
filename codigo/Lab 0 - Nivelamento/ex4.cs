using System;

class Program {
  public static void Main (string[] args) {
    int [] matricula = new int[10];
    double [] altura = new double[10];
    for(int i=0; i<10; i++){
      Console.Write("Digite a matricula: ");
      matricula[i]= int.Parse(Console.ReadLine());
      Console.Write("Digite a altura: ");
      altura[i]= double.Parse(Console.ReadLine());
    }
    int maior =0;
    for(int i=0; i<10; i++){
      if(altura[maior] < altura[i]){
        maior=i;
      }
    }

    int menor=0;
    for(int i=0; i<10;i++){
      if(altura[menor] > altura[i]){
        menor=i;
      }
    }

    Console.Write($"A matricula do maior é {matricula[maior]}, com os incriveis {altura[maior]} ");
    Console.Write($"A matricula da menor é {matricula[menor]}, com os incriveis {altura[menor]} ");
    
  }
}