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
            //ComprasNoSupermercado();
            //ValidadorDeSenhasComRequisitos();
            // FilaDoBanco();
            SequenciaLogica();
        }

        public static void SequenciaLogica()
        {
            int numeroEntrada = Convert.ToInt32(Console.ReadLine());
            for (int valorAtual = 1; valorAtual <= numeroEntrada; valorAtual++)
            {
                int valorAtual2 = (int) Math.Pow(valorAtual, 2);
                int valorAtual3 = (int) Math.Pow(valorAtual, 3);
                Console.WriteLine("{0} {1} {2}", valorAtual, valorAtual2, valorAtual3);
                Console.WriteLine("{0} {1} {2}", valorAtual, valorAtual2 + 1, valorAtual3 + 1);

            }
        }

        public static void FilaDoBanco()
        {
            List<int> resultados = new List<int>();
            var totalDeCasosDeTeste = int.Parse(Console.ReadLine() ?? string.Empty);

            for (int i = 0; i < totalDeCasosDeTeste; i++)
            {
                List<int> codigosDosClientes = new List<int>();
                List<int> codigosDosClientesOrdenados = new List<int>();

                int numeroDeClientes = int.Parse(Console.ReadLine() ?? string.Empty);
                string codigosClientes = Console.ReadLine() ?? string.Empty;

                foreach (var codigo in codigosClientes.Split(" "))
                {
                    codigosDosClientes.Add(int.Parse(codigo));
                    codigosDosClientesOrdenados.Add(int.Parse(codigo));
                }

                codigosDosClientesOrdenados.Sort();

                int resultValue = 0;

                int indiceListaVelha = 0;
                int indiceListaOrdenada = numeroDeClientes - 1;
                while (indiceListaVelha < numeroDeClientes && indiceListaOrdenada >= 0)
                {
                    if (codigosDosClientes[indiceListaVelha] == codigosDosClientesOrdenados[indiceListaOrdenada])
                    {
                        resultValue = resultValue + 1;
                    }

                    indiceListaOrdenada = indiceListaOrdenada - 1;
                    indiceListaVelha = indiceListaVelha + 1;
                }

                resultados.Add(resultValue);
            }

            foreach (var resultado in resultados)
            {
                Console.WriteLine(resultado);
            }
        }

        public static void ValidadorDeSenhasComRequisitos()
        {
            List<string> resultados = new List<string>();

            string senha;
            do
            {
                senha = Console.ReadLine() ?? string.Empty;
                Console.WriteLine(TemCaracteresPermitidos(senha));

                if (
                    TemMaiuscula(senha) &&
                    TemMinuscula(senha) &&
                    TemCaracteresPermitidos(senha) &&
                    senha.Length >= 6 &&
                    senha.Length <= 32)
                {
                    resultados.Add("Senha valida.");
                }
                else
                {
                    if (senha != "")
                    {
                        resultados.Add("Senha invalida.");
                    }
                }
            } while (senha != "");

            foreach (var resultado in resultados)
            {
                Console.WriteLine(resultado);
            }
        }

        public static bool TemCaracteresPermitidos(string senha)
        {
            //char[] caracteresPermitidos = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o',
            //    'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J',
            //    'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            for (int i = 0; i < senha.Length; i++)
            {
                if (!caracteres.Contains(senha[i]))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool TemMaiuscula(string senha)
        {
            for (int i = 0; i < senha.Length; i++)
            {
                if (char.IsUpper(senha[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool TemMinuscula(string senha)
        {
            for (int i = 0; i < senha.Length; i++)
            {
                if (char.IsLower(senha[i]))
                {
                    return true;
                }
            }

            return false;
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