using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MinhQuan_DotNetCoreMVC5_Demo.Models;
using MinhQuan_DotNetCoreMVC5_Demo.Models.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;

namespace MinhQuan_DotNetCoreMVC5_Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        readonly Services.SmtpHandling _smtpHandlingServices;
        public HomeController(ILogger<HomeController> logger)
        {
            _smtpHandlingServices = new Services.SmtpHandling();
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(Contact formData)
        {
            if (!ModelState.IsValid)
            {
                return View(formData);
            }
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

            //using (var client = new SmtpClient())
            //{
            //    client.Connect("smtp.gmail.com");
            //    client.Authenticate("TestSMTPQuan@gmail.com", "123@@Abc");

            //    var bodyBuilder = new BodyBuilder
            //    {
            //        HtmlBody = $"<p>{formData.Id}</p> <p>{formData.Name}</p> <p>{formData.Phone}</p> <p>{formData.Email}</p> <p>{formData.Note}</p>",
            //        TextBody = "{formData.Id} \r\n {formData.Name} \r\n {formData.Phone} \r\n {formData.Email} \r\n {formData.Note}"
            //    };

            //    var message = new MimeMessage
            //    {
            //        Body = bodyBuilder.ToMessageBody()
            //    };

            //    message.From.Add(new MailboxAddress("Noreply my site", "TestSMTPQuan@gmail.com"));
            //    message.To.Add(new MailboxAddress("Testing01", formData.Email));
            //    message.Subject = "New contact submit";

            //    client.Send(message);
            //    client.Disconnect(true);
            //}
            _smtpHandlingServices.sendEmail(formData.Id, formData.Name, formData.Phone, formData.Email, formData.Note);
            TempData["Message"] = "Thank you! We'll contact you shortly!";
            return RedirectToAction("Contact");
            //return Json(formData);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
