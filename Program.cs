using System;
namespace Atividade{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Digite o nome do cliente: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o endereço do cliente: ");
            string endereco = Console.ReadLine();
            Console.WriteLine("Digite o valor: ");
            float valor = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Pessoa Fisica ou Juridica? (F/J)");
            string op = Console.ReadLine();

            if(op == "F"){
                PessoaFisica pf = new PessoaFisica();
                pf.nome = nome;
                pf.endereco = endereco;
                pf.Pagar_Imposto(valor);

                Console.WriteLine("Digite o CPF: ");
                pf.cpf = Console.ReadLine();
                Console.WriteLine("Digite o RG: ");
                pf.rg = Console.ReadLine();
                
                Console.WriteLine("Nome: {0}", pf.nome);
                Console.WriteLine("Endereço: {0}", pf.endereco);
                Console.WriteLine("CPF: {0}", pf.cpf);
                Console.WriteLine("RG: {0}", pf.rg);
                Console.WriteLine("Valor: {0}", pf.valor);
                Console.WriteLine("Valor do Imposto: {0}", pf.valor_imposto);
                Console.WriteLine("Valor Total: {0}", pf.total);
            }
            else{
                PessoaJuridica pj = new PessoaJuridica();
                pj.nome = nome;
                pj.endereco = endereco;
                pj.Pagar_Imposto(valor);
                

                Console.WriteLine("Digite o CNPJ: ");
                pj.cnpj = Console.ReadLine();
                Console.WriteLine("Digite a Inscrição Estadual: ");
                pj.inscricao_estadual = Console.ReadLine();

                Console.WriteLine("Nome: {0}", pj.nome);
                Console.WriteLine("Endereço: {0}", pj.endereco);
                Console.WriteLine("CNPJ: {0}", pj.cnpj);
                Console.WriteLine("Inscrição Estadual: {0}", pj.inscricao_estadual);
                Console.WriteLine("Valor: {0}", pj.valor);
                Console.WriteLine("Valor do Imposto: {0}", pj.valor_imposto);
                Console.WriteLine("Valor Total: {0}", pj.total);
            }
        }
    }
}