<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="Practical_4_i__lab_exercise.Delete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
        <span class="auto-style1"><strong>Delete Customer</strong></span><br />
        <br />
        Customer ID&nbsp; :<asp:TextBox ID="txtID" runat="server" Width="149px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" Width="85px" OnClick="btnDelete_Click" />
&nbsp;
        <asp:Button ID="btnReset" runat="server" Text="Reset" Width="86px" OnClick="btnReset_Click" />
    
        <br />
        <br />
        <br />
        <asp:Label ID="lblMsg" runat="server"></asp:Label>
        <br />
    
</asp:Content>
