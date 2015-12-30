<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Library.aspx.cs" Inherits="Library.Library" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Library<br />
        <br />
        Code:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        Title:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        Editor:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        Audience:
        <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem>Children</asp:ListItem>
            <asp:ListItem>Teens</asp:ListItem>
            <asp:ListItem Selected="True">Adults</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        Category:<asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Science</asp:ListItem>
            <asp:ListItem>History</asp:ListItem>
            <asp:ListItem>Fiction</asp:ListItem>
            <asp:ListItem>Judaism</asp:ListItem>
            <asp:ListItem>Romance</asp:ListItem>
            <asp:ListItem>Other</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        Copies:<asp:TextBox ID="TextBox4" runat="server" TextMode="Number"></asp:TextBox>
        <br />
        <br />
        Active:<asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
            <asp:ListItem Selected="True">Active</asp:ListItem>
            <asp:ListItem>Inactive</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
