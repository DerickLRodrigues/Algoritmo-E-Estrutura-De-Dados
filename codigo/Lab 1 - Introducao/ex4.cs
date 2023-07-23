using System;

class Program
{
    public static void Main(string[] args)
    {
        int L = 5, C = 3;
        int[,] M = new int[L, C];
       Console.WriteLine("Numero: ");
        for (int i = 0; i < L; i++)
        {
            for (int j = 0; j < C; j++)
            {
                
                M[i, j] = int.Parse(Console.ReadLine());
            }
        }
      int [] sl = new int[L];
        for (int i = 0; i < L; i++)
        {
            for (int j = 0; j < C; j++)
            {
               sl[i] += M[i,j];
            }
          Console.WriteLine($"Soma da linha {i+1} = {sl[i]}");
        }
     
      
      int [] sc = new int[C];
     
      for(int i=0; i<L;i++)
      {
        for(int j=0; j<C; j++)
        {
          sc[j] += M[i,j]; 
        }
      }
      for(int j =0; j<C; j++){Console.WriteLine($"Soma da coluna {j+1} = {sc[j]}");}


    }
}