<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroJogador.aspx.cs" Inherits="CopaFifa.CadastroJogador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Id<br />
            <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
            <br />
            <br />

            Nome<br />
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            <br />
            <br />

            Data de Nascimento<br />
            <asp:TextBox ID="txtDataNascimento" runat="server"></asp:TextBox>
            <br />
            <br />

            Numero da Camisa<br />
            <asp:TextBox ID="txtNumeroCamisa" runat="server"></asp:TextBox>
            <br />
            <br />

            Posição<br />
            <asp:TextBox ID="txtPosicao" runat="server"></asp:TextBox>
            <br />
            <br />

            Convocação<br />
            <asp:TextBox ID="txtDataConvocacao" runat="server"></asp:TextBox>
            <br />
            <br />

            Data da Dispensa<br />
            <asp:TextBox ID="txtDataDispensa" runat="server"></asp:TextBox>
            <br />
            <br />

            <asp:Label ID="lblMensagem" runat="server"></asp:Label>
            <br />

            <asp:Button ID="btnExibirDados" runat="server" Text="Exibir Dados" OnClick="btnExibirDados_Click" />
            <br />
            <br />

            <asp:Button ID="btnCalcularIdade" runat="server" Text="Calcular Idade" OnClick="btnCalcularIdade_Click" />
            <br />
            <br />
            <asp:Button ID="btnCalcularIndenizacaoFifa" runat="server" Text="Calcular Indenização." OnClick="btnCalcularIndenizacaoFifa_Click"/>
            <br />
            <br />
            <asp:Button ID="btnExibirD" runat="server" Text="Exibir Dias" OnClick="btnExibirD_Click" />



        </div>
    </form>
</body>
</html>
