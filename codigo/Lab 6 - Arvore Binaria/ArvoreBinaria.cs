using System;

class Program {

    class Aluno {
        public string nome;
        public int matricula;
        public double nota;
    }

    class Nodo {
        public Aluno aluno;
        public Nodo esquerda;
        public Nodo direita;
    }

    class ArvoreBinaria {
        public Nodo raiz;

        public void Inserir(Aluno aluno) {
            Nodo novoNodo = new Nodo();
            novoNodo.aluno = aluno;

            if (raiz == null) {
                raiz = novoNodo;
            } else {
                InserirRecursivamente(raiz, novoNodo);
            }
        }

        private void InserirRecursivamente(Nodo atual, Nodo novoNodo) {
            if (novoNodo.aluno.matricula < atual.aluno.matricula) {
                if (atual.esquerda == null) {
                    atual.esquerda = novoNodo;
                } else {
                    InserirRecursivamente(atual.esquerda, novoNodo);
                }
            } else {
                if (atual.direita == null) {
                    atual.direita = novoNodo;
                } else {
                    InserirRecursivamente(atual.direita, novoNodo);
                }
            }
        }

        public Nodo Buscar(int matricula) {
            return BuscarRecursivamente(raiz, matricula);
        }

        private Nodo BuscarRecursivamente(Nodo atual, int matricula) {
            if (atual == null || atual.aluno.matricula == matricula) {
                return atual;
            }

            if (matricula < atual.aluno.matricula) {
                return BuscarRecursivamente(atual.esquerda, matricula);
            } else {
                return BuscarRecursivamente(atual.direita, matricula);
            }
        }

        public void Remover(int matricula) {
            raiz = RemoverRecursivamente(raiz, matricula);
        }

        private Nodo RemoverRecursivamente(Nodo atual, int matricula) {
            if (atual == null) {
                return atual;
            }

            if (matricula < atual.aluno.matricula) {
                atual.esquerda = RemoverRecursivamente(atual.esquerda, matricula);
            } else if (matricula > atual.aluno.matricula) {
                atual.direita = RemoverRecursivamente(atual.direita, matricula);
            } else {
                if (atual.esquerda == null) {
                    return atual.direita;
                } else if (atual.direita == null) {
                    return atual.esquerda;
                }

                atual.aluno = MinimoValor(atual.direita);

                atual.direita = RemoverRecursivamente(atual.direita, atual.aluno.matricula);
            }

            return atual;
        }

        private Aluno MinimoValor(Nodo nodo) {
            Aluno minimo = nodo.aluno;
            while (nodo.esquerda != null) {
                minimo = nodo.esquerda.aluno;
                nodo = nodo.esquerda;
            }
            return minimo;
        }

        public bool Vazia() {
            return raiz == null;
        }

       public void Caminhar() {
         Console.WriteLine("1 - Percuso em ordem, 2 - Pre Ordem, 3 - Pos Ordem, digite a opcao");
         int op = int.Parse(Console.ReadLine()); 
         if(op == 1){
            Console.WriteLine("Percurso em ordem:");
            CaminharEmOrdem(raiz);
            Console.WriteLine();
           }else if(op ==2){
            Console.WriteLine("Percurso em pré-ordem:");
            CaminharPreOrdem(raiz);
            Console.WriteLine();
           }else if( op == 3){
            Console.WriteLine("Percurso em pós-ordem:");
            CaminharPosOrdem(raiz);
            Console.WriteLine();
           }
        }

        private void CaminharEmOrdem(Nodo nodo) {
            if (nodo != null) {
                CaminharEmOrdem(nodo.esquerda);
                Console.WriteLine(nodo.aluno.nome);
                CaminharEmOrdem(nodo.direita);
            }
        }

        private void CaminharPreOrdem(Nodo nodo) {
            if (nodo != null) {
                Console.WriteLine(nodo.aluno.nome);
                CaminharPreOrdem(nodo.esquerda);
                CaminharPreOrdem(nodo.direita);
            }
        }

