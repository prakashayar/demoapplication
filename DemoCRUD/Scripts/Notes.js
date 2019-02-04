// This JS file created for Notes related client side operation

$(document).ready(function () {
    LoadNotes();
    $("#btnsave").prop("disabled", true);
});
// Load all notes by formating output
function LoadNotes() {
    $.ajax({
        type: "POST",
        url: "Notes.aspx/GetNotes",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: function (data) {
            $("#viewnotes").html("");
            var returnedstring = data.d;
            var jsondata = $.parseJSON(data.d);//if you want your data in json
            $("#hdnuserid").val(jsondata[0].Note_UserId);
            $("#spanUserName").html(jsondata[0].Note_UserName);
            for (var i = 0; i < jsondata.length; i++) {
                var htmlstring = '<tr>';
                htmlstring += '<td>';
                htmlstring += '<h4><div style="cursor:pointer;" onclick="getnotes(' + (jsondata[i].Note_Id) + ')">' + jsondata[i].Note_Title + '</h4>' + '<button type="button" class="btn pull-right" onclick="deletenote(' + jsondata[i].Note_Id + ')"><i class="fa fa-window-close"></i></button>';
                htmlstring += '<br />';
                htmlstring += '<h5>' + jsondata[i].Note_Body + '</h5>';
                htmlstring += '</td>';
                htmlstring += '</tr>';

                $("#viewnotes").append(htmlstring);
            }
        }
    });
}

// delete Ajax Call
function deletenote(id) {
    $.ajax({
        type: "POST",
        url: "Notes.aspx/DeleteNotes",
        data: "{'id': " + id + "}",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: function (data) {
            alert("Note has been deleted successfully.");
            LoadNotes();
        }
    });
}

// Get Note detail by Id and fill values in respective fields
function getnotes(id) {
    $.ajax({
        type: "POST",
        url: "Notes.aspx/GetNotesById",
        data: "{'id': " + id + "}",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: function (data) {
            var returnedstring = data.d;
            var jsondata = $.parseJSON(data.d);//if you want your data in json
            $("#txtnotetitle").val(jsondata.Note_Title);
            $("#txtnotebody").val(jsondata.Note_Body);
            $("#hdnnoteid").val(id);
            $("#btnsave").prop("disabled", false);
        }
    });
}

// Update note by passing required value
function updatenotes() {
    if (checkvalidation()) {
        $.ajax({
            type: "POST",
            url: "Notes.aspx/UpdateNotes",
            data: "{id : '" + $("#hdnnoteid").val() + "', title : '" + $("#txtnotetitle").val() + "', body : '" + $("#txtnotebody").val() + "'}",
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                alert("Note has been updated successfully.");
                $("#txtnotetitle").val("");
                $("#txtnotebody").val("");
                $("#hdnnoteid").val(0);
                LoadNotes();
                $("#btnsave").prop("disabled", true);
            }
        });
    }
}

//Insert note
function insertnotes() {
    if (checkvalidation()) {
        $.ajax({
            type: "POST",
            url: "Notes.aspx/InsertNotes",
            data: "{title : '" + $("#txtnotetitle").val() + "', body : '" + $("#txtnotebody").val() + "',userId : '" + $("#hdnuserid").val() + "'}",
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                alert("Note has been added successfully.");
                $("#txtnotetitle").val("");
                $("#txtnotebody").val("");
                $("#hdnnoteid").val(0);
                LoadNotes();
            }
        });
    }
}

// validate function
function checkvalidation() {
    if ($("#txtnotetitle").val() == "" || $("#txtnotebody").val() == "") {
        alert("Please enter values for title and body.")
        return false;
    }
    return true;
}
