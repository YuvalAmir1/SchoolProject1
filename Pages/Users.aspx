<%@ Page Title="" Language="C#" MasterPageFile="~/NavigationBar.Master" AutoEventWireup="true" CodeBehind="Users.aspx.cs" Inherits="SchoolProject1.Pages.Users" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<style>
		table {
			text-align: left;
			width: 100%
		}

		td, th {
			border-collapse: collapse;
			font-size: 75px;
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
	<div runat="server" id="TableData"></div>
</asp:Content>