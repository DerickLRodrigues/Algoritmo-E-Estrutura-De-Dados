# Funcionamento do Program.cs
Todos os exercícios foram desenvolvidos em arquivos unicos .cs. com os seus respectivos numeros do exercicio. Alguns solicitam entradas do usuário, outros apenas fazem cálculos sozinhos e printam os resultados. A descrição e a maneira como se seguem cada exercício encontra-se a seguir:

# Exercício 1: 
## Metodo Bubble Sort

Foi desenvolvida uma função do tipo void que recebe um vetor inteiro, após é criada duas variáveis max, que recebe o tamanho do vetor menos 1, e outra aux recebendo o valor de 0;
Logo em seguida há uma estrutura de repetição(FOR), que tem como entrada, i igual o max, i maior ou igual a 0, e o i sendo retirado menos 1
Dentro desse For, possui outro que tem como entrada, j igual a 0, i menor ou igual a i, j acrescentado mais 1.
Existe uma condicional(IF) dentro do segundo for, que tem como comparação V na posição j, ser maior  que V na posição i, se verdadeira ocorre uma troca dos valores utilizando a variável auxiliar. 
<br>
Entradas: Tamanho vetor 5, números: 4 1 48 32 74 <br>
Saida: 1 4 32 48 74




<img src=".\imagens\lista3ex1.png">

# Exercício 2:
## Metodo Selection

Foi desenvolvido uma função void que recebe um vetor inteiro, após é criada uma variável auxiliar, e vem duas estruturas de repetições a primeira iniciando em i igual 0, indo até o tamanho do vetor menos 1, onde uma variável menor é criada recebendo o I, após o outro for tem como entrada J igual a I, indo ate o tamanho do vetor,
Dentro dele há uma condicional onde se o Vetor no tamanho menor for maior que o V no tamanho j, o menor irar receber j, ao finalizar o segundo vetor, acontece a troca dos valores com a variável auxiliar;
<br>
Entrada: Tamanho vetor 5, números: 47 12 48 67 1<br>
Saida: 1 12 47 78 67




<img src=".\imagens\lista3ex2.png">


# Exercício 3:
## Metodo Insertion

Foi desenvolvida uma função do tipo void que recebe um vetor como parâmetro, dentro da função é criada duas variável auxiliar, menor e j, ambas recebendo 0, após tem uma estrutura de repetição(FOR) que o i se inicia em 1, e vai ate o tamanho do vetor menos 1, dentro menor recebe vetor na posição i, e o j recebe i menos 1, logo em seguida vindo uma estrutura de repetição(while) que tem como condição j maior ou igual a 0 e vetor na posição j, maior que o menor, se verdadeira, vetor na posição j + 1, ira receber Vetor na posição j e depois o j é retirado 1, após o while se encerrar o vetor na posição j mais 1, ira receber menor.
<br> Entrada: Tamanho vetor 5, números: 18 1 6 5 87 <br>
Saida: 1 5 6 18 87




<img src=".\imagens\lista3ex3.png">



# Exercício 4:
## Ordenação Merge

Foi desenvolvido uma função recursiva que recebe um vetor de inteiros, um inteiro para ser o inicio, e por ultimo um inteiro para receber o fim, após isso é verificado com uma estrutura de condição que o inicio é menor que o fim através de uma condição, se sim ir é criado uma  variável  auxiliar, chamada de meio, após é chamada duas vezes em ordem a própria função, a primeira passando o Vetor, o inicio e meio, a segunda passando o vetor, o meio + 1, e o fim, e por ultimo o vetor vai receber uma função chamada intercalar que recebe o vetor, inicio e fim;
No intercalar recebendo o vetor, inicio e fim, irá criar um vetor auxiliar do tamanho do vetor que chegou, esse vetor auxiliar irá ser preenchido por todo conteúdo do vetor passado como parâmetro, depois é criada quatro variáveis que recebem; 2 delas (i, J) o inicio, Meio recebendo inicio + fim dividido por 2, para definir o meio, e outra chamada de K onde, recebe meio + 1;
A seguir vem 1 while que ocorre quando i menor ou igual a meio e k menor ou igual ao fim onde ocorre uma estrutura de condição (if) que faz a comparação se Vetor Auxiliar na posição i for maior que vetor auxiliar na posição K, se sim Vetor na posição J recebe Vetor auxiliar na posição K, e o K é somado +1, se não Vetor na posição J recebe Vetor auxiliar na posição J recebe vetor auxiliar na posição I, e o I é somado +1; No final J é incrementado a +1;
A seguir vem outros dois while um que ve se i é menor ou igual a meio, que ocorre vetor na posição J recebe vetor auxiliar na posição I, j e i ambos recebem incremento de +1;
E o ultimo k é menor ou igual a fim, que ocorre vetor na posição J recebe vetor auxiliar na posição K, j e k ambos recebem incremento de +1;
Ao final é retornado aquele vetor<br>

