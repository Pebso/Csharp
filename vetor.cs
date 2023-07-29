using System.Globalization;

namespace Estudos
{
    internal class Program
    {
        static void Main(string[] args)//vetor
        {// split analisa o string original, e reconhece cada espaço em branco e separa o bloco de palavras
            //armazenando em um vetor de string
            string frase = Console.ReadLine();

            string[] vet = frase.Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];
            string p4 = vet[3];
            string p5 = vet[4];
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine(p4);
            Console.WriteLine(p5);

            Console.ReadLine();



        }
    }
}
