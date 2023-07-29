
using System.Globalization;

int n1 = int.Parse(Console.ReadLine());
char ch = char.Parse(Console.ReadLine());
double n2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

string nome = Console.ReadLine();
char sexo = char.Parse(Console.ReadLine());
int idade = int.Parse(Console.ReadLine());
double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("voce digitou: ");
Console.WriteLine(n1);
Console.WriteLine(ch);
Console.WriteLine(n2.ToString(), CultureInfo.InvariantCulture);

Console.WriteLine(nome);
Console.WriteLine(sexo);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString(), CultureInfo.InvariantCulture);

