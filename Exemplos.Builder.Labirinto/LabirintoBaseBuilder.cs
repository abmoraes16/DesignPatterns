namespace Exemplos.Builder.Labirinto
{
  abstract class LabirintoBaseBuilder
  {

    public abstract void DefineArea();
    public abstract void ConstruirPortas();
    public abstract void ConstruirParedes();
    public abstract void ConstruirInimigos();
    public abstract Labirinto GetResult();
  }
}