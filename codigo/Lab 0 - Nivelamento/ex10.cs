using System;
using System.IO;

class Program {
 public struct Pessoa{
  public string nome;
   public int idade;
   public double altura;
   public double peso;
   public int cod;
   public double imc;
 
   public override string ToString(){
     return($"{cod};{nome};{idade};{altura};{peso};{imc}");
   }
   public void Imprimir(){
      Console.WriteLine($"{cod} - {nome} - {idade} - {altura} - {peso} - {imc}");
    }
   public void cadastrar(int codigo){
      cod = codigo;
     Console.Write("Digite o nome: ");
     nome= Console.ReadLine();
     Console.Write("Digite a idade: ");
     idade= int.Parse(Console.ReadLine());
     Console.Write("Digite a altura: ");
     altura= double.Parse(Console.ReadLine());
     Console.Write("Digite o peso: ");
     peso= double.Parse(Console.ReadLine());
     imc = peso/Math.Pow(altura, 2);
     
   }
   
 }

  public struct CadastroPessoa{

        public int MAX;
        public int NP;
        public int SequenciaP;
        public Pessoa[] PESSOA;

      public CadastroPessoa(int quantidade){
           MAX = quantidade;
            NP = 0;
            SequenciaP = 1;
            PESSOA = new Pessoa[MAX];
      }

    public void ImprimirP(){
      Console.WriteLine("\n\nPACIENTES:\n");
      for(int i=0; i<NP;i++){
        PESSOA[i].Imprimir();
      }
    }

     public void CadastrarP(){
      if(NP == MAX){
        Console.WriteLine("Limite maximo");
      }else{
        PESSOA[NP++].cadastrar(SequenciaP++);
      }
    }
    
    public void GravarArquivo(){
        StreamWriter sw = new StreamWriter("arquivo.txt");
        sw.WriteLine(NP);
        for (int i = 0; i < NP; i++){
          sw.WriteLine(PESSOA[i].ToString());
        }
    }

    public void LerArquivo(){
      try{
        StreamReader sr = new StreamReader("arquivo.txt");
          NP= int.Parse(sr.ReadLine());
        for(int i=0; i<NP; i++){
          string[]pessoa = sr.ReadLine().Split(";");
          PESSOA[i].cod= int.Parse(pessoa[0]);
          PESSOA[i].nome=(pessoa[1]);
          PESSOA[i].idade=int.Parse(pessoa[2]);
          PESSOA[i].altura=double.Parse(pessoa[3]);
          PESSOA[i].peso=double.Parse(pessoa[4]);
          PESSOA[i].imc=double.Parse(pessoa[5]);
        }
        SequenciaP = PESSOA[NP -1].cod+1;
        sr.Close();
      }catch{}


      
    }
    
    
  }

   static int Menu()
        {
            int op = 0;
            Console.WriteLine("1 - Cadastrar uma nova pessoa");
            Console.WriteLine("2 - Ler o arquivo");
            Console.WriteLine("0 - Sair e salvar");
            op = int.Parse(Console.ReadLine());
            return op;
        }
  
  public static void Main (string[] args) {
    CadastroPessoa cP = new CadastroPessoa(10);
    cP.LerArquivo();
    int op=0;

     do{
     op = Menu();
      switch(op){
        case 1:
         cP.CadastrarP();
        break;
        case 2:
         cP.ImprimirP();
        break;
          
        case 0:
          cP.GravarArquivo();
          Console.WriteLine("\n\nEncerrando o programa...\n\n");
          break;
        default: Console.WriteLine("\n\nOpção Invalida!!!\n\n");
          break;  
      }
    }while(op != 0);


    
    
  }
}