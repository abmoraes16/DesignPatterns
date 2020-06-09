using System;

namespace Exemplos.Builder.Criptografia
{
    class Program
    {
        static void Main(string[] args)
        {
            CriptografiaCreator creator = new CriptografiaCreator(new CesarCriptografiaBuilder());
            Console.WriteLine(creator.descriptografar("teste").ToConvertidoString());

            CriptografiaCreator creator2 = new CriptografiaCreator(new FibonacciCriptografiaBuilder());
            Console.WriteLine(creator2.descriptografar("teste de fibonacci").ToConvertidoString());
        }
    }
}
