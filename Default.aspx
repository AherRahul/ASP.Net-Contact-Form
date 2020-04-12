<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication3.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://kit.fontawesome.com/a076d05399.js"></script>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous" />
    <link href="StyleSheet.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container">
                <div class="contact-parent">
                    <div class="contact-child child1">

                        <p>
                            <i class="fas fa-map-marker-alt"></i>Address
                            <br />
                            <span>110  Ash Lane,
                            <br />
                            YARROW FEUS, TD7 0XL</span>
                        </p>
                        <p>
                            <i class="fas fa-phone-alt"></i>Let's talk
                            <br />
                            <span>070 8826 9269</span>
                        </p>
                        <p>
                            <i class="far fa-envelope"></i>General Support
                            <br />
                            <span>andreea@andreeabunget.co.uk</span>
                        </p>

                    </div>
                    <div class="contact-child child2">
                        <div class="inside-contact">
                            <h2>Contact Us</h2>
                            <h3>
                                <asp:Label ID="confirm" runat="server" Text=""></asp:Label>
                            </h3>
                            <p>
                                <asp:Label ID="Label1" runat="server" Text="First Name *"></asp:Label></p>
                            <asp:TextBox ID="txt_first_name" runat="server" Required="required"></asp:TextBox>
                                
                                <asp:Label ID="Label6" runat="server" Text="Last Name *"></asp:Label></p>
                            <asp:TextBox ID="txt_last_name" runat="server" Required="required"></asp:TextBox>
                            <p>
                                <asp:Label ID="Label2" runat="server" Text="Email *"></asp:Label></p>
                            <asp:TextBox ID="txt_email" runat="server" Required="required"></asp:TextBox>

                            <p>
                                <asp:Label ID="Label3" runat="server" Text="Phone *"></asp:Label></p>
                            <asp:TextBox ID="txt_phone" runat="server" Required="required"></asp:TextBox>

                            <p>
                                <asp:Label ID="Label4" runat="server" Text="Cake Type *"></asp:Label></p>
                            <asp:TextBox ID="txt_subject" runat="server" Required="required"></asp:TextBox>

                            <p>
                                <asp:Label ID="Label5" runat="server" Text="Message *"></asp:Label></p>
                            <asp:TextBox ID="txt_message" runat="server" Required="required" TextMode="MultiLine" Rows="4"></asp:TextBox>

                            <asp:Button ID="btn_send" runat="server" Text="Send" OnClick="btn_send_Click"/>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
