<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="Practical_4_i__lab_exercise.Add" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
        <span class="auto-style2"><strong>Add New Customer</strong></span><br />
        <br />
        Please enter the following information:<br />
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
    
        <asp:Button ID="btnAdd" runat="server" Text="Add" Width="83px" OnClick="btnAdd_Click" />
&nbsp;
        <asp:Button ID="btnReset" runat="server" Text="Reset" Width="88px" OnClick="btnReset_Click" />
    

        <br />
        <br />
        <asp:Label ID="lblMsg" runat="server"></asp:Label>
    

    </asp:Content>
