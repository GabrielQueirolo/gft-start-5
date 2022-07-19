using System;

namespace Desafio3
{
    class Program
    {
        string numeroString;
        int numeroInt;
        int resto;
        int contador;

        public void Main(string[] args)
        {
            Console.Write("Escreva um número de 0 a 999.999.999(sem pontos): ");
            numeroString = Console.ReadLine();
            numeroInt = int.Parse(numeroString);
            while (numeroInt != 0)
            {
                resto = numeroInt % 1000;
                Centenas(resto / 100);
                resto = resto % 100;
                Dezenas(resto);
                Unidade(resto % 10);
                
                //Depois dele rodar os ultimos 3 algarismos, verificar se ainda possui mais, e se possuir, fazer o mesmo processo, apenas adicionando
                //mil ou milhão ao final do produto. Isso seria verificado através do contador, que conta a cada 3 algarismos trabalhados.
                //Cada vez que fossem trabalhados os 3 últimos algarismos, eles seriam retirados do número original
                //Quando não houvesse mais número a ser trabalhado, ou seja, numeroInt for zero, o processo seria terminado e o resultado exibido 
            }
        }

        public Centenas(int resto)
        {
            //Pega o resultado da divisão e atribui o seu texto, por exemplo, o número 435 chegaria como 4, e aí atribuiria ele a "quatrocentos"
        }
        public Dezenas(int resto)
        {
            //Pega o resultado da divisão e atribui o seu texto, por exemplo, o número 35 chegaria como 3, e aí atribuiria ele a "trinta"
            //Também é aqui que levaria em conta os número de dez a dezenove, tirando o tratamento na parte da Unidade
        }

        public Unidade(int resto)
        {
            //Pega o resultado da divisão e atribui o seu texto, por exemplo, o número 35 chegaria como 5, e aí atribuiria ele a "cinco"
        }

    }
}
