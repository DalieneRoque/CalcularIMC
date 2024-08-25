# Calculadora de Índice de Massa Corporal (IMC)

### Como é feito o cálculo de IMC
  * O IMC é calculado dividindo o peso (em kg) pela altura ao quadrado (em m), de acordo com a seguinte fórmula: 

~~~
IMC = peso / (altura x altura).
~~~

### Entrada de dados

* Console.Write: Exibe uma mensagem para o usuário. Aqui, estamos pedindo para o usuário informar o peso e a altura.
* double.Parse(Console.ReadLine()): Lê o valor digitado pelo usuário e tenta convertê-lo de string para double.
  O método Console.ReadLine() captura o que o usuário digita, e double.Parse converte essa entrada para o tipo double.
~~~
Console.Write("Informe o peso em Kg: ");
double peso = double.Parse(Console.ReadLine());

Console.Write("Informe a altura em metros: ");
double altura = double.Parse(Console.ReadLine());
~~~

### Cálculo do IMC

* O IMC (Índice de Massa Corporal) é calculado dividindo o peso (em kg) pela altura ao quadrado (em metros). Esse valor é armazenado na variável valorIMC.
~~~
double valorIMC = peso / (altura * altura);
~~~

### Estrutura Condicional (if-else)

* Condicionais (if-else if-else): Comparam o valor do IMC para verificar em qual faixa ele se encontra.
* Dependendo do valor do valorIMC, o programa exibe a classificação correspondente ("Abaixo do peso", "Normal", "Acima do peso", etc.).
* Console.WriteLine: Aqui usamos $"\n IMC = {valorIMC:F2} -> Classificação" para exibir a mensagem. O {valorIMC:F2} formata o IMC para mostrar apenas duas casas decimais.


### Pausa para Visualização (Console.ReadKey)

* Isso faz com que o programa aguarde até que o usuário pressione qualquer tecla, evitando que a janela do console feche imediatamente após a execução do programa.

~~~
Console.ReadKey();
~~~


