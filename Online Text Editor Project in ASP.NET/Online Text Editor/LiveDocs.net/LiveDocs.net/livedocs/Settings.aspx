<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Settings.aspx.cs" Inherits="LiveDocs.pages.pub.Settings" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../res/scripts/Settings.js" type="text/javascript"> </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MenuContentPlaceHolder" runat="server">   
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <table runat="server" style="width: inherit">
        <tr>
 
            <td colspan="2">
                <div style="float: left; width: inherit;" >
                    <asp:Panel ID="userInformationPanel" runat="server"></asp:Panel>
                </div>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <hr/>
            </td>
        </tr>
        <tr>
            <td td colspan="2">
                <div style="float: left; width: inherit;">
                    <asp:Panel ID="adminControls" runat="server"></asp:Panel>
                </div>
            </td>
        </tr>   
    </table>
 
    <div id="ChangeUsernameDialog"></div>
</asp:Content>