<%@ Page Language="C#" Inherits="ipfs.post.WWW.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>ipfs-post</title>
	<link rel="stylesheet" type="text/css" href="styles.css">
</head>
<body>
	<form id="form1" runat="server">
		<h1>ipfs-echo</h1>
		<div>Enter your keys or create new ones. Then enter the data and filename. </div>

		<table style="border-collapse:collapse;">
		<tr>
		<td>
		</td>
		<td>
		<asp:Button runat="server" id="CreateKeyButton" OnClick="CreateKeyButton_Click" Text="Create Keys" /></td></tr>
		<tr>
		<td>Ipfs key:</td><td><asp:TextBox runat="server" id="Folder"/></td>
		</tr>
		<tr>
		<td>Device:</td><td><asp:TextBox runat="server" id="Device"/></td>
		</tr>
		<tr>
		<td>Text:</td><td><asp:TextBox runat="server" id="TextData" TextMode="MultiLine" Rows="2" width="400" /></td>
		</tr>
		<tr>
		<td>File name:</td><td><asp:TextBox runat="server" id="File" text="file.txt"/></td>
		</tr>
		<tr>
		<td>Overwrite:</td><td><asp:CheckBox runat="server" id="Overwrite"/> (leave unchecked to append)</td>
		</tr>
		</table>
		<div><asp:Button runat="server" id="GoButton" OnClick="GoButton_Click" Text="Submit" /></div>

		<div><a href="CreateKey.aspx" target="_blank">Create Key</a></div>
	</form>
</body>
</html>

