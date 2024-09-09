<%@ page language="C#" masterpagefile="~/MasterPage.master" autoeventwireup="true" inherits="Default6, App_Web_9kv_mbjt" title="Untitled Page" %>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 218px;
        position: absolute; top: 250px" Text="Label" Visible="False" Width="776px"></asp:Label>
     <asp:Panel ID="Panel1" runat="server" BackColor="#6699FF" Height="500px" Style="position: relative;
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
    <asp:Panel ID="Panel2" runat="server" BackColor="GhostWhite" Height="356px" Style="left: 218px;
        position: absolute; top: 273px" Width="623px">
        <asp:Label ID="medialabel" runat="server" Font-Bold="True" ForeColor="Black" Style="left: 22px;
            position: absolute; top: 52px" Text="Media Label"></asp:Label>
        <asp:TextBox ID="media_label" runat="server" BackColor="Beige" Style="left: 158px;
            position: absolute; top: 49px" Width="422px"></asp:TextBox>
        <asp:Label ID="partno" runat="server" Font-Bold="True" ForeColor="Black" Style="left: 22px;
            position: absolute; top: 82px" Text="Part Number"></asp:Label>
        <asp:TextBox ID="part_no" runat="server" BackColor="Beige" Style="left: 158px; position: absolute;
            top: 80px" Width="422px"></asp:TextBox>
        <asp:Label ID="type_media" runat="server" Font-Bold="True" ForeColor="Black" Style="left: 22px;
            position: absolute; top: 112px" Text="Type Media"></asp:Label>
        <asp:DropDownList ID="typemedia" runat="server" BackColor="Beige" Style="left: 158px;
            position: absolute; top: 111px" Width="428px">
            <asp:ListItem>DVD</asp:ListItem>
            <asp:ListItem>CD</asp:ListItem>
            <asp:ListItem>FLOPPY</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="software_category" runat="server" Font-Bold="True" ForeColor="Black"
            Style="left: 22px; position: absolute; top: 142px" Text="Software Category"></asp:Label>
        <asp:DropDownList ID="softwarecategory" runat="server" BackColor="Beige" Style="left: 158px;
            position: absolute; top: 142px" Width="429px">
            <asp:ListItem>ORACLE</asp:ListItem>
            <asp:ListItem>WINDOWS</asp:ListItem>
            <asp:ListItem>AIX</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="mediadescription" runat="server" Font-Bold="True" ForeColor="Black"
            Style="left: 22px; position: absolute; top: 172px" Text="Media Description"></asp:Label>
        <asp:TextBox ID="media_description" runat="server" BackColor="Beige" Style="left: 158px;
            position: absolute; top: 173px" Width="422px"></asp:TextBox>
        <asp:Label ID="mediadate" runat="server" Font-Bold="True" ForeColor="Black" Style="left: 22px;
            position: absolute; top: 202px" Text="Media Date"></asp:Label>
        <asp:TextBox ID="media_date" runat="server" BackColor="Beige" Style="left: 158px;
            position: absolute; top: 204px" Width="422px"></asp:TextBox>
        <asp:Label ID="medialocation" runat="server" Font-Bold="True" ForeColor="Black" Style="left: 22px;
            position: absolute; top: 232px" Text="Media Location"></asp:Label>
        <asp:TextBox ID="media_location" runat="server" BackColor="Beige" Style="left: 158px;
            position: absolute; top: 235px" Width="422px"></asp:TextBox>
        <asp:Label ID="mediaremarks" runat="server" Font-Bold="True" ForeColor="Black" Style="left: 22px;
            position: absolute; top: 265px" Text="Remarks"></asp:Label>
        <asp:TextBox ID="remarks" runat="server" BackColor="Beige" Style="left: 158px; position: absolute;
            top: 266px" Width="422px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" BackColor="Snow" OnClick="Button1_Click1"
            Style="left: 591px; position: absolute; top: 203px" Text=".." Width="24px" />
        <asp:Calendar ID="Calendar1" runat="server" BackColor="Beige" BorderColor="#FFCC66"
            BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt"
            ForeColor="#663399" Height="200px" OnSelectionChanged="Calendar1_SelectionChanged1"
            ShowGridLines="True" Style="left: 369px; position: absolute; top: 224px" Visible="False"
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
            Style="left: 3px; position: absolute; top: 3px" Text="Software Details" Width="618px"></asp:Label>
    </asp:Panel>

    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:Button ID="save" runat="server" BackColor="Beige" Font-Bold="True" Font-Size="12pt"
        OnClick="save_Click" Style="left: 224px; position: absolute; top: 597px" Text="Save" Height="28px" />
    <asp:Button ID="query" runat="server" BackColor="Beige" Font-Bold="True" Font-Size="12pt"
        OnClick="query_Click" Style="left: 291px; position: absolute; top: 597px" Text="Query" Height="28px" />
    <asp:Button ID="update" runat="server" BackColor="Beige" Font-Bold="True" Font-Size="12pt"
        OnClick="update_Click" Style="left: 372px; position: absolute; top: 596px" Text="Update" Height="28px" />
    <asp:Button ID="clear" runat="server" BackColor="Beige" Font-Bold="True" Font-Size="12pt"
        OnClick="clear_Click" Style="left: 465px; position: absolute; top: 596px" Text="Clear" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

