namespace Exemplos.Builder.Labirinto
{
    class Director
    {
        public void Construir(LabirintoBaseBuilder builder)
        {
            builder.DefineArea();
            builder.ConstruirPortas();
            builder.ConstruirParedes();
            builder.ConstruirInimigos();
        }
    }
}