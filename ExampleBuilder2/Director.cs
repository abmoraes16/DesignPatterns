namespace ExampleBuilder2
{
    class Director
    {
        public void Construir(ILabirintoBuilder builder)
        {
            builder.ConstruirPortas();
            builder.ConstruirParedes();
            builder.ConstruirInimigos();
        }
    }
}