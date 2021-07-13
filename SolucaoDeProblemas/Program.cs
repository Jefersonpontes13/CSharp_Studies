using System;

namespace SolucaoDeProblemas
{
    class Program
    {
        static void Main(string[] args)
        {
            PreenchimentoDeVetorI();
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