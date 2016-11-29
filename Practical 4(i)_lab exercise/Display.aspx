<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Display.aspx.cs" Inherits="Practical_4_i__lab_exercise.Display" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <strong><span class="auto-style2">Search Customer Information</span><br class="auto-style2" />
        </strong>
        <br />
        Customer Id:
        <asp:TextBox ID="txtID" runat="server" Width="140px"></asp:TextBox>
&nbsp;
        <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
        <br />
        <br />
        <br />
        <span class="auto-style2"><strong>Result:</strong></span><br />
        <br />
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">Company Name</td>
                <td>:<asp:TextBox ID="txtCompany" runat="server" Width="171px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Contact Name</td>
                <td>:<asp:TextBox ID="txtName" runat="server" Width="172px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Phone</td>
                <td>:<asp:TextBox ID="txtPhone" runat="server" Width="173px"></asp:TextBox>
                </td>
            </tr>
        </table>
</asp:Content>