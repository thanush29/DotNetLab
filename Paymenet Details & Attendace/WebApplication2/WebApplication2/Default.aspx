<%@ Page Title="Attendance Percentage" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2><strong>Attendance Percentage</strong></h2>
    
    <div>
        <p>
            Name: <asp:TextBox ID="name" runat="server" Placeholder="Enter Name"></asp:TextBox>
        </p>
        <p>
            Reg. No: <asp:TextBox ID="regno" runat="server" Placeholder="Enter Registration Number"></asp:TextBox>
        </p>
        <p>
            Total Classes: <asp:TextBox ID="total" runat="server" Placeholder="Enter Total Classes"></asp:TextBox>
        </p>
        <p>
            Present: <asp:TextBox ID="present" runat="server" Placeholder="Enter Number of Classes Attended"></asp:TextBox>
        </p>
        <p>
            Absent: <asp:TextBox ID="absent" runat="server" ReadOnly="True"></asp:TextBox>
        </p>
        <p>
            Attendance Percentage: <asp:TextBox ID="percentage" runat="server" ReadOnly="True"></asp:TextBox>
        </p>
        <p>
            Fine: <asp:TextBox ID="fine" runat="server" ReadOnly="True"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Calculate Percentage" OnClick="Button1_Click" />
        </p>
    </div>

</asp:Content>
