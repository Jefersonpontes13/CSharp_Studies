using System;
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
            //MediaCoxinha();
            //ValidacaoDeNotas();
            ComprasNoSupermercado();
        }

        public static void ComprasNoSupermercado()
        {
            var totalDeCasosDeTeste = int.Parse(Console.ReadLine() ?? string.Empty);
            List<string> listasCompras = new List<string>();
            List<string> resultados = new List<string>();
            
            for (int i = 0; i < totalDeCasosDeTeste; i++)
            {
                listasCompras.Add(Console.ReadLine() ?? string.Empty);
            }

            foreach (var listaCompra in listasCompras)
            {
                List<string> novaLista = new List<string>();
                foreach (var elemento in listaCompra.Split(" "))
                {
                    if (!novaLista.Contains(elemento))
                    {
                        novaLista.Add(elemento);
                    }
                }
                
                novaLista.Sort();

                string novaListaString = string.Empty;
                
                foreach (var elemento in novaLista)
                {
                    novaListaString = novaListaString + elemento + " ";
                }

                novaLista = new List<string>();
                resultados.Add(novaListaString);
                
            }
            foreach (var resultado in resultados)
            {
                Console.WriteLine(resultado);
            }
        }

        private static void ValidacaoDeNotas()
        {
            List<string> resultados = new List<string>();
            string program;
            float nota1;
            float nota2;
            do
            {
                do
                {
                    nota1 = float.Parse(Console.ReadLine() ?? string.Empty);
                    if ((nota1 < 0) | (nota1 > 10))
                    {
                        //Console.WriteLine("nota invalida");
                        resultados.Add("nota invalida");
                    }
                } while (nota1 < 0 | nota1 > 10);
                
                do
                {
                    nota2 = float.Parse(Console.ReadLine() ?? string.Empty);
                    if ((nota2 < 0) | (nota2 > 10))
                    {
                        //Console.WriteLine("nota invalida");
                        resultados.Add("nota invalida");
                    }
                } while (nota2 < 0 | nota2 > 10);
                
                //Console.WriteLine("media = " + ((nota1 + nota2) / 2).ToString("N2"));
                resultados.Add("media = " + ((nota1 + nota2) / 2).ToString("N2"));
                do
                {
                    //Console.WriteLine("novo calculo (1-sim 2-nao)");
                    resultados.Add("novo calculo (1-sim 2-nao)");
                    program = Console.ReadLine() ?? string.Empty;
                    //Console.WriteLine(program);

                } while (program != "1" && program != "2");
                
                
            } while (program == "1");
            
            foreach (var resultado in resultados)
            {
                Console.WriteLine(resultado);
            }
        }


        private static void MediaCoxinha()
        {
            string[] line = (Console.ReadLine() ?? string.Empty).Split(" ");
            Console.WriteLine($"{double.Parse(line[0]) / double.Parse(line[1]): 0.00}");
        }

        private static void PedraPapelTesouraLagartoSpock()
        {
            int qtdTeste = int.Parse(Console.ReadLine() ?? string.Empty);
            List<string> resultados = new List<string>();

            string v1, v2;
            for (int i = 1;
                i <= qtdTeste;
                i++) //insira a variavel correta
            {
                string[] valores = (Console.ReadLine() ?? string.Empty).Split();
                v1 = valores[0];
                v2 = valores[1];

                switch (v1)
                {
                    case "tesoura":
                        if (v2 == "papel" | v2 == "lagarto")
                        {
                            resultados.Add($"Caso #{i}: Bazinga!");
                            break;
                        }
                        else if (v2 == "pedra" | v2 == "Spock")
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
                        if (v2 == "tesoura" | v2 == "lagarto")
                        {
                            resultados.Add($"Caso #{i}: Bazinga!");
                            break;
                        }
                        else if (v2 == "papel" | v2 == "Spock")
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
                        if (v2 == "pedra" | v2 == "Spock")
                        {
                            resultados.Add($"Caso #{i}: Bazinga!");
                            break;
                        }
                        else if (v2 == "lagarto" | v2 == "tesoura")
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
                        if (v2 == "papel" | v2 == "Spock")
                        {
                            resultados.Add($"Caso #{i}: Bazinga!");
                            break;
                        }
                        else if (v2 == "pedra" | v2 == "tesoura")
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
                        if (v2 == "tesoura" | v2 == "pedra")
                        {
                            resultados.Add($"Caso #{i}: Bazinga!");
                            break;
                        }
                        else if (v2 == "lagarto" | v2 == "papel")
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

            a = Convert.ToDouble(Console.ReadLine() ?? string.Empty);
            b = Convert.ToDouble(Console.ReadLine() ?? string.Empty);

            //complete com as variaveis
            mediaP = ((a * 3.5) + (b * 7.5)) / (2 + 3.5 + 7.5);

            Console.WriteLine("MEDIA = {0}", mediaP.ToString("0.00000"));
        }

        private static void SomaDeDoisNumeros()
        {
            //Declare Variables
            int A = Convert.ToInt32(Console.ReadLine() ?? string.Empty);
            int B = Convert.ToInt32(Console.ReadLine() ?? string.Empty);

            //Insira as variaveis de acordo com o solicitado
            int SOMA = A + B;

            //Print
            Console.WriteLine("SOMA = {0}", SOMA);
        }

        private static void DivisaoDeXNumeros()
        {
            int limit = Int32.Parse(Console.ReadLine() ?? string.Empty);
            List<string> resultados = new List<string>();

            for (int i = 0; i < limit; i++)
            {
                string[] line = (Console.ReadLine() ?? string.Empty).Split(" ");
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