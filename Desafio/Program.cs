﻿using System;
using System.Collections.Generic;

namespace Desafio
{
    class Program
    {

        static void Main(string[] args)
        {
            
            // DivisaoDeXNumeros();
            // SomaDeDoisNumeros();
            //MediaPonderada();
            //PedraPapelTesouraLagartoSpock();
            MediaCoxinha();
        }

        private static void MediaCoxinha()
        {
            string[] line = Console.ReadLine().Split(" ");
            Console.WriteLine($"{double.Parse(line[0]) / double.Parse(line[1]): 0.00}");
        }

        private static void PedraPapelTesouraLagartoSpock()
        {
            int qtdTeste = int.Parse(Console.ReadLine());
            
            List<string> resultados = new List<string>();

            string v1, v2;
            for (int i = 1; i <= qtdTeste; i++) //insira a variavel correta
            {
                string[] valores = Console.ReadLine().Split();
                v1 = valores[0];
                v2 = valores[1];

                switch (v1)
                {
                    case "tesoura":
                        if (v2 == "papel" | v2 == "lagarto" )
                        {
                            resultados.Add($"Caso #{i}: Bazinga!");
                            break;
                        }
                        else if (v2 == "pedra" | v2 == "Spock" )
                        {
                            resultados.Add($"Caso #{i}: Raj trapaceou!");
                            break;
                        }
                        else
                        {
                            resultados.Add($"Caso #{i}: De novo!");
                            break;
                        }
                        
                    case "pedra":
                        if (v2 == "tesoura" | v2 == "lagarto" )
                        {
                            resultados.Add($"Caso #{i}: Bazinga!");
                            break;
                        }
                        else if (v2 == "papel" | v2 == "Spock" )
                        {
                            resultados.Add($"Caso #{i}: Raj trapaceou!");
                            break;
                        }
                        else
                        {
                            resultados.Add($"Caso #{i}: De novo!");
                            break;
                        }
                        
                    case "papel":
                        if (v2 == "pedra" | v2 == "Spock" )
                        {
                            resultados.Add($"Caso #{i}: Bazinga!");
                            break;
                        }
                        else if (v2 == "lagarto" | v2 == "tesoura" )
                        {
                            resultados.Add($"Caso #{i}: Raj trapaceou!");
                            break;
                        }
                        else
                        {
                            resultados.Add($"Caso #{i}: De novo!");
                            break;
                        }
                        
                    case "lagarto": 
                        if (v2 == "papel" | v2 == "Spock" )
                        {
                            resultados.Add($"Caso #{i}: Bazinga!");
                            break;
                        }
                        else if (v2 == "pedra" | v2 == "tesoura" )
                        {
                            resultados.Add($"Caso #{i}: Raj trapaceou!");
                            break;
                        }
                        else
                        {
                            resultados.Add($"Caso #{i}: De novo!");
                            break;
                        }
                        
                    case "Spock":
                        if (v2 == "tesoura" | v2 == "pedra" )
                        {
                            resultados.Add($"Caso #{i}: Bazinga!");
                            break;
                        }
                        else if (v2 == "lagarto" | v2 == "papel" )
                        {
                            resultados.Add($"Caso #{i}: Raj trapaceou!");
                            break;
                        }
                        else
                        {
                            resultados.Add($"Caso #{i}: De novo!");
                            break;
                        }
                }
            }

            foreach (var resultado in resultados)
            {
                Console.WriteLine(resultado);
            }
        }

        private static void MediaPonderada()
        {
            double a, b, mediaP;

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            
            //complete com as variaveis
            mediaP = (( a * 3.5) + ( b * 7.5)) / (2 + 3.5 + 7.5);

            Console.WriteLine("MEDIA = {0}", mediaP.ToString("0.00000"));
        }

        private static void SomaDeDoisNumeros()
        {
            //Declare Variables
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
        
            //Insira as variaveis de acordo com o solicitado
            int SOMA = A + B;

            //Print
            Console.WriteLine("SOMA = {0}", SOMA);
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

