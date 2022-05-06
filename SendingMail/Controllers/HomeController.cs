using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SendingMail.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;


namespace SendingMail.Controllers
{
    public class HomeController : Controller
    {
        string MailBody = "<!DOCTYPE html>" +
                               "<html> " +
                                   "<body style=\"background -color:#ff7f26;text-align:center;\"> " +
                                   "<h1 style=\"color:#051a80;\">Welcome to Air_india World</h1> " +
                                   
                                   "<label style=\"color:orange;font-size:100px;border:5px dotted;border-radius:50px\">N</label> " +
                                   "</body> " +
                               "</html>";
        string subject = "Welcome to  World.";
        string mailTitle = "Email from .Net Core App";
        string fromEmail = "Trng2@evolvingsols.com";
        string fromEmailPassword = "Cybage@#123";



        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string toEmail)
        {
            //Email & Content 
            MailMessage message = new MailMessage(new MailAddress(fromEmail, mailTitle), new MailAddress(toEmail));
            message.Subject = subject;
            message.Body = MailBody;
            message.IsBodyHtml = true;


            
            SmtpClient smtp = new SmtpClient();
           
            smtp.Host = "webmail.evolvingsols.com";
            smtp.Port = 25;
            smtp.EnableSsl = false;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            System.Net.NetworkCredential credentials = new System.Net.NetworkCredential();
            credentials.UserName = fromEmail;
            credentials.Password = fromEmailPassword;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = credentials;
           
            smtp.Send(message);

            ViewBag.EmailSentMessage = "Email sent successfully";

            return View();
        }

    }
}
