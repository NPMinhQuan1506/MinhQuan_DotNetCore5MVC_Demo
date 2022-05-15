using MailKit.Net.Smtp;
using MimeKit;
namespace MinhQuan_DotNetCoreMVC5_Demo.Services
{
    public class SmtpHandling
    {
        public void sendEmail( int id, string name, string phone, string email, string note)
        {
            //TestSMTPQuan
            /*
             Step 1: Install mailkit
             Step 2: using MailKit.Net.Smtp, using MimeKit
             Step 3: Set enable Less secure app access in manage your account google/Secure
             Step 4: Click setting icon in gmail, then choose 'see all setting', go to ...POP/IMAP tab -> enable IMAP access
             Step 5: using SmtpClient
                  5.1: set bodyBuilder
                  5.2: set message
                  5.3: Add message from gmail
                  5.4: Add message to gmail
                  5.5: client send message then disconect client
            */

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com");
                client.Authenticate("YourEmail", "yourpassword");

                var bodyBuilder = new BodyBuilder
                {
                    HtmlBody = $"<p>{id}</p> <p>{name}</p> <p>{phone}</p> <p>{email}</p> <p>{note}</p>",
                    TextBody = "{id} \r\n {name} \r\n {phone} \r\n {email} \r\n {note}"
                };

                var message = new MimeMessage
                {
                    Body = bodyBuilder.ToMessageBody()
                };

                message.From.Add(new MailboxAddress("Noreply my site", "TestSMTPQuan@gmail.com"));
                message.To.Add(new MailboxAddress("Testing01", email));
                message.Subject = "New contact submit";

                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}
