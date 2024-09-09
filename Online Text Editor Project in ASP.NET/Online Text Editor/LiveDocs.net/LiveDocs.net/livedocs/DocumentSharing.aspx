<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DocumentSharing.aspx.cs" Inherits="LiveDocs.livedocs.DocumentSharing" %>

<table>
    <tr>
        <td>Username</td>
        <td>Level</td>
        <td></td>
    </tr>
    <asp:placeholder ID="UserList" runat="server"></asp:placeholder>
</table>
<hr/>
<table><tr>
           <td>Username/email:</td>
           <td><input type="text" id="AddUserTextbox" /></td>
       </tr>
    <tr>
        <td>Accesslevel: </td>
        <td><select id="SharingAddUserLevel">
                <option value="1">Read</option>
                <option value="2">Read/Write</option>
            </select>
        </td>
    </tr>
    <tr><td colspan="2">
            <input type="hidden" id="SharingAddUserDocID" value="<%= HttpContext.Current.Request["docID"] %>"/>
            <input id="Button1" type="button" value="Share with user" onclick=" DocumentSharingAddUser() "/>
        </td></tr>
</table>