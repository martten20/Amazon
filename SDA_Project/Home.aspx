<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="SDAProject.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>ecomerce</title>
                <style>

                            .topnav {
                                    overflow: hidden;
                                    background-color: #e9e9e9;
                            }

                            .topnav a {
                                    float: left;
                                    display: block;
                                    color: black;
                                    text-align: center;
                                    padding: 14px 16px;
                                    font-size: 17px;
                            }

                            .topnav a:hover {
                                    background-color: #ddd;
                                    color: black;
                            }
                            .button_header:hover {
                                    background-color: #ddd;
                                    color: black;
                            }
                            .button_header{
                                    background-color:#e9e9e9;
                                    float: left;
                                    display: block;
                                    color: black;
                                    text-align: center;
                                    padding: 14px 16px;
                                    text-decoration: none;
                                    font-size: 17px;
                                    border:none;
                            }
                            .button_search{
                                    background-color:#e9e9e9;
                                    float: right;
                                    display: block;
                                    color: black;
                                    text-align: center;
                                    padding: 14px 16px;
                                    text-decoration: none;
                                    font-size: 17px;
                                    border:none;
                            }
                            .button_search:hover {
                                    background-color: #ddd;
                                    color: black;
                            }



                            .topnav a.active {
                                    background-color: #2196F3;
                                    color: white;
                            }

                            .topnav .search-container {
                                        float: right;
                            }

                            .topnav input[type=text] {
                                        padding: 6px;
                                        margin-top: 8px;
                                        font-size: 17px;
                                        display: inline-block;
                                        border: 1px solid #ccc;
                                        border-radius: 4px;
                                        font-family: 'Yu Gothic UI Light';
                            }

                            .card {
                                        background-color:white;
                                        height:500px;
                                        width: 350px;
                                        padding:10px;
                                        border:solid;
                                        border-color:#f2f2f2;
                                        border-radius:15px;
                                        text-align: center;
                                        font-family:'Yu Gothic UI Light';
                                        float:left;
           
                            }
                            .img{
                                        width:200px;
                                        height:55%;
                            }
       
                            .price {
                                        color: grey;
                                        font-size: 17px;
                            }
                            .CardName{
                                        color:black;
                                        font-size:25px;
                            }
                            .button_card:hover {
                                        opacity: 0.7;
                            }
                            .button_card{
                                        width:100%;
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

      <body  style="background-color:#f2f2f2;">
          
          <h1 style="font-family: 'Yu Gothic UI Light'; font-size: xx-large; text-transform: uppercase; color: #000000; font-weight: 200">
            E-commerce
           </h1>  
              <form id="form1" runat="server">
       
                            <div class="topnav">
                                                <a class="active">Home</a>
                                                <asp:Button CssClass="button_header" ID="Button3" runat="server" Text="MyAccount" OnClick="Button3_Click"/>
                                                <asp:Button CssClass="button_header" ID="Button4" runat="server" Text="Contact Us" OnClick="Button4_Click" />
                                                <asp:Button CssClass="button_header" ID="Button1" runat="server" Text="MyCart" OnClick="Button1_Click" />
                                                <div class="search-container">
                       
                                                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                                                <asp:Button CssClass ="button_search" ID="Button2" runat="server" Text="Search" OnClick="Button2_Click" />
                 
                                                </div>
                          </div>
                         <img src ="src/banner2.jpg"  style="width:100%;height:400px; padding-top:20px;"  />   
                         <div   id ="div_card"  runat="server" style="padding-top:50px;"></div>           
      

             </form>
           </body>
</html>
