<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeptStdView.aspx.cs" Inherits="StudentManagementApp_WebForm.UI.DeptStdView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table>
        <tr>
            <td>
                Depertment
            </td>
            <td>
                <asp:DropDownList runat="server" ID="codeDropDownList"/>
            </td>
        </tr>
          <tr>
            <td> <asp:Button runat="server" ID="Button1" OnClick="btnSave_OnClick" Text="Show"/></td>
        </tr>
        
        <tr>
           <td>
              Reg No
           </td>
            <td>
                <asp:DropDownList runat="server" ID="regNoDropDownList"/>
                                    
            </td>
        </tr>   
         <tr>
            <td> <asp:Button runat="server" ID="Button2" OnClick="btnShow_OnClick" Text="Shudent Show"/></td>
        </tr>  
        <tr>
            <td>
                Name
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtName" ></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
                Email
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtEmail" ></asp:TextBox>
            </td>
        </tr>             
        
    </table>
    </div>
    </form>
</body>
</html>
