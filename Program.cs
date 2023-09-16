Console.WriteLine("--- Decomposição Decimal ---\n");

Console.WriteLine("Digite um número inteiro: ");
int numeroDigitado, centenas, dezenas, unidades;
numeroDigitado = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("O número possui: ");

centenas = numeroDigitado / 100;

dezenas = (numeroDigitado % 100) / 10;

unidades = (numeroDigitado % 100) % 10;

Console.WriteLine($"{centenas,10} centena(S)");
Console.WriteLine($"{dezenas, 10} desena(S)");
Console.WriteLine($"{unidades,10} unidade(S)");
