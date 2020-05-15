namespace ExampleBuilder{
    public class FibonacciCriptografiaBuilder : CriptografiaBuilderBase{
        public FibonacciCriptografiaBuilder(){
            inicializaCriptografia();
            Criptografia.Nome = "Fibonacci";
            Criptografia.Tipo = "Normal";
        }

        public override void descriptografar(string texto)
        {
            //... PROCESSO PARA DESCRIPTOGRAFAR ...
            Criptografia.TextoDescriptografado = "texto: "+ texto +", de criptografia "+ Criptografia.Nome +" descriptografado"; 
        }

        public override string TextoDecifradoToString()
        {
            return base.Criptografia.TextoDescriptografado.ToString();
        }
    }
}