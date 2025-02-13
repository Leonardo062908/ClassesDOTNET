// Importação de bibliotecas não é necessária nesse caso, pois estamos utilizando funcionalidades básicas do .NET

// Exibe uma mensagem no console
Console.WriteLine("Hello, World!");

// Declara uma variável `texto` e armazena a entrada do usuário
var texto = Console.ReadLine(); 

// Exibe no console o texto digitado pelo usuário usando interpolação de strings ($)
Console.WriteLine($"Texto digitado: {texto}");

// ------------------------------------------------------
// Declaração de variáveis com diferentes tipos numéricos
// ------------------------------------------------------

var numeroInteiro = 12;        // `int` → Número inteiro (tipo inferido automaticamente como int)
var numeroDecimal = 20.5;      // `double` → Número decimal (padrão do .NET para números com ponto flutuante)
var numeroFlutuante = 20.5f;   // `float` → Número de ponto flutuante (precisa do sufixo `f` para indicar que é float)
var numeroDecimalGrande = 20.5m; // `decimal` → Tipo mais preciso para cálculos financeiros (precisa do sufixo `m`)

// ------------------------------------------------------
// Entrada de dados e conversão para `float`
// ------------------------------------------------------

// Solicita que o usuário digite um número e exibe a mensagem no console
Console.WriteLine("Digite um número de sua preferência:");

// Lê a entrada do usuário, converte para `float` e armazena na variável `numero`
float numero = float.Parse(Console.ReadLine());

// Exibe o número digitado pelo usuário no console, usando interpolação de strings ($)
Console.WriteLine($"O número digitado: {numero}");

// ------------------------------------------------------
// Tipos de dados para texto
// ------------------------------------------------------

// Declara uma string curta
var textoPequeno = "Olá, mundo!";

// Declara uma string multilinha usando a sintaxe de strings de múltiplas linhas (@" ")
var textoGrande = """
                  Olá mundo!!
                  Como você está?;
                  tudo bem e você?
                  """;

// Exibe o texto longo no console
Console.WriteLine (textoGrande);

// ------------------------------------------------------
// Booleanos (valores verdadeiro/falso)
// ------------------------------------------------------

var verdadeiro = true;  // Representa um valor booleano verdadeiro
var falso = false;      // Representa um valor booleano falso

// ------------------------------------------------------
// Operadores de Decisão (`if-else`)
// ------------------------------------------------------

// Aqui há um erro lógico: a condição `!(numero > 10)` é equivalente a `numero <= 10`
// No entanto, a mensagem dentro do `if` é incorreta, pois diz que o número é maior que 10 quando na verdade não é.
if (!(numero > 10)) 
    Console.WriteLine("O número NÃO é maior que 10!");
else
    Console.WriteLine("O número é maior que 10!");

// ------------------------------------------------------
// Operador Ternário
// ------------------------------------------------------

// Versão simplificada do `if-else`, utilizando um operador ternário para decidir entre duas mensagens
Console.WriteLine(!(numero > 10) ? "O número NÃO é maior que 10!" : "O número é maior que 10!");

// ------------------------------------------------------
// Estrutura de Decisão `switch-case`
// ------------------------------------------------------

// Dependendo do valor da variável `numero`, um caso específico será executado
switch (numero)
{
    case 10:
        Console.WriteLine("O número é 10"); // Se o número for 10, esta linha será executada
    break;    
    case 20:
        Console.WriteLine("O número é 20"); // Se o número for 20, esta linha será executada
    break;
    default:
        Console.WriteLine("O número é diferente de 10 e 20"); // Caso nenhuma das opções acima seja verdadeira
    break;    
}

// ------------------------------------------------------
// Laço de Repetição `while`
// ------------------------------------------------------

// Inicializa uma variável `i` com 0
var i = 0;

// Enquanto `i` for menor que 10, o bloco de código será executado repetidamente
while (i < 10)
{
    Console.WriteLine(i); // Exibe o valor atual de `i`
    i++; // Incrementa `i` para evitar um loop infinito
}

// ------------------------------------------------------
// Laço de Repetição `foreach`
// ------------------------------------------------------

// Declara um array de inteiros chamado `numeros`, contendo valores de 11 a 20
var numeros = new int[]{11,12,13,14,15,16,17,18,19,20};

// Usa um loop `foreach` para percorrer cada elemento do array `numeros`
foreach (var n in numeros)
    Console.WriteLine(n); // Exibe cada número do array
