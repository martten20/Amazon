<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyCart.aspx.cs" Inherits="SDAProject.MyCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
        <head runat="server">
                <title>CartPage</title>
                <style>
                            .topnav {
                                    overflow: hidden;
                                    background-color: #e9e9e9;
                            }
                            .img{
                                    width:100%;
                                    height:65%;
                            }
                            .topnav a {
                                    float: left;
                                    display: block;
                                    color: black;
                                    text-align: center;
                                    padding: 14px 16px;
                                    text-decoration: none;
                                    font-size: 17px;
                            }

                            .topnav a.active {
                                    background-color: #2196F3;
                                    color: white;
                            }

                            .card {
                                    background-color:white;
                                    width: 500px;
                                    padding:10px;
                                    border:solid;
                                    border-color:#f2f2f2;
                                    text-align: center;
                                    font-family:'Yu Gothic UI Light';
                                    float:left;
           
                            }
                            input[type=text] {
                                    width: 100%;
                                    padding: 12px 20px;
                                    margin: 8px 0;
                                    display: inline-block;
                                    border: 1px solid #ccc;
                                    border-radius: 4px;
                                    font-family: 'Yu Gothic UI Light';
                            }


                            .card_B {
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
                            .totalcost{
                                    text-align:center;
                                    text-transform: uppercase;
                                    font-size: large;
                                    font-family: 'Yu Gothic Light'; 

                            }
                            .price {
                                    color: grey;
                                    font-size: 17px;
                            }
                            .CardName{
                                        color:black;
                                        font-size:25px;
                            }
                            .card_B:hover {
                                        opacity: 0.7;
                            }
                            .button_HEADER:hover {
                                        background-color: #ddd;
                                        color: black;
                            }
                            .button_HEADER{
                                    background-color:#e9e9e9;
                                    float: left;
                                    display: block;
                                    color: black;
                                    text-align: center;
                                    padding: 14px 16px;
                                    font-size: 17px;
                                    border:none;
                            }


                </style>
        </head>
        <body style="background-color:#f2f2f2;">
                    <h1 style="font-family: 'Yu Gothic UI Light'; font-size: xx-large; text-transform: uppercase; color: #000000; font-weight: 200">
                    E-commerce
                    </h1>  
                    <form id="form1" runat="server">
           
                                <div class="topnav">
                                        <asp:Button CssClass="button_HEADER" ID="Button1" runat="server" Text="Home" OnClick="Button1_Click"/>
                                        <asp:Button CssClass="button_HEADER" ID="Button2" runat="server" Text="MyAccount" OnClick="Button2_Click"/>
                                        <asp:Button CssClass="button_HEADER" ID="Button4" runat="server" Text="Contact Us" OnClick="Button4_Click"/>
                                        <a class="active">MyCart</a>
                                </div>
            
               
                                <div   id ="div_card"  runat="server" style="padding-top:50px; width:100%; display:flex;justify-content:center;"></div>  

                                <div id="totalCost" runat ="server" style="padding-top:50px; width:auto;"></div>
                                <h2 style="font-family: 'Yu Gothic UI Light'; font-size: xx-large; text-transform: uppercase; color: #000000; font-weight: 200; width:1000px;">Payment Method</h2>


                                <asp:RadioButton runat="server" id="r1" Text="Visa" OnCheckedChanged="Unnamed1_CheckedChanged" AutoPostBack="True"></asp:RadioButton>
                                <asp:RadioButton runat="server" id="r2" Text="Cash" OnCheckedChanged="Unnamed2_CheckedChanged" AutoPostBack="True"></asp:RadioButton>                   
         
                                <div id ="divv" runat="server" visible ="false">

                   
                                            <asp:TextBox  style="width:90%;"   ID="TextBox5" runat="server" placeholder="Card Number" ></asp:TextBox>
              
                                            <asp:TextBox   style="width:90%;"   ID="TextBox6" runat="server" placeholder="CVV" ></asp:TextBox>
                   
                                           
                                            <asp:TextBox style="width:25%; padding-right:15px;" ID="TextBox7" runat="server" placeholder="Year" ></asp:TextBox>

                                            <asp:TextBox style="width:25%; padding-left:15px;" ID="TextBox1" runat="server" placeholder="Month" ></asp:TextBox>
   
                               </div>  
                               <asp:Button CssClass="card_B" ID="Button3" runat="server" Text="Buy" style =" width:100%;" OnClick="Button3_Click"/> 
                    </form>
        </body>
</html>
