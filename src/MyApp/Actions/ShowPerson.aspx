<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShowPerson.aspx.cs" Inherits="MyApp.Actions.ShowPerson" %>
<%@ Import Namespace="FubuMVC.UI" %>
<asp:Content ContentPlaceHolderID="Content" runat="server">
<h2>Showing a person</h2>
<dl>
<dt><%= this.LabelFor(x => x.Person.Name) %></dt><dd><%= this.InputFor(x => x.Person.Name) %></dd>
<dt><%= this.LabelFor(x => x.Person.Birthday) %></dt><dd><%= this.InputFor(x => x.Person.Birthday) %></dd>
</dl>
</asp:Content>
