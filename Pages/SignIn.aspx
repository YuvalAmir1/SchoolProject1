<%@ Page Title="" Language="C#" MasterPageFile="~/NavigationBar.Master" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="SchoolProject1.Pages.SignIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="font-size: 200%">
        <h2>Sign In:</h2>

        <label for="userName">User Name: </label>
        <input type="text" name="userName" style="line-height: 40px; font-size: 25px" />
        <br />
        <br />
        <label for="password">Password: </label>
        <input type="password" name="password" style="line-height: 40px; font-size: 25px" />
        <br />
        <br />
        <input type="submit" value="Confirm" style="width: 150px; height: 60px; font-size: 30px" />
        <div runat="server" id="message"></div>
    </div>
</asp:Content>