        private void CaminharPosOrdem(Nodo nodo) {
            if (nodo != null) {
                CaminharPosOrdem(nodo.esquerda);
                CaminharPosOrdem(nodo.direita);
                Console.WriteLine(nodo.aluno.nome);
            }
        }

        public Nodo Esquerda(Nodo nodo) {
            return nodo.esquerda;
        }

        public Nodo Direita(Nodo nodo) {
            return nodo.direita;
        }

        public int Tamanho() {
            return TamanhoRecursivamente(raiz);
        }

        private int TamanhoRecursivamente(Nodo nodo) {
            if (nodo == null) {
                return 0;
            }

            return 1 + TamanhoRecursivamente(nodo.esquerda) + TamanhoRecursivamente(nodo.direita);
        }

        public int Altura() {
    return AlturaRecursivamente(raiz);
}

private int AlturaRecursivamente(Nodo nodo) {
    if (nodo == null) {
        return -1; 
    }

    int alturaEsquerda = AlturaRecursivamente(nodo.esquerda);
    int alturaDireita = AlturaRecursivamente(nodo.direita);

    if(alturaEsquerda>alturaDireita){
      return 1 + alturaEsquerda;
    }else{
      return 1 + alturaDireita;
    }

    
}
      
    }

    public static int Menu() {
        Console.WriteLine("1 - Inserir");
        Console.WriteLine("2 - Remover");
        Console.WriteLine("3 - Buscar");
        Console.WriteLine("4 - Verificar se está vazia");
        Console.WriteLine("5 - Caminhar Todos metodos");
        Console.WriteLine("6 - Tamanho");
        Console.WriteLine("7 - Altura");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("Digite a opção: ");
        int op = int.Parse(Console.ReadLine());
        return op;
    }

    public static void Main(string[] args) {

        ArvoreBinaria arvore = new ArvoreBinaria();

        int op = 0;
        do {
            switch (op = Menu()) {
                case 1:
                    Console.WriteLine("Informe o nome do aluno:");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Informe a matrícula do aluno:");
                    int matricula = int.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a nota do aluno:");
                    double nota = double.Parse(Console.ReadLine());

                    Aluno novoAluno = new Aluno();
                    novoAluno.nome = nome;
                    novoAluno.matricula = matricula;
                    novoAluno.nota = nota;

                    arvore.Inserir(novoAluno);
                    Console.WriteLine($"{novoAluno.nome} inserido com sucesso!");
                    break;
                case 2:
                    Console.WriteLine("Informe a matrícula do aluno a ser removido:");
                    int matriculaRemover = int.Parse(Console.ReadLine());
                    arvore.Remover(matriculaRemover);
                    Console.WriteLine($"Aluno com matrícula {matriculaRemover} removido.");
                    break;
                case 3:
                    Console.WriteLine("Informe a matrícula do aluno a ser buscado:");
                    int matriculaBuscar = int.Parse(Console.ReadLine());
                    Nodo nodoEncontrado = arvore.Buscar(matriculaBuscar);
                    if (nodoEncontrado != null) {
                        Console.WriteLine($"Aluno encontrado: {nodoEncontrado.aluno.nome}");
                    } else {
                        Console.WriteLine("Aluno não encontrado.");
                    }
                    break;
                case 4:
              if(arvore.Vazia()){
                Console.WriteLine("A arvore esta vazia");
              }else{
                Console.WriteLine("A arvore nao esta vazia");
              }
                    
                    break;
                case 5:
                    arvore.Caminhar();
                    break;
                
            case 6:
                    Console.WriteLine($"Tamanho da árvore: {arvore.Tamanho()}");
                    break;
            case 7:
                    Console.WriteLine($"Altura da árvore: {arvore.Altura()}");
                    break;
                default:
                    Console.WriteLine("Adeus");
                    break;
            }

        } while (op != 0);
    }
}
