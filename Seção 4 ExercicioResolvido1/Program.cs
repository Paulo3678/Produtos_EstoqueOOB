using System;
using System.Globalization;    

namespace Seção_4_ExercicioResolvido1
{
    class Program
    {
        static void Main(string[] args)
        {
            Produtos x;
            x = new Produtos();


            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            x.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            x.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Dados do produto: " + x);

            Console.WriteLine();

            Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            x.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + x);

            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            int remover = int.Parse(Console.ReadLine());
            x.RemoverProdutos(remover);

            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + x);

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
