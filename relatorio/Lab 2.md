# Funcionamento do Program.cs
Todos os exercícios foram desenvolvidos em arquivos unicos .cs. com os seus respectivos numeros do exercicio. Alguns solicitam entradas do usuário, outros apenas fazem cálculos sozinhos e printam os resultados. A descrição e a maneira como se seguem cada exercício encontra-se a seguir:

# Exercício 1: 
## Escreva um método recursivo que retorne o fatorial de um número.

Foi desenvolvido uma função recursiva que recebe um numero inteiro, faz uma comparação se o numero tiver o valor igual a 0, retorna o numero 1 sendo a condição de parada, caso a condição não tenha sido alcançada ele irá fazer o numero multiplicando a chamada recursiva do numero menos 1. <br>
Entrada: 10 <br>
Saida: 3628800 <br>



<img src=".\imagens\lista2ex1.png">

# Exercício 2:
## Uma multiplicação pode ser vista como uma sequência de somas. Escreva um método recursivo que realize a multiplicação de dois números inteiros, A e B, recebidos por parâmetro.

Foi desenvolvido uma função recursiva que recebe dois números inteiros A e B, faz uma comparação se o numero B tiver o valor igual a 0, retorna 0 , sendo a condição de parada, se não irá retornar o A somando o chamado da função de A, B-1 <br>
Entrada: 4 8 <br>
Saida: 32 <br>



<img src=".\imagens\lista2ex2.png">


# Exercício 3:
## Escreva um método recursivo que realize a potenciação entre dois números inteiros, A e B, recebidos por parâmetro. Seu método deve, portanto, retornar o resultado de A

Foi desenvolvido uma função recursiva que recebe dois números inteiros A e B, faz uma comparação se o numero B tiver o valor igual a 0, retorna 1 sendo a condição de parada, se não irá retornar o A multiplicando o chamado da função de A, B-1 <br>
Entrada: 7 4 <br>
Saida: 2401 <br>



<img src=".\imagens\lista2ex3.png">



# Exercício 4:
## Escreva um método recursivo que receba uma frase e uma letra como parâmetros. Este método deve retornar a quantidade de ocorrências desta letra nesta frase.

Foi desenvolvido uma função recursiva que recebe uma string Frase, e um char Letra, faz uma comparação se o tamanho da frase tiver o tamanho 0, retorna o numero 0 sendo a condição de parada, após isso é criada uma variável Count do valor 0, e faz uma comparação se a frase na posição 0, for igual a letra, vai acrescentar 1 ao Count, e por ultimo retorna Count mais a chamada recursiva recebendo a frase transformada em substring, e a letra. <br>
Entrada: eu gosto das aulas de aeds, do leonardo        Letra: a <br>
Saida: 5



<img src=".\imagens\lista2ex4.png">


# Exercício 5:
## Escreva um método recursivo que calcule a soma dos elementos de valor par de um vetor de números inteiros positivos.

Foi desenvolvido uma função recursiva que recebe um vetor de números inteiros e um contador de posição (sempre passado inicialmente como 0) como parâmetros. A condição de parada é que a posição atinja o último número do vetor. Se a condição de parada não é atingida, a função verifica se o número em questão é par, e se for, soma a uma variável auxiliar que será retorna no fim do desempilhamento. Em todo caso, a cada iteração, a função é chamada recursivamente passando o vetor e o contador mais 1 como parâmetros. <br>
Entrada: Vetor tamanho 5, Numeros: 12 47 13 4 004 <br>
Saida: 20 



<img src=".\imagens\lista2ex5.png">



# Exercício 6:
## Escreva um método recursivo que receba uma frase e retorne a mesma frase, sem nenhuma vogal.

