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
        public static void adcTopo(ref elemento ultimo, elemento novo){
            ultimo.proximo = novo;
        }

        public static elemento removerTopo(ref elemento ultimo, ref elemento primeiro){
            if(primeiro == ultimo){
                Console.WriteLine("A pilha está vazia");
                return new elemento();
            }
            else{
                elemento removido = ultimo;

                elemento pesquisar = primeiro;
                while(pesquisar.proximo != ultimo){
                    pesquisar = pesquisar.proximo;
                }
                ref elemento refPesquisa = ref pesquisar;
                ultimo = refPesquisa;

                return removido;
            }
        }

        public static void imprimirPilha(ref elemento primeiro, ref elemento ultimo){
            elemento pesquisar;
            if(primeiro == ultimo){
                Console.WriteLine("Pilha Vazia!");
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

        public static void imprimirPilhaDoTopoAteBase(ref elemento primeiro, ref elemento ultimo){
            elemento pesquisar = ultimo;
            if(primeiro == ultimo){
                Console.WriteLine("Pilha Vazia!");
            }
            else{
                while(pesquisar != primeiro){
                    Console.WriteLine(pesquisar.Aluno.nome);
                    pesquisar = GetElementoAnterior(ref primeiro, pesquisar);
                }
                Console.WriteLine(primeiro.Aluno.nome);
            }
        }

        private static elemento GetElementoAnterior(ref elemento primeiro, elemento atual){
            elemento pesquisar = primeiro;
            while(pesquisar.proximo != atual){
                pesquisar = pesquisar.proximo;
            }
            return pesquisar;
        }

        public static void topoPilha(ref elemento primeiro, ref elemento ultimo){
            if(primeiro == ultimo){
                Console.WriteLine("Pilha Vazia!");
            }
            else{
                Console.WriteLine(ultimo.Aluno.nome);
            }
        }
    }

    public static int Menu(){
        Console.WriteLine("1 - Inserir");
        Console.WriteLine("2 - Remover");
        Console.WriteLine("3 - Imprimir Pilha do Topo até a Base");
        Console.WriteLine("4 - Topo Pilha");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("Digite a opção: ");
        int op = int.Parse(Console.ReadLine());
        return op;
    }

    public static void Main (string[] args) {
        elemento primeiro = new elemento();
        elemento ultimo = primeiro;
        int op = 0;

        do{
            switch(op = Menu()){
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

                    operacoes.adcTopo(ref ultimo, novo);
                    ultimo = novo;
                    break;
                case 2:
                    elemento removido = operacoes.removerTopo(ref ultimo, ref primeiro);
                    Console.WriteLine($"O aluno foi removido: {removido.Aluno.nome}");
                    break;
                case 3:
                    operacoes.imprimirPilhaDoTopoAteBase(ref primeiro, ref ultimo);
                    break;
                case 4:
                    operacoes.topoPilha(ref primeiro, ref ultimo);
                    break;
                
                default:
                    Console.WriteLine("Adeus");
                    break;
            }
        } while(op != 0);
    }
}
