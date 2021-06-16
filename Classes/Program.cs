using System;
using Classes.Classes;
namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Ponto origem = new Ponto(0, 0);
            Ponto ponto1 = new Ponto(1, 1);
            Console.WriteLine(origem.x);
            Console.WriteLine(ponto1.y);
        }
    }
}