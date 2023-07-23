using System;

class Program{
public class MSDSort {
    public const int R = 256;
    public const int CUTOFF = 15;

    public static void Sort(string[] V) {
        int n = V.Length;
        string[] aux = new string[n];
        Sort(V, 0, n - 1, 0, aux);
    }

    public static void Sort(string[] V, int lo, int hi, int d, string[] aux) {
        if (hi <= lo + CUTOFF) {
            InsertionSort(V, lo, hi, d);
            return;
        }

        int[] count = new int[R + 2];
        for (int i = lo; i <= hi; i++) {
            int c = CharAt(V[i], d);
            count[c + 2]++;
        }

        for (int r = 0; r < R + 1; r++) {
            count[r + 1] += count[r];
        }

        for (int i = lo; i <= hi; i++) {
            int c = CharAt(V[i], d);
            aux[count[c + 1]++] = V[i];
        }

        for (int i = lo; i <= hi; i++) {
            V[i] = aux[i - lo];
        }

        for (int r = 0; r < R; r++) {
            Sort(V, lo + count[r], lo + count[r + 1] - 1, d + 1, aux);
        }
    }

    public static void InsertionSort(string[] V, int lo, int hi, int d) {
        for (int i = lo; i <= hi; i++) {
            for (int j = i; j > lo && Less(V[j], V[j - 1], d); j--) {
                Swap(V, j, j - 1);
            }
        }
    }

    public static bool Less(string v, string w, int d) {
        return v.Substring(d).CompareTo(w.Substring(d)) < 0;
    }

    public static void Swap(string[] V, int i, int j) {
        string temp = V[i];
        V[i] = V[j];
        V[j] = temp;
    }

    public static int CharAt(string s, int d) {
        if (d < s.Length) {
            return (int) s[d];
        } else {
            return -1;
        }
    }
  
  }

public static void Main(string[] args) {

    

    string[] V = { "Algoritmos", "Estruturas", "De", "Dados", "Do", "Professor", "Leonardo" };
  Console.WriteLine("Digite as palavras: ");
  for(int i=0; i<V.Length;i++)
      Console.Write($"{V[i]} ");
    MSDSort.Sort(V);
  Console.WriteLine("Ordenadas: ");
   for(int i=0; i<V.Length;i++)
      Console.Write($"{V[i]} ");
  
   
    
}
}