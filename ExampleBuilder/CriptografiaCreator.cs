namespace ExampleBuilder{
    public class CriptografiaCreator
    {
        private CriptografiaBuilderBase _criptografiaBuilderBase;
        public CriptografiaCreator(CriptografiaBuilderBase criptografiaBuilderBase){
            _criptografiaBuilderBase = criptografiaBuilderBase;
        }

        public void descriptografar(string texto){
            _criptografiaBuilderBase.descriptografar(texto);
        }

        public string TextoDecifradoToString(){
            return _criptografiaBuilderBase.TextoDecifradoToString();
        }
    }
}