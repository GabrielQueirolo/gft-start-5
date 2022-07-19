using System;

namespace Desafio2
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem vindo ao Dungeons & Dragons!\n");
            DeterminarRaca();
        }

        static void DeterminarRaca()
        {
            Console.WriteLine("Suas opções de raça são:\n1 - Anão\n2 - Elfo\n3 - Humano");
            Console.Write("Escolha a sua raça: ");
            bool escolhido = int.TryParse(Console.ReadLine(), out int escolha);

            switch (escolha)
            {
                case 1:
                    Console.WriteLine("\nRaça escolhida: Anão");
                    break;
                case 2:
                    Console.WriteLine("\nRaça escolhida: Elfo");
                    Elfo elfo = new Elfo();
                    break;
                case 3:
                    Console.WriteLine("\nRaça escolhida: Humano");
                    break;
                default:
                    Console.WriteLine("\nNão existe opção para esta escolha\n");
                    DeterminarRaca();
                    break;

            }
            Console.WriteLine("Fora");
            Console.ReadLine();
        }
    }
}
