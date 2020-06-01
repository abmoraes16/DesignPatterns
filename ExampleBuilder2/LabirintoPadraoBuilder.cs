namespace ExampleBuilder2
{
    class LabirintoPadraoBuilder : LabirintoBaseBuilder
    {
        private Labirinto _labirinto = new Labirinto();

        public override void DefineArea(){
            _labirinto.Area = 200;
        }
    
        public override void ConstruirPortas()
        {
            _labirinto.Portas = 8;
        }
    
        public override void ConstruirParedes()
        {
            _labirinto.Paredes = 30;
        }
    
        public override void ConstruirInimigos()
        {
            _labirinto.Inimigos = 10;
        }

        public override Labirinto GetResult()
        {
            return _labirinto;
        }
    }
}