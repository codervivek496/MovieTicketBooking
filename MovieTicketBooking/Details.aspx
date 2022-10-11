<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="MovieTicketBooking.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Booking Details</title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-sweetalert/1.0.1/sweetalert.min.js"></script>
    <link href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-sweetalert/1.0.1/sweetalert.css" rel="stylesheet" />

    <script type="text/javascript"></script>
</head>
<body">
    <center>
    <form id="form1" runat="server" style="border:thick">
        <h1>Booking Details</h1>
        <div>
            <table>
                <tr>
                    <td>Enter Name</td>
                    <td><asp:TextBox ID="TextBox1" runat="server" placeholder="Enter Your Name" Width="161px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Enter Mobile number</td>
                    <td><asp:TextBox ID="TextBox2" runat="server" placeholder="0123456789" MaxLength="14"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Enter Movie ID</td>
                    <td><asp:TextBox ID="TextBox3" runat="server" placeholder="Enter Movie ID"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Seat Number</td>
                    <td><asp:TextBox ID="TextBox4" runat="server" placeholder="Enter your seat number"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2" align="center"><br />
                        <asp:Button ID="Button1" runat="server" Text="Back" OnClick="Button1_Click1" />
                        <asp:Button ID="Button2" runat="server" Text="Submit" OnClick="Button2_Click1" />
                        <asp:Button ID="Button3" runat="server" Text="Cancel" OnClick="Button3_Click1" />
                    </td>
                    
                </tr>
            </table>
        </div>
    </form>
        </center>
</body>
</html>
