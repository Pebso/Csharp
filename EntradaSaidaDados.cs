using System.Globalization;

int n1 = int.Parse(Console.ReadLine());
char ch = char.Parse(Console.ReadLine());
double n2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

string[] vet = Console.ReadLine().Split( ' ' );// aspas simples para dividir nos espaços em branco
string nome = vet[0];
char sexo = char.Parse(vet[1]);// Parse para vetor tem o msm raciocinio do readline
int idade = int.Parse(vet[2]);
double altura = double.Parse(vet[3],CultureInfo.InvariantCulture);
Console.WriteLine("voce digitou: ");
Console.WriteLine(n1);
Console.WriteLine(ch);
Console.WriteLine(n2.ToString(), CultureInfo.InvariantCulture);
Console.WriteLine(nome);
Console.WriteLine(sexo);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));





