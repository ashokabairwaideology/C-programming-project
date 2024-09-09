<%@ page language="C#" masterpagefile="~/MasterPage.master" autoeventwireup="true" inherits="Default7, App_Web_-l0fsmyu" title="Untitled Page" %>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 212px;
        position: absolute; top: 275px" Text="Label" Visible="False" Width="815px"></asp:Label>
       <asp:Panel ID="Panel1" runat="server" BackColor="#6699FF" Height="470px" Style="position: relative;
        top: -8px; left: 5px;" Width="153px" ForeColor="#3366FF">
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
                     Style="left: 11px; position: absolute; top: 14px" OnClick="server_master_Click">Server Master</asp:LinkButton>
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
    &nbsp;&nbsp;
    <asp:Panel ID="Panel2" runat="server" BackColor="GhostWhite" BorderStyle="Solid" Height="286px"
        Style="left: 210px; position: absolute; top: 297px" Width="623px">
        <asp:Label ID="documentlabel" runat="server" BackColor="GhostWhite" Font-Bold="True" ForeColor="Black"
            Style="left: 13px; position: absolute; top: 44px" Text="Document Label"></asp:Label>
        <asp:TextBox ID="document_label" runat="server" BackColor="Beige" Style="left: 167px;
            position: absolute; top: 42px" Width="410px"></asp:TextBox>
        <asp:Label ID="documentcategory" runat="server" BackColor="GhostWhite" Font-Bold="True"
            ForeColor="Black" Style="left: 13px; position: absolute; top: 73px" Text="Document Category"></asp:Label>
        <asp:DropDownList ID="document_category" runat="server" BackColor="Beige" Style="left: 167px;
            position: absolute; top: 71px" Width="416px">
            <asp:ListItem>ORACLE</asp:ListItem>
            <asp:ListItem>AIX</asp:ListItem>
            <asp:ListItem>SAN</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="documentdescription" runat="server" BackColor="GhostWhite" Font-Bold="True"
            ForeColor="Black" Style="left: 13px; position: absolute; top: 102px" Text="Document Description"></asp:Label>
        <asp:TextBox ID="document_description" runat="server" BackColor="Beige" Style="left: 167px;
            position: absolute; top: 100px" Width="410px"></asp:TextBox>
        <asp:Label ID="documentlocation" runat="server" BackColor="GhostWhite" Font-Bold="True"
            ForeColor="Black" Style="left: 13px; position: absolute; top: 131px" Text="Document Location"></asp:Label>
        <asp:TextBox ID="document_location" runat="server" BackColor="Beige" Style="left: 167px;
            position: absolute; top: 129px" Width="410px"></asp:TextBox>
        <asp:Label ID="documentdate" runat="server" BackColor="GhostWhite" Font-Bold="True" ForeColor="Black"
            Style="left: 13px; position: absolute; top: 160px" Text="Document Date"></asp:Label>
        <asp:TextBox ID="document_date" runat="server" BackColor="Beige" Style="left: 167px;
            position: absolute; top: 158px" Width="410px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" BackColor="Beige" OnClick="Button1_Click1"
            Style="left: 592px; position: absolute; top: 158px" Text=".." Width="24px" />
        &nbsp;
        <asp:Label ID="documentremarks" runat="server" BackColor="GhostWhite" Font-Bold="True"
            ForeColor="Black" Style="left: 13px; position: absolute; top: 189px" Text="Remarks"></asp:Label>
        <asp:TextBox ID="remarks" runat="server" BackColor="Beige" Style="left: 167px; position: absolute;
            top: 187px" Width="410px"></asp:TextBox>
        <asp:Calendar ID="Calendar1" runat="server" BackColor="Beige" BorderColor="#FFCC66"
            BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt"
            ForeColor="#663399" Height="200px" OnSelectionChanged="Calendar1_SelectionChanged"
            ShowGridLines="True" Style="left: 369px; position: absolute; top: 178px" Visible="False"
            Width="220px">
            <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
            <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
            <SelectorStyle BackColor="#FFCC66" />
            <OtherMonthDayStyle ForeColor="#CC9966" />
            <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
            <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
            <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
        </asp:Calendar>
        <asp:Label ID="Label3" runat="server" BackColor="GhostWhite" Font-Bold="True" Font-Italic="True"
            ForeColor="Black" Style="left: 1px; position: absolute; top: 0px" Text="Document Details"
            Width="619px"></asp:Label>
    </asp:Panel>

            

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:Button ID="save" runat="server" BackColor="Beige" Font-Bold="True" Font-Size="12pt"
        OnClick="save_Click" Style="left: 230px; position: absolute; top: 555px" Text="Save" />
    <asp:Button ID="query" runat="server" BackColor="Beige" Font-Bold="True" Font-Size="12pt"
        OnClick="query_Click" Style="left: 313px; position: absolute; top: 554px" Text="Query" />
    <asp:Button ID="update" runat="server" BackColor="Beige" Font-Bold="True" Font-Size="12pt"
        OnClick="update_Click" Style="left: 409px; position: absolute; top: 556px" Text="Update" />
    &nbsp;
    <asp:Button ID="clear" runat="server" BackColor="Beige" Font-Bold="True" Font-Size="12pt"
        OnClick="clear_Click" Style="left: 513px; position: absolute; top: 554px" Text="Clear" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

