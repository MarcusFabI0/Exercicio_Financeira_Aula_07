using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Financeira_Aula07
{
    public class Contrato
    {
        public Guid idContrato { get; set; } = Guid.NewGuid();
        public string Contratante { get; set; }
        public decimal Valor { get; set; }
        public int Prazo { get; set; }

        public virtual decimal CalculoPrestacao(decimal valor, int prazo)
        {
            return valor / prazo;
        }

        public virtual void ExibirInfo()
        {
            Console.WriteLine($"=-=-=-=INFORMAÇÕES DO CONTRATO=-=-=-=");
            Console.WriteLine($"VALOR DO CONTRATO -> R${Valor}");
            Console.WriteLine($"PRAZO DO CONTRATO -> {Prazo} meses");
            Console.WriteLine($"VALOR DA PRESTAÇÃO -> R${CalculoPrestacao(Valor,Prazo):N2}");
        }

    }
}