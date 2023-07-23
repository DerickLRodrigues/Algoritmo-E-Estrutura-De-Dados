# Funcionamento do Program.cs
Todos os exercícios foram desenvolvidos em arquivos unicos .cs. com os seus respectivos numeros do exercicio. Alguns solicitam entradas do usuário, outros apenas fazem cálculos sozinhos e printam os resultados. A descrição e a maneira como se seguem cada exercício encontra-se a seguir:



# Exercício Fila Dinamica: 

## Foi desenvolvida três classes sendo elas: 
### Aluno 
que tem o nome, matricula e nota
### Elemento 
que cria e encapsula o aluno e salva a referencia
### Operacoes 
que tem os métodos que fazem os métodos sendo eles:
#### adcElementoFila:
que recebe de parâmetro o ponteiro do ultimo elemento juntamente com o numero, e la é inserido
####  removeFila: 
que recebe os ponteiros como parâmetro, o metodo pega o primeiro elemento, e salva em outra variável, e depois faz com o primeiro apontar para o segundo elemento, e retorna a outra variável
#### imprimiFila: 
que recebe os ponteiros, faz uma comparação com uma condicional If, se verdadeiro, fala que a lista é vazia se falsa, cria uma variável pesquisa que recebe o primeiro, depois vem uma estrutura de repetição While, que ocorre enquanto a pesquisa for diferente do ultimo, e vai imprimindo, e o pesquisa sendo incrementado.
#### tamanhoFila: 
Funciona muito parecido com o imprimiFila, com todas as estruturas, so que ao inves de ir imprimindo ele vai contando através de uma variável auxiliar e a retorna no final
#### primeiroFila: 
também recebe os ponteiros, e através de uma comparação com If, se verdadeira imprimi, lista vazia, se falsa, imprimi o primeiro elemento da fila


## Entradas e saidas:
adcElementoFila (entrada): <br>
Nome: Derick, Ana, Leo <br>
Matricula:3, 4, 9 <br>
nota:2, 1, 04
 
<img src=".\imagens\lista5ex0.png">
<img src=".\imagens\lista5ex1.png">
<img src=".\imagens\lista5ex2.png">
 
removeFila(saída): O Aluno Derick foi Removido

<img src=".\imagens\lista5ex3.png">
 
primeiroFila(saída): Ana

<img src=".\imagens\lista5ex4.png">
 
imprimiFila(saída): Ana, Leo

<img src=".\imagens\lista5ex5.png">
 
tamanhoFila(saída): 2

<img src=".\imagens\lista5ex6.png">


# Lista Dinamica:

## Foi desenvolvida três classes sendo elas: 
### aluno
que tem o nome, matricula e nota
### Elemento 
que cria e encapsula o aluno e salva a referencia
### Operacoes 
que tem os métodos que fazem os métodos sendo eles:
#### adcElementoLista: 
que recebe de parâmetro o ponteiro do ultimo elemento e o numero, ele percorre toda a lista e se o numero inserido tiver no meio da lista, ele faz as conexões dos ponteiros e atualizando, caso não ele apenas adiciona no final
#### removeLista: 
que recebe os ponteiros como parâmetro, o metodo verifica se a posicao existe, se sim passa pela a lista fazendo desconexão e as conexões novas necessárias.
#### imprimiLista: 
que recebe os ponteiros, faz uma comparação com uma condicional If, se verdadeiro, fala que a lista é vazia se falsa, cria uma variável pesquisa que recebe o primeiro, depois vem uma estrutura de repetição While, que ocorre enquanto a pesquisa for diferente do ultimo, e vai imprimindo, e o pesquisa sendo incrementado.
#### tamanhoLista: 
Funciona muito parecido com o imprimiLista, com todas as estruturas, so que ao inves de ir imprimindo ele vai contando através de uma variável auxiliar e a retorna no final
#### procurar: 
funciona parecido com as funções tamanhoLista e imprimiLista so que recebe uma string procurada, e onde na estrutura de repetição While, tem uma condicional If, que se aquele elmento for igual o procurado, ele retornara True, se não ao final retornara true.

