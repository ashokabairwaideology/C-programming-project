<%@ Page Language="C#" MasterPageFile="~/Home.master" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1" bgcolor="#FFCCFF" style="width: 96%">
    <tr>
        <td bgcolor="White" colspan="2" style="font-size: 23px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label 
                ID="Label16" runat="server" 
                ForeColor="#CC00FF" 
                style="color: #6600FF; font-size: xx-large; font-family: Harrington; font-style: italic; font-weight: 700; text-transform: uppercase; letter-spacing: 1pt;" 
                Text="REGISTRATION FORM"></asp:Label>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server" Text="FirstName:" ToolTip="        "></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txt_firstname" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="refval1" runat="server" 
                ControlToValidate="txt_firstname" Text="*" ValidationGroup="submit" ></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label2" runat="server" Text="LastName"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txt_lastname" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="txt_lastname" Text="*" ValidationGroup="submit" ></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label3" runat="server" Text="UserName:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txt_username" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                ControlToValidate="txt_username" ErrorMessage="User Name Must not Be Blank" 
                ValidationGroup="chechavbl">*</asp:RequiredFieldValidator>
            <asp:Label ID="lbl_exist" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                Text="Check Avaliabilty" ValidationGroup="chechavbl" />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                ShowMessageBox="True" ShowSummary="False" ValidationGroup="chechavbl" />
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label4" runat="server" Text="Password:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txt_pswd" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ControlToValidate="txt_pswd" Text="*" ValidationGroup="submit" ></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" 
                ControlToCompare="txt_pswd" ControlToValidate="txt_confrmpswd" 
                ErrorMessage="Not match" ValidationGroup="submit"></asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label5" runat="server" Text="Confirm Password:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txt_confrmpswd" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                ControlToValidate="txt_confrmpswd" Text="*" ValidationGroup="submit" ></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label6" runat="server" Text="EmailId:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txt_Emailid" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                ControlToValidate="txt_Emailid" Text="*" ValidationGroup="submit" ></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label7" runat="server" Text="Alternate Emailid:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txt_confmemail" runat="server" style="margin-bottom: 0px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label8" runat="server" Text="Gender:"></asp:Label>
        </td>
        <td>
            <asp:RadioButtonList ID="rad_gender" runat="server" Height="38px" Width="122px">
            
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label9" runat="server" Text="MaritalStatus:"></asp:Label>
        </td>
        <td>
            <asp:RadioButtonList ID="rdo_ms" runat="server" Width="140px">
                <asp:ListItem>single</asp:ListItem>
                <asp:ListItem>Married</asp:ListItem>
            </asp:RadioButtonList>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label10" runat="server" Text="DataOfBirth:"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddl_dd" runat="server">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>9</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>11</asp:ListItem>
                <asp:ListItem>12</asp:ListItem>
                <asp:ListItem>13</asp:ListItem>
                <asp:ListItem>14</asp:ListItem>
                <asp:ListItem>15</asp:ListItem>
                <asp:ListItem>16</asp:ListItem>
                <asp:ListItem>17</asp:ListItem>
                <asp:ListItem>18</asp:ListItem>
                <asp:ListItem>19</asp:ListItem>
                <asp:ListItem>20</asp:ListItem>
                <asp:ListItem>21</asp:ListItem>
                <asp:ListItem>22</asp:ListItem>
                <asp:ListItem>23</asp:ListItem>
                <asp:ListItem>24</asp:ListItem>
                <asp:ListItem>25</asp:ListItem>
                <asp:ListItem>26</asp:ListItem>
                <asp:ListItem>27</asp:ListItem>
                <asp:ListItem>28</asp:ListItem>
                <asp:ListItem>29</asp:ListItem>
                <asp:ListItem>30</asp:ListItem>
                <asp:ListItem>31</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="ddl_mm" runat="server">
                <asp:ListItem>January</asp:ListItem>
                <asp:ListItem>Febraury</asp:ListItem>
                <asp:ListItem>March</asp:ListItem>
                <asp:ListItem>April</asp:ListItem>
                <asp:ListItem>May</asp:ListItem>
                <asp:ListItem>June</asp:ListItem>
                <asp:ListItem>July</asp:ListItem>
                <asp:ListItem>August</asp:ListItem>
                <asp:ListItem>September</asp:ListItem>
                <asp:ListItem>October</asp:ListItem>
                <asp:ListItem>November</asp:ListItem>
                <asp:ListItem>December</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="ddl_yr" runat="server">
                <asp:ListItem>1991</asp:ListItem>
                <asp:ListItem>1992</asp:ListItem>
                <asp:ListItem>1993</asp:ListItem>
                <asp:ListItem>1994</asp:ListItem>
                <asp:ListItem>1995</asp:ListItem>
                <asp:ListItem>1996</asp:ListItem>
                <asp:ListItem>1997</asp:ListItem>
                <asp:ListItem>1998</asp:ListItem>
                <asp:ListItem>1999</asp:ListItem>
                <asp:ListItem>2000</asp:ListItem>
                <asp:ListItem>2001</asp:ListItem>
                <asp:ListItem>2002</asp:ListItem>
                <asp:ListItem>2003</asp:ListItem>
                <asp:ListItem>2004</asp:ListItem>
                <asp:ListItem>2005</asp:ListItem>
                <asp:ListItem>2006</asp:ListItem>
                <asp:ListItem>2007</asp:ListItem>
                <asp:ListItem>2008</asp:ListItem>
                <asp:ListItem>2009</asp:ListItem>
                <asp:ListItem>2010</asp:ListItem>
                <asp:ListItem>2011</asp:ListItem>
                <asp:ListItem>2012</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label11" runat="server" Text="PhoneNo:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txt_phno" runat="server" Height="28px" Width="130px"></asp:TextBox>
            
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label12" runat="server" Text="Hint Question:"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddl_hintq" runat="server">
           
                <asp:ListItem>what is your first phone number?</asp:ListItem>
                <asp:ListItem>what is your first class teacher name?</asp:ListItem>
                <asp:ListItem>who is your best friend?</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label13" runat="server" Text="Hint Answer:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txt_hinta" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                ControlToValidate="txt_hinta" Text="*" ValidationGroup="submit" ></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            City</td>
        <td>
            <asp:DropDownList ID="ddl_city" runat="server" 
                style="height: 22px; width: 77px">
                <asp:ListItem>Hyderabad</asp:ListItem>
                <asp:ListItem>Banglore</asp:ListItem>
                <asp:ListItem>pune</asp:ListItem>
                <asp:ListItem>chennai</asp:ListItem>
                <asp:ListItem>Jaipur</asp:ListItem>
                <asp:ListItem>Mysore</asp:ListItem>
                <asp:ListItem>Mumbai</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            State:</td>
        <td>
            <asp:DropDownList ID="ddl_state" runat="server" Height="16px">
                <asp:ListItem>AndhraPradesh</asp:ListItem>
                <asp:ListItem>Tamilnadu</asp:ListItem>
                <asp:ListItem>Karnataka</asp:ListItem>
                <asp:ListItem>Bihar</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            Upload</td>
        <td>
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </td>
    </tr>
    <tr>
        <td colspan="2">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_register" runat="server" onclick="btn_register_Click" 
                Text="SUBMIT" ValidationGroup="submit" Height="25px" 
                style="font-size: large; font-weight: 700" Width="94px" />
        </td>
    </tr>
</table>
</asp:Content>

