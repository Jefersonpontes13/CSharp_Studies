using System;
using System.Collections.Generic;

namespace DesafiosAitmeticosIntermediarios
{
    class Program
    {
        static void Main(string[] args)
        {
            //QantidadeNotasEMoedas();
            //TiposDeTriangulos();
            TeoremaDeBhaskara();
        }

        public static void TeoremaDeBhaskara()
        {
            double a, b, c, delta, r1, r2;
            string[] valor = Console.ReadLine().Split();

            a = Convert.ToDouble(valor[0]);
            b = Convert.ToDouble(valor[1]);
            c = Convert.ToDouble(valor[2]);
            delta = (Math.Pow(b, 2) - (4 * a * c));
            r1 = (-b + Math.Sqrt(delta)) / (2 * a);
            r2 = (-b - Math.Sqrt(delta)) / (2 * a);

            if (a != 0 && delta > 0) {
                Console.WriteLine($"R1 = {r1.ToString("F5")}");
                Console.WriteLine($"R2 = {r2.ToString("F5")}");
            } else {
                Console.WriteLine("Impossivel calcular");
            }
        }

        public static void TiposDeTriangulos()
        {
            string[] entrada = Console.ReadLine()?.Split(' ');
            List<double> ladosTrianulo = new List<double>();
            
            ladosTrianulo.Add(double.Parse(entrada[0]));
            ladosTrianulo.Add(double.Parse(entrada[1]));
            ladosTrianulo.Add(double.Parse(entrada[2]));
            
            ladosTrianulo.Sort();

            if (ladosTrianulo[2] >= ladosTrianulo[0] + ladosTrianulo[1])
                Console.WriteLine("NAO FORMA TRIANGULO");
            else if (Math.Pow(ladosTrianulo[2], 2) == Math.Pow(ladosTrianulo[0], 2) + Math.Pow(ladosTrianulo[1], 2))
                Console.WriteLine("TRIANGULO RETANGULO");
            else if (Math.Pow(ladosTrianulo[2], 2) > Math.Pow(ladosTrianulo[0], 2) + Math.Pow(ladosTrianulo[1], 2))
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            else if (Math.Pow(ladosTrianulo[2], 2) < Math.Pow(ladosTrianulo[0], 2) + Math.Pow(ladosTrianulo[1], 2))
                Console.WriteLine("TRIANGULO ACUTANGULO");
            if (ladosTrianulo[2] == ladosTrianulo[0] & ladosTrianulo[2] == ladosTrianulo[1])
                Console.WriteLine("TRIANGULO EQUILATERO");
            if ((ladosTrianulo[2] == ladosTrianulo[0] & ladosTrianulo[2] != ladosTrianulo[1])| 
                (ladosTrianulo[2] == ladosTrianulo[1] & ladosTrianulo[2] != ladosTrianulo[0]) | 
                (ladosTrianulo[0] == ladosTrianulo[1] & ladosTrianulo[0] != ladosTrianulo[2]))
                Console.WriteLine("TRIANGULO ISOSCELES");

            Console.ReadLine();
        }

        public static void QantidadeNotasEMoedas()
        {
            List<float> notas = new List<float>();
            List<int> notasQuantidade = new List<int>();
            notas.Add((float) 100.00);
            notas.Add((float) 50.00);
            notas.Add((float) 20.00);
            notas.Add((float) 10.00);
            notas.Add((float) 5.00);
            notas.Add((float) 2.00);

            List<float> moedas = new List<float>();
            List<int> moedasQuantidade = new List<int>();
            moedas.Add((float) 1.00);
            moedas.Add((float) 0.50);
            moedas.Add((float) 0.25);
            moedas.Add((float) 0.10);
            moedas.Add((float) 0.05);
            moedas.Add((float) 0.01);

            float valor;

            valor = (float) Convert.ToDecimal(Console.ReadLine());

            foreach (var nota in notas)
            {
                if ((int)(valor / nota) != 0)
                {
                    notasQuantidade.Add((int)(valor / nota));
                    valor -= ((int)(valor / nota)) * nota;
                }
                else
                {
                    notasQuantidade.Add(0);
                }
            }

            foreach (var moeda in moedas)
            {
                if ((int) (valor / moeda) != 0)
                {
                    moedasQuantidade.Add((int)(valor / moeda));
                    valor -= ((int) (valor / moeda)) * moeda;
                }
                else
                {
                    moedasQuantidade.Add(0);
                }
            }
            
            Console.WriteLine("NOTAS:");
            for (int indice = 0; indice < notas.Count; indice++)
            {
                Console.WriteLine(notasQuantidade[indice] + " nota(s) de R$ " + notas[indice].ToString("N2"));
            }
            
            Console.WriteLine("MOEDAS:");
            for (int indice = 0; indice < moedas.Count; indice++)
            {
                Console.WriteLine(moedasQuantidade[indice] + " moeda(s) de R$ " + moedas[indice].ToString("N2"));
            }
        }
    }
}