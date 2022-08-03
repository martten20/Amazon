<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pinfo.aspx.cs" Inherits="SDAProject.Pinfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
        <head runat="server">
            <title></title>
            <style>
                    .topnav {
                        overflow: hidden;
                        background-color: #e9e9e9;
                    }
                    .button_header:hover {
                      background-color: #ddd;
                      color: black;
                    }
                    
                    .button_header{
                      background-color:#e9e9e9;
                      float: left;
                     
                      color: black;
                      text-align: center;
                      padding: 14px 16px;
                      
                      font-size: 17px;
                      border:none;
                    }
                    .button_header_active{
                      float: left;
                      background-color: #2196F3;
                      color: white;
                      text-align: center;
                      padding: 14px 16px;
                      font-size: 17px;
                      border:none;
                    }
                    h1{
                        font-family: 'Yu Gothic UI Light';
                    }
                    div {
                      border-radius: 5px;
                      background-color: #f2f2f2;
                      margin-bottom: 22px;
                    }

                    input[type=text]{
                      width: 100%;
                      padding: 12px 20px;
                      margin: 8px 0;
                      display: inline-block;
                      border: 1px solid #ccc;
                      border-radius: 4px;
                      box-sizing: border-box;
                      font-family: 'Yu Gothic UI Light';
                    }

                     input[type=number]{
                      width: 100%;
                      padding: 12px 20px;
                      margin: 8px 0;
                      border: 1px solid #ccc;
                      border-radius: 4px; 
                      font-family: 'Yu Gothic UI Light';
                    }


                    .button_submit {
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
        <body style="background-color:#f2f2f2;">
               <h1 style="font-family: 'Yu Gothic UI Light'; font-size: xx-large; text-transform: uppercase; color: #000000; font-weight: 200">
                E-commerce
               </h1>  
            <form id="form1" runat="server">
                            <div class="topnav">
                                        <asp:Button CssClass="button_header" ID="Button2" runat="server" Text="Home" OnClick="Button2_Click1" />
                                         <asp:Button CssClass="button_header_active" ID="Button3" runat="server" Text="MyAccount"/>
                                        <asp:Button CssClass="button_header" ID="Button6" runat="server" Text="Contact Us" OnClick="Button6_Click"/>
                                        <asp:Button CssClass="button_header" ID="Button1" runat="server" Text="MyCart" OnClick="Button1_Click1"  />
                            </div>
                         <div style="padding-top:20px;">
                                      <asp:Label ID="Label1" runat="server" Text="Adress"></asp:Label>
                                      <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                      <asp:Label ID="Label2" runat="server" Text="Area"></asp:Label>
                                      <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                      <asp:Label ID="Label3" runat="server" Text="Number"></asp:Label>
                                      <asp:TextBox ID="TextBox3" runat="server" type="number"></asp:TextBox>
                                     <asp:Button ID="Button4" CssClass =" button_submit " runat="server" Text="View" style="width:100%" OnClick="Button2_Click" />
                                     <asp:Button ID="Button5" CssClass="button_submit " runat="server" Text="Update" style="width:100%" OnClick="Button1_Click" />
                        </div>
            </form>
        </body>
</html>
