<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASP.NET_Programing.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
   
    <form id="form1" runat="server"> 
        <div id="title">
            <asp:Label ID="Label1" Text="ASP.NET 게시판" runat="server" />
        </div>
        <div>
            <asp:gridview id="GridView1" runat="server" autogeneratecolumns="False" 
                datasourceid="SqlDataSource1" emptydatatext="There are no data records to display.">
                <%--      
                <columns>
                    <asp:boundfield datafield="userNo" headertext="userNo" readonly="True" 
                        sortexpression="userNo" />
                    <asp:boundfield datafield="usrName" headertext="usrName" sortexpression="usrName" />
                    <asp:boundfield datafield="userAge" headertext="userAge" sortexpression="userAge" />
                </columns>
                --%>

                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField DataField="userNo" HeaderText="번호">
                        <HeaderStyle Width="60px" />
                        <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>

                    <asp:BoundField DataField="userName" HeaderText="이름">
                        <HeaderStyle Width="70px" />
                        <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>

                    <asp:BoundField DataField="userAge" HeaderText="나이">
                        <HeaderStyle Width="30px" />
                        <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <EmptyDataTemplate>
                    등록된 사용자가 없습니다.
                </EmptyDataTemplate>
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#F7F6F3" ForeColor="#333333" />
            </asp:gridview>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:webboardConnectionString %>" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [user]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
