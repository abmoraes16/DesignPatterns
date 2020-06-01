using System;

namespace ExampleBuilder2
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
 
            ILabirintoBuilder builderFacil = new LabirintoFacilBuilder();
        
            director.Construir(builderFacil);
            Labirinto labirintoFacil = builderFacil.GetResult();
            labirintoFacil.Show();

            ILabirintoBuilder builderDificil = new LabirintoDificilBuilder();

            director.Construir(builderDificil);
            Labirinto labirintoDificil = builderDificil.GetResult();
            labirintoDificil.Show();
        }
    }
}
