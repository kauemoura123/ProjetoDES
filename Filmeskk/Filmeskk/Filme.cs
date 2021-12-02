using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmeskk
{
    class Filme
    {
        private string nomeFilme;
        private string nomeDiretor;
        private string genero;
        private string idioma;
        private string classificacao;

        public void cadastrarFilme()
        {
            Console.WriteLine("Digite o nome do Filme:");
            nomeFilme = Console.ReadLine();
            Console.WriteLine("Digite o nome do Diretor");
            nomeDiretor = Console.ReadLine();
            Console.WriteLine("Digite o genero");
            genero = Console.ReadLine();
            Console.WriteLine("Digite o idioma");
            idioma = Console.ReadLine();
            Console.WriteLine("Digite a classificacao");
            classificacao = Console.ReadLine();
        }


        public void mostraCompra()
        {
            Console.WriteLine("--- Cadastro da Compra ---");
            Console.WriteLine("Filme:{0}", nomeFilme);
            Console.WriteLine("Diretor:{0}", nomeDiretor);
            Console.WriteLine("genero:{0}", genero);
            Console.WriteLine("idioma:{0}", idioma);
            Console.WriteLine("classificacao:{0}", classificacao);
        }


        public string nomeCliente()
        {
            return nomeFilme;
        }
    }
}
