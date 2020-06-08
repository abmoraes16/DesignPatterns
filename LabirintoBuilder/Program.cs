using System;

namespace LabirintoBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
 
            LabirintoBaseBuilder builderPadrao = new LabirintoPadraoBuilder();
        
            director.Construir(builderPadrao);
            Labirinto labirintoFacil = builderPadrao.GetResult();
            labirintoFacil.Show();

            LabirintoBaseBuilder builderDificil = new LabirintoDificilBuilder();

            director.Construir(builderDificil);
            Labirinto labirintoDificil = builderDificil.GetResult();
            labirintoDificil.Show();
        }
    }
}
