<%@ Page Language="C#" Inherits="ipfs.post.WWW.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>ipfs-echo</title>
	<link rel="stylesheet" type="text/css" href="styles.css">
</head>
<body>
	<form id="form1" runat="server">
		<h1>ipfs-echo</h1>
		<div>To publish text data to ipfs; enter the text, the name/key/id of the device, and click submit.</div>
		<div>Ipfs key: <asp:TextBox runat="server" id="Folder"/></div>
		<div>Device key: <asp:TextBox runat="server" id="DeviceKey"/></div>
		<div>Text: <asp:TextBox runat="server" id="TextData"/></div>
		<div>File name: <asp:TextBox runat="server" id="File"/></div>
		<div>Overwrite: <asp:CheckBox runat="server" id="Overwrite"/> (leave unchecked to append)</div>
		<div><asp:Button runat="server" id="GoButton" OnClick="GoButton_Click" Text="Submit" /></div>

		<div><a href="CreateKey.aspx" target="_blank">Create Key</a></div>
	</form>
</body>
</html>

