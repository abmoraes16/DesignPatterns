using System;

namespace Exemplo.DocumentoFiscal.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            NotaFiscal nota = new NotaFiscalBuilder()
                       .setCnpj("111.111.111/0001-11")
                       .setProduto(new Produto("Mesa 6 cadeiras", 1000.0))
                       .setObservacao("Deixar na Administração")
                       .setData(DateTime.Parse("2020-11-01"))
                       .build();

            nota.print();
        }
    }
}
