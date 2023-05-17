<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="P01NewASPNetWebApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
		<h1>Welcome to My ASP.NET Web Application</h1>
		<p>This is a simple web application built using ASP.NET.</p>
		<asp:TextBox ID="txtNumber1" runat="server"></asp:TextBox>
		<asp:TextBox ID="txtNumber2" runat="server"></asp:TextBox>
		<br />
		<asp:Button ID="Calculate" OnClick="btnCalculate_Click" Text="Calculate" runat="server" />
		<br />
		<asp:Label ID="lblResult" Text="Your result will be visible here :)" runat="server" />


	</form>
</body>


</html>
