<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>
<%@ PreviousPageType VirtualPath="~/Default.aspx" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Courses</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblDefault"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="text-align:right">Course:</td>
            <td>
                <asp:DropDownList ID="ddlCourse" runat="server" 
                    ToolTip="Select the Course you prefer">
                    <asp:ListItem Text="Pick a Course"></asp:ListItem>
                    <asp:ListItem Text="Jewish History"></asp:ListItem>
                    <asp:ListItem Text="MVC"></asp:ListItem>
                    <asp:ListItem Text="Are Crabs Really Immortal"></asp:ListItem>
                    <asp:ListItem Text="Terrorism"></asp:ListItem>
                    <asp:ListItem Text="Not Sure"></asp:ListItem>                    
                </asp:DropDownList>
            </td>
            <td>
                <asp:RequiredFieldValidator runat="server"
                    InitialValue="Pick a Course"
                    Text="Select a course or select Not Sure"
                    Display="Dynamic"
                    ControlToValidate="ddlCourse"
                    >
                </asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="text-align:right">I Speak Hebrew:</td>
            <td>
                <asp:CheckBox ID="cbHebrew" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnPrevious" runat="server" 
                    Text="Previous" 
                    Style="text-align:left"
                    PostBackUrl="Default.aspx" OnClick="btnPrevious_Click" />
                </td>
            <td></td>
            <td>
                <asp:Button ID="btnNext" runat="server" Text="Next" 
                    OnClick="btnNext_Click" 
                    Style="text-align:right" PostBackUrl="~/Default3.aspx"
                    />

            </td>
        </tr>
    </table>
            <p></p>
            <p>
            </p>
    </div>
    </form>
</body>
</html>
