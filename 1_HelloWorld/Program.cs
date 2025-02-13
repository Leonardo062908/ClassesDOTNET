// Importação de bibliotecas não é necessária nesse caso, pois estamos utilizando funcionalidades básicas do .NET

// Exibe uma mensagem no console
Console.WriteLine("Hello, World!");

// Declara uma variável `texto` e armazena a entrada do usuário
var texto = Console.ReadLine(); 

// Exibe no console o texto digitado pelo usuário usando interpolação de strings ($)
Console.WriteLine($"Texto digitado: {texto}");

// Declaração de variáveis com diferentes tipos numéricos

var numeroInteiro = 12;        // `int` → Número inteiro (tipo inferido automaticamente como int)
var numeroDecimal = 20.5;      // `double` → Número decimal (padrão do .NET para números com ponto flutuante)
var numeroFlutuante = 20.5f;   // `float` → Número de ponto flutuante (precisa do sufixo `f` para indicar que é float)
var numeroDecimalGrande = 20.5m; // `decimal` → Tipo mais preciso para cálculos financeiros (precisa do sufixo `m`)

// Solicita que o usuário digite um número e exibe a mensagem no console
Console.WriteLine("Digite um número de sua preferência:");

// Lê a entrada do usuário, converte para `float` e armazena na variável `numero`
float numero = float.Parse(Console.ReadLine());

// Exibe o número digitado pelo usuário no console, usando interpolação de strings ($)
Console.WriteLine($"O número digitado: {numero}");