using System;
using System.Collections.Generic;

namespace Exemplo.DocumentoFiscal.Builder
{
    class NotaFiscalBuilder
    {
        private string Cnpj { get; set; }
        private List<Produto> Produtos { get; set; }
        private string Observacao { get; set; }
        private DateTime Data { get; set; }

        public NotaFiscalBuilder(){
            Produtos = new List<Produto>();
        }

        public NotaFiscalBuilder setCnpj(string _cnpj)
        {
            this.Cnpj = _cnpj;
            return this;
        }

        public NotaFiscalBuilder setProduto(Produto _produto)
        {
            this.Produtos.Add(_produto);
            return this;
        }

        public NotaFiscalBuilder setObservacao(string _observacao)
        {
            this.Observacao = _observacao;
            return this;
        }

        public NotaFiscalBuilder setData(DateTime data)
        {
            this.Data = data;
            return this;
        }

        public NotaFiscal build()
        {
            return new NotaFiscal(Cnpj,Produtos,Observacao,Data);
        }
    }
}