## Entradas e saidas

adcElementoLista (entrada): <br>
Nome: Derick, Leo, Barbara<br>
matricula: 4, 534, 1<br>
nota: 2, 32, 1<br>
posicao: 2, 4, 1
 
<img src=".\imagens\lista5ex7.png">
<img src=".\imagens\lista5ex8.png">
<img src=".\imagens\lista5ex9.png">

motrarLista(saida):Derick Barbara Leo

<img src=".\imagens\lista5ex10.png">

removerElementoLista: posicao 1
 
<img src=".\imagens\lista5ex11.png">

procurar: Erick, Leo
 
<img src=".\imagens\lista5ex12.png">
<img src=".\imagens\lista5ex13.png">
  
verificarTamanhoLista: 2 
 
<img src=".\imagens\lista5ex14.png">

# Pilha Dinamica:

## Foi desenvolvida três classes sendo elas: 
### aluno
que tem o nome, matricula e nota
### Elemento que cria e encapsula o aluno e salva a referencia
### Operacoes
que tem os métodos que fazem os métodos sendo eles:
#### adcTopo: 
que recebe de parâmetro o ponteiro do ultimo elemento juntamente com o numero, e la é inserido
#### removerTopo: 
que recebe os ponteiros como parâmetro, o metodo pega o ultimo elemento, e salva em outra variável, e depois faz com que percorra toda a estrutura ate o penúltimo, e depois atualiza o apontando para o nulo
#### imprimiPilha: 
que recebe os ponteiros, faz uma comparação com uma condicional If, se verdadeiro, fala que a lista é vazia se falsa, cria uma variável pesquisa que recebe o primeiro, depois vem uma estrutura de repetição While, que ocorre enquanto a pesquisa for diferente do ultimo, e vai imprimindo, e o pesquisa sendo incrementado.
#### topoPilha: 
recebe os parâmetro, pega o ultimo elemento e o retorna 

## Entradas e saidas

adcTopo (entrada):<br>
nome: Derick, Barbora, Leonardo<br>
matricula: 4, 43, 01<br>
nota: 23, 0, 10
 
<img src=".\imagens\lista5ex15.png">
<img src=".\imagens\lista5ex16.png">
<img src=".\imagens\lista5ex17.png">
 

removerTopo (saida): O Aluno Leonardo Foi Removido

<img src=".\imagens\lista5ex18.png">
 
topoPilha (saida): Barbora

<img src=".\imagens\lista5ex19.png">
 
imprimiPilha (saida): Derick Barbora
 
<img src=".\imagens\lista5ex20.png">

## Manutenção solicitadas

### Pilha

Impressão do topo ate a base: A função foi modificada para pegar o elemento do topo ate a base, de maneira, que fica salvando o elemento anterior e o retornando

#### Entradas e saidas

Inseridos, Derick, Barbara, Ana<br>
Saida, Ana, Barbara, Derick<br>

<img src=".\imagens\Pilha Impressao.png">

### Lista


Colocar no primeiro disponivel: Pergunta se quer inserir no primeiro lugar disponível, ou selecionar onde inserir: no menu foi criado uma 6 opção, inserir no primeiro disponível, onde pega e percorre a lista ate encontra algum elemento nulo, e o coloca-lo 

Entrada: Derick, Barbara, Ana<br>
<img src=".\imagens\ListaPrimeiroElemento.png"><br>

Saida: Derick, Barbara, Ana<br>
<img src=".\imagens\ListaSaidaPrimeiroElemento.png"><br>


Remover Primeiro Disponível da Lista, no menu foi criado uma 7 opção, onde pega e percorre a lista ate encontrar um primeiro elemento e o excluí-lo<br>

Saida: Derick, Barbara<br>

<img src=".\imagens\ListaExclusaoPrimeiroElemento.png">

### Fila

estava dando um problema que apos tentar remover mesmo que apos tirasse todos os elementos, crashava, foi resolvido fazendo uma verificação se é nulo ou nao

#### Entradas e saidas

Saida, Ana, Barbara, Derick

<img src=".\imagens\FilaErro.png">
