<%@ Page Title="" Language="C#" MasterPageFile="~/TemplateLogin.Master" AutoEventWireup="true" CodeBehind="MainLogin.aspx.cs" Inherits="PayMeCard.MainLogin" %>

<asp:Content runat="server" ContentPlaceHolderID="content" ID="content1">

    <div class="body"></div>
    <div class="grad"></div>
    <div class="header">
        <div>PAYME<span>_0.0.1</span></div>
    </div>
    <br>
    <div class="login">
        <input type="text" placeholder="username" name="user"><br>
        <input type="password" placeholder="password" name="password"><br>
        <input type="button" value="Login">
    </div>
</asp:Content>
