# Funcionamento do Program.cs
Todos os exercícios foram desenvolvidos em arquivos unicos .cs. com os seus respectivos numeros do exercicio. Alguns solicitam entradas do usuário, outros apenas fazem cálculos sozinhos e printam os resultados. A descrição e a maneira como se seguem cada exercício encontra-se a seguir:


# Exercício Arvore Binaria: 

## São feitas 3 classes
### Aluno
com nome, matricula(essa que iremos utilizar para construir), nota
### Nodo
encapsulando Aluno, nodo esquerdo e nodo direito
### ArvoreBinaria 
que contem os métodos sendo eles:
#### Inserir 
que verifica se a raiz é nula com um If, se não, chama recursivamente o inserirRecursivamente
#### InserirRecursivamente
verifica se a matricula que chega, é menor que a raiz, se sim, dentro dele tem outro If, que ve se a esquerda esta nulo, se sim ele apenas adiciona, se não, ele chama recursivamente novamente, mas se o primeiro if de verificação ser falso, ela entra verificando se a direita é nulo, se sim so adiciona, se não, chama recursivamente novamente
#### Remover 
coloca a nova raiz, sendo definida, chamando o RemoverRecursivamente
#### RemoverRecursivamente
vai verificar se o nodo atual é nulo, depois tem uma condicional If que verifica se é menor que o matricula se sim, tenta chamar novamente recursivamente, se não, utiliza do else if se é maior, se sim chama recursivamente, se não vai para um else, que tem mais um if que vai verificar se a esquerda ou a direita esta vazia, depois vai chamar para o atual o MinimoValor.
#### MinimoValor
vai verificar qual é o menor para fazer a rotação.
#### Buscar 
vai verificar se o atual é nulo, ou se o atual é igual a matricula procurada, se sim returno naquele momento, se não vai para outra condicional que vai verificar se é maior ou menor para ir chamando para a direita ou esquerda
#### Vazia
serve para ver se a arvore esta vazia ou não, com um simples IF se estiver nulo, é vazio
#### Caminhar
vai chamando o caminharRecursivamente, e enquanto não for vazio vai chamando para caminhar para a direita e esquerda e o imprimindo
#### Tamanho
Vai passando e contando todos os nodos da arvore e somando, e no final retorna o total
#### Altura 
vai chamando recursivamente para o nodo a esquerda e a direita para ver qual que tem o maior valor, oque tiver o maior valor vai ser retornado muito parecido com o tamanho, so que ao inves ir somando todos, somente o do mais baixo

## Entradas e saídas:

Inserir (entrada): <br>
Nome Derick Barbara <br>
Matricula 21 12 <br>
Nota 3 4
 
<img src=".\imagens\lista6ex0.png"> 
<img src=".\imagens\lista6ex1.png"> 
 
Para não ter que colocar muitas imagens, foi criado mais alunos, e segue os números de matriculas deles, que é o mais importante para esse caso, 34 234 342 320 3420 097 685 

Remover (entrada): 34

<img src=".\imagens\lista6ex2.png"> 
 
Buscar (entrada): 234 e 875
 
<img src=".\imagens\lista6ex3.png">
<img src=".\imagens\lista6ex4.png">  
 
Verificar se esta vazio (saida): 
 
<img src=".\imagens\lista6ex5.png"> 

caminhar (saida): Barbara, Derick, Cleiton, Ana, Rodrigo, Luis, Jorge, Alberto

<img src=".\imagens\lista6ex6.png"> 
  
Tamanho (saida): 8

<img src=".\imagens\lista6ex7.png"> 
 
Altura (saida): 4
 
<img src=".\imagens\lista6ex8.png">  

## Manutenção solicitadas

para a solução do problema que foi notado, quando se chama o metodo 5 de caminhar, aparece a opção para selecionar para ser ordem, pre ordem ou pos ordem chamando as suas funções onde ocorre:
Em ordem, chama para a esquerda recursivamente, depois printa raiz, e chama para a direita recursivamente
Pre ordem, imprimi a Raiz, chama para a esquerda recursivamente e depois para a direita recursivamente
Pos Ordem, chama para a esquerda recursivamente, depois para a direita recursivamente, e depois printa a raiz



Os números inseridos foram 34, 23, 58, 2, 1 e 3

Em ordem:
1 2 3 23 34 58 

<img src=".\imagens\EmOrdem.png">  

Pré-ordem:
34 23 2 1 3 58 

<img src=".\imagens\PreOrdem.png">  

Pós-ordem:
1 3 2 23 58 34 

<img src=".\imagens\PosOrdem.png">  
