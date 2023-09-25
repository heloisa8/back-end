Console.WriteLine("digite o valor de x");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("digite o valor de y");
int y = int.Parse(Console.ReadLine());

//exemplos de operações aritimeticas
int soma = x + y;
int subtracao = x - y;
int divisao = x / y;
int multiplicacao = x * y;
int resto = x % y;
int restoDiv2 = x % 2;
int restoDiv3 = y % 2;

//console para exibir na tela as variaveis em cada linha
// soma: 15
Console.WriteLine($"soma: {soma}");

// subtração: -5
Console.WriteLine($"subtracao: {subtracao}");

// divisão: 0
Console.WriteLine($"divisao: {divisao}");

// multiplicação: 50
Console.WriteLine($"multiplicacao: {multiplicacao}");

// resto: 5
Console.WriteLine($"resto: {resto}");

if (restoDiv2 == 0){
    Console.WriteLine($"o numero {x} é par");
}
else {
    Console.WriteLine($"o numero {y} é impar");
}
//gerador ternario
// condição ? se verdade : senão
string resultado = (restoDiv3 == 0) ? $"o numero {x} é par" : $"o numero {y} é impar";
Console.WriteLine(resultado);

int diaSemana = 3;
switch (diaSemana){
    case 1:
    Console.WriteLine("Hoje é domingo!");
    break;
    case 2:
    Console.WriteLine("Hoje é segunda!");
    break;
    case 3:
    Console.WriteLine("Hoje é terça");
    break;
    case 4:
    Console.WriteLine("Hoje é quarta");
    break;
    case 5:
    Console.WriteLine("hoje é quinta");
    break;
    case 6:
    Console.WriteLine("hoje é sexta");
    break;
    case 7:
    Console.WriteLine("hoje é sabado");
    break;
    default:
    Console.WriteLine("dia invalido");
}
