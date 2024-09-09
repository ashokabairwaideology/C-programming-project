<%@ Page Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="Feedback.aspx.cs" Inherits="Feedback" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <script type="text/javascript">
		
		  function ShowMessage()
    {
       
    if(document.getElementById("message").value != "")
    {
      alert(document.getElementById("message").value);
      document.getElementById("message").value = "";
      }
    }
    </script>

    <div>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="X-Large"
            Height="29px" Style="z-index: 100; left: 401px; position: absolute; top: 299px"
            Text="Feedback" Width="167px"></asp:Label>
        <asp:Label ID="lblfeedback" runat="server" Font-Bold="True" Font-Size="X-Large" Height="23px"
            Style="z-index: 101; left: 166px; position: absolute; top: 470px" Text="subject of feedback"
            Width="315px"></asp:Label>
        <asp:TextBox ID="tbxsubfeedback" runat="server" Height="19px" Style="z-index: 112;
            left: 534px; position: absolute; top: 470px" Width="196px"></asp:TextBox>
        &nbsp;&nbsp;
        <asp:Label ID="lblemail" runat="server" Font-Bold="True" Font-Size="X-Large" Height="22px"
            Style="z-index: 103; left: 298px; position: absolute; top: 506px" Text="Email id"
            Width="181px"></asp:Label>
        <asp:TextBox ID="tbxemailid" runat="server" Height="22px" Style="z-index: 104; left: 534px;
            position: absolute; top: 507px" Width="203px"></asp:TextBox>
        <asp:Label ID="lblcomment" runat="server" Font-Bold="True" Font-Size="X-Large" Style="z-index: 105;
            left: 280px; position: absolute; top: 620px" Text="Comment/Query" Width="61px"></asp:Label>
        <asp:TextBox ID="tbxcomment" runat="server" Height="81px" Style="z-index: 106; left: 532px;
            position: absolute; top: 592px" TextMode="MultiLine" Width="205px"></asp:TextBox>
        <asp:Button ID="btnsubmit" runat="server" OnClick="btnsubmit_Click" Style="z-index: 107;
            left: 470px; position: absolute; top: 740px" Text="submit" />
        <asp:Button ID="btncancel" runat="server" OnClick="btncancel_Click" Style="z-index: 108;
            left: 549px; position: absolute; top: 739px" Text="cancel" />
        &nbsp;
        <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Larger" Style="z-index: 110;
            left: 410px; position: absolute; top: 553px" Text="Date" Width="38px"></asp:Label>
        <asp:TextBox ID="tbxdate" runat="server" Style="z-index: 111; left: 533px; position: absolute;
            top: 553px"></asp:TextBox>
        <input id="message" runat="server" style="z-index: 131; left: 54px; position: absolute;
            top: 310px" type="hidden" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </div>
</asp:Content>

