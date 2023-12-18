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
            <asp:gridview id="GridView1" runat="server" autogeneratecolumns="False" DataKeyNames="userNo, userName, userAge" OnRowDeleting="GridView1_RowDeleting" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowUpdating="GridView1_RowUpdating" emptydatatext="There are no data records to display." OnRowEditing="GridView1_RowEditing" OnRowCommand="GridView1_RowCommand">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:TemplateField HeaderText="번호" SortExpression="userNo">
                        <EditItemTemplate>
                            <asp:Label ID="lblUserNo" runat="server" Text='<%# Eval("userNo") %>'></asp:Label>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("userNo") %>'></asp:Label>
                        </ItemTemplate>
                        <HeaderStyle Width="60px" />
                        <ItemStyle HorizontalAlign="Center" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="이름" SortExpression="userName">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtUserName" runat="server" Text='<%# Bind("userName") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblUserName" runat="server" Text='<%# Bind("userName") %>'></asp:Label>
                        </ItemTemplate>
                        <HeaderStyle Width="70px" />
                        <ItemStyle HorizontalAlign="Center" />
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="나이" SortExpression="userAge">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtUserAge" runat="server" Text='<%# Bind("userAge") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblUserAge" runat="server" Text='<%# Bind("userAge") %>'></asp:Label>
                        </ItemTemplate>
                        <HeaderStyle Width="30px" />
                        <ItemStyle HorizontalAlign="Center" />
                    </asp:TemplateField>
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <EmptyDataTemplate>
                    등록된 사용자가 없습니다.
                </EmptyDataTemplate>
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#F7F6F3" ForeColor="#333333" />

                <Columns>
                    <asp:TemplateField HeaderText="수정" ShowHeader="True">
                        <EditItemTemplate>
                            <asp:Button ID="btnUpdate" runat="server" Text="저장" CommandName="Update" />
                            <asp:Button ID="btnCancel" runat="server" Text="취소" CommandName="Cancel" />
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Button ID="btnEdit" runat="server" Text="수정" CommandName="Edit" />
                            <asp:Button ID="btnDelete" runat="server" Text="삭제" CommandName="Delete" />
                        </ItemTemplate>
                        <FooterTemplate>
                            <asp:Button ID="btnAdd" runat="server" Text="추가" CommandName="Add" />
                        </FooterTemplate>
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#F7F6F3" ForeColor="#333333" />
            </asp:gridview>

            <div style="margin-top: 10px;">
                <asp:Button ID="btnAdd" runat="server" Text="추가" CommandName="Add" />
            </div>
        </div>
    </form>
</body>
</html>
