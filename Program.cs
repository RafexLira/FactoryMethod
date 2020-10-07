using FactoryMethodExample.ConcretCreator;
using FactoryMethodExample.Creator;
using FactoryMethodExample.CreatorConcret;
using FactoryMethodExample.Product;
using System;

namespace FactoryMethodExample
{
    class Program
    {      
        static void Main(string[] args)
        {

            string console = null;
            string x;
            CartaoFactory cartaoFactory = null;

            do
            {
                Console.WriteLine("\nISTO É APENAS UM TESTE\n");
                Console.WriteLine("Digite o tipo de cartão que deseja");
                Console.WriteLine("Opção 1 - Cartão Black");
                Console.WriteLine("Opção 2 - Cartão Platinum");
                Console.WriteLine("Opção 3 - Cartão Titanium");
                console = Console.ReadLine();
          

            if (console =="1" || console == "2" || console == "3" +
                "" )
            {
                switch (console)
                {
                    case "1":
                        cartaoFactory = new BlackFactory(50000, 0);
                        break;

                    case "2":
                        cartaoFactory = new PlatinumFactory(10000, 100);
                        break;

                    case "3":
                        cartaoFactory = new TitaniumFactory(150000, 150);
                        break;

                    default:
                        break;
                }

                CartaoCredito cartaoCredito = cartaoFactory.BuscarCartaoCredito();
                    Console.WriteLine("\nISTO É APENAS UM TESTE\n");
                    Console.WriteLine("\nObrigado por escolher o seu cartão");
                Console.WriteLine("\nSegue a baixo os detalhes do seu cartão:\n");
                Console.WriteLine("Tipo do cartão:{0}\nCrédito Limite:{1}\nCobrança Anual:{2}",
                cartaoCredito.TipoCartao, cartaoCredito.LimiteCredito, cartaoCredito.CobrancaAnual);
                    Console.WriteLine("\nDeseja continuar? S/N\n");
                    x = Console.ReadLine().ToUpper();
                }
            else
            {  Console.WriteLine("\nISTO É APENAS UM TESTE\n");
                Console.WriteLine("\nNúmero inválido\n");
                Console.WriteLine("\nDeseja continuar? S/N\n");
                x = Console.ReadLine().ToUpper();
                Console.WriteLine("\nISTO É APENAS UM TESTE\n");

            }
            }
            while ( x == "S" || x == "SIM");

            Console.ReadKey();

        }
    }
}