Entrada: Tamanho vetor 10  Numeros: 12 17 58 5847 02 14 36 48 59<br>
Saida: 2 12 14 17 36 47 48 58 59 5847





<img src=".\imagens\lista3ex4.png">


# Exercício 5:
## Metodo Shell
Foi desenvolvido uma função do tipo void, que recebe um vetor de inteiros e uma variável inteira chamada de Hop, após vem uma estrutura condicional que verifica se a variável é igual a 1, se sim, ocorre uma estrutura de repetição(for) idêntica ao método insertion (já citado aqui), se a condicional for falsa, ira ocorrer uma estrutura muita parecida, com o método insertion, onde invés de ocorrer a diminuição de 1 em 1, vai se diminuindo de acordo a variável Hop passada como parâmetro, e no final ocorre uma chamada recursiva do método passando o vetor, e o Hop dividido por 2.
<br>Entrada: Tamanho vetor 16 Números: 47 25 14 98 47 01 23 54 25 17 59 012 26 74 89 47 <br>
Saida: 1, 12, 14, 17, 23, 25, 25, 26, 47, 47, 47, 54, 59, 74, 89, 98




<img src=".\imagens\lista3ex5.png">



# Exercício 6:
## Metodo Quicksort

Foi desenvolvido duas funções, a primeira uma void, que recebe um vetor, duas variáveis inteira, sendo inicio e fim, dentro da função ocorre a criação de uma variável inteira, chamada de parte, após tem uma condicional que verifica se inicio é menor que fim, se verdadeira, ocorre que a variável parte recebe a segunda função partição passando como parâmetro, o vetor, inicio e fim; Após ocorre a chamada por meio recursivo da própria função duas vezes na primeira passando o vetor, i inicio e parte menos 1, e na segunda o vetor, parte mais 1, e fim; se falsa a condição, não ocorre nada e encerra
Segunda função, é do tipo inteira, onde recebe o vetor, duas variáveis inteira, inicio e fim, dentro da função, ocorre a criação de 3 variáveis do tipo inteira, pivô recebendo vetor na posição fim, part recebendo inicio menos 1, e aux, depois há uma estrutura de repetição onde tem como condição, o i recebendo o inicio e indo ate o fim menos 1, dentro dele há uma estrutura condicional, que verifica que se o vetor na posição i, é menor que o pivô, se sim o part recebe mais 1, ocorre a troca de i com part e avança o i, se não ocorre apenas o avanço do i, após a estrutura ser finalizada, part troca com o pivô e retorna o valor que esta em part.
<br>
Entrada: Tamanho vetor 10 Números 47 59 14 26 35 15 16 34 18 59 <br>
Saida: 14 15 16 18 26 34 35 47 59 59 




<img src=".\imagens\lista3ex6.png">

# Exercício 7:
## Metodo Couting

