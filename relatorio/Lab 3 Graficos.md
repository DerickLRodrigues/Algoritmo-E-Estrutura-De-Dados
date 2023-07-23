# Funcionamento do Program.cs
Todos os testes foram executados usando a mesma configuração de computador, todos considerando os milissegundos de execução, e foi utilizado uma função para preencher o vetor com números aleatórios de 0 até 100000.
# Exercício 1: 
## Metodo Bubble Sort

Tempos de execução:<br>
<img src=".\imagens\Graficos\Tabela1.png">
<br>Gráfico:<br>
<img src=".\imagens\Graficos\Grafico1.png">




# Exercício 2:
## Metodo Selection

Tempos de execução:<br>
<img src=".\imagens\Graficos\Tabela2.png">
<br>Gráfico:<br>
<img src=".\imagens\Graficos\Grafico2.png">


# Exercício 3:
## Metodo Insertion

Tempos de execução:<br>
<img src=".\imagens\Graficos\Tabela3.png">
<br>Gráfico:<br>
<img src=".\imagens\Graficos\Grafico3.png">



# Exercício 4:
## Ordenação Merge

Tempos de execução:<br>
<img src=".\imagens\Graficos\Tabela4.png">
<br>Gráfico:<br>
<img src=".\imagens\Graficos\Grafico4.png">







# Exercício 5:
## Metodo Shell

Tempos de execução:<br>
<img src=".\imagens\Graficos\Tabela5.png">
<br>Gráfico:<br>
<img src=".\imagens\Graficos\Grafico5.png">



# Exercício 6:
## Metodo Quicksort

Tempos de execução:<br>
<img src=".\imagens\Graficos\Tabela6.png">
<br>Gráfico:<br>
<img src=".\imagens\Graficos\Grafico6.png">

# Exercício 7:
## Metodo Couting

Tempos de execução:<br>
<img src=".\imagens\Graficos\Tabela7.png">
<br>Gráfico:<br>
<img src=".\imagens\Graficos\Grafico7.png">

# Exercício 8:
## Metodo RadixSort LSD

Tempos de execução:<br>
<img src=".\imagens\Graficos\Tabela8.png">
<br>Gráfico:<br>
<img src=".\imagens\Graficos\Grafico8.png">


# Conclusões:
## Aqui possui comentarios sobre oque foi observado

Com os gráficos e tabelas podemos notar que quase todos os métodos ordenando vetores com até 500 números foram menos que 0 milissegundos, com exceção do couting, que para 50, 100, e 500 teve um tempo de 5, 4 e 5 milissegundos, sendo o pior para esses casos.
 Para um vetor de 1000 números já houve um cenário diferente, onde tivemos Radix Sort LSD, Quick e Shell sendo os melhores com tempo de menos de 0 milissegundos, e o pior sendo couting que continua mantendo o seu 5 milissegundos.
Para um vetor de 5000 numeros podemos notar que os melhores é Radix Sort LSD e Quick, onde tivemos menos de 0 milissegundos, e os piores foram os métodos de ordenação básica, bolha, insertion e selection, onde notamos que eles começam a crescer muito o tempo em milissegundos.
Um vetor de 100000 numeros, os melhores métodos de ordenação foram couting, RadixSort LSD, e Quick respectivamente, e os piores sendo os métodos de ordenação básica, bolha, insertion e selection, que o tempo de execução deles começou a ter uma grande diferença ao demais.
Um vetor de 500000, ainda mantemos couting, radixsort LSD, e Quick respectivamente sendo os melhores, e os piores sendo os métodos de ordenação básica.
E por ultimo o vetor de 1000000, onde mantemos o top 3 anterior e os piores também sendo os mesmos.
Com essa pequena analise podemos notar que para vetores pequenos, os métodos de ordenação básica, pode ser utilizado para uma pequena base de dados, notamos também que o método Couting, quando mais números repetidos possuir ele se beneficia, por causa disso nos vetores menores ele era um dos piores, e depois começou a se tornar um dos melhores, o RadixSort LSD, por utilizar um método também de contagem, dividindo os numeros em numeros menores, também não fica muita para tras, para uma base de dados que não conhecemos podemos também olhar que o Quick, Merge e o Shell pode ser um dos melhores a ser utilizado.
<br>
Gráficos com todos os métodos:
<img src=".\imagens\Graficos\Grafico9.png">
