<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reg.aspx.cs" Inherits="SDAProject.Reg" %>

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
                          box-sizing: border-box;
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
                         input[type=number], select,textarea {
                          width: 100%;
                          padding: 12px 20px;
                          margin: 8px 0;
                          display: inline-block;
                          border: 1px solid #ccc;
                          border-radius: 4px;
             
                          font-family: 'Yu Gothic UI Light';
                        }


                        input[type=submit] {
                          border-color: inherit;
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
                                 <h1 style="font-family: 'Yu Gothic UI Light'; font-size: xx-large; text-transform: uppercase; color: #000000; font-weight: 200;text-align:center;">
                                                    E-commerce
                                 </h1> 
                                <form id="form1" runat="server">
                                                <div>
                                                                    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                                                                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                                                     
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" style=" float:right ;"  runat="server"  ControlToValidate="TextBox1" ErrorMessage="Fill Name"></asp:RequiredFieldValidator>
                                                                   
                                                                <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                                                                    <asp:TextBox  type="password" ID="TextBox2" runat="server"></asp:TextBox>

                                                                    <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
                                                                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

                                                                     <asp:Label ID="Label4" runat="server" Text="Address"></asp:Label>
                                                                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>

                                                                    <asp:Label ID="Label5" runat="server" Text="Area"></asp:Label>
                                                                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>

                                                                    <asp:Label ID="Label6" runat="server" Text="Mobile"></asp:Label>
                                                                    <asp:TextBox type ="number" ID="TextBox6" runat="server" style="width:100%"></asp:TextBox>
                                                                    

                                                                    <asp:Button ID="Button1" runat="server" Text="SignUp" style="width:100%" OnClick="Button1_Click"/>
                                                                    <asp:Button ID="google" runat="server" Text="Sign UP With GOOGLE " OnClick="google_Click1"/>
                                                </div>
                                </form>
            </body>
</html>