Foi desenvolvido uma função recursiva que recebe uma string frase, faz uma comparação se a string estiver vazia, irá retornar a frase, sendo a condição de parada, se não é criada uma variável tipo char que recebe a primeira letra da frase, e uma string que transformar a frase em uma substring, faz uma comparação e se tiver uma vogal ira chamar a função recursiva passando a string auxiliar, caso a comparação não for verdadeira, vai retornar a char auxiliar, mais a chamada recursiva passando a string auxiliar  <br>
Entrada: eu gosto das aulas de aeds, do leonardo        <br>
Saida: gst ds ls d ds, d lnrd <br>



<img src=".\imagens\lista2ex6.png">

# Exercício 7:
## Busca Binaria

Foi desenvolvido uma função recursiva que recebe um vetor de inteiros, e o numero a ser procurado, é criado duas variáveis auxiliar, meio que recebe a metade do vetor, e fim que recebe a ultima posição, é realizada uma comparação se o tamanho do vetor for igual a 0, ele ve se vetor naquela posição é igual o numero procurado, se for retorna 0, se não retornando -1, após isso é realizada outras duas comparações que se o vetor na posição meio é igual procurado retornando o meio, e se o vetor na posição fim é igual o procurando, retornando o fim, sendo as primeiras condições de paradas, após esse pre processamento é feita outra comparação se o Vetor na posição meio é maior que o procurado, se sim é criado um subvetor que recebe o Vetor ate no numero do meio e retorna a função passando o subvetor, e o numero procurado, e por ultimo tem uma comparação que faz se o procurado é maior que o vetor na posição meio, se sim é criado um subvetor recebendo o vetor meio + 1, retornando a chamada da função com o vetor auxiliar e o numero procurado. <br>
Entrada: 1 2 3 4 5 6 7 8 9 10 11   numero buscado 11 <br>
Saída: 10 




<img src=".\imagens\lista2ex7.png">

# Exercício 8:
## Ordenação usando Busca Binaria

Foi desenvolvido uma função recursiva que recebe um vetor de inteiros, um inteiro para ser o inicio, e por ultimo um inteiro para receber o fim, após isso é verificado que o inicio é menor que o fim através de uma condição, se sim ir é criado uma  variável  auxiliar, chamada de meio, após é chamada duas vezes em ordem a própria função, a primeira passando o Vetor, o inicio e meio, a segunda passando o vetor, o meio + 1, e o fim, e por ultimo o vetor vai receber uma função chamada intercalar que recebe o vetor, inicio e fim;
No intercalar recebendo o vetor, inicio e fim, irá criar um vetor auxiliar do tamanho do vetor que chegou, esse vetor auxiliar irá ser preenchido por todo conteúdo do vetor passado como parâmetro, depois é criada quatro variáveis que recebem; 2 delas (i, J) o inicio, Meio recebendo inicio + fim dividido por 2, para definir o meio, e outra chamada de K onde, recebe meio + 1;
A seguir vem 1 while que ocorre quando i menor ou igual a meio e k menor ou igual ao fim onde ocorre uma estrutura de condição (if) que faz a comparação se Vetor Auxiliar na posição i for maior que vetor auxiliar na posição K, se sim Vetor na posição J recebe Vetor auxiliar na posição K, e o K é somado +1, se não Vetor na posição J recebe Vetor auxiliar na posição J recebe vetor auxiliar na posição I, e o I é somado +1; No final J é incrementado a +1;
A seguir vem outros dois while um que ve se i é menor ou igual a meio, que ocorre vetor na posição J recebe vetor auxiliar na posição I, j e i ambos recebem incremento de +1;
E o ultimo k é menor ou igual a fim, que ocorre vetor na posição J recebe vetor auxiliar na posição K, j e k ambos recebem incremento de +1;
Ao final é retornado aquele vetor <br>

Entrada: Tamanho Vetor 10, números 12 43 54 23 65 23 54 65 76 87 <br>
Saída: 12 – 23 – 23 – 43 – 54 – 65 – 76 – 87 –  <br>




<img src=".\imagens\lista2ex8.png">


