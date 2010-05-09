<%@ Page Title="" Language="C#" MasterPageFile="~/Edit.Master" AutoEventWireup="true" CodeBehind="MakeAppointment.aspx.cs" Inherits="MyApp.Actions.MakeAppointment" %>
<asp:Content ContentPlaceHolderID="Content" runat="server">
<h2>Making an appointment</h2>

<p>
    <%= this.LabelFor(x => x.Appointment.Patient) %>
    <br />
    <%= this.InputFor(x => x.Appointment.Patient) %>
</p>

<p>
    <%= this.LabelFor(x => x.Appointment.CoverageDate)%>
    <br />
    <%= this.InputFor(x => x.Appointment.CoverageDate)%>
</p>

<p>
    <%= this.LabelFor(x => x.Appointment.Physician) %>
    <br />
    <%= this.InputFor(x => x.Appointment.Physician) %>
</p>

<p>
    <%= this.LabelFor(x => x.Appointment.StartTime) %>
    <br />
    <%= this.InputFor(x => x.Appointment.StartTime) %>
</p>

<p>
    <%= this.LabelFor(x => x.Appointment.EndTime) %>
    <br />
    <%= this.InputFor(x => x.Appointment.EndTime) %>
</p>

</asp:Content>
