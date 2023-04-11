using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente
{
    internal class Conta
    {
        public int numero { get; set; }
        public decimal saldo { get; set; }
        public decimal limite { get; set; }
        public bool ehEspecial { get; set; }
        public Movimentacao[] movimentacoes;

        public decimal Sacar(decimal sacar)
        {
            Movimentacao movimentacao = new Movimentacao();

            int posicaoVazia = PegaPosicaoVazia();

            movimentacoes[posicaoVazia] = movimentacao;

            return saldo = saldo - sacar;
        }

        public decimal Depositar(decimal depositar)
        {
            Movimentacao movimentacao = new Movimentacao();

            int posicaoVazia = PegaPosicaoVazia();

            movimentacoes[posicaoVazia] = movimentacao;

            return saldo += depositar;
        }

        public void ExibirExtrato()
        {
            Console.WriteLine($"Extrato - Saldo: {saldo}");
        }


        public decimal TransferirPara(Conta conta, decimal deposito)
        {
            Sacar(deposito);

            decimal valorDepositado = conta.Depositar(deposito);

            return valorDepositado;
        }

        public int PegaPosicaoVazia()
        {
            for (int i = 0; i < movimentacoes.Length; i++)
            {
                if (movimentacoes[i] == null)
                    return i;
            }

            return -1;
        }
    }
}
