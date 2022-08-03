<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContactAsPage.aspx.cs" Inherits="SDAProject.ContactAsPage" %>

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
                  display: block;
                  color: black;
                  text-align: center;
                  padding: 14px 16px;
                  text-decoration: none;
                  font-size: 17px;
                  border:none;
                }
                .button_header_active{
                  background-color: #2196F3;
                  color: white;
                  float: left;
                  display: block;
                  text-align: center;
                  padding: 14px 16px;
                  text-decoration: none;
                  font-size: 17px;
                  border:none;
                }
                input[type=text], select, textarea {
                  width: 100%; 
                  padding: 12px; 
                  border: 1px solid #ccc; 
                  border-radius: 4px;                
                  margin-top: 6px; 
                  margin-bottom: 16px; 
                  resize: vertical 
                }

                .button_submit{
                  background-color: #2196F3;
                  color: white;
                  padding: 12px 20px;
                  border: none;
                  border-radius: 4px;
                  cursor: pointer;
                }

                .container {
                  border-radius: 5px;
                  background-color: #f2f2f2;
                  padding: 20px;
                }


    </style>
</head>
<body style="background-color:#f2f2f2;">
    <form id="form1" runat="server">
                    <h1 style="font-family: 'Yu Gothic UI Light'; font-size: xx-large; text-transform: uppercase; color: #000000; font-weight: 200">
                            E-commerce
                    </h1>  
   
                    <div class="topnav">
                             <asp:Button CssClass="button_header" ID="Button2" runat="server" Text="Home" OnClick="Button2_Click"/>
                             <asp:Button CssClass="button_header" ID="Button1" runat="server" Text="MyAccount" OnClick="Button1_Click" />
                             <asp:Button CssClass="button_header_active" ID="Button3" runat="server" Text="Contact Us" OnClick="Button1_Click" />
                             <asp:Button CssClass="button_header" ID="Button4" runat="server" Text="MyCart" OnClick="Button4_Click1"  />           
                    </div>
                    <div class="container">
                             
                                                    <label for="fname">First Name</label>
                                                    <input type="text" id="fname" name="firstname" placeholder="Your name..">

                                                    <label for="lname">Last Name</label>
                                                    <input type="text" id="lname" name="lastname" placeholder="Your last name..">

                                                    <label for="country">Country</label>
                                                    <select id="country" name="country">
                                                    <option value="Egypt">Egypt</option>
                                                    <option value="Usa">USA</option>
                                                    </select>

                                                    <label>Problem</label>
                                                    <textarea id="Problem" name="Problem" placeholder="Your Problem" style="height:200px"></textarea>

                                                    <input class="button_submit"  type="submit" value="SEND">

                             
                    </div>
        
    </form>
</body>
</html>
