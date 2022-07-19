using System;
using System.Collections.Generic;

namespace Desafio1
{
    class Program
    {
        static bool ativo = true;
        static bool sucesso = false;
        static bool deNovo = false;
        static int numero;
        static string romano;
        static Dictionary<int, string> Unidade = new Dictionary<int, string>() { { 0, "" }, { 1, "I" }, { 2, "II" }, { 3, "III" }, { 4, "IV" }, { 5, "V" }, { 6, "VI" }, { 7, "VII" }, { 8, "VIII" }, { 9, "IX" } };
        static Dictionary<int, string> Dezena = new Dictionary<int, string>() { { 0, "" }, { 1, "X" }, { 2, "XX" }, { 3, "XXX" }, { 4, "XL" }, { 5, "L" }, { 6, "LX" }, { 7, "LXX" }, { 8, "LXXX" }, { 9, "XC" } };
        static Dictionary<int, string> Centena = new Dictionary<int, string>() { { 0, "" }, { 1, "C" }, { 2, "CC" }, { 3, "CCC" }, { 4, "CD" }, { 5, "D" }, { 6, "DC" }, { 7, "DCC" }, { 8, "DCCC" }, { 9, "CM" } };
        static Dictionary<int, string> Mil = new Dictionary<int, string>() {{ 0, "" }, { 1, "M" }, { 2, "MM" }, { 3, "MMM" }, { 4, "" }, { 5, "" }, { 6, "" }, { 7, "" }, { 8, "" }, { 9, "" } };
        static void Main(string[] args)
        {
            while (ativo)
            {
                while (!sucesso)
                {
                    Console.Write("Digite seu número de 1 a 3999 a ser convertido para numerais romanos: ");
                    sucesso = int.TryParse(Console.ReadLine(), out numero);
                }
                Conversao(numero);
                Console.WriteLine("Seu número em romanos é: " + romano + "\n");
                deNovo = false;
                while (!deNovo)
                {
                    Console.WriteLine("Deseja transformar outro número? (S/N)");
                    string resposta = Console.ReadLine();
                    if (resposta == "S" || resposta == "s")
                    {
                        deNovo = true;
                        sucesso = false;
                    }
                    else if (resposta == "N" || resposta == "n")
                    {
                        deNovo = true;
                        ativo = false;
                        Console.WriteLine("Até mais!");
                    }
                    else
                    {
                        Console.WriteLine("Resposta inválida!\n");
                    }
                }
            }
        }

        public static void Conversao(int numero)
        {
            int unidade = numero % 10;
            numero = numero / 10;
            int dezena = numero % 10;
            numero = numero / 10;
            int centena = numero % 10;
            numero = numero / 10;
            romano = Mil[numero] + Centena[centena] + Dezena[dezena] + Unidade[unidade];
        }
    }
}
