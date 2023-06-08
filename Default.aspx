<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Examen_final._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">Transportes America S.A</h1>
            <p>Ingreso de vehiculo</p>
        </section>
    <div class="row">
            <section class="col-md-4" aria-labelledby="hostingTitle">
                <p>
                    &nbsp;<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Text="Button" />
                </p>
            </section>
        </div>
    </main>

</asp:Content>
