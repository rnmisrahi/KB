<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%--<%@ PreviousPageType VirtualPath="~/Default2.aspx" %>--%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Web Forms - Wizard</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td style="text-align:right">ID:</td>
                    <td>
                        <asp:TextBox ID="txtId" runat="server" PlaceHolder="9-digit "></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="StudentIdValidator" runat="server"
                            ControlToValidate="txtId"
                            text="Required Field">
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1"
                                runat="server"
                                ControlToValidate="txtId"
                                text="Field requires 9 digit"
                                ValidationExpression="\d{9}">
                            </asp:RegularExpressionValidator>
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right">Name:</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server" PlaceHolder="Enter Name"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="NameValidator" runat="server"
                            ControlToValidate="txtName"
                            text="Name from 2 to 10 characters"
                            ValidationExpression=".{2,10}"
                            >

                        </asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right">Loves Girls:</td>
                    <td>
                        <asp:CheckBox ID="cbLovesGirls" runat="server" />
                    </td>
                    <td>
                    </td>
                </tr>
            </table>
            <p></p>
            <p>
                <asp:Button ID="btnNext" runat="server" Text="Next" 
                    OnClick="btnNext_Click"
                    PostBackUrl="Default2.aspx" />
            </p>
        </div>
    </form>
</body>
</html>
