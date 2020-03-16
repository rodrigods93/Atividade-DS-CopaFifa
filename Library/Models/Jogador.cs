using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Jogador
    {
        private int id;
        private string nmNome;
        private DateTime dtNascimento;
        private int nrCamisa;
        private string nmPosicao;
        private DateTime dtConvocacao;
        private DateTime dtDispensa;

        public int Id { get => id; set => id = value; } // get=pegar
        public string NmNome { get => nmNome; set => nmNome = value; }
        public DateTime DtNascimento { get => dtNascimento; set => dtNascimento = value; }
        public int NrCamisa { get => nrCamisa; set => nrCamisa = value; }
        public string NmPosicao { get => nmPosicao; set => nmPosicao = value; }
        public DateTime DtConvocacao { get => dtConvocacao; set => dtConvocacao = value; }
        public DateTime DtDispensa { get => dtDispensa; set => dtDispensa = value; }

        public string ObterDados()
        {
            string mensagemformatada =
                string.Format("Nome: {0} N°: {1}  Posição:{2}", nmNome, nrCamisa, nmPosicao);

            return mensagemformatada;

        }
        public int CalcularIdade()
        {
            return DateTime.Now.Subtract(DtNascimento).Days / 365;

        }

        public double CalcularIndenizacaoFifa()
        {
             int qtDias = (dtConvocacao.Subtract(dtConvocacao).Days / 365 - dtDispensa.Subtract(dtDispensa).Days / 365)+15;
             double indFifa= qtDias * 32914.71;
            string resultado = string.Format("Dias {0} , Valor Indenização {1}", qtDias, indFifa);
         
             return indFifa;

            //valor da multa por dia 32.914,71

        }

        public int ExibirDias()
        {
            int qtDias2 = dtConvocacao.Subtract(dtConvocacao).Days / 365 - dtDispensa.Subtract(dtDispensa).Days / 365;
            return qtDias2;

        }

    }
}
