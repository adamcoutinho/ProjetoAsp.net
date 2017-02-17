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
                <asp:TextBox ID="txtValueDate" runat="server" CssClass="form-control" />                
            </div>           
        </div>
        <div class="col-md-9">
            <div class="form-group">
                <br />
                <asp:Button runat="server" ID="btnDate" OnClick="btnDate_Click" CssClass="btn btn-default" Text="data" />
            </div>
        </div>
    </div>    
    <div class="row">
        <div class="col-md-12">
            <div class="form-group">
                <asp:Calendar runat="server" ID="txtDate" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Visible="False" Width="350px" OnSelectionChanged="txtDate_SelectionChanged">
                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                    <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                    <TodayDayStyle BackColor="#CCCCCC" />
                </asp:Calendar>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-6">
            <div class="form-group">
                <asp:GridView ID="GridViewPessoa" CssClass="table table-bordered" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridViewPessoa_SelectedIndexChanged">
                </asp:GridView>
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
