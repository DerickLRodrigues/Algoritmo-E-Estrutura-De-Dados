using System;

class Program {

    static string Troca(string frase){

      
      string conversao = "";
      for(int i=0; i < frase.Length; i++){
        
        
        if(frase[i] == 'A' || frase[i] == 'a' ){
          conversao += '&';
        }else{
         conversao += (char)(frase[i]);
        }
        
      }
      return conversao;
      
    }
  
  public static void Main (string[] args) {
    string frase, f;
    Console.WriteLine("Escreva a sua frase: ");
    frase = Console.ReadLine();
    f = Troca(frase);
    Console.WriteLine("A frase ficou assim: {0}", f);

    
  }
}