<%@ Page Title="" Language="C#" ValidateRequest="false" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Editor.aspx.cs" Inherits="LiveDocs.livedocs.Editor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <script type="text/javascript" src="/res/scripts/Editor.js" ></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MenuContentPlaceHolder" runat="server">
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
      <div id="DropDownMenu" ClientIDMode="Static">
          <table style="width: inherit">
              <tr>
                  <td>
        <ul id="top-nav">
            <li>
                <a href="#" class="top-nav-list">File</a>
                <ul>
                    <li>
                        <div class="wrap">
                             <a href="#" onclick="EditorCheckoutRevision()">Checkout</a>
                             <a href="#" onclick="EditorCommitRevision()">Commit</a>
                             <a href="#" onclick="saveAsFile(<%=Request["revID"] %>)">Export to File</a>
                        </div>
                       
                    </li>
                </ul>
            </li>            
        </ul>
        </td>
        <td style="text-align: right">
        <label id="updateRevisionStatus"></label>
        </td>
        </tr>
        </table>
    </div>
    <div id="EntireEditorArea" >
        <asp:UpdatePanel ID="UpdatePanel1" UpdateMode="Conditional" runat="server">         
            <ContentTemplate>
          
            <div id="EditorMenubar">
                <table >
                    <tr>
                        <td>
                            <asp:ImageButton ID="BoldButton" OnClientClick="buttonClick('Bold'); return false;" AlternateText="Bold" runat="server" ImageUrl="~/res/gfx/icons/editor/bold.png" />
                        </td>
                        <td>
                            <asp:ImageButton ID="ItalicButton" OnClientClick="buttonClick('Italic'); return false;" AlternateText="Italic" runat="server" ImageUrl="~/res/gfx/icons/editor/italic.png" />
                        </td>
                        <td>
                            <asp:ImageButton ID="Underline" OnClientClick="buttonClick('Underline'); return false;" AlternateText="Underline" runat="server" ImageUrl="~/res/gfx/icons/editor/underscore.png" />
                        </td>
                        <td>
                            <asp:ImageButton ID="StrikeButton" OnClientClick="buttonClick('Strikethrough'); return false;" AlternateText="Strikethrough" runat="server" ImageUrl="~/res/gfx/icons/editor/strikethrough.png" />
                        </td>
                         <td>
                            <asp:ImageButton ID="SubSButton" OnClientClick="buttonClick('Subscript'); return false;" AlternateText="Subscript" runat="server" ImageUrl="~/res/gfx/icons/editor/subscript.png" />
                        </td>
                        <td>
                            <asp:ImageButton ID="SuperSButton" OnClientClick="buttonClick('Superscript'); return false;" AlternateText="Superscript" runat="server" ImageUrl="~/res/gfx/icons/editor/superscript.png" />
                        </td>           
                        <td>
                            <asp:DropDownList ID="TextSizeDropDownList"  runat="server">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:DropDownList ID="FontDropDownList" runat="server">
                            </asp:DropDownList>
                          
                        </td>
                    </tr>
                 
                </table>
                </div>
        <div id="Wrapper" align="center">
            <div id="InnerWrapperMarkup">
                <textarea id="MarkupText" clientidmode="Static" onkeyup="markupChanged();"  autofocus="true" draggable="false" runat="server"></textarea>
            </div>
            <div id="InnerWrapperHtml">
                <span id="HtmlText" clientidmode="Static" runat="server">
                    
                </span>
                
            </div>
            
        </div>     
            </div>            
            </ContentTemplate>       
        </asp:UpdatePanel>  
      </div>
                      
  <asp:Panel runat="server" id="InnerWrapperRevisions"></asp:Panel>
    <div id="EditorDialog" title="Document Action">
       
    </div>
    <script type="text/javascript">$('#ChatMinimized').hide();</script>
    <div id="ChatMinimized" ><a href="#" style="padding: 5px;" onclick="$('#ChatMinimized').hide(); $('#ChatMain').show();"><img src="/res/gfx/icons/editor/maxichat.png" /></a></div>
    <div id="ChatContainer">
        
        <div id="ChatPanel">
            
            <div id="ChatMain">
                <a id="ChatMinimizer" href="#" style="float:right; padding:5px;" onclick="$('#ChatMinimized').show(); $('#ChatMain').hide();"><img src="/res/gfx/icons/editor/minichat.png" /></a>
            <div id="ChatScrollContainer">
                
                <asp:UpdatePanel runat="server">
                    <Triggers>
                        <asp:AsyncPostBackTrigger controlid="ChatSend" eventname="Click" />
                    </Triggers>
            <ContentTemplate>
                
                   <asp:Panel runat="server" ID="ChatLog"></asp:Panel>
                   
                    
                         </ContentTemplate>
               </asp:UpdatePanel>
               </div> 
               <asp:TextBox Width="150" ID="ChatText" runat="server"></asp:TextBox>
                    <asp:Button ID="ChatSend"
                        runat="server" Text="Send" onclick="ChatSend_Click" OnClientClick="ScrollChatToBottom()" />
            </div>
        </div>
        </div>
</asp:Content>

