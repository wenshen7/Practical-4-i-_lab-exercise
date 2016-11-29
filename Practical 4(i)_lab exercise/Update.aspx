<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="Practical_4_i__lab_exercise.Update" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <span class="auto-style2"><strong>Edit Customer Detail</strong></span><br />
        <br />
        <table style="width:100%;">
            <tr>
                <td class="auto-style3">Customer ID</td>
                <td>:<asp:TextBox ID="txtID" runat="server" Width="171px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Contact Name</td>
                <td>:<asp:TextBox ID="txtName" runat="server" Width="172px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Phone</td>
                <td>:<asp:TextBox ID="txtPhone" runat="server" Width="173px"></asp:TextBox>
                </td>
            </tr>
        </table>
    
        <asp:Button ID="btnSave" runat="server" Text="Save" Width="86px" OnClick="btnSave_Click" />
&nbsp;
        <asp:Button ID="btnReset" runat="server" Text="Reset" Width="82px" OnClick="btnReset_Click" />

        <br />
        <br />
        <asp:Label ID="lblMsg" runat="server"></asp:Label>

 </asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style3 {
            height: 20px;
            width: 115px;
        }
    </style>
</asp:Content>
