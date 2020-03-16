using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CopaFifa
{
    public partial class CadastroJogador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            

        }

        protected void btnExibirDados_Click(object sender, EventArgs e)
        {
            Jogador j = new Jogador();
            j.Id = Convert.ToInt32(txtId.Text);
            j.NmNome = txtNome.Text;
            j.NmPosicao = txtPosicao.Text;
            j.DtNascimento = Convert.ToDateTime(txtDataNascimento.Text);
            j.NrCamisa = Convert.ToInt32(txtNumeroCamisa.Text);
            j.DtConvocacao = Convert.ToDateTime(txtDataConvocacao.Text);
            j.DtDispensa = Convert.ToDateTime(txtDataDispensa.Text);

            lblMensagem.Text = j.ObterDados();

        }

        protected void btnCalcularIdade_Click(object sender, EventArgs e)
        {
            Jogador j = new Jogador();
            j.DtNascimento = Convert.ToDateTime(txtDataNascimento);

            lblMensagem.Text = j.CalcularIdade().ToString();
        }

        protected void btnCalcularIndenizacaoFifa_Click(object sender, EventArgs e)
        {
            Jogador j = new Jogador();
            lblMensagem.Text = j.CalcularIndenizacaoFifa().ToString();


        }

        protected void btnExibirD_Click(object sender, EventArgs e)
        {
            Jogador j = new Jogador();
            lblMensagem.Text = j.ExibirDias().ToString();

        }
    }
}