<%@ page language="C#" masterpagefile="~/MasterPage.master" autoeventwireup="true" inherits="Default2, App_Web_z_-nr4kl" title="Untitled Page" %>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
    <asp:Label ID="cartlabel" runat="server" Font-Bold="True" Style="left: 176px; position: absolute;
        top: 261px" Text="Cartridge Label" ForeColor="White"></asp:Label>
    <asp:TextBox ID="cart_label" runat="server" Style="left: 295px; position: absolute;
        top: 259px"></asp:TextBox>
          <asp:Panel ID="Panel1" runat="server" BackColor="#6699FF" Height="481px" Style="position: relative;
        top: -2px; left: 0px;" Width="153px" ForeColor="#3366FF">
             &nbsp; &nbsp;
             <asp:Panel ID="Panel4" runat="server" Height="189px" Style="left: 11px; position: absolute;
                 top: 256px" Width="125px" BackColor="#CCCCFF" BorderStyle="Dashed">
                 <asp:LinkButton ID="server_master_reports" runat="server" PostBackUrl="~/server master reports.aspx"
                     Style="left: 11px; position: absolute; top: 14px">Server Master</asp:LinkButton>
                 <asp:LinkButton ID="server_history_reports" runat="server" PostBackUrl="~/server history reports.aspx"
                     Style="left: 11px; position: absolute; top: 43px">Server History</asp:LinkButton>
                 <asp:LinkButton ID="server_cartridges_reports" runat="server" PostBackUrl="~/server cartridge reports.aspx"
                     Style="left: 11px; position: absolute; top: 72px">Server Cartridges</asp:LinkButton>
                 <asp:LinkButton ID="mock_restoration_details" runat="server" PostBackUrl="~/mock restore reports.aspx"
                     Style="left: 11px; position: absolute; top: 101px" Width="110px">Mock Restoration</asp:LinkButton>
                 <asp:LinkButton ID="software_details_reports" runat="server" PostBackUrl="~/software details reports.aspx"
                     Style="left: 11px; position: absolute; top: 130px">Software Details</asp:LinkButton>
                 <asp:LinkButton ID="document_details_reports" runat="server" PostBackUrl="~/document details reports.aspx"
                     Style="left: 11px; position: absolute; top: 160px" Width="107px">Document Details</asp:LinkButton>
             </asp:Panel>
             &nbsp;
             <asp:Panel ID="Panel3" runat="server" BackColor="#CCCCFF" BorderStyle="Dashed" Height="189px"
                 Style="left: 10px; position: absolute; top: 24px" Width="125px">
                 <asp:LinkButton ID="server_master" runat="server" PostBackUrl="~/server_master.aspx"
                     Style="left: 11px; position: absolute; top: 14px">Server Master</asp:LinkButton>
                 <asp:LinkButton ID="server_history" runat="server" PostBackUrl="~/server_history.aspx"
                     Style="left: 11px; position: absolute; top: 41px">Server History</asp:LinkButton>
                 <asp:LinkButton ID="server_cartridges" runat="server" PostBackUrl="~/server_cartridges.aspx"
                     Style="left: 11px; position: absolute; top: 68px" Width="107px">Server Cartridges</asp:LinkButton>
                 <asp:LinkButton ID="mock_restoration" runat="server" PostBackUrl="~/cartridges_mock_restore.aspx"
                     Style="left: 11px; position: absolute; top: 95px">Mock Restoration</asp:LinkButton>
                 <asp:LinkButton ID="software_details" runat="server" PostBackUrl="~/software_details.aspx"
                     Style="left: 11px; position: absolute; top: 122px">Software Details</asp:LinkButton>
                 <asp:LinkButton ID="document_detail" runat="server" PostBackUrl="~/document_details.aspx"
                     Style="left: 11px; position: absolute; top: 152px">Document Details</asp:LinkButton>
             </asp:Panel>
             &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
             <asp:Label ID="Label1" runat="server" ForeColor="#330033" Style="left: 21px; position: absolute;
                 top: 233px" Text="Reports"></asp:Label>
    </asp:Panel>
    <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 174px;
        position: absolute; top: 302px" Text="Label" Visible="False" Width="814px"></asp:Label>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:GridView ID="mock_restore" runat="server" OnSelectedIndexChanged="mock_restore_SelectedIndexChanged"
        Style="left: 179px; position: absolute; top: 337px" BackColor="Gainsboro" Font-Size="Smaller" ForeColor="Black">
        <HeaderStyle Font-Size="Smaller" />
    </asp:GridView>
    <asp:Button ID="query" runat="server" BackColor="#FFFF80" Font-Bold="True" OnClick="query_Click"
        Style="left: 469px; position: absolute; top: 258px" Text="Query" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

