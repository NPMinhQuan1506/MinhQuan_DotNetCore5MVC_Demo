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

        public HomeController(ILogger<HomeController> logger)
        {
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
            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com");
                client.Authenticate("TestSMTPQuan@gmail.com", "123@@Abc");

                var bodyBuilder = new BodyBuilder
                {
                    HtmlBody = $"<p>{formData.Id}</p> <p>{formData.Name}</p> <p>{formData.Phone}</p> <p>{formData.Email}</p> <p>{formData.Note}</p>",
                    TextBody = "{formData.Id} \r\n {formData.Name} \r\n {formData.Phone} \r\n {formData.Email} \r\n {formData.Note}"
                };

                var message = new MimeMessage
                {
                    Body = bodyBuilder.ToMessageBody() 
                };

                message.From.Add(new MailboxAddress("Noreply my site", "TestSMTPQuan@gmail.com"));
                message.To.Add( new MailboxAddress("Testing01", formData.Email));
                message.Subject = "New contact submit";
                
                client.Send(message);
                client.Disconnect(true);
            }
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
