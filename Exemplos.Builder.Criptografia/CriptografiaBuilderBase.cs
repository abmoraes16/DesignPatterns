namespace Exemplos.Builder.Criptografia{
    public abstract class CriptografiaBuilderBase{
        private Criptografia _criptografia;

        public Criptografia Criptografia
        {
            get {return _criptografia;}
        }

        public void inicializaCriptografia(){
            _criptografia = new Criptografia();
        }

        public abstract void descriptografar(string texto);  
        public abstract string TextoDecifradoToString();
    }
}