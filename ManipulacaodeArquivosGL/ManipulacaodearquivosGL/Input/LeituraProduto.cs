using System;
using System.Globalization;
using System.Text.RegularExpressions; //não está colocado. 

namespace ManipulacaodearquivosGL.Input
{
    public class LeituraProduto
    {  
        public int LerCodigoProduto()
        {
            try
            {
                Console.Write("Informe o código do Produto:");

                int codigoproduto = int.Parse(Console.ReadLine());

                if(codigoproduto > 0)
                {
                    return codigoproduto;
                }
                else
                {
                    throw new Exception("Codigo do Produto é invalido");
                }             
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalido...." + e.Message);
                return LerCodigoProduto();
            }
        }

        public string LerNomeProduto()
        {
            try
            {
                Console.Write("Informe o nome do produto:");

                string nomeProduto = Console.ReadLine();

                return nomeProduto;

            }
            catch (Exception e)
            {
                Console.WriteLine("Nome Invalido..." + e.Message);
                return LerNomeProduto();
            }
        }

        public double LerPreco()
        {
            try
            {
                Console.Write("Informe o preço do produto R$ ");

                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(preco > 0 && preco <= 10000)
                {
                    return preco;
                }
                else
                {
                    throw new Exception("PreenchimentoInvalido");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalido.." + e.Message);
                return LerPreco();
            }
        }
    }
}
