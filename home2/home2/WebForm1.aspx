<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="home2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class=" mb-3">

                <label for="exampleInputForm" class="form-label">ID</label>
                <asp:TextBox runat="server" ID="BookID" aria-describedby="emailHelp" class="form-constrol"></asp:TextBox>
                <asp:Button runat="server" ID="addBook" Text="Add Book" OnClick="addbook_click" />

            </div>
        </div>
    </form>
</body>
</html>
