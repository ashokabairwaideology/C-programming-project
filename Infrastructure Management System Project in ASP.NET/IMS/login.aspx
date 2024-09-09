<%@ page language="C#" autoeventwireup="true" inherits="login, App_Web_kme17h35" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <script language="javascript">window.name="DefaultPage"</script>
</head>
<body bgcolor="black">
    <form id="form1" runat="server" target="DefaultPage">
    <div >
        &nbsp; &nbsp;&nbsp;&nbsp;
        <asp:Panel ID="Panel1" runat="server" BackColor="Snow" Height="247px" Style="left: 244px;
            position: absolute; top: 119px" Width="469px" BorderStyle="Solid" BorderColor="#0000C0">
            <asp:Label ID="Label1" runat="server" Style="left: 29px; position: absolute; top: 80px"
                Text="User ID" Font-Bold="True"></asp:Label>
            <asp:Label ID="Label2" runat="server" Style="left: 29px; position: absolute; top: 130px"
                Text="Password" Font-Bold="True"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Style="left: 168px; position: absolute;
                top: 78px" ForeColor="#000000" Width="160px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" Style="left: 168px; position: absolute;
                top: 128px" TextMode="Password" ForeColor="#000000" Width="160px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click"  Style="left: 173px;
                position: absolute; top: 209px" Text="Submit" Font-Bold="True" />
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            &nbsp;&nbsp; <strong><span style="font-size: 14pt">Login
                <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="Red" Style="left: 6px;
                position: absolute; top: 172px" Text="Label" Visible="False" Width="459px"></asp:Label>
            </span></strong></asp:Panel>
        &nbsp;
   
    </div>
       
    </form>
</body>
</html>
