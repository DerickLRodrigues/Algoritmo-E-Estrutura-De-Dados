# Funcionamento do Program.cs
Todos os exercícios foram desenvolvidos em arquivos unicos .cs. com os seus respectivos numeros do exercicio. Alguns solicitam entradas do usuário, outros apenas fazem cálculos sozinhos e printam os resultados. A descrição e a maneira como se seguem cada exercício encontra-se a seguir:

# Exercício 1: 
## Alguns números de quatro algarismos possuem uma característica particular. Se separamos esse número em dois grupos e os somarmos encontramos um outro número cujo quadrado é exatamente igual ao número fornecido anteriormente. Veja o exemplo: Número = 3025. Separando o número em dois grupos de dois algarismos temos o 30 e o 25 . A soma de 30 com 25 é igual a 55 O Quadrado de 55 é igual a 3025. Faça um programa que mostre os números de 1000 a 9999 que possuem essa característica.

Para a resolução desse problema, primeiro deveria entender como que iria para fazer a divisão dos 2 grupos, optei por dividir por 100 onde pegaria os dois primeiro dígitos, e após fazer uma operação para pegar o resto divido por 100, pegando os dois últimos dígitos, depois faz a soma dos dois números obtidos e faz a elevação ao quadrado, e verifica se é igual ao numero de entrada. <br>
A entrada é feita com um for que vai de 1000 a 9999. <br>
Saida: 2025 3025 9801


<img src=".\imagens\lista1ex1.png">

# Exercício 2:
## Um Número é dito Primo se possui como divisores o número 1 e ele mesmo. Em outras palavras, um Número Primo possui dois divisores de 1 até ele. Faça um programa que mostre se um determinado número inteiro, lido pelo teclado, é Primo.

Para definir se um numero é primo, foi criado uma função que percorre um vetor iniciando em dois, onde vai ate o antecessor do numero referencia, dentro desse for a uma estrutura de condição onde se o numero referencia dividido pelo o numero do For dar o resto do resultado de 0, retorna que o numero não é primo e para a estrutura de repetição , caso passe pela a estrutura por completa e não em nada, retorna que o numero é perfeito <br>

Entradas do exemplo: 187  7 <br>
Saida do exemplo: não é primo  é primo


<img src=".\imagens\lista1ex2at1.png">



## Um Número é dito Perfeito se a soma de seus divisores menores que ele é igual a ele. Por exemplo, o número 6 possui os  divisores 1, 2 e 3, cuja soma é igual a 6. Faça um programa que liste os números perfeitos de 1 a 1000.

Foi criada uma função que recebe um numero, e cria uma variável acumuladora, e um for que se inicia em 1 e vai ate o antecessor do numero referencia, dentro dele possui uma estrutura de condição, que se o numero referencia dividido pelo o numero do for, o resto ser igual a 0, o acumulador ira receber e somar o numero, no final da estrutura de repetição, existe uma estrutura de condição onde, se o acumulador tiver o mesmo valor que o numero referencia, fala que o numero é perfeito<br>
Entradas: For percorrendo de 1 a 1000 <br>
Saida: 6 28 496


<img src=".\imagens\lista1ex2at2.png">

# Exercício 3:
## Faça um programa que receba os elementos de dois vetores, A e B, cada um com 5 posições. Considere que nenhum dos vetores possui elementos repetidos. Crie um vetor resultante C que possua os elementos comuns entre A e B. Crie um vetor resultante D que contenha os elementos de A que não existam em B.

Foi criado 4 vetores, onde 2 deles  recebe as entradas do usuário através de 2 for, após isso existe 1 for dentro de outro for, que faz a comparação se os números são iguais ou não, se forem salvam no vetor C, se não salvam no vetor D<br>
Entradas: 1 2 3 4 5 4 5 6 7 8 <br>
Saida: <br>
Elementos comuns entre A e B: <br>
4 5 
Elementos de A que não existem em B: <br>
1 2 3   


<img src=".\imagens\lista1ex3.png">



# Exercício 4:
## Faça um programa que receba os elementos de uma matriz de 5 linhas por 3 colunas. Mostre a soma dos elementos de cada uma das linhas e das colunas da matriz.

Para a resolução foi criada, uma matriz de 5 linhas e 3 colunas onde há dois for, um dentro do outro, para o preenchimento da matriz, depois é criado um vetor de tamanho 5, após isso é criado um dois for encapsulados que fazem a soma da linha e recebe a soma da linha e após é criado um vetor de tamanho 3, após isso é criado um dois for encapsulados que fazem a soma da coluna e recebe a soma da Coluna<br>

Entradas: 1 4 7 5 2 4 7 9 6 4 2 1 7 5 8<br>
Saidas: <br>
Soma da linha 1 = 12 <br>
Soma da linha 2 = 11<br>
Soma da linha 3 = 22<br>
Soma da linha 4 = 7<br>
Soma da linha 5 = 20<br>
Soma da coluna 1 = 24<br>
Soma da coluna 2 = 22<br>
Soma da coluna 3 = 26<br>


<img src=".\imagens\lista1ex4.png">


# Exercício 5:
## Faça um programa que chame uma função capaz de calcular o Fatorial de um número inteiro.

Na resolução deste exercício, foi desenvolvido um método recursivo que tem como condição de parada passar um número menor que 1. Neste caso ele retorna 1, caso contrário, o método faz a chamada recursiva passando N-1 como parâmetro e multiplicando os desempilhamentos.<br>

Entrada: 14  <br>
Saida: 1278945280<br>


<img src=".\imagens\lista1ex5.png">



# Exercício 6:
## Faça um programa que chame uma função capaz de calcular x^y, sendo x e y inteiros. Utilize passagem de parâmetros por referência.

Foi criado um método recursivo que recebe o X e Y, que tem como condição de parada um numero menor que 1, neste caso retornando 1 caso contrario a chamada recursiva passando X, Y-1 como parâmetro e multiplicando os desempilhamentos.<br>
Entrada 8 3 <br>
Saida 512<br>


<img src=".\imagens\lista1ex6.png">
