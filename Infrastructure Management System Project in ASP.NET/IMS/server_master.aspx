<%@ page language="C#" masterpagefile="~/MasterPage.master" autoeventwireup="true" inherits="Default2, App_Web_-l0fsmyu" title="Untitled Page" %>

<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">

    
    <asp:Panel ID="Panel1" runat="server" BackColor="#6699FF" Height="556px" Style="position: relative;
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
                     Style="left: 9px; position: absolute; top: 14px">Server Master</asp:LinkButton>
                 <asp:LinkButton ID="server_history" runat="server" PostBackUrl="~/server_history.aspx"
                     Style="left: 9px; position: absolute; top: 41px">Server History</asp:LinkButton>
                 <asp:LinkButton ID="server_cartridges" runat="server" PostBackUrl="~/server_cartridges.aspx"
                     Style="left: 9px; position: absolute; top: 68px" Width="107px">Server Cartridges</asp:LinkButton>
                 <asp:LinkButton ID="mock_restoration" runat="server" PostBackUrl="~/cartridges_mock_restore.aspx"
                     Style="left: 9px; position: absolute; top: 95px" OnClick="mock_restoration_Click">Mock Restoration</asp:LinkButton>
                 <asp:LinkButton ID="software_details" runat="server" PostBackUrl="~/software_details.aspx"
                     Style="left: 9px; position: absolute; top: 122px">Software Details</asp:LinkButton>
                 <asp:LinkButton ID="document_detail" runat="server" PostBackUrl="~/document_details.aspx"
                     Style="left: 9px; position: absolute; top: 152px">Document Details</asp:LinkButton>
             </asp:Panel>
             &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
             <asp:Label ID="Label1" runat="server" ForeColor="#330033" Style="left: 21px; position: absolute;
                 top: 233px" Text="Reports"></asp:Label>
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server" Height="554px" Style="left: 164px; position: absolute;
        top: 215px" Width="895px" BackColor="GhostWhite">
        <asp:Label ID="servername" runat="server" Style="left: 9px; position: absolute;
        top: 41px" Text="Server Name" BackColor="Transparent" ForeColor="Black" Font-Bold="True" Font-Size="11pt"></asp:Label>
    <asp:TextBox ID="server_name" runat="server" Style="left: 155px; position: absolute;
        top: 38px" Width="184px" BackColor="Beige" ForeColor="#000000"></asp:TextBox>
    <asp:Label ID="serverip" runat="server" Style="left: 9px; position: absolute;
        top: 74px" Text="Server IP" ForeColor="Black" Font-Bold="True" Font-Size="11pt"></asp:Label>
    <asp:TextBox ID="server_ip" runat="server" Style="left: 155px; position: absolute;
        top: 71px" Width="184px" BackColor="Beige" ForeColor="#000000"></asp:TextBox>
    <asp:Label ID="serveralias" runat="server" Style="left: 9px; position: absolute;
        top: 106px" Text="Server Alias" ForeColor="Black" Font-Bold="True" Font-Size="11pt"></asp:Label>
    <asp:TextBox ID="server_alias" runat="server" Style="left: 155px; position: absolute;
        top: 103px" Width="184px" BackColor="Beige" ForeColor="#000000"></asp:TextBox>
    <asp:Label ID="servermake" runat="server" Style="left: 9px; position: absolute;
        top: 138px" Text="Server Make" ForeColor="Black" Font-Bold="True" Font-Size="11pt"></asp:Label>
    <asp:TextBox ID="server_make" runat="server" Style="left: 155px; position: absolute;
        top: 135px" Width="184px" BackColor="Beige" ForeColor="#000000"></asp:TextBox>
    <asp:Label ID="servermodel" runat="server" Style="left: 9px; position: absolute;
        top: 170px" Text="Server Model" ForeColor="Black" Font-Bold="True" Font-Size="11pt"></asp:Label>
    <asp:TextBox ID="server_model" runat="server" Style="left: 155px; position: absolute;
        top: 167px" Width="184px" BackColor="Beige" ForeColor="#000000"></asp:TextBox>
    <asp:Label ID="servertype" runat="server" Style="left: 9px; position: absolute;
        top: 200px" Text="Server Type" ForeColor="Black" Font-Bold="True" Font-Size="11pt"></asp:Label>
    <asp:TextBox ID="server_type" runat="server" Style="left: 155px; position: absolute;
        top: 197px" Width="184px" BackColor="Beige" ForeColor="#000000"></asp:TextBox>
    <asp:Label ID="serverslno" runat="server" Style="left: 9px; position: absolute;
        top: 231px" Text="Server SLNO" ForeColor="Black" Font-Bold="True" Font-Size="11pt"></asp:Label>
    <asp:TextBox ID="server_slno" runat="server" Style="left: 155px; position: absolute;
        top: 228px" Width="184px" BackColor="Beige" ForeColor="#000000"></asp:TextBox>
    <asp:Label ID="servercpudet" runat="server" Style="left: 9px; position: absolute;
        top: 260px" Text="Server CPU DET" ForeColor="Black" Font-Bold="True" Font-Size="11pt"></asp:Label>
    <asp:TextBox ID="server_cpu_det" runat="server" Style="left: 155px; position: absolute;
        top: 257px" Width="184px" BackColor="Beige" ForeColor="#000000"></asp:TextBox>
    <asp:Label ID="serverram" runat="server" Style="left: 9px; position: absolute;
        top: 290px" Text="Server Ram" ForeColor="Black" Font-Bold="True" Font-Size="11pt"></asp:Label>
    <asp:TextBox ID="server_ram" runat="server" Style="left: 155px; position: absolute;
        top: 287px" Width="184px" BackColor="Beige" ForeColor="#000000"></asp:TextBox>
    <asp:Label ID="serverdisks" runat="server" Style="left: 9px; position: absolute; top: 321px"
        Text="Server Disks" ForeColor="Black" Font-Bold="True" Font-Size="11pt"></asp:Label>
    <asp:TextBox ID="server_disks" runat="server" Style="left: 155px; position: absolute;
        top: 318px" Width="184px" BackColor="Beige" ForeColor="#000000"></asp:TextBox>
    <asp:Label ID="serverpcix" runat="server" Style="left: 9px; position: absolute;
        top: 350px" Text="Server PCI X" BackColor="Transparent" ForeColor="Black" Font-Bold="True" Font-Size="11pt" Height="16px"></asp:Label>
    <asp:TextBox ID="server_pci_x" runat="server" Style="left: 155px; position: absolute;
        top: 347px" Width="184px" BackColor="Beige" ForeColor="#000000"></asp:TextBox>
    <asp:Label ID="serveros" runat="server" Style="left: 9px; position: absolute;
        top: 381px" Text="Server OS" ForeColor="Black" Font-Bold="True" Font-Size="11pt" Height="16px"></asp:Label>
    <asp:TextBox ID="server_os" runat="server" Style="left: 155px; position: absolute;
        top: 378px" Width="184px" BackColor="Beige" ForeColor="#000000"></asp:TextBox>
    <asp:Label ID="serverdbas" runat="server" Height="1px" Style="left: 9px; position: absolute;
        top: 410px" Text="Server DB AS" Width="133px" ForeColor="Black" Font-Bold="True" Font-Size="11pt"></asp:Label>
    <asp:TextBox ID="server_db_as" runat="server" Style="left: 155px; position: absolute;
        top: 407px" Width="184px" BackColor="Beige" ForeColor="#000000"></asp:TextBox>
    <asp:Label ID="serverservhosted" runat="server" Style="left: 9px; position: absolute;
        top: 441px" Text="Server SERV Hosted" ForeColor="Black" Font-Bold="True" Font-Size="11pt"></asp:Label>
    <asp:TextBox ID="server_serv_hosted" runat="server" Style="left: 155px; position: absolute;
        top: 438px" Width="184px" BackColor="Beige" ForeColor="#000000"></asp:TextBox>
         <asp:Label ID="serverapplhosted" runat="server" Style="left: 9px; position: absolute;
        top: 475px" Text="Server APPL Hosted" ForeColor="Black" Font-Bold="True" Font-Size="11pt"></asp:Label>
       <asp:TextBox ID="server_appl_hosted" runat="server" Style="left: 155px; position: absolute;
        top: 472px" Width="184px" BackColor="Beige" ForeColor="#000000"></asp:TextBox>
         <asp:Label ID="servermgmtact" runat="server" Style="left: 355px; position: absolute;
        top: 40px" Text="Server MGMT Act" ForeColor="Black" Font-Bold="True" Font-Size="12pt"></asp:Label>
        <asp:TextBox ID="server_mgmt_act" runat="server" Style="left: 526px; position: absolute;
        top: 38px" Width="240px" BackColor="Beige" ForeColor="#000000"></asp:TextBox>
    <asp:Label ID="servermonitoract" runat="server" Style="left: 355px; position: absolute;
        top: 73px" Text="Server Monitor Act" ForeColor="Black" Font-Bold="True" Font-Size="12pt"></asp:Label>
     <asp:TextBox ID="server_monitor_act" runat="server" Style="left: 526px; position: absolute;
        top: 71px" Width="240px" BackColor="Beige" ForeColor="#000000"></asp:TextBox>
    <asp:Label ID="serverbackplan1date" runat="server" Style="left: 355px; position: absolute;
        top: 105px" Text="Server BCK Plan1 Date                                " ForeColor="Black" Font-Bold="True" Font-Size="12pt"></asp:Label>
    <asp:TextBox ID="server_bck_plan1_dt" runat="server" Style="left: 526px; position: absolute;
        top: 103px" Width="240px" BackColor="Beige" ForeColor="#000000"></asp:TextBox>
    <asp:Label ID="serverbackplan2date" runat="server" Style="left: 355px; position: absolute;
        top: 137px" Text="Server BCK Plan2 Date                                    " ForeColor="Black" Font-Bold="True" Font-Size="12pt"></asp:Label>
    <asp:TextBox ID="server_bck_plan2_dt" runat="server" Style="left: 526px; position: absolute;
        top: 135px" Width="240px" BackColor="Beige" ForeColor="#000000"></asp:TextBox>
        <asp:Label ID="serverprocatno" runat="server" Style="left: 355px; position: absolute;
        top: 169px" Text="Server PROC AT No" ForeColor="Black" Font-Bold="True" Font-Size="12pt"></asp:Label>
        <asp:TextBox ID="server_proc_at_no" runat="server" Style="left: 526px; position: absolute;
        top: 167px" Width="240px" BackColor="Beige" ForeColor="#000000"></asp:TextBox>
  
  
    
    &nbsp; &nbsp;&nbsp;
    <asp:Label ID="serverprocatdt" runat="server" Style="left: 355px; position: absolute;
        top: 199px" Text="Server PROC AT Date" BackColor="Transparent" ForeColor="Black" Font-Bold="True" Font-Size="12pt"></asp:Label>
      <asp:TextBox ID="server_proc_at_dt" runat="server" Style="left: 526px; position: absolute;
        top: 197px" Width="240px" BackColor="Beige" ForeColor="#000000"></asp:TextBox>
        
    <asp:Label ID="serverinstdt" runat="server" Style="left: 355px; position: absolute;
        top: 230px" Text="Server INST Date" ForeColor="Black" Font-Bold="True" Font-Size="12pt"></asp:Label>
    <asp:TextBox ID="server_inst_dt" runat="server" Style="left: 526px; position: absolute;
        top: 228px" Width="240px" BackColor="Beige" ForeColor="#000000"></asp:TextBox>
   
    
   
    &nbsp;
    <asp:Label ID="serverwarrtyexpdate" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="Black"
        Style="left: 355px; position: absolute; top: 259px" Text="Server Warrty Exp Date"></asp:Label>
        <asp:TextBox ID="server_warrty_exp_dt" runat="server" Style="left: 526px; position: absolute;
        top: 257px" Width="240px" BackColor="Beige" ForeColor="#000000"></asp:TextBox>
          <asp:Label ID="serversupplier" runat="server" Style="left: 355px; position: absolute;
        top: 289px" Text="Server Supplier" ForeColor="Black" Font-Bold="True" Font-Size="12pt"></asp:Label>
   
         <asp:TextBox ID="server_supplier" runat="server" Style="left: 526px; position: absolute;
        top: 287px" Width="240px" BackColor="Beige" ForeColor="#000000" OnTextChanged="TextBox31_TextChanged"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" BackColor="GhostWhite" Font-Bold="True" Font-Italic="True"
            Style="left: 3px; position: absolute; top: 1px" Text="Server Master" Width="768px"></asp:Label>
    <asp:Label ID="servermaintagency" runat="server" Style="left: 355px; position: absolute;
        top: 320px" Text="Server Maint Agency" ForeColor="Black" Font-Bold="True" Font-Size="12pt"></asp:Label>
        <asp:TextBox ID="server_maint_agency" runat="server" BackColor="Beige" ForeColor="#000000"
        Style="left: 526px; position: absolute; top: 318px" Width="240px"></asp:TextBox>
    <asp:Label ID="serverlocation" runat="server" Style="left: 355px; position: absolute;
        top: 349px" Text="Server Location" ForeColor="Black" Font-Bold="True" Font-Size="12pt"></asp:Label>    
    <asp:TextBox ID="server_location" runat="server" Style="left: 526px; position: absolute;
        top: 347px" Width="240px" BackColor="Beige" ForeColor="#000000"></asp:TextBox>
    
    <asp:Label ID="serverrackname" runat="server" Style="left: 355px; position: absolute;
        top: 380px" Text="Server Rack Name" ForeColor="Black" Font-Bold="True" Font-Size="12pt"></asp:Label>
    <asp:TextBox ID="server_rack_name" runat="server" Style="left: 526px; position: absolute;
        top: 378px" Width="240px" BackColor="Beige" ForeColor="#000000"></asp:TextBox>
    <asp:Label ID="serverrackposition" runat="server" Style="left: 355px; position: absolute;
        top: 409px" Text="Server Rack Position" ForeColor="Black" Font-Bold="True" Font-Size="12pt"></asp:Label>
    <asp:TextBox ID="server_rack_position" runat="server" Style="left: 526px; position: absolute;
        top: 407px" Width="240px" BackColor="Beige" ForeColor="#000000" CausesValidation="True"></asp:TextBox>
        <asp:Label ID="serverresponsibility" runat="server" Style="left: 355px; position: absolute;
        top: 440px" Text="Server Responsibility" ForeColor="Black" Font-Bold="True" Font-Size="12pt"></asp:Label>
    <asp:TextBox ID="server_responsibility" runat="server" Style="left: 526px; position: absolute;
        top: 438px" Width="240px" BackColor="Beige" ForeColor="#000000"  OnTextChanged="server_responsibility_TextChanged"></asp:TextBox>
    <asp:Label ID="serverremarks" runat="server" Font-Bold="True" ForeColor="Black"
        Style="left: 355px; position: absolute; top: 474px" Text="Server Remarks" Font-Size="12pt"></asp:Label>
    <asp:TextBox ID="server_remarks" runat="server" Font-Bold="False" Style="left: 526px;
        position: absolute; top: 472px" Width="240px" BackColor="Beige" ForeColor="#000000"></asp:TextBox>
     
    <asp:Button ID="server_bck_plan1_date" runat="server" BackColor="Beige" ForeColor="#000000"
        OnClick="server_bck_plan1_date_Click" Style="left: 776px; position: absolute; top: 104px" Text=".."
        Width="24px" />
    <asp:Button ID="server_bck_plan2_date" runat="server" BackColor="Beige" ForeColor="#000000"
        OnClick="server_bck_plan2_date_Click" Style="left: 778px; position: absolute;
        top: 134px" Text=".." Width="24px"  />
    <asp:Button ID="server_proc_at_date" runat="server" BackColor="Beige" ForeColor="#000000"
        OnClick="server_proc_at_date_Click1" Style="left: 777px; position: absolute; top: 196px"
        Text=".." Width="24px" />
    <asp:Button ID="server_inst_date" runat="server" BackColor="Beige" ForeColor="#000000"
        OnClick="server_inst_date_Click" Style="left: 776px; position: absolute; top: 226px" Text=".."
        Width="24px" />
    <asp:Button ID="server_warrty_exp_date" runat="server" BackColor="Beige" ForeColor="#000000"
        OnClick="server_warrty_exp_date_Click" Style="left: 778px; position: absolute; top: 256px" Text=".."
        Width="24px" />
    <asp:Calendar ID="Calendar_bck_plan1_date" runat="server" BackColor="Beige" OnSelectionChanged="Calendar_bck_plan1_date_SelectionChanged" Style="left: 553px; position: absolute; top: 125px"
        Visible="False" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#000000" Height="200px" ShowGridLines="True" Width="220px">
        <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
        <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
        <SelectorStyle BackColor="#FFCC66" />
        <OtherMonthDayStyle ForeColor="#CC9966" />
        <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
        <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
        <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
    </asp:Calendar>
    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="server_rack_position"
        ErrorMessage="u must enter rack position as number" MaximumValue="999999" MinimumValue="0"
        Style="left: 773px; position: absolute; top: 397px" Type="Integer" Width="119px"></asp:RangeValidator>
