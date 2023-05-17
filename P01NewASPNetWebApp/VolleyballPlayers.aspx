<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VolleyballPlayers.aspx.cs" Inherits="P01NewASPNetWebApp.VolleyballPlayers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
		<p>Some text:</p>
		<p><%Response.Write(SampleString); %></p>
		<p><% =SampleString %></p>


		<table>
			<tr>
				<th>ID</th>
				<th>First name</th>
				<th>Last name</th>
			</tr>
			<%
				foreach (var player in PlayerList)
				{
			%>
			<%
				}

			%>
		</table>
	</form>
</body>
</html>
