using ManipulacaodearquivosGL.Input;
using ManipulacaodearquivosGL.Model;
using System;
using System.IO;

namespace ManipulacaodearquivosGL.Data
{
    class arquivo
    {
        #region GravarProdutoExcel
        public void GravarProdutoExcel(Product produto)
        {
            try
            {
                //se quiser altere a extensão do arquivo. 
                var streamWriter = new StreamWriter("C:\\Users\\Andre\\source\\repos\\ArquivosTestes\\Vendas.CSV",true);
                streamWriter.WriteLine(produto.CodigoProduto + " ; " +produto.NomeProduto + " ; " + produto.PrecoProduto);
                streamWriter.Close();

                Console.WriteLine("Produto Gravado com Sucesso !");       
            }
            catch (Exception e)
            {

                throw new Exception("Error....:" + e.Message);
            }
        }
        #endregion

        public void GravarArquivoXml(Product produto)
        {
            try
            {             
                var xml = System.Xml.XmlWriter.Create("C:\\Users\\Andre\\source\\repos\\ArquivosTestes\\vendas.xml");

                xml.WriteStartDocument();
                xml.WriteStartElement("produto");
                xml.WriteElementString("codigo", produto.CodigoProduto.ToString());
                xml.WriteElementString("nome", produto.NomeProduto);
                xml.WriteElementString("preco", produto.PrecoProduto.ToString());
                xml.WriteEndElement();
                xml.WriteEndDocument();
                xml.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error..:" + e.Message);
            }
        }
    }
}
