using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Financeira_Aula07
{
    public class ContratoPessoaFisica : Contrato
    {
        public string CPF { get; set; }
        public DateTime dataNasc { get; set; }

        public int Idade()
        {
            int idade = DateTime.Now.Year - dataNasc.Year;

            if (DateTime.Now.DayOfYear < dataNasc.DayOfYear)
            {
                idade = (DateTime.Now.Year - dataNasc.Year) - 1;
            }
            return idade;
        }

        public override decimal CalculoPrestacao(decimal valor, int prazo)
        {
            switch (Idade())
            {
                case <= 30:
                    return base.CalculoPrestacao(valor, prazo) + 1;
                    break;

                case <= 40:
                    return base.CalculoPrestacao(valor, prazo) + 2;
                    break;

                case <= 50:
                    return base.CalculoPrestacao(valor, prazo) + 3;
                    break;

                default:
                    return base.CalculoPrestacao(valor, prazo) + 4;
                    break;
            }
        }

        public override void ExibirInfo()
        {
            Console.WriteLine("=-=-=Imprimindo Contrato Pessoa Fisica=-=-=");
            Console.WriteLine($"Código do contrato: {idContrato}");
            Console.WriteLine($"Contratante: {Contratante}");
            Console.WriteLine($"CPF:{Convert.ToUInt64(CPF):000\\.000\\.000\\-00}");
            Console.WriteLine($"IDADE DO CONTRATANTE -> {Idade()} ANOS.");
            base.ExibirInfo();
        }
    }
}
