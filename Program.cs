Console.WriteLine("Faça o Calculo da área ");

double Raio;
double r;
double PI = 3.14159;

Console.WriteLine("A = 3,14159 * R²");
Console.Write("A = 3,14159 * ");

Raio  = double.Parse(Console.ReadLine());
r = Math.Pow(Raio,2);

double multi = PI * r;

Console.WriteLine($"O resultado da conta é esse: {multi}");