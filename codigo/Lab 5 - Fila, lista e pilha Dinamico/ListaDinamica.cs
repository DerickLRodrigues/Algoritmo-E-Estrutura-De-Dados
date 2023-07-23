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
        public static void adcElementoLista(ref elemento primeiro, ref elemento ultimo, elemento novo, int posicao)
{
    if (primeiro == ultimo)
    {
        primeiro.proximo = novo;
        ultimo = novo;
    }
    else if (posicao == -1)
    {
        elemento auxiliar = primeiro.proximo;
        primeiro.proximo = novo;
        novo.proximo = auxiliar;
    }
    else if (posicao == 0)
    {
        elemento auxiliar = primeiro.proximo;
        primeiro.proximo = novo;
        novo.proximo = auxiliar;
    }
    else
    {
        elemento pesquisado = primeiro.proximo;

        for (int i = 0; i <= posicao; i++)
        {
            if (pesquisado == ultimo)
            {
                ultimo.proximo = novo;
                ultimo = novo;
                i = posicao;
            }
            else if (i == posicao - 1)
            {
                elemento auxiliar = pesquisado.proximo;
                pesquisado.proximo = novo;
                novo.proximo = auxiliar;
            }
            else
            {
                pesquisado = pesquisado.proximo;
            }
        }
    }
}
    public static void adcElementoLista(ref elemento primeiro, ref elemento ultimo, elemento novo)
{
    elemento pesquisado = primeiro;
    while (pesquisado.proximo != null)
    {
        if (pesquisado.proximo.Aluno == null)
        {
            novo.proximo = pesquisado.proximo.proximo;
            pesquisado.proximo = novo;
            return;
        }
        pesquisado = pesquisado.proximo;
    }

    ultimo.proximo = novo;
    ultimo = novo;
}



        public static elemento removerElementoLista(ref elemento primeiro, ref elemento ultimo, int posicao){
            elemento pesquisado = primeiro.proximo;
            elemento removido = new elemento();

            if(primeiro == ultimo){
                
                Console.WriteLine("Lista vazia!");
               
            }
            else if(posicao == 0){
                removido = primeiro.proximo;
                if(primeiro.proximo == ultimo){
                    ultimo = primeiro;
                }
                else{
                    primeiro.proximo = primeiro.proximo.proximo;
                }
            }
            else{
                for(int i = 0; i <= posicao; i++){
                    if(pesquisado == ultimo){
                        Console.WriteLine($"A posição não existe na fila ");
                        break;
                    }
                    else if(pesquisado.proximo == ultimo && i == posicao - 1){
                        removido = pesquisado.proximo;
                        ultimo = pesquisado;
                    }
                    else if(i == posicao - 1){
                        removido = pesquisado.proximo;
                        pesquisado.proximo = pesquisado.proximo.proximo;
                        break;
                    }
                    else{
                        pesquisado = pesquisado.proximo;
                    }
                }
            }
            return removido;
        }

    public static elemento removerElementoLista(ref elemento primeiro, ref elemento ultimo)
{
    if (primeiro.proximo == null)
    {
        Console.WriteLine("Lista vazia!");
        return null;
    }

    elemento pesquisado = primeiro.proximo;
    while (pesquisado != null)
    {
        if (pesquisado.Aluno != null)
        {
            elemento removido = pesquisado;
            primeiro.proximo = pesquisado.proximo;
            if (pesquisado == ultimo)
                ultimo = primeiro;
            return removido;
        }
        pesquisado = pesquisado.proximo;
    }

    Console.WriteLine("Não há elementos não nulos na lista!");
    return null;
}



        public static void imprimirLista(ref elemento primeiro, ref elemento ultimo){
            elemento pesquisar;
            if(primeiro == ultimo){
                Console.WriteLine("Lista Vazia!");
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
              if(pesquisar.Aluno.nome == nome){
                  p = true;
                }

         return p;
            
        }
    
    }

  

  public static int Menu(){
    Console.WriteLine("1 - Inserir");
    Console.WriteLine("2 - Remover");
    Console.WriteLine("3 - Mostrar ");
    Console.WriteLine("4 - Procurar ");
    Console.WriteLine("5 - Verificar Tamanho ");
    Console.WriteLine("6 - Inserir no Primeiro Disponivel");
    Console.WriteLine("7 - Remover no Primeiro Disponivel");
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
                    Console.WriteLine("posição que quer colocar:");
                    int posicao = int.Parse(Console.ReadLine());
         elemento novo = new elemento();
                        novo.Aluno.nome = nome;
                        novo.Aluno.matricula = matricula;
                        novo.Aluno.nota = nota;

                        operacoes.adcElementoLista(ref primeiro, ref ultimo, novo, posicao);
                       
        break;
      case 2:
        Console.WriteLine("posição que vai remover:");
                    int p = int.Parse(Console.ReadLine());
                    elemento removido = operacoes.removerElementoLista(ref primeiro, ref ultimo, p);
        if(removido != null){
                    Console.WriteLine($"O aluno foi removido {removido.Aluno.nome} ");
          }
        break;
      case 3:
         operacoes.imprimirLista(ref primeiro, ref ultimo);
        break;
      case 4:
         Console.WriteLine("Informe o nome do aluno:");
                string nomeAluno = Console.ReadLine();
                if(operacoes.Procurar(ref primeiro, ref ultimo, nomeAluno)){
                  Console.WriteLine($"O Aluno {nomeAluno} esta na lista");
                }else{
                  Console.WriteLine($"Infelizmente o aluno {nomeAluno} nao ta na lista");
                }
        break;
      case 5:
         Console.WriteLine($"O tamanho da lista é {operacoes.tamanhoLista(ref primeiro, ref ultimo)}");
        break;
  case 6:
        Console.WriteLine("Informe o nome do aluno:");
                    string Nome = Console.ReadLine();
                    Console.WriteLine("Informe a matrícula do aluno:");
                    int Matricula = int.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a nota do aluno:");
                    double Nota = double.Parse(Console.ReadLine());
                    
                    
         elemento Novo = new elemento();
                        Novo.Aluno.nome = Nome;
                        Novo.Aluno.matricula = Matricula;
                        Novo.Aluno.nota = Nota;

                        operacoes.adcElementoLista(ref primeiro, ref ultimo, Novo);
                       
        break;
  case 7:
        
                    elemento Removido = operacoes.removerElementoLista(ref primeiro, ref ultimo);
        if(Removido != null){
                    Console.WriteLine($"O aluno foi removido {Removido.Aluno.nome} ");}
        break;
      default:
        Console.WriteLine("Adeus");
        break;
      }
      
    }while(op!=0);

            
            
    
  }
}