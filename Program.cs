using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Financeira_Aula07
{
    public class Program
    {
        public static void Main(string[] args)
        {
            


            Console.WriteLine("Olá, tudo bem?");
            Console.WriteLine("Por favor, escolha o cadastro desejado:");
            Console.WriteLine("1 - Contrato Pessoa Juridica.\n2 - Contrato Pessoa Fisica");


            string escolhaCadastro = Validacoes.ValidaOpcao();

            if (escolhaCadastro == "1")
            {
                var contratoPJ = new ContratoPessoaJuridica();
                Console.WriteLine("Você escolheu Contrato Pessoa Juridica!");
                Console.WriteLine("Digite o nome do Contratante");
                contratoPJ.Contratante = Validacoes.EntradaVazia();
                Console.WriteLine("Digite o CNPJ da empresa (apenas números):");
                contratoPJ.CNPJ = Validacoes.ValidaCNPJ();
                Console.WriteLine("Digite a Inscrição Estadual da empresa (apenas números):");
                contratoPJ.inscEstadual = Validacoes.ValidaInscricaoEstadual();
                Console.WriteLine("Digite o valor do contrato em R$:");
                contratoPJ.Valor = Validacoes.ValidaValor();
                Console.WriteLine("Digite o prazo do contrato:");
                contratoPJ.Prazo = (int)Validacoes.ValidaPrazo();
                Console.Clear();

                contratoPJ.ExibirInfo();
              
            }

            else if (escolhaCadastro == "2")
            {
                var contratoPF = new ContratoPessoaFisica();
                Console.WriteLine("Você escolheu Contrato Pessoa Física!");
                Console.WriteLine("Digite o nome do Contratante");
                contratoPF.Contratante = Validacoes.EntradaVazia();
                Console.WriteLine("Digite o CPF do contratante (apenas números):");
                contratoPF.CPF = Validacoes.ValidaCPF();
                Console.WriteLine("Digite a data de nascimento no formato dia/mês/ano:");
                contratoPF.dataNasc = Validacoes.ValidaData();
                Console.WriteLine("Digite o valor do contrato em R$:");
                contratoPF.Valor = Validacoes.ValidaValor();
                Console.WriteLine("Digite o prazo do contrato:");
                contratoPF.Prazo = (int)Validacoes.ValidaPrazo();
                Console.Clear();

                
                contratoPF.ExibirInfo();
            }

        }


        
    } 
}
