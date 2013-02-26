<%@ Page Title="Welcome" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProjectsAndProposalsWebFormApp._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
                <h2>Projects and Proposals MIS.</h2>
            </hgroup>
            <p>
                Welcome to Sogeti's Projects and Proposals MIS ASP.Net prototype.
            </p>
        </div>
    </section>
</asp:Content>

<asp:Content runat="server" ID="Content1" ContentPlaceHolderID="MainContent">
    <section style="vertical-align: middle"></section>
</asp:Content>