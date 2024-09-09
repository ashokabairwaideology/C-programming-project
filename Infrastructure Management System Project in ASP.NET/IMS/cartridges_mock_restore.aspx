<%@ page language="C#" masterpagefile="~/MasterPage.master" autoeventwireup="true" inherits="Default5, App_Web_5xv5d6d0" title="Untitled Page" %>

<script runat="server">

    protected void query_Click(object sender, EventArgs e)
    {

    }
</script>

<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
   
    
    <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 179px;
        position: absolute; top: 239px" Text="Label" Visible="False" Width="823px"></asp:Label>
          <asp:Panel ID="Panel1" runat="server" BackColor="#6699FF" Height="472px" Style="position: relative;
        top: 0px; left: 0px;" Width="153px" ForeColor="#3366FF">
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
    <asp:Panel ID="Panel2" runat="server" BackColor="GhostWhite" Height="279px" Style="left: 178px;
        position: absolute; top: 261px" Width="679px">
         <asp:Label ID="cartlabel" runat="server" Font-Bold="True" Style="left: 19px; position: absolute;
        top: 63px" Text="Cartridge Label" Font-Size="12pt" BackColor="GhostWhite"></asp:Label>
        <asp:TextBox ID="cart_label" runat="server" BackColor="Beige" ForeColor="Black"
        Style="left: 231px; position: absolute; top: 61px" Width="402px"></asp:TextBox>
    <asp:Label ID="cartmockrestoredt" runat="server" Font-Bold="True" Style="left: 19px;
        position: absolute; top: 105px" Text="Cartridge Mock Restore Date" Font-Size="12pt" BackColor="GhostWhite"></asp:Label>
    <asp:TextBox ID="cart_mock_restore_dt" runat="server" BackColor="Beige" ForeColor="Black"
        Style="left: 231px; position: absolute; top: 103px" Width="402px"></asp:TextBox>
    <asp:Label ID="cartcloseddt" runat="server" Font-Bold="True" Style="left: 19px;
        position: absolute; top: 145px" Text="Cartridge Closed Date" Font-Size="12pt" BackColor="GhostWhite"></asp:Label>
    <asp:TextBox ID="cart_closed_dt" runat="server" BackColor="Beige" ForeColor="Black"
        Style="left: 231px; position: absolute; top: 143px" Width="402px"></asp:TextBox>
    <asp:Label ID="cartremarks" runat="server" Font-Bold="True" Style="left: 19px; position: absolute;
        top: 187px" Text="Remarks" Font-Size="12pt" BackColor="GhostWhite"></asp:Label>
    <asp:TextBox ID="remarks" runat="server" BackColor="Beige" ForeColor="Black"
        Style="left: 231px; position: absolute; top: 185px" Width="402px"></asp:TextBox>
    &nbsp; &nbsp;
    <asp:Calendar ID="Calendar1" runat="server" BackColor="Beige" OnSelectionChanged="Calendar1_SelectionChanged" Style="left: 420px; position: absolute; top: 123px"
        Visible="False" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px">
        <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
        <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
        <SelectorStyle BackColor="#FFCC66" />
        <OtherMonthDayStyle ForeColor="#CC9966" />
        <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
        <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
        <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
    </asp:Calendar>
    <asp:Calendar ID="Calendar2" runat="server" BackColor="Beige" OnSelectionChanged="Calendar2_SelectionChanged" Style="left: 417px; position: absolute; top: 165px"
        Visible="False" Height="200px" Width="220px" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" ShowGridLines="True">
        <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
        <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
        <SelectorStyle BackColor="#FFCC66" />
        <OtherMonthDayStyle ForeColor="#CC9966" />
        <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
        <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
        <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
    </asp:Calendar>
    <asp:Button ID="Button2" runat="server" BackColor="Beige" ForeColor="Black"
        OnClick="Button2_Click" Style="left: 643px; position: absolute; top: 142px" Text=".."
        Width="24px" OnLoad="Button2_Load" />
    <asp:Button ID="Button1" runat="server" BackColor="Beige" ForeColor="Black"
        OnClick="Button1_Click" Style="left: 646px; position: absolute; top: 102px; display: inline;" Text=".."
        Width="24px" OnLoad="Button1_Load" BorderStyle="Outset" SkinID="buttoncskin" />
        <asp:Button ID="save" runat="server" BackColor="Beige" Font-Bold="True" Font-Size="12pt"
        OnClick="save_Click" Style="left: 14px; position: absolute; top: 245px" Text="Save" />
    &nbsp;
    <asp:Button ID="query" runat="server" BackColor="Beige" Font-Bold="True" Font-Size="12pt"
        OnClick="query_Click" Style="left: 84px; position: absolute; top: 245px" Text="Query" />
    <asp:Button ID="update" runat="server" BackColor="Beige" Font-Bold="True" Font-Size="12pt"
        OnClick="update_Click" Style="left: 170px; position: absolute; top: 245px" Text="Update" />
    <asp:Button ID="clear" runat="server" BackColor="Beige" Font-Bold="True" Font-Size="12pt"
        OnClick="clear_Click" Style="left: 261px; position: absolute; top: 245px" Text="Clear" />
        <asp:Label ID="Label3" runat="server" BackColor="GhostWhite" Font-Bold="True" Font-Italic="True"
            Style="left: 4px; position: absolute; top: 3px" Text="Mock Restoration Details"
            Width="670px"></asp:Label>
    </asp:Panel>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

