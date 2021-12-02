using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmeskk
{
    class Compra
    {
        public double preco;
        public string nomeFilme;
        public DateTime dataCompra;
        public double quantidade;
        public string nomeCliente;

        public void cadastrarCompra()
        {
            dataCompra = DateTime.Now;
            Console.WriteLine(dataCompra.Date);
            Console.WriteLine("Digite o Nome do Filme:");
            nomeFilme = Console.ReadLine();
            Console.WriteLine("Digite o preco do Filme:");
            preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade:");
            quantidade = double.Parse(Console.ReadLine());
        }


        public void mostraCompra()
        {
            Console.WriteLine("--- Cadastro da Compra ---");
            Console.WriteLine("Filme:{0}", nomeFilme);
            Console.WriteLine("Preco:{0}", preco);
            Console.WriteLine("Data da Compra:{0}", dataCompra);
            Console.WriteLine("Quantidade:{0}", quantidade);
        }
    }
}
