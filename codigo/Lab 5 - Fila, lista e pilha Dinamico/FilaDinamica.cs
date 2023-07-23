using System;

class Program {

  class aluno{
        public string nome;
        public int matricula;
        public double nota;
    }

    class elemento{
        public aluno Aluno = new aluno();
        public elemento proximo;
    }

  class operacoes{
        public static void adcElementoFila(ref elemento ultimo, elemento novo){
            ultimo.proximo = novo;
            ultimo = ultimo.proximo;
        }

        public static elemento removeFila(ref elemento primeiro, ref elemento ultimo){
    if(primeiro == ultimo){
        Console.WriteLine("Fila Vazia!");
        return new elemento();
    }
    elemento removido = primeiro.proximo;

    primeiro.proximo = primeiro.proximo.proximo;

    if (primeiro.proximo == null) {
        ultimo = primeiro;
    }

    return removido;
}


        public static void imprimiFila(ref elemento primeiro, ref elemento ultimo){
            elemento pesquisar;
            if(primeiro == ultimo){
                Console.WriteLine("Fila Vazia!");
                pesquisar = primeiro;
            }
            else{
                pesquisar = primeiro.proximo;
            }
            while(pesquisar != ultimo){
                Console.Write(pesquisar.Aluno.nome + " ");
                pesquisar = pesquisar.proximo;
            }
            Console.WriteLine(ultimo.Aluno.nome);
        }

    public static int tamanhoFila(ref elemento primeiro, ref elemento ultimo){
            elemento pesquisar;
            if(primeiro == ultimo){
                
              return 0;
                
            }
            else{
                pesquisar = primeiro.proximo;
            }
      int t=0;
            while(pesquisar != ultimo){
                t++;
                pesquisar = pesquisar.proximo;
            }
            return t + 1;
        }

     public static void primeiroFila(ref elemento primeiro, ref elemento ultimo){
            elemento pesquisar;
            if(primeiro == ultimo){
                Console.WriteLine("Fila Vazia!");
                pesquisar = primeiro;
            }
            else{
                pesquisar = primeiro.proximo;
              Console.WriteLine(pesquisar.Aluno.nome);
            }
           
        }
    
    }

  public static int Menu(){
    Console.WriteLine("1 - Inserir");
    Console.WriteLine("2 - Remover");
    Console.WriteLine("3 - Mostrar ");
    Console.WriteLine("4 - Verificar Tamanho ");
    Console.WriteLine("5 - Primeiro Fila ");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("Digite a opcao: ");
   int op =int.Parse(Console.ReadLine());
    return op;
  }
  
  public static void Main (string[] args) {

    elemento primeiro = new elemento();
            elemento ultimo = primeiro;
        int op=0;
    do{

      switch(op=Menu()){
      case 1:
        Console.WriteLine("Informe o nome do aluno:");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Informe a matrícula do aluno:");
                    int matricula = int.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a nota do aluno:");
                    double nota = double.Parse(Console.ReadLine());
                    
                    elemento novo = new elemento();
                    novo.Aluno.nome = nome;
                    novo.Aluno.matricula = matricula;
                    novo.Aluno.nota = nota;

                    operacoes.adcElementoFila(ref ultimo, novo);
                   
        break;
      case 2:
        elemento removido = operacoes.removeFila(ref primeiro, ref ultimo);
                    Console.WriteLine($"O Aluno {removido.Aluno.nome} foi removido");
        break;
      case 3:
        operacoes.imprimiFila(ref primeiro, ref ultimo);
        break;
      case 4:
       Console.WriteLine($"o tamanho é {operacoes.tamanhoFila(ref primeiro, ref ultimo)}");
        break;
      case 5: 
        operacoes.primeiroFila(ref primeiro, ref ultimo);
        break;
      default:
        Console.WriteLine("Adeus");
        break;
      }
      
    }while(op != 0);
           
            
    
  }
}