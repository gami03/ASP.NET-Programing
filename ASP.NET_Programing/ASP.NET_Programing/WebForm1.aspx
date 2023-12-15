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
            <asp:gridview id="GridView1" runat="server" autogeneratecolumns="False" emptydatatext="There are no data records to display.">

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

                <columns>
                    <asp:commandfield buttontype="Button" showeditbutton="true" showheader="true" headertext="수정" />
                    <asp:commandfield buttontype="Button" showdeletebutton="true" showheader="true" headertext="삭제" />

                </columns>
            </asp:gridview>
            <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" OnSelecting="SqlDataSource1_Selecting" />--%>
        </div>
    </form>
</body>
</html>
