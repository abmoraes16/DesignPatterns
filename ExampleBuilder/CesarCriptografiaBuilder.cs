namespace ExampleBuilder{
    public class CesarCriptografiaBuilder : CriptografiaBuilderBase{
        public CesarCriptografiaBuilder(){
            inicializaCriptografia();
            Criptografia.Nome = "Cifra de Cesar";
            Criptografia.Tipo = "3 posições";
        }

        public override void descriptografar(string texto)
        {
            //... PROCESSO PARA DESCRIPTOGRAFAR ...
            Criptografia.TextoDescriptografado = texto + " " + Criptografia.Nome + " descriptografado"; 
        }

        public override string TextoDecifradoToString()
        {
            return base.Criptografia.TextoDescriptografado.ToString();
        }
    }
}