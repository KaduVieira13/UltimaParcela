using System;

namespace UltimaParcela
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime horaSistema = DateTime.Now;

            Console.WriteLine("--- Financiamento ---\n");
            Console.Write("Digite o valor do financiamento: ");
            decimal valor = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a quantidade de parcelas desejada: ");
            int parcelas = Convert.ToInt32(Console.ReadLine());

            DateTime vencimento = horaSistema.AddMonths(parcelas);
            TimeSpan parcelamento = horaSistema - vencimento;
            decimal parcelaMensal = valor / parcelas;

            Console.WriteLine($"Seu finciamento de {valor:C2} será parcelado em {parcelas}x. ");
            Console.WriteLine($"A data da última parcela é: {vencimento.Date}");
            Console.WriteLine($"O valor mensal de cada parcela é: {parcelaMensal:C2} ");


            
        }
    }
}
