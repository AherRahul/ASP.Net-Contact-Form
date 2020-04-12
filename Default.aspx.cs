using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace WebApplication3
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                // credentials
                var from = "thecakeshop369@gmail.com";
                var to = "thecakeshop369@gmail.com";
                const string Password = "C@keshop123";

                // email subject
                string mail_subject = txt_subject.Text.ToString();

                //email body
                string mail_message = "From: " + txt_first_name.Text + " " + txt_last_name.Text + "\n";
                mail_message += "Email: " + txt_email.Text + "\n";
                mail_message += "Order For Category: " + txt_subject.Text + "\n";
                mail_message += "Phone: " + txt_phone.Text + "\n";
                mail_message += "Message: \n" + txt_message.Text + "\n";


                // mail smtp 
                var smtp = new SmtpClient();
                {
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, Password);
                    smtp.Timeout = 20000;
                }

                smtp.Send(from, to, mail_subject, mail_message);

                Confirm();

                confirm.Text = "Thanks for contacting us! We will be in touch with you shortly";

                txt_subject.Text = "";
                txt_first_name.Text = "";
                txt_last_name.Text = "";
                txt_email.Text = "";
                txt_phone.Text = "";
                txt_message.Text = "";


            }

            // error message 
            catch (Exception)
            {
                confirm.Text = "<p> Oh no! <br> Something went wrong while sending your message ";
                confirm.ForeColor = Color.Red;
            }
        }

        // send confirmation mail back to client
        private void Confirm()
        {
            // pass text input to variable
            string ToEmail = txt_email.Text.Trim();
            string UserName = txt_first_name.Text + " " + txt_last_name.Text;
            string subject2 = txt_subject.Text;

            MailMessage mailMessage = new MailMessage("thecakeshop369@gmail.com", ToEmail);



            StringBuilder sbEmailBody = new StringBuilder();
            sbEmailBody.Append("<img src='https://tonycreators.com/wp-content/uploads/2020/03/Tony-Creators-Logo-e1585059175346.png' alt=logo width='150';/>");
            sbEmailBody.Append("<br/><br/>");
            sbEmailBody.Append("Dear " + UserName + ",<br/><br/>");
            sbEmailBody.Append("Thank you for reaching us!<br/>");
            sbEmailBody.Append("We received you order regarding " + subject2 + " cake category<br/>");
            sbEmailBody.Append("We will be back to you within 2 working days. It might take a little longer on evenings and weekends but we want" +
                " you to know that we are doing our best to get back to you as soon as possible");
            sbEmailBody.Append("<br/><br/><br/>");
            sbEmailBody.Append("Sincerely, <br/>");
            sbEmailBody.Append("<b>The Cake Shop<br>Mob No: 1234567890</b>");


            // convert the html tag
            mailMessage.IsBodyHtml = true;

            mailMessage.Body = sbEmailBody.ToString();
            mailMessage.Subject = "Re: Thank you for your email";
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

            smtpClient.Credentials = new System.Net.NetworkCredential()
            {
                UserName = "thecakeshop369@gmail.com",
                Password = "C@keshop123"
            };


            smtpClient.EnableSsl = true;
            smtpClient.Send(mailMessage);
        }

    }
}