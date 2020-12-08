using System;
using Csharp.Classes;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
           Mastercard m = new Mastercard();

           m.NomeTitular = "Brenda Larissa Benfica dos Santos";

           m.Numero = "5450 2285 5846 8592";

           m.Bandeira = "MasterCard";
           
           Console.ForegroundColor = ConsoleColor.DarkYellow;
           Console.Write($"Nome do cartão: {m.NomeTitular} \r\n");
           Console.Write($"Número do cartão: {m.Numero} \r\n");
           Console.Write($"Bandeira: {m.Bandeira} \r\n ");
           Console.WriteLine($"CVV: {m.Token} \r\n");

        }
    }
}
