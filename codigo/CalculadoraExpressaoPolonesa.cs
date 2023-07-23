
using System;
using System.Collections.Generic;

class Program
{

  static string criadorExpressao(string conta)
    {
        Stack<char> operators = new Stack<char>();
        string expressao = "";

        for (int i = 0; i < conta.Length; i++)
        {
            char indice = conta[i];
             //verifica se é numero
            if (char.IsDigit(indice))
            {
                expressao += indice;

                // vai verificar se o proximo tbm é numero
                while (i + 1 < conta.Length && char.IsDigit(conta[i + 1]))
                {
                    i++;
                    expressao += conta[i];
                }

                expressao += " ";
            }
            //inicia o parentese
            else if (indice == '(')
            {
                operators.Push(indice);
            }
          //fecha o parentese
            else if (indice == ')')
            {
              //vai removendo 
                while (operators.Count > 0 && operators.Peek() != '(')
                {
                    expressao += operators.Pop() + " ";
                }
                 //remove o (
                if (operators.Count > 0 && operators.Peek() == '(')
                {
                    operators.Pop(); 
                }
            }
          //Verifica se é operador
            else if (eOperador(indice))
            {
              //tratamento de prioridade
                while (operators.Count > 0 && operators.Peek() != '(' && prioridade(indice) <= prioridade(operators.Peek()))
                {
                    expressao += operators.Pop() + " ";
                }
                   //sem prioridade
                operators.Push(indice);
            }
        }
        //adiciona tudo que tava la na pilha sobrando
        while (operators.Count > 0)
        {
            expressao += operators.Pop() + " ";
        }
          //retorna sem o espaco
        return expressao.Trim();
    }

    static bool eOperador(char indice)
    {
        return indice == '+' || indice == '-' || indice == '*' || indice == '/';
    }

    static int prioridade(char Tipo)
    {
        if (Tipo == '+' || Tipo == '-')
            {
                return 1;
            }
            else if (Tipo == '*' || Tipo == '/')
            {
                return 2;
            }
            else
            {
                return 0;
            }
    }

  static double somaPilha(string expressao)
    {
        Stack<double> pilha = new Stack<double>();

        string[] numeros = expressao.Split(' ');

        foreach (string operador in numeros)
        {

          //Se for numero vai adicionar na pilha
            if (double.TryParse(operador, out double numero))
            {
               
                pilha.Push(numero);
            }
            else
            {
                // faz aquela famosa operacao
                double n2 = pilha.Pop();
                double n1 = pilha.Pop();
                double resultado = operacoes(operador, n1, n2);
                pilha.Push(resultado);
            }
        }

        // final ta no topo
        return pilha.Pop();
    }

    static double operacoes(string operadorMatematico, double n1, double n2)
    {
      
        switch (operadorMatematico)
        {
            case "+":
                return n1 + n2;
            case "-":
                return n1 - n2;
            case "*":
                return n1 * n2;
            case "/":
                return n1 / n2;
            default:

          //tratamento de erro
                throw new ArgumentException("Há algum simbolo invalido");
        }
    }

  
  
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a operação (por exemplo, 3 + 5 * (7 - 2) / 4 ):");
        string conta = Console.ReadLine();
       // string conta = "9+4*(7-7+(2/3))*1";
        
        string expresaPolonesa = criadorExpressao(conta);
        string juntar = "";

            //juntar valores da expressão
            for (int i=0; i < expresaPolonesa.Length; i++) 
            {
                if (expresaPolonesa[i] != ' ')
                {
                     juntar += expresaPolonesa[i];
                }
            }

         Console.WriteLine($"A expressao ficou: {juntar} ");

         double resultado = somaPilha(expresaPolonesa);
        Console.WriteLine($"Resultado final: {resultado}" );

      
    }

    
}
