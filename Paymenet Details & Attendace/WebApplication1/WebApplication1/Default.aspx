<%@ Page Title="Payment Details" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Payment Details Form
    </h2>

    <div>
        <label>Name: </label><asp:TextBox ID="TextBox1" runat="server" Placeholder="Enter Name"></asp:TextBox>
        <br /><br />
        <label>Quantity: </label><asp:TextBox ID="TextBox2" runat="server" Placeholder="Enter Quantity"></asp:TextBox>
        <br /><br />
        <label>Rate: </label><asp:TextBox ID="TextBox3" runat="server" Placeholder="Enter Rate"></asp:TextBox>
        <br /><br />
        <label>Gross Amount: </label><asp:TextBox ID="TextBox4" runat="server" ReadOnly="True"></asp:TextBox>
        <br /><br />
        <label>Discount: </label><asp:TextBox ID="TextBox5" runat="server" ReadOnly="True"></asp:TextBox>
        <br /><br />
        <label>Net Amount: </label><asp:TextBox ID="TextBox6" runat="server" ReadOnly="True"></asp:TextBox>
        <br /><br />
        <asp:Button ID="Button1" runat="server" Text="Calculate" OnClick="Button1_Click" />
    </div>
</asp:Content>
