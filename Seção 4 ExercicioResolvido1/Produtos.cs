using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Seção_4_ExercicioResolvido1
{
    class Produtos
    {

        public string Nome;
        public double Preco;
        public int Quantidade;


        public double ValorToralEmEstoque()
        {
            return Preco * Quantidade;

        }

        public void AdicionarProdutos(int quantidade)
        {

            Quantidade = Quantidade + quantidade;

        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade;


        }


        public override string ToString()
        {
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) +
            ", " + Quantidade + " unidades, Total: $ " 
            + ValorToralEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