<asp:Calendar ID="Calendar_bck_plan2_date" runat="server" BackColor="Beige" OnSelectionChanged="Calendar_bck_plan2_date_SelectionChanged" Style="left: 554px; position: absolute; top: 158px"
        Visible="False" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px">
        <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
        <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
        <SelectorStyle BackColor="#FFCC66" />
        <OtherMonthDayStyle ForeColor="#CC9966" />
        <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
        <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
        <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
    </asp:Calendar>
    <asp:Calendar ID="Calendar_proc_at_date" runat="server" BackColor="Beige" OnSelectionChanged="Calendar_proc_at_date_SelectionChanged" Style="left: 552px; position: absolute; top: 217px"
        Visible="False" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px">
        <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
        <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
        <SelectorStyle BackColor="#FFCC66" />
        <OtherMonthDayStyle ForeColor="#CC9966" />
        <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
        <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
        <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
    </asp:Calendar>
    <asp:Calendar ID="Calendar_inst_date" runat="server" BackColor="Beige" OnSelectionChanged="Calendar_inst_date_SelectionChanged" Style="left: 551px; position: absolute; top: 251px"
        Visible="False" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px">
        <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
        <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
        <SelectorStyle BackColor="#FFCC66" />
        <OtherMonthDayStyle ForeColor="#CC9966" />
        <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
        <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
        <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
    </asp:Calendar>
    <asp:Calendar ID="Calendar_warrty_exp_date" runat="server" BackColor="Beige" OnSelectionChanged="Calendar_warrty_exp_date_SelectionChanged" Style="left: 555px; position: absolute; top: 285px"
        Visible="False" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px">
        <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
        <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
        <SelectorStyle BackColor="#FFCC66" />
        <OtherMonthDayStyle ForeColor="#CC9966" />
        <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
        <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
        <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
    </asp:Calendar>
    <asp:Button ID="save" runat="server" BackColor="Beige" Font-Bold="True" Font-Size="12pt"
        OnClick="save_Click" Style="left: 7px; position: absolute; top: 522px" Text="Save" />
    &nbsp;
    <asp:Button ID="query" runat="server" BackColor="Beige" Font-Bold="True" Font-Size="12pt"
        OnClick="query_Click" Style="left: 81px; position: absolute; top: 521px" Text="Query" />
    &nbsp;
    <asp:Button ID="update" runat="server" BackColor="Beige" Font-Bold="True" Font-Size="12pt"
        OnClick="update_Click" Style="left: 167px; position: absolute; top: 522px" Text="Update" />
    <asp:Button ID="clear" runat="server" BackColor="Beige" Font-Bold="True" Font-Size="12pt"
        OnClick="clear_Click" Style="left: 267px; position: absolute; top: 522px" Text="Clear" />
   
        
    </asp:Panel>
    &nbsp; &nbsp;
   
    &nbsp;&nbsp;
    <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 171px;
        position: absolute; top: 194px" Text="Label" Visible="False" Width="806px"></asp:Label>
    
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    &nbsp;&nbsp;&nbsp; &nbsp; &nbsp;
   
    
  
    &nbsp;
     
    
    
</asp:Content>

    
    
