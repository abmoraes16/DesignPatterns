using System;
using Xunit;

namespace Exemplos.Builder.Criptografia
{
    public class CriptografiaTest
    {
        [Theory]
        [InlineData("teste Cifra de Cesar descriptografado")]
        public void DescriptografarCesar(string texto){
            CriptografiaCreator creator = new CriptografiaCreator(new CesarCriptografiaBuilder());
            Assert.Equal(creator.descriptografar("teste").ToConvertidoString(),texto);
        }

        [Theory]
        [InlineData("teste Fibonacci descriptografado")]
        public void DescriptografarFibonacci(string texto){
            CriptografiaCreator creator = new CriptografiaCreator(new FibonacciCriptografiaBuilder());
            Assert.Equal(creator.descriptografar("teste").ToConvertidoString(),texto);
        }
    }
}
