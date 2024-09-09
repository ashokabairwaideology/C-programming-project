<%@ page language="C#" masterpagefile="~/MasterPage.master" autoeventwireup="true" inherits="Default3, App_Web_-l0fsmyu" title="Untitled Page" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

   
   
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
    
          <asp:Panel ID="Panel1" runat="server" BackColor="#6699FF" Height="498px" Style="position: relative;
        top: -11px; left: 5px;" Width="153px" ForeColor="#3366FF">
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
    <asp:Panel ID="Panel2" runat="server" Height="496px" Style="left: 188px; position: absolute;
        top: 206px" Width="666px" BackColor="GhostWhite">
         <asp:Label ID="servername" runat="server" Style="left: 13px; position: absolute;
        top: 37px" Text="Server Name" Font-Bold="True" Font-Size="12pt"></asp:Label>
    <asp:TextBox ID="server_name" runat="server" Style="left: 195px; position: absolute;
        top: 35px" BackColor="Beige" ForeColor="Black" Width="425px"></asp:TextBox>
    <asp:Label ID="problemreportdate" runat="server" Style="left: 13px; position: absolute;
        top: 65px" Text="Problem Report Date" Font-Bold="True" Font-Size="12pt"></asp:Label>
    <asp:TextBox ID="problem_report_date" runat="server" Style="left: 195px; position: absolute;
        top: 63px" BackColor="Beige" ForeColor="Black" Width="425px"></asp:TextBox>
    <asp:Label ID="problemdesription" runat="server" Style="left: 13px; position: absolute;
        top: 89px" Text="Problem Description" Font-Bold="True" Font-Size="12pt"></asp:Label>
    <asp:TextBox ID="problem_desription" runat="server" Style="left: 195px; position: absolute;
        top: 87px" BackColor="Beige" ForeColor="Black" Width="425px"></asp:TextBox>
    <asp:Label ID="oemagency" runat="server" Style="left: 13px; position: absolute;
        top: 115px" Text="OEM Agency" Font-Bold="True" Font-Size="12pt"></asp:Label>
    <asp:TextBox ID="oem_agency" runat="server" Style="left: 195px; position: absolute;
        top: 113px" BackColor="Beige" ForeColor="Black" Width="425px"></asp:TextBox>
    <asp:Label ID="callreportdate" runat="server" Style="left: 13px; position: absolute; top: 141px"
        Text="Call Report Date" Font-Bold="True" Font-Size="12pt"></asp:Label>
    <asp:TextBox ID="call_report_date" runat="server" Style="left: 195px; position: absolute;
        top: 139px" BackColor="Beige" OnTextChanged="TextBox5_TextChanged" ForeColor="Black" Width="425px"></asp:TextBox>
    <asp:Label ID="sereveravailabilitystatus" runat="server" Style="left: 13px; position: absolute;
        top: 167px" Text="Server Availibity Status" Font-Bold="True" Font-Size="12pt"></asp:Label>
      
    &nbsp;
    <asp:TextBox ID="server_availability_status" runat="server" BackColor="Beige"
        ForeColor="Black" Style="left: 195px; position: absolute; top: 165px" Width="425px"></asp:TextBox>
  
    <asp:Label ID="serverdowndate" runat="server" Style="left: 13px; position: absolute;
        top: 194px" Text="Server Down Date" Font-Bold="True" Font-Size="12pt"></asp:Label>
    <asp:TextBox ID="server_down_date" runat="server" Style="left: 195px; position: absolute;
        top: 192px" BackColor="Beige" ForeColor="Black" Width="425px"></asp:TextBox>
    <asp:Label ID="serverrestartdate" runat="server" Style="left: 13px; position: absolute;
        top: 222px" Text="Server Restart Date" Font-Bold="True" Font-Size="12pt"></asp:Label>
    <asp:TextBox ID="server_restart_date" runat="server" Style="left: 195px; position: absolute;
        top: 220px" BackColor="Beige" ForeColor="Black" Width="425px"></asp:TextBox>
        
    <asp:Label ID="callattenddate" runat="server" Style="left: 13px; position: absolute;
        top: 251px" Text="Call Attend Date" Font-Bold="True" Font-Size="12pt"></asp:Label>
    <asp:TextBox ID="call_attend_date" runat="server" Style="left: 195px; position: absolute;
        top: 249px" BackColor="Beige" ForeColor="Black" Width="425px"></asp:TextBox>
    <asp:Label ID="callattendengg" runat="server" Style="left: 13px; position: absolute;
        top: 279px" Text="Call Attend Engineer" Font-Bold="True" Font-Size="12pt"></asp:Label>
    <asp:TextBox ID="call_attend_engg" runat="server" Style="left: 195px; position: absolute;
        top: 277px" BackColor="Beige" ForeColor="Black" Width="425px"></asp:TextBox>
    <asp:Label ID="problempartno" runat="server" Style="left: 13px; position: absolute;
        top: 308px" Text="Problem Part Number" Font-Bold="True" Font-Size="12pt"></asp:Label>
    <asp:TextBox ID="problem_part_no" runat="server" Style="left: 195px; position: absolute;
        top: 306px" BackColor="Beige" ForeColor="Black" Width="425px"></asp:TextBox>
    <asp:Label ID="problempartdesc" runat="server" Style="left: 13px; position: absolute;
        top: 334px" Text="Problem Part Desc" Font-Bold="True" Font-Size="12pt"></asp:Label>
    <asp:TextBox ID="problem_part_desc" runat="server" Style="left: 195px; position: absolute;
        top: 332px" BackColor="Beige" ForeColor="Black" Width="425px"></asp:TextBox>
    <asp:Label ID="problemreasons" runat="server" Style="left: 13px; position: absolute;
        top: 360px" Text="Problem Reasons" Font-Bold="True" Font-Size="12pt"></asp:Label>
    <asp:TextBox ID="problem_reasons" runat="server" Style="left: 195px; position: absolute;
        top: 358px" BackColor="Beige" ForeColor="Black" Width="425px"></asp:TextBox>
    <asp:Label ID="Actionstaken" runat="server" Style="left: 13px; position: absolute;
        top: 386px" Text="Actions Taken" Font-Bold="True" Font-Size="12pt"></asp:Label>
        <asp:Label ID="Label3" runat="server" BackColor="GhostWhite" Font-Bold="True" Font-Italic="True"
            Style="left: 2px; position: absolute; top: 3px" Text="Server History" Width="660px"></asp:Label>
    <asp:TextBox ID="Actions_taken" runat="server" Style="left: 195px; position: absolute;
        top: 384px" BackColor="Beige" ForeColor="Black" Width="425px"></asp:TextBox>
    <asp:Label ID="serverremarks" runat="server" Style="left: 13px; position: absolute; top: 416px"
        Text="Remarks" Font-Bold="True" Font-Size="12pt"></asp:Label>
    <asp:TextBox ID="remarks" runat="server" Style="left: 195px; position: absolute;
        top: 414px" BackColor="Beige" ForeColor="Black" Width="425px"></asp:TextBox>
    &nbsp; &nbsp;&nbsp; &nbsp;&nbsp;
    <asp:Calendar ID="Calendar1" runat="server" BackColor="Beige" OnSelectionChanged="Calendar1_SelectionChanged1" Style="left: 403px; position: absolute; top: 83px"
        Visible="False" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px">
        <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
        <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
        <SelectorStyle BackColor="#FFCC66" />
        <OtherMonthDayStyle ForeColor="#CC9966" />
        <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
        <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
        <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
    </asp:Calendar>
    <asp:Calendar ID="Calendar2" runat="server" BackColor="Beige" BorderColor="#FFCC66"
        BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt"
        ForeColor="#663399" Height="200px" OnSelectionChanged="Calendar2_SelectionChanged"
        ShowGridLines="True" Style="left: 401px; position: absolute; top: 162px" Visible="False"
        Width="220px">
        <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
        <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
        <SelectorStyle BackColor="#FFCC66" />
        <OtherMonthDayStyle ForeColor="#CC9966" />
        <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
        <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
        <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
    </asp:Calendar>
    
     
     
    
    
    <asp:Button ID="save" runat="server" BackColor="Beige" Font-Bold="True" Font-Size="12pt"
        OnClick="save_Click" Style="left: 7px; position: absolute; top: 465px" Text="Save" />
    <asp:Button ID="query" runat="server" BackColor="Beige" Font-Bold="True" Font-Size="12pt"
        OnClick="query_Click" Style="left: 77px; position: absolute; top: 465px" Text="Query" />
    <asp:Button ID="update" runat="server" BackColor="Beige" Font-Bold="True" Font-Size="12pt"
        OnClick="update_Click" Style="left: 158px; position: absolute; top: 465px" Text="Update" />
    &nbsp;
    <asp:Button ID="clear" runat="server" BackColor="Beige" Font-Bold="True" Font-Size="12pt"
        OnClick="clear_Click" Style="left: 251px; position: absolute; top: 465px" Text="Clear" />
    <asp:Calendar ID="Calendar3" runat="server" BackColor="Beige" BorderColor="#FFCC66"
        BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt"
        ForeColor="#663399" Height="200px" OnSelectionChanged="Calendar3_SelectionChanged1"
        ShowGridLines="True" Style="left: 404px; position: absolute; top: 216px" Visible="False"
        Width="220px">
        <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
        <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
        <SelectorStyle BackColor="#FFCC66" />
        <OtherMonthDayStyle ForeColor="#CC9966" />
        <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
        <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
        <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
    </asp:Calendar>
    <asp:Calendar ID="Calendar4" runat="server" BackColor="Beige" BorderColor="#FFCC66"
        BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt"
        ForeColor="#663399" Height="200px" OnSelectionChanged="Calendar4_SelectionChanged1"
        ShowGridLines="True" Style="left: 402px; position: absolute; top: 239px" Visible="False"
        Width="220px">
        <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
        <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
        <SelectorStyle BackColor="#FFCC66" />
        <OtherMonthDayStyle ForeColor="#CC9966" />
        <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
        <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
        <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
    </asp:Calendar>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Style="left: 630px;
        position: absolute; top: 62px" Text=".." Width="24px" BackColor="Beige" ForeColor="Black" OnLoad="Button1_Load" />
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Style="left: 628px;
        position: absolute; top: 138px" Text=".." Width="24px" BackColor="Beige" ForeColor="Black" OnLoad="Button2_Load" />
    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Style="left: 628px;
        position: absolute; top: 191px" Text=".." Width="24px" BackColor="Beige" ForeColor="Black" OnLoad="Button3_Load" />
    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Style="left: 630px;
        position: absolute; top: 219px" Text=".." Width="24px" BackColor="Beige" ForeColor="Black" OnLoad="Button4_Load" />
    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Style="left: 630px;
        position: absolute; top: 248px" Text=".." Width="24px" BackColor="Beige" ForeColor="Black" OnLoad="Button5_Load" />
        <asp:Calendar ID="Calendar5" runat="server" BackColor="Beige" BorderColor="#FFCC66"
            BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt"
            ForeColor="#663399" Height="200px" OnSelectionChanged="Calendar5_SelectionChanged1"
            ShowGridLines="True" Style="left: 405px; position: absolute; top: 267px" Width="220px" Visible="False">
            <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
            <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
            <SelectorStyle BackColor="#FFCC66" />
            <OtherMonthDayStyle ForeColor="#CC9966" />
            <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
            <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
            <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
        </asp:Calendar>
    </asp:Panel>
    
    <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 192px;
        position: absolute; top: 184px" Text="Label" Visible="False" Width="797px"></asp:Label>
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
   
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;

    </asp:Content>

