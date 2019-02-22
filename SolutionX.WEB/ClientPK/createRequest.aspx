<%@ Page Title="" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="createRequest.aspx.cs" Inherits="SolutionX.WEB.ClientPK.createRequest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-lg-12 label">

        <asp:Label ID="Label1" CssClass="h1 col-lg-12 text-center" lang="en" runat="server" Text="Create ticket"></asp:Label>
        <br />
        <asp:Label ID="Label2" CssClass="h3 col-lg-12" lang="en" runat="server" Text="Request detail:"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" lang="en" CssClass="form-control " runat="server"></asp:TextBox>
        <asp:Label ID="Label3" CssClass="h3 col-lg-12" runat="server" Text="Attached file:"></asp:Label>
        <input id="file" type="file" />
        <asp:Button ID="Button1" CssClass="btn-primary" runat="server" Text="Button" />
        <br>
    </div>    
                     
     
    
</asp:Content>
