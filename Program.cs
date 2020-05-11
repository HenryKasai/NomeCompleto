using System;

namespace NomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Olá usuário, seu nome é: ");
            string nome = Console.ReadLine();
            Console.Write("E o seu sobrenome é: ");
            string sobrenome = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Nome completo: " + nome + " " + sobrenome + ".");
            Console.WriteLine("Nome de catálogo: " + sobrenome + ", " + nome + ".");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();
        }
    }
}
