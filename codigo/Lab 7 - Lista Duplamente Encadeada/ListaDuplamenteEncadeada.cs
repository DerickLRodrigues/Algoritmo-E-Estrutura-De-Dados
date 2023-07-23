using System;

class Program {

    class aluno {
        public string nome;
        public int matricula;
        public double nota;
    }

    class elemento {
        public aluno Aluno = new aluno();
        public elemento proximo;
        public elemento anterior;
    }

    class metodos {
        public static void adcElementoLista(ref elemento primeiro, ref elemento ultimo, elemento novo, int posicao) {
            if (posicao < 0) {
                Console.WriteLine("Não existe posição menor que 0!");
            } else if (primeiro == ultimo) {
                novo.anterior = primeiro;
                novo.proximo = primeiro;
                primeiro.proximo = novo;
                ultimo = novo;
            } else if (posicao == 0) {
                novo.proximo = primeiro.proximo;
                novo.anterior = primeiro;
                primeiro.proximo.anterior = novo;
                primeiro.proximo = novo;
            } else {
                elemento pesquisado = primeiro.proximo;

                for (int i = 0; i <= posicao; i++) {
                    if (pesquisado == ultimo) {
                        novo.anterior = pesquisado;
                        novo.proximo = pesquisado.proximo;
                        pesquisado.proximo.anterior = novo;
                        pesquisado.proximo = novo;
                        ultimo = novo;
                        i = posicao;
                    } else if (i == posicao - 1) {
                        elemento auxiliar = pesquisado.proximo;
                        novo.anterior = pesquisado;
                        novo.proximo = auxiliar;
                        pesquisado.proximo = novo;
                        auxiliar.anterior = novo;
                    } else {
                        pesquisado = pesquisado.proximo;
                    }
                }
            }
        }

        public static elemento removerLista(ref elemento primeiro, ref elemento ultimo, int posicao) {
            elemento pesquisado = primeiro.proximo;
            elemento removido = new elemento();

            if (primeiro == ultimo) {
                Console.WriteLine("Lista vazia!");
            } else if (posicao == 0) {
                removido = primeiro.proximo;
                if (primeiro.proximo == ultimo) {
                    ultimo = primeiro;
                } else {
                    primeiro.proximo = primeiro.proximo.proximo;
                    primeiro.proximo.anterior = primeiro;
                }
            } else {
                for (int i = 0; i <= posicao; i++) {
                    if (pesquisado == ultimo) {
                        Console.WriteLine($"A posição especificada não existe na fila tem {i} posições.");
                        break;
                    } else if (pesquisado.proximo == ultimo && i == posicao - 1) {
                        removido = pesquisado.proximo;
                        ultimo = pesquisado;
                        ultimo.proximo = null;
                    } else if (i == posicao - 1) {
                        removido = pesquisado.proximo;
                        pesquisado.proximo = pesquisado.proximo.proximo;
                        pesquisado.proximo.anterior = pesquisado;
                        break;
                    } else {
                        pesquisado = pesquisado.proximo;
                    }
                }
            }
            return removido;
        }

        public static void imprimirLista(ref elemento primeiro, ref elemento ultimo) {
            elemento pesquisar;
            if (primeiro == ultimo) {
                Console.WriteLine("Lista Vazia!");
                pesquisar = primeiro;
            } else {
                pesquisar = primeiro.proximo;
            }
            while (pesquisar != ultimo) {
                Console.Write(pesquisar.Aluno.nome + " ");
                pesquisar = pesquisar.proximo;
            }
            Console.WriteLine(ultimo.Aluno.nome);
        }

       public static int tamanhoLista(ref elemento primeiro, ref elemento ultimo){

      elemento pesquisar;
      int t=0;

           if(primeiro == ultimo){
                return t;
            }
            else{
                pesquisar = primeiro.proximo;
            }
            
            while(pesquisar != ultimo){
                t++;
                pesquisar = pesquisar.proximo;
            }

      return t +1;
            
        }

    public static bool Procurar(ref elemento primeiro, ref elemento ultimo, string nome){

      elemento pesquisar;
      bool p = false;

       if(primeiro == ultimo){
                Console.WriteLine("Lista Vazia!");
                pesquisar = primeiro;
         
            }
            else{
                pesquisar = primeiro.proximo;
            }
            
            while(pesquisar != ultimo){
                if(pesquisar.Aluno.nome == nome){
                  p = true;
                }
                pesquisar = pesquisar.proximo;
            }

         return p;
            
        }

       public static void imprimirInverso(ref elemento primeiro, ref elemento ultimo) {
            elemento pesquisar;
            if (ultimo == primeiro) {
                Console.WriteLine("Lista Vazia!");
                pesquisar = ultimo;
            } else {
                pesquisar = ultimo;
            }
            while (pesquisar != primeiro) {
                Console.Write(pesquisar.Aluno.nome + " ");
                pesquisar = pesquisar.anterior;
            }
            Console.WriteLine(primeiro.Aluno.nome);
        }
    
      
      
    }

    public static int Menu() {
        Console.WriteLine("1 - Inserir");
        Console.WriteLine("2 - Remover");
        Console.WriteLine("3 - Mostrar ");
        Console.WriteLine("4 - Procurar ");
        Console.WriteLine("5 - Verificar Tamanho ");
      Console.WriteLine("6 - Imprimir de tras para frente ");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("Digite a opção: ");
        int op = int.Parse(Console.ReadLine());
        return op;
    }

    public static void Main(string[] args) {

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
                    Console.WriteLine("Agora informe a posição em que deseja adicionar:");
                    int posicao = int.Parse(Console.ReadLine());
         elemento novo = new elemento();
                        novo.Aluno.nome = nome;
                        novo.Aluno.matricula = matricula;
                        novo.Aluno.nota = nota;

                        metodos.adcElementoLista(ref primeiro, ref ultimo, novo, posicao);
                        Console.WriteLine($"{novo.Aluno.nome} inserido com sucesso!");
        break;
      case 2:
        Console.WriteLine("Escolha em qual posição deseja remover:");
                    int p = int.Parse(Console.ReadLine());
                    elemento removido = metodos.removerLista(ref primeiro, ref ultimo, p);
                    Console.WriteLine($"Aluno removido: {removido.Aluno.nome}");
                    
        break;
      case 3:
         metodos.imprimirLista(ref primeiro, ref ultimo);
        break;
      case 4:
         Console.WriteLine("Informe o nome do aluno:");
                string nomeAluno = Console.ReadLine();
                if(metodos.Procurar(ref primeiro, ref ultimo, nomeAluno)){
                  Console.WriteLine($"O Aluno {nomeAluno} esta na lista");
                }else{
                  Console.WriteLine($"Infelizmente o aluno {nomeAluno} nao ta na lista");
                }
        break;
      case 5:
         Console.WriteLine($"O tamanho da lista é {metodos.tamanhoLista(ref primeiro, ref ultimo)}");
        break;
      case 6:
        metodos.imprimirInverso(ref primeiro, ref ultimo);
        break;
      default:
        Console.WriteLine("Adeus");
        break;
      }
      
    }while(op!=0);
      
    }
}