Foi criada uma função do tipo void, que recebe um vetor, dentro da função, ocorre a criação de uma variável do tipo inteira maior recebendo o vetor na posição 0, depois há uma estrutura de repetição onde, tem como parâmetro i recebendo 1 indo ate o tamanho do vetor menos 1, onde tem uma condicional que verifica se o vetor na posição i é maior que a variável maior, onde se sim, maior vai receber aquele valor, ao fim da estrutura é criado dois vetores, um para a contagem recebendo maior mais um, e o outro v2 que recebe o tamanho do vetor parâmetro, depois vem uma estrutura de repetição onde se inicia em i= 0 e vai ate o vetor menos 1, onde ocorre que o vetor contagem na posição do vetor na pos i recebe mais um, depois vem o outra estrutura de repetição que iniciada em i = 1, e vai ate o tamanho do vetor contagem menos 1, o contagem na posição i irá receber o contagem na posição i menos 1, e por fim vem o ultimo vetor onde ocorre que o i iniciado no tamanho do vetor menos 1, vai ate chegar igual 0, onde ocorre que V2 na posição do vetor contagem na pos do vetor pos i menos 1 recebe vetor na posição i, e o contagem na pos vetor pos i recebe -1, ao final vem a ultima estrutura onde passa todos os dados do V2 para o vetor 
 <br>
Entrada: Tamanho vetor 10 Números 47 9 14 62 15 87 26 14 29 13 <br>
Saida: 9 13 14 14 15 26 29 47 62 87





<img src=".\imagens\lista3ex7.png">

# Exercício 8:
## Metodo RadixSort LSD

Para a solução foi desenvolvida duas funções, a primeira do tipo void, que recebe um vetor,  que após ocorre a criação de uma variável do tipo inteira maior recebendo o vetor na posição 0, depois há uma estrutura de repetição onde, tem como parâmetro i recebendo 1 indo ate o tamanho do vetor menos 1, onde tem uma condicional que verifica se o vetor na posição i é maior que a variável maior, onde se sim, maior vai receber aquele valor, no final há outra estrutura de repetição que ocorre de dígitos igual a 1, indo de maior dividido por dígitos maior que 0, e dígitos crescendo vezes 10, onde ocorre a chamada da outra função, contagem recebendo o vetor e o digito
A segunda função chamada de contagem, também é do tipo void, recebe um vetor, e um inteiro, diferente da função do exercício anterior, ela já cria o vetor 2 com o tamanho do vetor e o contar no tamanho 10, depois vem uma estrutura de repetição onde se inicia em i= 0 e vai ate o vetor menos 1, onde ocorre que o vetor contagem na posição do vetor na pos i dividido por unidade e resto da divisão por 10 recebe mais um, depois vem o outra estrutura de repetição que iniciada em i = 1, e vai ate o tamanho do vetor contar menos 1, o contar na posição i irá receber o contagem na posição i menos 1, e por fim vem o ultimo vetor onde ocorre que o i iniciado no tamanho do vetor menos 1, vai ate chegar igual 0, onde ocorre que V2 na posição do vetor contagem na pos do vetor pos i dividido por unidade e resto dividido por 10, menos 1 recebe vetor na posição i, e o conta na pos vetor pos i recebe -1, ao final vem a ultima estrutura onde passa todos os dados do V2 para o vetor
<br>
Entrada: Tamanho vetor 10 Números 648 197 1874 1354 100000 15 2 2 4 <br> 
Saida: 2 2 4 15 48 197 648 1354 1874 100000





<img src=".\imagens\lista3ex8.png">


# Exercício 9:
## Metodo RadixSort MSD

Para a solução foi desenvolvida duas funções, a primeira do tipo void, que recebe um vetor,  que após ocorre a transformação dos valores do alfabeto para números, e após isso ocorre a chamada da outra função chamada de Sort para ordenar ela com o método de inserção, onde acontece processos similar ao dos métodos anteriores onde podemos ver que ao invés de estarem usando uma grande variedade de números, podemos notar que eles são limitados ao números de letras que tem no alfabeto, se diversas palavras tiverem o começo igual, cai numa estrutura condicional que chama um Swap que ocorre que faz comparação com a segunda letra, esse processo acontece, ate chegar em uma letra de valor diferente.
<br>
Entrada: Palbras "Algoritmos", "Estruturas", "De", "Dados", "Do", "Professor", "Leonardo" <br> 
Saida: Algoritmos Dados De Do Estruturas Leonardo Professor





<img src=".\imagens\lista3ex9.png">
