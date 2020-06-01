namespace ExampleBuilder2
{
    class Director
    {
        public void Construir(LabirintoBaseBuilder builder)
        {
            builder.ConstruirPortas();
            builder.ConstruirParedes();
            builder.ConstruirInimigos();
        }
    }
}