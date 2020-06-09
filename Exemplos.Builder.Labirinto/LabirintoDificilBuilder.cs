namespace Exemplos.Builder.Labirinto
{
    class LabirintoDificilBuilder : LabirintoBaseBuilder
    {
        private Labirinto _labirinto = new Labirinto();
    
        public override void DefineArea(){
            _labirinto.Area = 280;
        }
        
        public override void ConstruirPortas()
        {
            _labirinto.Portas = 14;
        }
    
        public override void ConstruirParedes()
        {
            _labirinto.Paredes = 50;
        }
    
        public override void ConstruirInimigos()
        {
            _labirinto.Inimigos = 21;
        }

        public override Labirinto GetResult()
        {
            return _labirinto;
        }
    }
}