using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Financeira_Aula07
{
    internal class Validacoes
    {

        public static string ValidaOpcao()
        {
            string escolhaCadastro;

            do
            {
                escolhaCadastro = Console.ReadLine().Trim();
                if (String.IsNullOrWhiteSpace(escolhaCadastro) || (escolhaCadastro != "1") && (escolhaCadastro != "2"))
                {

                    Console.WriteLine("Por favor insira um valor válido '1 ou 2'");
                }
            } while (String.IsNullOrWhiteSpace(escolhaCadastro) || (escolhaCadastro != "1") && (escolhaCadastro != "2"));
            return escolhaCadastro;
        }

        public static string EntradaVazia()
        {
            string EntradaUsuario;
            do
            {
                EntradaUsuario = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(EntradaUsuario))
                {
                    Console.WriteLine("Campo não pode estar em branco! Por favor preencha conforme solicitado.");
                }
            } while (String.IsNullOrWhiteSpace(EntradaUsuario));
            return EntradaUsuario;
        }

        public static decimal ValidaValor()
        {
            decimal valorContrato = 0m;
            bool entrada = false;

            while (!entrada)
            {
                entrada = (decimal.TryParse(Console.ReadLine(), out valorContrato) && valorContrato > 0);

                if (!entrada)
                {
                    Console.WriteLine("Valor inválido! Por favor tente novamente..");
                    break;
                }
                else
                {
                    break;
                }
            }
            return valorContrato;

        }

        public static decimal ValidaPrazo()
        {
            int valorPrazo = 0;
            bool entrada = false;

            while (!entrada)
            {
                entrada = (int.TryParse(Console.ReadLine(), out valorPrazo) && valorPrazo > 0);

                if (!entrada)
                {
                    Console.WriteLine("Valor inválido! Por favor tente novamente..");
                    break;
                }
                else
                {
                    break;
                }
            }
            return valorPrazo;

        }

        public static string ValidaCPF()
        {
            string cpf;
            do
            {
                cpf = Console.ReadLine();
                if (((string.IsNullOrEmpty(cpf)) || cpf.Length != 11))
                {
                    Console.WriteLine("CPF em branco ou com a quantidade de dígitos incorretas! Por favor tente novamente e preencha conforme solicitado");
                }
            }
            while ((string.IsNullOrEmpty(cpf)) || cpf.Length != 11);
            return cpf;
        }

        public static string ValidaCNPJ()
        {
            string cnpj;
            do
            {
                cnpj = Console.ReadLine();
                if (((string.IsNullOrEmpty(cnpj)) || cnpj.Length != 14))
                {
                    Console.WriteLine("CNPJ em branco ou com a quantidade de dígitos incorretas! Por favor tente novamente e preencha conforme solicitado");
                }
            } while (((string.IsNullOrEmpty(cnpj)) || cnpj.Length != 14));

            return cnpj;
        }

        public static string ValidaInscricaoEstadual()
        {
            string ie;
            do
            {
                ie = Console.ReadLine();
                if (((string.IsNullOrEmpty(ie)) || ie.Length != 9))
                {
                    Console.WriteLine("Inscrição Estadual em branco ou com a quantidade de dígitos incorretas! Por favor tente novamente e preencha conforme solicitado");
                }

            } while (((string.IsNullOrEmpty(ie)) || ie.Length != 9));
            return ie;
        }

        public static DateTime ValidaData()
        {
            var data = DateTime.MinValue;

            var validacao = false;

            while (!validacao)
            {
                validacao = DateTime.TryParse(Console.ReadLine(), out data) && data <= DateTime.Now;
                if (!validacao)
                {
                    Console.WriteLine("Data inválida ou vazia, por favor tente novamente...");
                }

            }
            return data;
        }
    }
}
