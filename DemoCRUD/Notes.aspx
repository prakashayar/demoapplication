<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Notes.aspx.cs" Inherits="DemoCRUD.Notes" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <script src="Scripts/Notes.js"></script>    
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <div class="row">

        <section class="table-responsive">
            <table class="table table-condensed">
                <tbody>
                    <tr>
                        <td colspan="2">
                            <h1><span id="spanUserName"></span> Notes</h1>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <table class="table table-condensed" style="overflow-y:auto">
                                <tbody id="viewnotes">
                                    <tr>
                                        
                                        <td>Prakash</td>
                                    </tr>                                    
                                    
                                </tbody>
                            </table>
                        </td>
                        <td>

                            <table class="table table-condensed">
                                <tr>
                                    <td>
                                        <button type="button" class="btn pull-right" onclick="insertnotes()"><i class="fa fa-plus-square"></i>Add Notes</button>
                                    </td>
                                </tr>
                                <tr>
                                    <td>

                                        <label for="lbltitle">Title :</label>

                                    </td>
                                </tr>
                                <tr>
                                    <td>

                                        <input type="text" id="txtnotetitle" required/>


                                    </td>
                                </tr>
                                <tr>
                                    <td>

                                        <label for="lblbody">Body :</label>

                                    </td>
                                </tr>
                                <tr>
                                    <td>

                                        <textarea id="txtnotebody" class="span10" rows="15" required></textarea>

                                    </td>
                                </tr>
                                <tr>
                                    <td>

                                        <button id="btnsave" type="button" class="btn pull-right" style="background-color:dodgerblue" onclick="updatenotes()" >Save</button>
                                        <input type="hidden" id="hdnnoteid" />
                                        <input type="hidden" id="hdnuserid" />
                                    </td>
                                </tr>
                            </table>


                        </td>
                    </tr>

                </tbody>
            </table>
        </section>


    </div>
</asp:Content>
