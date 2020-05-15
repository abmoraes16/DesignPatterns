using System;

namespace ExampleBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            CriptografiaCreator creator = new CriptografiaCreator(new CesarCriptografiaBuilder());
            creator.descriptografar("teste");
            Console.WriteLine(creator.TextoDecifradoToString());

            CriptografiaCreator creator2 = new CriptografiaCreator(new FibonacciCriptografiaBuilder());
            creator2.descriptografar("teste de fibonacci");
            Console.WriteLine(creator2.TextoDecifradoToString());
        }
    }
}
