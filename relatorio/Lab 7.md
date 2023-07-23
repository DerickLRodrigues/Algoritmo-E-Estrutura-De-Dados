# Funcionamento do Program.cs
Todos os exercícios foram desenvolvidos em arquivos unicos .cs. com os seus respectivos numeros do exercicio. Alguns solicitam entradas do usuário, outros apenas fazem cálculos sozinhos e printam os resultados. A descrição e a maneira como se seguem cada exercício encontra-se a seguir:



# Exercício Lista Dinamica Duplamente encadeada: 

## Foi desenvolvida três classes sendo elas: 
### aluno
que tem o nome, matricula e nota
### Elemento 
que cria e encapsula o aluno e salva duas referencia próximo e anterior
(o codigo utilizado foi o mesmo que a lista encadeada, somente adicionando o elemento anterior)
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
funciona parecido com as funções tamanhoLista e imprimiLista so que recebe uma string procurada, e onde na estrutura de repetição While, tem uma condicional If, que se aquele elemento for igual o procurado, ele retornara True, se não ao final retornara true.
#### imprimirInverso: 
funciona parecido com o imprimirLista, so que ao inves de começar pelo o primeiro ate o ultimo, comeca  pelo ultimo, vai ate o primeiro

## Entradas e Saidas

adcElementoLista: <br>
nome Rodrigo, Hungria, Pedro <br>
matricula 2, 0, 4<br>
nota 1, 4, 3<br>
posicao 1, 0, 2
 
<img src=".\imagens\lista7ex0.png">   
<img src=".\imagens\lista7ex1.png">   
<img src=".\imagens\lista7ex2.png">   
 
removerElementoLista: posicao 0

<img src=".\imagens\lista7ex3.png">   
 
imprimirLista: Rodrigo Pedro

<img src=".\imagens\lista7ex4.png">   
 
procurar: Ana, Rodrigo

<img src=".\imagens\lista7ex5.png">
<img src=".\imagens\lista7ex6.png">      
 
 
tamanhoLista:
 
<img src=".\imagens\lista7ex7.png">   

imprimirInverso:

<img src=".\imagens\lista7ex8.png">   
 
