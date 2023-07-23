using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite o seu salario");
    double salario = double.Parse(Console.ReadLine());
    if(salario < 1700){
      salario += 300;
    Console.WriteLine("Seu aumentou foi de 300, ficando {0}", salario); 
    }else{
      salario += 200;
      Console.WriteLine("Seu aumentou foi de 200, ficando {0}", salario); 
    }

    
  }
}