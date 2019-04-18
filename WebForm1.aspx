<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_415.NewFolder1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:RadioButtonList ID="rblProduct" runat="server"></asp:RadioButtonList>
            <asp:RadioButtonList ID="rblReviewer" runat="server"></asp:RadioButtonList>
            <asp:RadioButtonList ID="overall" runat="server"></asp:RadioButtonList>

            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
    <form id="form2" runat="server">
        <div>
            <asp:RadioButtonList ID="rblProduct2" runat="server"></asp:RadioButtonList>
            <asp:RadioButtonList ID="rblReviewer2" runat="server"></asp:RadioButtonList>
            <asp:RadioButtonList ID="overall2" runat="server"></asp:RadioButtonList>

            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
    <form id="form3" runat="server">
        <div>
            <asp:RadioButtonList ID="rblProduct3" runat="server"></asp:RadioButtonList>
            <asp:RadioButtonList ID="rblReviewer2" runat="server"></asp:RadioButtonList>
            <asp:RadioButtonList ID="overall3" runat="server"></asp:RadioButtonList>

            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
