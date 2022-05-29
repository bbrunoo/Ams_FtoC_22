double Graus = 0.0;
double Fahrenheit = 0.0;

Console.WriteLine("Escreva a temperatura em Fahrenheit para a conversao para Graus:");
Fahrenheit = Convert.ToInt32(Console.ReadLine());

Graus = (Fahrenheit - 32) * 5 / 9;

Console.WriteLine($"{Fahrenheit} Fahrenheit em Graus é igual á: {Graus}");
