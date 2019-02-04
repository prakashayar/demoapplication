# demoapplication


Used database in this project is mssql sql express 
Authentication mode is windows 
Open SQL Server Management Studio
Run DatabaseScirptForDemo.sql for database creation
Run InsertDataScript.sql for some sample data
Need to change configuration -> appSettings -> ConnectionsString as per installed SQL in your system

UserName : prakash
Password : prakash@123

Used FormAuthentication
Once Logged with mentioned credentials, you will redirct to Notes.aspx

For add new note, fill title , body and click Add note button
For update existing note, click on title of particular note. Respective value fill in title & body textboxes. 
Make changes & click on Save button.
Please note that Save button only enable when particular note is in edit mode.
Click on close button which appears at each note to delete note.

