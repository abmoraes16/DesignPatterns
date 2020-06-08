namespace CriptografiaBuilder{
    public class CriptografiaCreator
    {
        private CriptografiaBuilderBase _criptografiaBuilderBase;
        public CriptografiaCreator(CriptografiaBuilderBase criptografiaBuilderBase){
            _criptografiaBuilderBase = criptografiaBuilderBase;
        }

        public CriptografiaCreator descriptografar(string texto){
            _criptografiaBuilderBase.descriptografar(texto);
            return this;
        }

        public string ToConvertidoString(){
            return _criptografiaBuilderBase.TextoDecifradoToString();
        }
    }
}