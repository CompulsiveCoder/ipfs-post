<%@ Page Language="C#" Inherits="ipfs.post.WWW.Echo" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>ipfs-echo - Echo</title>
	<link rel="stylesheet" type="text/css" href="styles.css">
</head>
<body>
	<form id="form1" runat="server">
		<h1>ipfs-echo</h1>
		<% if (DidPublish){ %>
		<div>The provided text has been published to ipfs.</div>
		<div>Text: <%= TextData %></div>
		<div>File name: <%= FileName %></div>
		<div>Ipfs key: <%= FolderName %></div>
		<div>Device key: <%= DeviceKey %></div>
		<div>&nbsp;</div>
		<div>You can access the data via the following links:</div>
		<div><a href='<%= LocalUrl %>'><%= LocalUrl %></a></div>
		<div><a href='<%= IpfsUrl %>'><%= IpfsUrl %></a></div>
		<div>Note: because of the way ipfs works it can take some time for data to move through the system, so be patient. If your data doesn't show up straight away you can just hit refresh every few seconds and it should show up.</div>

		<div>&nbsp;</div>
		<div>Post data using the following link:</div>
		<div><a href='<%= PostUrl %>'><%= PostUrl %></a></div>
		<div>Try it out by opening the link above in the browser. Every time the page loads it should add that text to the ipfs based files.</div>
		<div><a href="Default.aspx">&laquo; back to form</a></div>
		<% } else { %>
		<div>Invalid arguments. Publish aborted.</div>
		<% } %>
	</form>
</body>
</html>

