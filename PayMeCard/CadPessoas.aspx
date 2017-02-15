<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="CadPessoas.aspx.cs" Inherits="PayMeCard.CadPessoas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="server">
    <h1>Cadastro Pessoas</h1>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="heading" runat="server">
    <h3>Dados Iniciais</h3>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
    <div class="row">
        <div class="col-md-4">
            <div class="form-group">
                <asp:Label runat="server">Nome:</asp:Label>
                <asp:TextBox CssClass="form-control" runat="server" ID="txtName" />

            </div>
        </div>
        <div class="col-md-1">
            <div class="form-group">
                <asp:Label runat="server">idade:</asp:Label>
                <asp:TextBox CssClass="form-control" runat="server" ID="txtIdade" />
            </div>
        </div>
    </div>
    <div class="row">
         <div class="col-md-3">
            <div class="form-group">
                <asp:Label runat="server">Data Nascimento:</asp:Label>
                <asp:Calendar runat="server" ID="txtDate"  />
            </div>
        </div>
    </div>
    <div class="row">
         <div class="col-md-1">
            <div class="form-group">
                <asp:Button ID="btSalvar" runat="server" CssClass="btn btn-default" Text="salvar" OnClick="btSalvar_Click" />
            </div>
        </div>
    </div>
    
</asp:Content>
