using System;
using ManipulacaodearquivosGL.Input;
using ManipulacaodearquivosGL.Model;
using System.Globalization;
using ManipulacaodearquivosGL.Data;


namespace ManipulacaodearquivosGL
{
    class Program
    {
        static void Main(string[] args)
        {
            //variavel para usar a classe produto
            //intanciação da classe produto
            var produto = new Product();
            //variavel para usar a classe leituradeproduto
            //intanciação da classe leitura de produto
            var leitura = new LeituraProduto();

            produto.CodigoProduto = leitura.LerCodigoProduto();
            produto.NomeProduto = leitura.LerNomeProduto();
            produto.PrecoProduto = (decimal)leitura.LerPreco();

            Console.WriteLine("\n Fofureces da Lili");
            Console.WriteLine(" Codigo do produto: " + produto.CodigoProduto);
            Console.WriteLine(" Nome do Produto: " + produto.NomeProduto);
            Console.WriteLine(" Preco do produto R$ " + produto.PrecoProduto.ToString("F2",CultureInfo.InvariantCulture));

            var arquivo = new arquivo();
            
            arquivo.GravarProdutoExcel(produto);
            arquivo.GravarArquivoXml(produto);

            Console.ReadKey();
        }
    }
}
