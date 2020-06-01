namespace ExampleBuilder2
{
  abstract class ILabirintoBuilder
  {
    public abstract void ConstruirPortas();
    public abstract void ConstruirParedes();
    public abstract void ConstruirInimigos();
    public abstract Labirinto GetResult();
  }
}