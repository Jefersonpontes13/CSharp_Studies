using System;
using System.Collections.Generic;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            // DivisaoDeXNumeros();
            
        }

        private static void DivisaoDeXNumeros()
        {
            int limit = Int32.Parse(Console.ReadLine());
            List<string> resultados = new List<string>();
            
            for (int i = 0; i < limit; i++)
            {
                string[] line = Console.ReadLine().Split(" ");
                double X = double.Parse(line[0]);
                double Y = double.Parse(line[1]);
                if (Y == 0)
                {
                    resultados.Add("divisao impossivel"); 
                }
                else
                {
                    resultados.Add((X / Y).ToString("N1"));
                }
            }

            foreach (var resultado in resultados)
            {
                Console.WriteLine(resultado);
            }
        }
    }
    

    
}

