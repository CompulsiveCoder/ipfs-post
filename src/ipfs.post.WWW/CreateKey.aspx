<%@ Page Language="C#" Inherits="ipfs.post.WWW.CreateKey" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>GetKey</title>
</head>
<body>
	<form id="form1" runat="server">
		<asp:Button runat="server" Text="Create Keys" id="CreateKeyButton" OnClick="CreateKeyButton_Clicked" />
		<p>
		Ipfs key: <%= Keys.IpfsKey %><br/>
		Device key: <%= Keys.DeviceKey %><br/>
		Private key: <%= Keys.PrivateKey %><br/>
		</p>
	</form>
</body>
</html>

