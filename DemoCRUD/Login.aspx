<%@ Page Title="Login Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DemoCRUD.Login" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server" >
    <div class="row">
        <div class="col-md-12">
            <h1>Log In</h1>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            
        </div>
        <div class="col-md-4">
            <div class="row">
                <div class="col-25">
                    <label for="lblusername">Username</label>
                </div>
                <div class="col-75">                    
                    <asp:TextBox ID="txtUserName" runat="server" MaxLength="50"></asp:TextBox>*
                    <asp:RequiredFieldValidator ID="reqUserName" runat="server" ControlToValidate="txtUserName"
                         EnableClientScript="true"  Display="Dynamic" ErrorMessage="Please enter username" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="row">
                <div class="col-25">
                    <label for="lblpassword">Password</label>
                </div>
                <div class="col-75">                    
                    <asp:TextBox ID="txtPassword" runat="server" MaxLength="50" TextMode="Password" ></asp:TextBox>*
                    <asp:RequiredFieldValidator ID="reqPassword" runat="server" ControlToValidate="txtPassword"
                         EnableClientScript="true"  Display="Dynamic" ErrorMessage="Please enter password" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="row">
                <br />
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
            </div>
            <div class="row">
                <asp:Button ID="btnSumbit" runat="server" Text="Submit" OnClick="btnSumbit_Click" />
            </div>
        </div>

        <div class="col-md-4">
        </div>
    </div>
</asp:Content>
