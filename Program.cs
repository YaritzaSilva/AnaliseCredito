using System;

namespace AnaliseCredito
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada1,entrada2, entrada3;
            double valor, parcelas, renda, porcent, vlpar;

            Console.WriteLine("--ANÁLISE DE CRÉDITO--");
            Console.Write("Digite o valor: R$ ");
            entrada1= Console.ReadLine();
            valor= Convert.ToDouble(entrada1);
            Console.Write("Quantidade de parcelas: ");
            entrada2= Console.ReadLine();
            parcelas= Convert.ToDouble(entrada2);
            Console.Write("Renda mensal: R$ ");
            entrada3= Console.ReadLine();
            renda= Convert.ToDouble(entrada3);
            Console.WriteLine("---------");

            porcent= (30* renda)/100;
            vlpar= valor/parcelas;

            if (vlpar>porcent)
            {
                Console.WriteLine("Empréstimo negado!");
            }

            else
            {
                Console.WriteLine("Empréstimo aprovado!");
            }

        }
    }
}
