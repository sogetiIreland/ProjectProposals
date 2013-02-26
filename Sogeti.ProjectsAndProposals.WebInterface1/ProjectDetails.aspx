<%@ Page Title="Project Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProjectDetails.aspx.cs" Inherits="Sogeti.ProjectsAndProposals.WebInterface1.ProjectDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">

    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 75%;">
        <tr>
            <td>Project Name:</td>
            <td><asp:TextBox ID="tb_name" runat="server" Width="200px"></asp:TextBox></td>
            <td>Client:</td>
            <td><asp:DropDownList ID="cb_client" runat="server" DataTextField="clientName" DataValueField="clientID"></asp:DropDownList></td>
        </tr>
        <tr>
            <td>Description:</td>
            <td colspan="3"><asp:TextBox ID="tb_description" runat="server" Width="501px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Sogeti Practitioner:</td>
            <td><asp:DropDownList ID="cb_practitioner" runat="server" DataTextField="firstName" DataValueField="personID"></asp:DropDownList></td>
            <td>Account Manager:</td>
            <td><asp:DropDownList ID="cb_accountManager" runat="server" DataTextField="firstName" DataValueField="personID"></asp:DropDownList></td>
        </tr>
        <tr>
            <td>Delivery Manager:</td>
            <td><asp:DropDownList ID="cb_deliveryManager" runat="server" DataTextField="firstName" DataValueField="personID"></asp:DropDownList></td>
            <td>Administrator:</td>
            <td><asp:DropDownList ID="cb_administrator" runat="server" DataTextField="firstName" DataValueField="personID"></asp:DropDownList></td>
        </tr>
        <tr>
            <td>Start Date:</td>
            <td><asp:TextBox ID="startdate" runat="server"></asp:TextBox></td>
            <td>End Date:</td>
            <td><asp:TextBox ID="enddate" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Revised Date:</td>
            <td>[DATE PICKER CONTROL]</td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td><asp:Button ID="btn_LoadNext" runat="server" Text="Load Next" /></td>
            <td><asp:Button ID="btn_save" runat="server" Text="Save" /></td>
            <td><asp:Button ID="btn_cancel" runat="server" Text="Cancel" /></td>
            <td><asp:Button ID="btn_exit" runat="server" Text="Exit" /></td>
        </tr>

    </table>
   
</asp:Content>
