namespace Exemplo.DocumentoFiscal.Builder
{
    class Produto
    {
        private string Nome;
        private double Preco;

        public string GetDescricaoProduto(){
            return Nome+" de valor "+Preco;
        }

        public Produto(string _nome, double _preco)
        {
            this.Nome = _nome;
            this.Preco = _preco;
        }
    }
}