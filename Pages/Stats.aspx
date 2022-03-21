<%@ Page Title="" Language="C#" MasterPageFile="~/NavigationBar.Master" AutoEventWireup="true" CodeBehind="Stats.aspx.cs" Inherits="SchoolProject1.Pages.Stats" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        table {
            text-align: left;
            width: 100%
        }

        td, th {
            border-collapse: collapse;
            font-size: 70px;
        }

        td {
            text-align: center;
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
            <td></td>
            <th style="width: 25%; text-align: center;">Current</th>
            <th style="width: 25%; text-align: center;">Total</th>
        </tr>
        <tr>
            <th>Visitors: </th>
            <td runat="server" id="CurrentVisitorsCount"></td>
            <td runat="server" id="TotalVisitorsCount"></td>
        </tr>
        <tr>
            <th>Logged in visitors: </th>
            <td runat="server" id="CurrentLoggedInCount"></td>
            <td runat="server" id="TotalLoggedInCount"></td>
        </tr>
        <tr>
            <th>Guests: </th>
            <td runat="server" id="CurrentGuestsCount"></td>
            <td runat="server" id="TotalGuestsCount"></td>
        </tr>
    </table>
</asp:Content>
