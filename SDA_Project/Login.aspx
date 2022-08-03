<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SDAProject.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    


    <title></title>
        <style>
            h1{
                font-family: 'Yu Gothic UI Light';


            }
            div {
              border-radius: 5px;
              background-color: #f2f2f2;
              margin-bottom: 22px;
        }

            input[type=text], select,textarea {
              width: 100%;
              padding: 12px 20px;
              margin: 8px 0;
              display: inline-block;
              border: 1px solid #ccc;
              border-radius: 4px;
              font-family: 'Yu Gothic UI Light';
            }
            input[type=password], select,textarea {
              width: 100%;
              padding: 12px 20px;
              margin: 8px 0;
              display: inline-block;
              border: 1px solid #ccc;
              border-radius: 4px;
              font-family: 'Yu Gothic UI Light';
            }


            input[type=submit] {
              border-style: none;
              background-color: #2196F3;
              color: white;
              padding: 14px 20px;
              margin: 8px 0;
              border-radius: 4px;
              cursor: pointer;
              font-family: 'Yu Gothic UI Light';
            }
    </style>
</head>
 
<body style="background-color:#f2f2f2; padding-top:10%">

         <h1 style="font-family: 'Yu Gothic UI Light'; font-size: xx-large; text-transform: uppercase; color: #000000; font-weight: 200;text-align:center;">
                            E-commerce
         </h1>  
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            <asp:TextBox  type="password" ID="TextBox2" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Sign in "  style="width:100%" OnClick="Button1_Click"/>
            <asp:Button ID="google"  runat="server" Text="Sign in With GOOGLE "  OnClick="google_Click1"/>  
        </div>

    </form>
</body>
</html>
