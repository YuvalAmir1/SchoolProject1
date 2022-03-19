<%@ Page Title="" Language="C#" MasterPageFile="~/NavigationBar.Master" AutoEventWireup="true" CodeBehind="UserPage.aspx.cs" Inherits="SchoolProject1.Pages.UserPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        table {
            text-align: left;
            width: 100%
        }

        td, th {
            border-collapse: collapse;
            font-size: 86px;
        }

        tr:nth-child(even) {
            background-color: #97c0e6;
        }

        tr:nth-child(odd) {
            background-color: #d2e3f2;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <th>Username: </th>
            <td runat="server" id="Username"></td>
        </tr>
        <tr>
            <th>Password: </th>
            <td runat="server" id="Password"></td>
        </tr>
        <tr>
            <th>Admin? </th>
            <td runat="server" id="IsAdmin"></td>
        </tr>
    </table>
</asp:Content>