using System;

class Program {
    static void Main(string[] args) {
        int[] A = new int[5];
        int[] B = new int[5];
        int[] C = new int[5];
        int[] D = new int[5];
        int contadorC = 0, contadorD = 0;

        Console.WriteLine("Digite os elementos do vetor A:");
        for (int i = 0; i < 5; i++) {
            A[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Digite os elementos do vetor B:");
        for (int i = 0; i < 5; i++) {
            B[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 5; i++) {
            // Verifica se o elemento de A existe em B
            bool existe = false;
            for (int j = 0; j < 5; j++) {
                if (A[i] == B[j]) {
                    existe = true;
                    C[contadorC] = A[i];
                    contadorC++;
                    break;
                }
            }

            // Se o elemento de A não existe em B, adiciona em D
            if (!existe) {
                D[contadorD] = A[i];
                contadorD++;
            }
        }

        Console.WriteLine("Elementos comuns entre A e B:");
        for (int i = 0; i < contadorC; i++) {
            Console.Write(C[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Elementos de A que não existem em B:");
        for (int i = 0; i < contadorD; i++) {
            Console.Write(D[i] + " ");
        }
        Console.WriteLine();
    }
}
