# Funcionamento do Program.cs
Todos os exercícios foram desenvolvidos em arquivos unicos .cs. com os seus respectivos numeros do exercicio. Alguns solicitam entradas do usuário, outros apenas fazem cálculos sozinhos e printam os resultados. A descrição e a maneira como se seguem cada exercício encontra-se a seguir:

# Exercício Fila Estatica: 

## Foi desenvolvida quatro funções, sendo elas: 
### adcElementoFila
do tipo void, ela recebe o vetor, o numero que vai ser inserido e por referencia a posição, onde ocorre que o vetor na posição, recebe o numero enviado, e a variável posição recebe o incremento de 1.
### removeFila 
do tipo void, ela recebe o vetor e a posicao por referencia, onde ocorre que há uma variável que recebe o vetor na posicao 0, e após isso uma estrutura de repetição, que vai substituindo o vetor na posicao i, por i + 1, no final a ultima posicao recebe 0, e a variável posicao tem um decremento de 1
### primeiroFila 
do tipo Int, onde recebe o vetor e retorna o vetor na posicao 0
### imprimiFila 
do tipo void, recebe o vetor, e com uma estrutura de repetição, imprime tudo
### No main 
a posição é iniciada em 0, para ser alterada somente nas chamadas das funções 

## Entradas e Saidas

adcElementoFila (entrada): 2, 6, 8 

<img src=".\imagens\lista4ex0.png">

removeFila(saída): 2

<img src=".\imagens\lista4ex1.png">

primeiroFila(saída): 6

<img src=".\imagens\lista4ex2.png">

imprimiFila(saída)6, 8, 0

<img src=".\imagens\lista4ex3.png">

# Exercício Lista Estatica: 

## Foi desenvolvida quatro funções, sendo elas: 
### adcElementoLista 
do tipo void, ela recebe o vetor, o numero que vai ser inserido e a posição, onde ocorre que o vetor na posição, recebe o numero enviado.
### excluirElementoPos 
do tipo void, ela recebe o vetor e a posicao que vai ser excluida, onde ocorre que o vetor naquela posicao, recebe 0, e depois vem uma estrutura de repetição, jogando todas as casas anteriores para frente, assim como na fila.
### procurarElemento 
do tipo bool, onde recebe o vetor e o numero, onde através de uma estrutura de repetição, irá percorrer o vetor, e dentro da estrutura, há uma condicional If, que se o vetor naquela posicao for igual o numero, retornar true, caso não ocorra e chega no final da estrutura de repetição, returna False 
### imprimiLista 
do tipo void, recebe o vetor, e com uma estrutura de repetição, imprime tudo
### Main
quando selecionada a opção procurar elementos, tem um IF que se verdadeiro, imprime numero encontrado, se falso não encontrado
 

## Entradas e Saidas

adcElementoLista (entrada): 2 na posicao 2, 6 na posicao 0, 8 na posicao 1 

<img src=".\imagens\lista4ex4.png">

removeLista(entrada): posicao 1

<img src=".\imagens\lista4ex5.png">

procurarElemento( entrada e saída):numero 8, não encontrado, numero 2 encontrado

<img src=".\imagens\lista4ex6.png">

imprimiFila(saída)6, 2, 0

<img src=".\imagens\lista4ex7.png">

# Exercício Pilha Estatica: 

## Foi desenvolvida quatro funções, sendo elas: 
### adcTopo 
do tipo void, ela recebe o vetor, o numero que vai ser inserido e por referencia a posição, onde ocorre que o vetor na posição, recebe o numero enviado, e a variável posição recebe o incremento de 1.
### removeTopo 
do tipo int, ela recebe o vetor e a posicao por referencia, onde a posicao recebe o decremento de 1, e retorna o vetor na posicao.
### pilhaTopo 
do tipo Int, onde recebe o vetor e a posicao e retorna o vetor na posicao contador – 1.
### mostrarPilha 
do tipo void, recebe o vetor e a posicao, e com uma estrutura de repetição, imprime tudo ate chegar na posicao.
### main 
a posição é iniciada em 0, para ser alterada somente nas chamadas das funções 


## Entradas e Saidas

adcTopo (entrada): 3, 9, 22 

<img src=".\imagens\lista4ex8.png">

removeTopo (saída): 22

<img src=".\imagens\lista4ex9.png">

pilhaTopo (saída): 9

<img src=".\imagens\lista4ex10.png">

mostrarPilha (saída)3, 9

<img src=".\imagens\lista4ex11.png">