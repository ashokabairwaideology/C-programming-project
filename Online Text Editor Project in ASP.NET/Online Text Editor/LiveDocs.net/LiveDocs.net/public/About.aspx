<%@ Page Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="LiveDocs.pages.pub.About" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <h3>About</h3>
    <p>LiveDocs is a simple multi-user text editor. It&#39;s designed to work with 
        markuptext that has extensive html capabilties since the output is
        produced directly from the input with some additional &lt;tag&gt; support. It does not support running scripts. Additional features included 
        are :&nbsp;
    </p>
    <ul>
        <li>
            Revision support. Create different versions of the same document with option to switch between revision and work on newer or older page content.
        </li>
        <li>
            Save to file. User can choose to store html markup as 
            any format on the local machine.
        </li>
        <li>
            Standard text editor tools such as bold, italic, text size and more..
        </li>
        <li>
            Open and password-protected sharing to non-registered users.
        </li>
        <li>
            Sharing documents between livedocs' users and allowing read-only or read/write permissions on chosen document.
        </li>
    </ul>
  
</asp:Content>