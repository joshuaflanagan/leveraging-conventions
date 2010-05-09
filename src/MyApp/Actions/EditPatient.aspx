<%@ Page Title="" Language="C#" MasterPageFile="~/Edit.Master" AutoEventWireup="true" CodeBehind="EditPatient.aspx.cs" Inherits="MyApp.Actions.EditPatient" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Scripts" runat="server">
<script type="text/javascript">

    $(document).ready(function(){
        $(".date").datepicker();
    });

</script>
</asp:Content>

<asp:Content ContentPlaceHolderID="Content" runat="server">
<h2>Editing a patient</h2>
<p>
    <%= this.LabelFor(x => x.Patient.Name) %>
    <br />
    <%= this.InputFor(x => x.Patient.Name) %>
</p>

<p>
    <%= this.LabelFor(x => x.Patient.Birthday) %>
    <br />
    <%= this.InputFor(x => x.Patient.Birthday).AddClass("date") %>
</p>

<p>
    <%= this.LabelFor(x => x.Patient.Hometown) %>
    <br />
    <%= this.InputFor(x => x.Patient.Hometown) %>
</p>

<p>
    <%= this.LabelFor(x => x.Patient.Anniversary) %>
    <br />
    <%= this.InputFor(x => x.Patient.Anniversary).AddClass("date") %>
</p>
</asp:Content>