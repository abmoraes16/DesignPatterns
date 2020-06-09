using System;
using System.Collections.Generic;

namespace Exemplo.DocumentoFiscal.Builder
{
    internal class NotaFiscal
    {
        private string Cnpj { get; set; }
        private List<Produto> Produtos { get; set; }
        private string Observacao { get; set; }
        private DateTime Data { get; set; }

        public NotaFiscal(string _cnpj, List<Produto> _produtos, string _observacao, DateTime _data){
            Cnpj = _cnpj;
            Produtos = _produtos;
            Observacao = _observacao;
            Data = _data;
        }

        public void print()
        {
            string descricaoProdutos = "";

            foreach(var produto in Produtos)
            {
                descricaoProdutos = String.Concat(descricaoProdutos, produto.GetDescricaoProduto());
            }

            Console.WriteLine("\nNota Fiscal:\n CNPJ: " +Cnpj+ 
                            "\nProdutos:\n "+descricaoProdutos+
                            "\nObservacao: " + Observacao+
                            "\nData:" +Data+"\n");
        }
    }
}