<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainForm.aspx.cs" Inherits="SDAProject.MainForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
                      text-decoration: none;
                      font-size: 17px;
                    }

                    .topnav a:hover {
                      background-color: #ddd;
                      color: black;
                    }



                
           </style>
</head>
<body style="background-color:#f2f2f2;">

    <form id="form1" runat="server">
                 <h1 style="font-family: 'Yu Gothic UI Light'; font-size: xx-large; text-transform: uppercase; color: #000000; font-weight: 200">
                        E-commerce
                 </h1>  
      
           
         <div class="topnav">
             <a href="https://localhost:44354/Login.aspx">Login</a>
             <a href="https://localhost:44354/Reg.aspx">Registration</a>
                          
         </div>
       
         <div>
                     <img src ="src/1.jpg"  style="width:100%" />
                    <div>
                            <video   style="width:100%; height:540px;" controls="controls"  autoplay="autoplay">
                                     <source src="src/1.mp4" type="video/mp4">                      
                                     </video>
                    </div>
                   
                    

        </div>
    </form>
</body>
</html>
