<%@ page language="C#" masterpagefile="~/MasterPage.master" autoeventwireup="true" inherits="Default4, App_Web_9kv_mbjt" title="Untitled Page" %>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">

    
         <asp:Panel ID="Panel1" runat="server" BackColor="#6699FF" Height="484px" Style="position: relative;
        top: 27px; left: 1px;" Width="153px" ForeColor="#3366FF">
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
    <asp:Panel ID="Panel2" runat="server" Height="464px" Style="left: 174px; position: absolute;
        top: 245px" Width="664px" BackColor="GhostWhite">
     <asp:Label ID="cartlabel" runat="server" Style="left: 23px; position: absolute;
        top: 52px" Text="Cartridge Label" Font-Bold="True" Font-Size="12pt"></asp:Label>
    <asp:TextBox ID="cart_label" runat="server" Style="left: 202px; position: absolute;
        top: 50px" BackColor="Beige" ForeColor="Black" Width="416px"></asp:TextBox>
    <asp:Label ID="cartmake" runat="server" Style="left: 23px; position: absolute;
        top: 85px" Text="Cartridge Make" Font-Bold="True" Font-Size="12pt"></asp:Label>
    <asp:TextBox ID="cart_make" runat="server" Style="left: 202px; position: absolute;
        top: 83px" BackColor="Beige" ForeColor="Black" Width="416px"></asp:TextBox>
    <asp:Label ID="cart_type" runat="server" Style="left: 23px; position: absolute;
        top: 118px" Text="Cartridge Type" Font-Bold="True" Font-Size="12pt"></asp:Label>
      <asp:DropDownList ID="cart_type_list" runat="server" BackColor="Beige" ForeColor="Black"
        Style="left: 202px; position: absolute; top: 116px" Width="416px" OnSelectedIndexChanged="cart_type_list_SelectedIndexChanged">
        <asp:ListItem>3590</asp:ListItem>
        <asp:ListItem>LTOU3</asp:ListItem>
        <asp:ListItem>DAT72</asp:ListItem>
        <asp:ListItem>DLTIV</asp:ListItem>
        <asp:ListItem>DDS3</asp:ListItem>
    </asp:DropDownList>  
        
    &nbsp;
    <asp:Label ID="cartcapacity" runat="server" Style="left: 23px; position: absolute;
        top: 151px" Text="Cartridge Capacity" Font-Bold="True" Font-Size="12pt"></asp:Label>
    <asp:TextBox ID="cart_capacity" runat="server" Style="left: 202px; position: absolute;
        top: 149px" BackColor="Beige" ForeColor="Black" Width="416px"></asp:TextBox>
       <asp:Label ID="cartpurpose" runat="server" Font-Bold="True" Style="left: 23px;
        position: absolute; top: 184px" Text="Cartridge Purpose" Font-Size="12pt"></asp:Label>
    <asp:TextBox ID="cart_purpose" runat="server" BackColor="Beige" Style="left: 202px;
        position: absolute; top: 182px" ForeColor="Black" Width="416px"></asp:TextBox>
        
    <asp:Label ID="cartlocation" runat="server" Style="left: 23px; position: absolute;
        top: 217px" Text="Cartridge Location" Font-Bold="True" Font-Size="12pt"></asp:Label>
    <asp:TextBox ID="cart_location" runat="server" Style="left: 202px; position: absolute;
        top: 215px" BackColor="Beige" ForeColor="Black" Width="416px"></asp:TextBox> 
    <asp:Label ID="cartstatus" runat="server" Style="left: 23px; position: absolute;
        top: 250px" Text="Cartdridge Status" Font-Bold="True" Font-Size="12pt"></asp:Label>
    <asp:TextBox ID="cart_status" runat="server" Style="left: 202px; position: absolute;
        top: 248px" BackColor="Beige" ForeColor="Black" Width="416px"></asp:TextBox>
    <asp:Label ID="cartinitlabeldate" runat="server" Style="left: 23px; position: absolute;
        top: 285px" Text="Cartridge Init Label Date" Font-Bold="True" Font-Size="12pt"></asp:Label>
    <asp:TextBox ID="cart_init_label_date" runat="server" Style="left: 202px; position: absolute;
        top: 283px" BackColor="Beige" ForeColor="Black" Width="416px"></asp:TextBox>
    <asp:Label ID="cartcloseddate" runat="server" Style="left: 23px; position: absolute;
        top: 315px" Text="Cartridge Closed Date" Font-Bold="True" Font-Size="12pt"></asp:Label>
    <asp:TextBox ID="cart_closed_date" runat="server" Style="left: 202px; position: absolute;
        top: 313px" BackColor="Beige" ForeColor="Black" Width="416px"></asp:TextBox>
    <asp:Label ID="cartcontents" runat="server" Height="4px" Style="left: 23px; position: absolute;
        top: 349px" Text="Cartridge Contents" Font-Bold="True" Font-Size="12pt"></asp:Label>
    <asp:TextBox ID="cart_contents" runat="server" Style="left: 202px; position: absolute;
        top: 347px" BackColor="Beige" ForeColor="Black" Width="416px"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" BackColor="GhostWhite" Font-Bold="True" Font-Italic="True"
            Style="left: 3px; position: absolute; top: 2px" Text="Server Cartridges" Width="659px"></asp:Label>
         <asp:Label ID="cartremarks" runat="server" Height="9px" Style="left: 23px; position: absolute;
        top: 384px" Text="Remarks" Font-Bold="True" Font-Size="12pt"></asp:Label>
    <asp:TextBox ID="remarks" runat="server" Style="left: 202px; position: absolute;
        top: 382px" BackColor="Beige" ForeColor="Black" Width="416px"></asp:TextBox>
    <asp:Button ID="cartridge_init_label_dt" runat="server" BackColor="Beige" ForeColor="Black"
        OnClick="cartridge_init_label_dt_Click" Style="left: 634px; position: absolute;
        top: 282px" Text=".." Width="24px" />
    <asp:Button ID="cartridge_closed_dt" runat="server" BackColor="Beige" ForeColor="Black"
        OnClick="cartridge_closed_dt_Click" Style="left: 634px; position: absolute; top: 312px"
        Text=".." Width="24px" /> 
        <asp:Calendar ID="Calendar1" runat="server" BackColor="Beige" OnSelectionChanged="Calendar1_SelectionChanged" Style="left: 407px; position: absolute; top: 306px"
        Visible="False" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px">
        <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
        <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
        <SelectorStyle BackColor="#FFCC66" />
        <OtherMonthDayStyle ForeColor="#CC9966" />
        <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
        <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
        <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
    </asp:Calendar>
    <asp:Calendar ID="Calendar2" runat="server" BackColor="Beige" OnSelectionChanged="Calendar2_SelectionChanged" Style="left: 409px; position: absolute; top: 340px"
        Visible="False" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px">
        <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
        <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
        <SelectorStyle BackColor="#FFCC66" />
        <OtherMonthDayStyle ForeColor="#CC9966" />
        <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
        <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
        <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
    </asp:Calendar>
    <asp:Button ID="Button3" runat="server" BackColor="Beige" Font-Bold="True" Font-Size="12pt"
        OnClick="Button3_Click" Style="left: 11px; position: absolute; top: 432px" Text="Save" />
    <asp:Button ID="query" runat="server" BackColor="Beige" Font-Bold="True" Font-Size="12pt"
        OnClick="query_Click" Style="left: 84px; position: absolute; top: 434px" Text="Query" />
    <asp:Button ID="update" runat="server" BackColor="Beige" Font-Bold="True" Font-Size="12pt"
        OnClick="update_Click" Style="left: 168px; position: absolute; top: 432px" Text="Update" />
    <asp:Button ID="clear" runat="server" BackColor="Beige" Font-Bold="True" Font-Size="12pt"
        OnClick="clear_Click" Style="left: 270px; position: absolute; top: 430px" Text="Clear" />  
    </asp:Panel>
    <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 178px;
        position: absolute; top: 216px" Text="Label" Visible="False" Width="813px"></asp:Label>

    
    
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    
    
   
    
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

