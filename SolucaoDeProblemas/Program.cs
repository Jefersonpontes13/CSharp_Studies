using System;
using System.Collections.Generic;

namespace SolucaoDeProblemas
{
    class Program
    {
        static void Main(string[] args)
        {
            //PreenchimentoDeVetorI();
            TrigoNoTabuleiro();
        }

        public static void TrigoNoTabuleiro()
        {
            string[] valores = new[]
            {
                "0",
                "0",
                "0",
                "0",
                "0",
                "0",
                "0",
                "0",
                "0",
                "0",
                "0",
                "0",
                "1",
                "2",
                "5",
                "10",
                "21",
                "43",
                "87",
                "174",
                "349",
                "699",
                "1398",
                "2796",
                "5592",
                "11184",
                "22369",
                "44739",
                "89478",
                "178956",
                "357913",
                "715827",
                "1431655",
                "2863311",
                "5726623",
                "11453246",
                "22906492",
                "45812984",
                "91625968",
                "183251937",
                "366503875",
                "733007751",
                "1466015503",
                "2932031007",
                "5864062014",
                "11728124029",
                "23456248059",
                "46912496118",
                "93824992236",
                "187649984473",
                "375299968947",
                "750599937895",
                "1501199875790",
                "3002399751580",
                "6004799503160",
                "12009599006321",
                "24019198012642",
                "48038396025285",
                "96076792050570",
                "192153584101141",
                "384307168202282",
                "768614336404564",
                "1537228672809129",
                "3074457345618258",
            };

            int qtdTeste = int.Parse(Console.ReadLine());
            string[] resultados = new string[qtdTeste];
            for (int teste = 0; teste < qtdTeste; teste++)
            {
                int valorTeste = int.Parse(Console.ReadLine());

                if (valorTeste < 2)
                {
                    resultados[teste] = valores[valorTeste];
                }
                else
                {
                    resultados[teste] = valores[valorTeste - 2];
                }

                for (int indice = 0; indice < qtdTeste; indice++)
                {
                    Console.WriteLine(resultados[indice] + " kg");
                }

                Console.Read();
            }
        }

        public static void PreenchimentoDeVetorI()
        {
            int TAMANHO_VETOR = 10;
            int valorLido = int.Parse(Console.ReadLine());

            Console.WriteLine("N[{0}] = {1}", 0, valorLido);

            for (int indice = 1; indice < TAMANHO_VETOR; indice++)
            {
                Console.WriteLine("N[{0}] = {1}", indice, valorLido * 2);
                valorLido = valorLido * 2;
            }
        }
    }
}