using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmeskk
{
    class Cliente
    {
        private string nome;
        private double cpf;
        private string endereco;
        private double telefone;
        private string email;

        public void cadastrarCliente()
        {
            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF");
            cpf = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o endereco");
            endereco = Console.ReadLine();
            Console.WriteLine("Digite o Telefone");
            telefone = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o email");
            email = Console.ReadLine();

        }

        public void mostrarCadastro()
        {
            Console.WriteLine("--- Cadastro ---");
            Console.WriteLine("Nome:{0}", nome);
            Console.WriteLine("CPF:{0}", cpf);
            Console.WriteLine("Endereco:{0}", endereco);
            Console.WriteLine("telefone:{0}", telefone);
            Console.WriteLine("email:{0}", email);
        }

        public string nomeCliente()
        {
            return nome;
        }


    }
}
