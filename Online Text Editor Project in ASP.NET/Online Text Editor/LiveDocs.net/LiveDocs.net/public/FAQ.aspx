<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="FAQ.aspx.cs" Inherits="LiveDocs.pages.pub.FAQ" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MenuContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <h3>FAQ</h3> 
    <ul id="FAQList">
      <li>
          Does the editor support 
          HTML5 markup? <b>: <br />HTML5 support is client side and must be supported by your browser to function correctly. </b>
      </li>
      <li>
          Can you import rich-text directly into the editor? <b>: <br />No, rich-text to markup conversion is not currently implemented. It can however be pasted into the editor and will appear as pure text.</b>
      </li>
      <li>
          Which tags are supported in addition to conventional html? <b>:</b>
          <ul>
              <li>
                  <b>Fonts</b><br/>
                  &lt;courier&gt;&lt;/courier&gt;<br/>
                  &lt;arial&gt;&lt;/arial&gt;<br/>
                  &lt;comic&gt;&lt;/comic&gt;<br/>
              </li>
            
              <li>
                  <b>Text size</b><br/>
                  &lt;1-10&gt;&lt;/1-10&gt;
              </li>
              
          </ul>
      </li>
  </ul>
              
</asp:Content>
