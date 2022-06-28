using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Financeira_Aula07
{
    public class ContratoPessoaJuridica : Contrato
    {
        public string CNPJ { get; set; }
        public string inscEstadual { get; set; }

        public override decimal CalculoPrestacao(decimal valor, int prazo)
        {
            return base.CalculoPrestacao(valor, prazo) + 3;
        }

        public override void ExibirInfo()
        {
            Console.WriteLine("=-=-=Imprimindo Contrato Pessoa Juridica=-=-=");
            Console.WriteLine($"Código do contrato: {idContrato}");
            Console.WriteLine($"Contratante: {Contratante}");
            Console.WriteLine($"CNPJ:{Convert.ToUInt64(CNPJ).ToString(@"00\.000\.000\/0000\-00")}");
            Console.WriteLine($"Inscrição Estadual:{Convert.ToUInt64(inscEstadual).ToString(@"000\.000\.000\.000")}");
            base.ExibirInfo();
        }
    }
}
